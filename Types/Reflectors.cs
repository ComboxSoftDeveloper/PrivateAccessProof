using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;

namespace PrivateAccessProof.Types;

/// <summary>
/// Остальные способы добраться до приватного члена: рефлексия, скомпилированное
/// дерево выражений и метод, собранный из инструкций IL.
///
/// Всё, что можно подготовить заранее, подготовлено в статическом конструкторе:
/// иначе замер показывал бы стоимость поиска члена, а не стоимость доступа.
/// </summary>
internal static class Reflectors
{
    /// <summary>Описание приватного поля со строкой.</summary>
    internal static readonly FieldInfo TokenField;

    /// <summary>Описание приватного поля с числом.</summary>
    internal static readonly FieldInfo CounterField;

    /// <summary>Описание приватного метода.</summary>
    internal static readonly MethodInfo RevealMethod;

    /// <summary>Чтение поля скомпилированным деревом выражений.</summary>
    internal static readonly Func<Secret, string> TokenByExpression;

    /// <summary>Запись поля скомпилированным деревом выражений.</summary>
    internal static readonly Action<Secret, string> WriteByExpression;

    /// <summary>Чтение поля методом, собранным из инструкций IL.</summary>
    internal static readonly Func<Secret, string> TokenByEmit;

    /// <summary>Запись поля методом, собранным из инструкций IL.</summary>
    internal static readonly Action<Secret, string> WriteByEmit;

    /// <summary>Вызов приватного метода через делегат.</summary>
    internal static readonly Func<Secret, int, string> RevealByDelegate;

    /// <summary>Подготовка всех способов один раз.</summary>
    static Reflectors()
    {
        const BindingFlags Private = BindingFlags.Instance | BindingFlags.NonPublic;

        TokenField = typeof(Secret).GetField("_token", Private)
            ?? throw new InvalidOperationException("Поле _token не найдено");

        CounterField = typeof(Secret).GetField("_counter", Private)
            ?? throw new InvalidOperationException("Поле _counter не найдено");

        RevealMethod = typeof(Secret).GetMethod("Reveal", Private)
            ?? throw new InvalidOperationException("Метод Reveal не найден");

        ParameterExpression instance = Expression.Parameter(typeof(Secret), "instance");
        MemberExpression field = Expression.Field(instance, TokenField);
        TokenByExpression = Expression.Lambda<Func<Secret, string>>(field, instance).Compile();

        ParameterExpression value = Expression.Parameter(typeof(string), "value");
        WriteByExpression = Expression.Lambda<Action<Secret, string>>(
            Expression.Assign(field, value), instance, value).Compile();

        TokenByEmit = BuildReader();
        WriteByEmit = BuildWriter();

        RevealByDelegate = RevealMethod.CreateDelegate<Func<Secret, int, string>>();
    }

    /// <summary>
    /// Метод чтения, собранный вручную. Флаг в конце разрешает обращаться
    /// к приватному члену: без него будет отказ в доступе.
    /// </summary>
    private static Func<Secret, string> BuildReader()
    {
        DynamicMethod method = new("ReadToken", typeof(string), [typeof(Secret)], typeof(Secret), true);
        ILGenerator il = method.GetILGenerator();

        il.Emit(OpCodes.Ldarg_0);
        il.Emit(OpCodes.Ldfld, TokenField);
        il.Emit(OpCodes.Ret);

        return method.CreateDelegate<Func<Secret, string>>();
    }

    /// <summary>Метод записи, собранный вручную.</summary>
    private static Action<Secret, string> BuildWriter()
    {
        DynamicMethod method = new("WriteToken", null, [typeof(Secret), typeof(string)], typeof(Secret), true);
        ILGenerator il = method.GetILGenerator();

        il.Emit(OpCodes.Ldarg_0);
        il.Emit(OpCodes.Ldarg_1);
        il.Emit(OpCodes.Stfld, TokenField);
        il.Emit(OpCodes.Ret);

        return method.CreateDelegate<Action<Secret, string>>();
    }

    /// <summary>
    /// Поиск поля заново на каждом обращении. Так писать не надо, но именно
    /// так рефлексию чаще всего и применяют, поэтому вариант замеряется.
    /// </summary>
    internal static FieldInfo FindTokenField()
    {
        return typeof(Secret).GetField("_token", BindingFlags.Instance | BindingFlags.NonPublic)
            ?? throw new InvalidOperationException("Поле _token не найдено");
    }
}
