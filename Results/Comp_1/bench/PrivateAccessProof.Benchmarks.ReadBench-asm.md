## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.Direct()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE11E0FA80]; PrivateAccessProof.Subjects.ReadDirect(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadDirect(PrivateAccessProof.Types.Secret)
       mov       rax,[rcx+8]
       ret
; Total bytes of code 5
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.ReflectionFresh()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE11E0FA80]; PrivateAccessProof.Subjects.ReadReflectionFresh(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadReflectionFresh(PrivateAccessProof.Types.Secret)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFE11E0FA98]; PrivateAccessProof.Types.Reflectors.FindTokenField()
       mov       rsi,rax
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rsi],rcx
       jne       near ptr M01_L08
       cmp       qword ptr [rsi+30],0
       jne       near ptr M01_L02
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       call      qword ptr [7FFE11C74B58]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       short M01_L05
M01_L00:
       test      rcx,rcx
       je        near ptr M01_L06
       call      00007FFE716D9400
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE11C7D8C0]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       jne       near ptr M01_L07
       mov       dword ptr [rdi+20],0F
M01_L01:
       lea       rcx,[rsi+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rcx,[rsi+30]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE11D7E3A0]; System.Reflection.FieldAccessor.GetValue(System.Object)
M01_L03:
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L04
       mov       rcx,offset MT_System.String
       cmp       [rdx],rcx
       jne       short M01_L09
M01_L04:
       mov       rax,rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE11EAD7E8]
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE11EAD800]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L07:
       mov       dword ptr [rdi+20],11
       jmp       near ptr M01_L01
M01_L08:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,[rsi]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       jmp       near ptr M01_L03
M01_L09:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 336
```
```assembly
; PrivateAccessProof.Types.Reflectors.FindTokenField()
       push      rbx
       sub       rsp,20
       mov       rcx,23D692B8AF0
       mov       rdx,23D692B8B18
       mov       r8d,24
       call      qword ptr [7FFE119EA490]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       test      rax,rax
       je        short M02_L00
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,8D
       mov       rdx,7FFE11CE8420
       call      qword ptr [7FFE11AAF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE11D77AF8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 108
```
```assembly
; System.Type.GetRootElementType()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
M03_L00:
       cmp       rsi,[rbx]
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE6EFEB7A8]; Precode of System.RuntimeType.GetCorElementType()
       cmp       eax,1D
       ja        short M03_L01
       mov       ecx,1FEF7FFF
       bt        ecx,eax
       jae       short M03_L04
M03_L01:
       cmp       eax,10
       sete      dil
       movzx     edi,dil
M03_L02:
       test      edi,edi
       jne       short M03_L03
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       rcx,rbx
       lea       r11,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M03_L00
M03_L04:
       mov       edi,1
       jmp       short M03_L02
M03_L05:
       mov       rcx,rbx
       lea       r11,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M03_L02
; Total bytes of code 114
```
```assembly
; System.RuntimeType.get_IsNullableOfT()
       mov       rax,[rcx+18]
       test      al,2
       jne       short M04_L01
       mov       eax,[rax]
       and       eax,0F0000
       cmp       eax,50000
       sete      al
       movzx     eax,al
M04_L00:
       ret
M04_L01:
       xor       eax,eax
       jmp       short M04_L00
; Total bytes of code 31
```
```assembly
; System.Reflection.FieldAccessor.GetValue(System.Object)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
M05_L00:
       mov       ecx,[rbx+20]
       test      ecx,ecx
       jne       short M05_L04
       mov       rcx,[rbx+8]
       mov       rdi,[rcx+10]
       mov       rcx,[rdi+18]
       mov       rbp,rsi
       test      rbp,rbp
       je        short M05_L01
       mov       rdx,[rbp]
       cmp       rdx,rcx
       jne       short M05_L06
M05_L01:
       mov       rax,rbp
M05_L02:
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M05_L13
       cmp       [rsi],sil
       mov       rax,[rbx+10]
       mov       rax,[rsi+rax+8]
M05_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L04:
       cmp       ecx,11
       ja        short M05_L05
       mov       ecx,ecx
       lea       rax,[7FFE11B1FD60]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M05_L00]
       add       rax,rdx
       jmp       rax
M05_L05:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L06:
       mov       rax,22D73400038
       mov       rax,[rax]
       add       rax,10
       rorx      r8,rdx,20
       xor       r8,rcx
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       mov       r10d,[rax]
       shrx      r8,r8,r10
       xor       r10d,r10d
       cmp       r10d,8
       jge       short M05_L10
M05_L07:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       lea       r9,[r9+r9*2]
       lea       r9,[rax+r9*8]
       mov       r11d,[r9]
       mov       r14,[r9+8]
       and       r11d,0FFFFFFFE
       cmp       r14,rdx
       jne       short M05_L08
       mov       r14,rcx
       xor       r14,[r9+10]
       cmp       r14,1
       jbe       short M05_L09
M05_L08:
       test      r11d,r11d
       je        short M05_L10
       inc       r10d
       add       r8d,r10d
       and       r8d,[rax+4]
       cmp       r10d,8
       jl        short M05_L07
       jmp       short M05_L10
M05_L09:
       cmp       r11d,[r9]
       jne       short M05_L10
       jmp       short M05_L11
M05_L10:
       mov       r14d,2
M05_L11:
       cmp       r14d,1
       je        near ptr M05_L01
       test      r14d,r14d
       jne       short M05_L12
       xor       ebp,ebp
       jmp       near ptr M05_L01
M05_L12:
       mov       rdx,rsi
       call      qword ptr [7FFE11AAFA98]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
       jmp       near ptr M05_L02
M05_L13:
       test      rsi,rsi
       jne       near ptr M05_L22
       jmp       near ptr M05_L21
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE119EA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M05_L14
       test      rsi,rsi
       jne       near ptr M05_L22
       jmp       near ptr M05_L21
M05_L14:
       cmp       [rsi],sil
       mov       rdx,[rbx+10]
       lea       rdx,[rsi+rdx+8]
       mov       rcx,[rbx+18]
       call      qword ptr [7FFE11EAD890]
       jmp       near ptr M05_L03
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE119EA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M05_L15
       test      rsi,rsi
       jne       near ptr M05_L22
       jmp       near ptr M05_L21
M05_L15:
       cmp       [rsi],sil
       mov       rcx,[rbx+10]
       mov       rsi,[rsi+rcx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M05_L16
       call      qword ptr [7FFE11D7E328]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M05_L16:
       mov       rcx,rsi
       call      qword ptr [7FFE11EAD878]
       jmp       near ptr M05_L03
       mov       rax,[rbx+10]
       mov       rax,[rax]
       jmp       near ptr M05_L03
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE11EAD890]
       jmp       near ptr M05_L03
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx]
       cmp       [rdx],dl
       add       rdx,8
       call      qword ptr [7FFE11EAD890]
       jmp       near ptr M05_L03
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M05_L17
       call      qword ptr [7FFE11D7E328]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M05_L17:
       mov       rcx,rsi
       call      qword ptr [7FFE11EAD878]
       jmp       near ptr M05_L03
       mov       rcx,rbx
       call      qword ptr [7FFE11D7E3B8]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M05_L18
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE119EA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M05_L18
       test      rsi,rsi
       jne       near ptr M05_L22
       jmp       near ptr M05_L21
M05_L18:
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M05_L19
       call      qword ptr [7FFE11D7E328]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M05_L19:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE11D7E3D0]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rsi,rax
       cmp       byte ptr [rsp+28],0
       je        short M05_L20
       mov       rcx,rbx
       call      qword ptr [7FFE11D7E3E8]; System.Reflection.FieldAccessor.Initialize()
M05_L20:
       mov       rax,rsi
       jmp       near ptr M05_L03
       mov       rcx,rbx
       call      qword ptr [7FFE11D7E3B8]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M05_L23
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE119EA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M05_L23
       test      rsi,rsi
       jne       short M05_L22
M05_L21:
       call      qword ptr [7FFE11EAD8A8]
       int       3
M05_L22:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFE11EAD8C0]
       int       3
M05_L23:
       mov       dword ptr [rsp+28],1
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M05_L24
       call      qword ptr [7FFE11D7E328]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M05_L24:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE11D7E3D0]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       jmp       near ptr M05_L03
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE11DC2A38]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M05_L25
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE11DC2A38]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M05_L25
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE11EAD8D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE11D77AF8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L25:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE11DC2A38]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M05_L27
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M05_L26
       call      qword ptr [7FFE11D7E328]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M05_L26:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE11C7D8C0]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       je        short M05_L27
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE11EAD8F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L27:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE11EAD908]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1115
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M06_L00
       cmp       [rdx],rcx
       jne       short M06_L01
M06_L00:
       mov       rax,rdx
       ret
M06_L01:
       jmp       qword ptr [7FFE11C74D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.ReflectionCached()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE11E1FA68]; PrivateAccessProof.Subjects.ReadReflectionCached(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadReflectionCached(PrivateAccessProof.Types.Secret)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,1B6C5001310
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+30],0
       je        short M01_L02
M01_L00:
       mov       rcx,[rsi+30]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE11D8E3A0]; System.Reflection.FieldAccessor.GetValue(System.Object)
       mov       rdx,rax
       mov       rax,rdx
       test      rax,rax
       je        short M01_L01
       mov       rcx,offset MT_System.String
       cmp       [rax],rcx
       jne       near ptr M01_L08
M01_L01:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       call      qword ptr [7FFE11C84B58]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       short M01_L05
M01_L03:
       test      rcx,rcx
       je        short M01_L06
       call      00007FFE716D9400
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE11C8D8C0]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       jne       short M01_L07
       mov       dword ptr [rdi+20],0F
M01_L04:
       lea       rcx,[rsi+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE11EBD608]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE11EBD620]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L07:
       mov       dword ptr [rdi+20],11
       jmp       short M01_L04
M01_L08:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 285
```
```assembly
; System.Reflection.FieldAccessor.GetValue(System.Object)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
M02_L00:
       mov       ecx,[rbx+20]
       test      ecx,ecx
       jne       short M02_L04
       mov       rcx,[rbx+8]
       mov       rdi,[rcx+10]
       mov       rcx,[rdi+18]
       mov       rbp,rsi
       test      rbp,rbp
       je        short M02_L01
       mov       rdx,[rbp]
       cmp       rdx,rcx
       jne       short M02_L06
M02_L01:
       mov       rax,rbp
M02_L02:
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M02_L13
       cmp       [rsi],sil
       mov       rax,[rbx+10]
       mov       rax,[rsi+rax+8]
M02_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L04:
       cmp       ecx,11
       ja        short M02_L05
       mov       ecx,ecx
       lea       rax,[7FFE11B2E520]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
M02_L05:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L06:
       mov       rax,1B6C5000038
       mov       rax,[rax]
       add       rax,10
       rorx      r8,rdx,20
       xor       r8,rcx
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       mov       r10d,[rax]
       shrx      r8,r8,r10
       xor       r10d,r10d
       cmp       r10d,8
       jge       short M02_L10
M02_L07:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       lea       r9,[r9+r9*2]
       lea       r9,[rax+r9*8]
       mov       r11d,[r9]
       mov       r14,[r9+8]
       and       r11d,0FFFFFFFE
       cmp       r14,rdx
       jne       short M02_L08
       mov       r14,rcx
       xor       r14,[r9+10]
       cmp       r14,1
       jbe       short M02_L09
M02_L08:
       test      r11d,r11d
       je        short M02_L10
       inc       r10d
       add       r8d,r10d
       and       r8d,[rax+4]
       cmp       r10d,8
       jl        short M02_L07
       jmp       short M02_L10
M02_L09:
       cmp       r11d,[r9]
       jne       short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       r14d,2
M02_L11:
       cmp       r14d,1
       je        near ptr M02_L01
       test      r14d,r14d
       jne       short M02_L12
       xor       ebp,ebp
       jmp       near ptr M02_L01
M02_L12:
       mov       rdx,rsi
       call      qword ptr [7FFE11ABFA98]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L13:
       test      rsi,rsi
       jne       near ptr M02_L22
       jmp       near ptr M02_L21
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE119FA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L14
       test      rsi,rsi
       jne       near ptr M02_L22
       jmp       near ptr M02_L21
M02_L14:
       cmp       [rsi],sil
       mov       rdx,[rbx+10]
       lea       rdx,[rsi+rdx+8]
       mov       rcx,[rbx+18]
       call      qword ptr [7FFE11EBD6B0]
       jmp       near ptr M02_L03
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE119FA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L15
       test      rsi,rsi
       jne       near ptr M02_L22
       jmp       near ptr M02_L21
M02_L15:
       cmp       [rsi],sil
       mov       rcx,[rbx+10]
       mov       rsi,[rsi+rcx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L16
       call      qword ptr [7FFE11D8E328]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L16:
       mov       rcx,rsi
       call      qword ptr [7FFE11EBD698]
       jmp       near ptr M02_L03
       mov       rax,[rbx+10]
       mov       rax,[rax]
       jmp       near ptr M02_L03
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE11EBD6B0]
       jmp       near ptr M02_L03
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx]
       cmp       [rdx],dl
       add       rdx,8
       call      qword ptr [7FFE11EBD6B0]
       jmp       near ptr M02_L03
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L17
       call      qword ptr [7FFE11D8E328]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L17:
       mov       rcx,rsi
       call      qword ptr [7FFE11EBD698]
       jmp       near ptr M02_L03
       mov       rcx,rbx
       call      qword ptr [7FFE11D8E3B8]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M02_L18
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE119FA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L18
       test      rsi,rsi
       jne       near ptr M02_L22
       jmp       near ptr M02_L21
M02_L18:
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L19
       call      qword ptr [7FFE11D8E328]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L19:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE11D8E3D0]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rsi,rax
       cmp       byte ptr [rsp+28],0
       je        short M02_L20
       mov       rcx,rbx
       call      qword ptr [7FFE11D8E3E8]; System.Reflection.FieldAccessor.Initialize()
M02_L20:
       mov       rax,rsi
       jmp       near ptr M02_L03
       mov       rcx,rbx
       call      qword ptr [7FFE11D8E3B8]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M02_L23
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE119FA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L23
       test      rsi,rsi
       jne       short M02_L22
M02_L21:
       call      qword ptr [7FFE11EBD6C8]
       int       3
M02_L22:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFE11EBD6E0]
       int       3
M02_L23:
       mov       dword ptr [rsp+28],1
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L24
       call      qword ptr [7FFE11D8E328]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L24:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE11D8E3D0]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       jmp       near ptr M02_L03
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE11DD2A38]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M02_L25
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE11DD2A38]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L25
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE11EBD6F8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE11D87AF8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L25:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE11DD2A38]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M02_L27
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L26
       call      qword ptr [7FFE11D8E328]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L26:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE11C8D8C0]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       je        short M02_L27
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE11EBD710]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L27:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE11EBD728]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1115
```
```assembly
; System.Type.GetRootElementType()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
M03_L00:
       cmp       rsi,[rbx]
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE6EFEB7A8]; Precode of System.RuntimeType.GetCorElementType()
       cmp       eax,1D
       ja        short M03_L01
       mov       ecx,1FEF7FFF
       bt        ecx,eax
       jae       short M03_L04
M03_L01:
       cmp       eax,10
       sete      dil
       movzx     edi,dil
M03_L02:
       test      edi,edi
       jne       short M03_L03
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       rcx,rbx
       lea       r11,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M03_L00
M03_L04:
       mov       edi,1
       jmp       short M03_L02
M03_L05:
       mov       rcx,rbx
       lea       r11,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M03_L02
; Total bytes of code 114
```
```assembly
; System.RuntimeType.get_IsNullableOfT()
       mov       rax,[rcx+18]
       test      al,2
       jne       short M04_L01
       mov       eax,[rax]
       and       eax,0F0000
       cmp       eax,50000
       sete      al
       movzx     eax,al
M04_L00:
       ret
M04_L01:
       xor       eax,eax
       jmp       short M04_L00
; Total bytes of code 31
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L00
       cmp       [rdx],rcx
       jne       short M05_L01
M05_L00:
       mov       rax,rdx
       ret
M05_L01:
       jmp       qword ptr [7FFE11C84D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.Expression()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE11DFFA68]; PrivateAccessProof.Subjects.ReadExpression(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadExpression(PrivateAccessProof.Types.Secret)
       sub       rsp,28
       mov       rdx,1DE0B401328
       mov       rax,[rdx]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,28
       ret
; Total bytes of code 33
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.Emit()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE11DEFA80]; PrivateAccessProof.Subjects.ReadEmit(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadEmit(PrivateAccessProof.Types.Secret)
       sub       rsp,28
       mov       rdx,231A1801338
       mov       rax,[rdx]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,28
       ret
; Total bytes of code 33
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.Accessor()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE11DFF990]; PrivateAccessProof.Subjects.ReadAccessor(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadAccessor(PrivateAccessProof.Types.Secret)
       mov       rax,[rcx+8]
       ret
; Total bytes of code 5
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.Direct()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE0E2FCE58]; PrivateAccessProof.Subjects.ReadDirect(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadDirect(PrivateAccessProof.Types.Secret)
       mov       rax,[rcx+8]
       ret
; Total bytes of code 5
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.ReflectionFresh()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE0E2FCF30]; PrivateAccessProof.Subjects.ReadReflectionFresh(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadReflectionFresh(PrivateAccessProof.Types.Secret)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFE0E2FD0F8]; PrivateAccessProof.Types.Reflectors.FindTokenField()
       mov       rcx,rax
       mov       rdx,rbx
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       mov       rax,rdx
       test      rax,rax
       je        short M01_L00
       mov       rcx,offset MT_System.String
       cmp       [rax],rcx
       jne       short M01_L01
M01_L00:
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       call      qword ptr [7FFE0DEF43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 68
```
```assembly
; PrivateAccessProof.Types.Reflectors.FindTokenField()
       push      rbx
       sub       rsp,20
       mov       rcx,1E322968D90
       mov       rdx,1E322968DB8
       mov       r8d,24
       call      qword ptr [7FFE0DE3A630]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       test      rax,rax
       je        short M02_L00
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,8D
       mov       rdx,7FFE0E0D1530
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0E0B6718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M03_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M03_L02
M03_L01:
       mov       rax,rdx
       ret
M03_L02:
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L01
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L01
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L01
       test      rax,rax
       jne       short M03_L00
M03_L03:
       lea       rax,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
       jmp       qword ptr [rax]
; Total bytes of code 73
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.ReflectionCached()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE0E2CCC18]; PrivateAccessProof.Subjects.ReadReflectionCached(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadReflectionCached(PrivateAccessProof.Types.Secret)
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,25BEAC04520
       mov       rcx,[rcx]
       call      qword ptr [7FFE0E1E75C0]; System.Reflection.RtFieldInfo.GetValue(System.Object)
       mov       rdx,rax
       mov       rax,rdx
       test      rax,rax
       je        short M01_L00
       mov       rcx,offset MT_System.String
       cmp       [rax],rcx
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFE0DEC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 64
```
```assembly
; System.Reflection.RtFieldInfo.GetValue(System.Object)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       test      byte ptr [rbx+38],1
       je        near ptr M02_L08
       mov       eax,[rbx+38]
M02_L00:
       mov       rcx,[rbx+8]
       cmp       byte ptr [rcx+94],0
       jne       near ptr M02_L13
       mov       rdi,[rbx+10]
M02_L01:
       test      rdi,rdi
       je        short M02_L02
       mov       rcx,offset MT_System.RuntimeType
       xor       edx,edx
       cmp       [rdi],rcx
       cmovne    rdi,rdx
M02_L02:
       test      al,2
       jne       near ptr M02_L12
       test      byte ptr [rbx+1C],10
       jne       short M02_L03
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M02_L15
M02_L03:
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        near ptr M02_L09
M02_L04:
       mov       rbp,rdx
       test      rbp,rbp
       je        short M02_L05
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbp],rcx
       jne       near ptr M02_L17
M02_L05:
       xor       ecx,ecx
       mov       [rsp+28],ecx
       test      rdi,rdi
       je        near ptr M02_L18
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        short M02_L10
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L10
M02_L06:
       movzx     ecx,byte ptr [rax+95]
       mov       [rsp+28],ecx
       lea       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rbp
       mov       r9,rdi
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rsi,rax
       movzx     ebx,byte ptr [rsp+28]
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        short M02_L11
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L11
M02_L07:
       mov       [rax+95],bl
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L08:
       mov       rcx,rbx
       call      qword ptr [7FFE0E1F5EC0]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       jmp       near ptr M02_L00
M02_L09:
       mov       rcx,rbx
       call      qword ptr [7FFE0E1F6088]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
       jmp       near ptr M02_L04
M02_L10:
       mov       rcx,rdi
       call      qword ptr [7FFE0DE16658]; System.RuntimeType.InitializeCache()
       jmp       short M02_L06
M02_L11:
       mov       rcx,rdi
       call      qword ptr [7FFE0DE16658]; System.RuntimeType.InitializeCache()
       jmp       short M02_L07
M02_L12:
       test      rdi,rdi
       je        short M02_L14
       mov       rcx,rbx
       call      qword ptr [7FFE0E1E6E48]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L14
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE0E3A5500]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE0E086718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L13:
       xor       edi,edi
       jmp       near ptr M02_L01
M02_L14:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0E1FCFD8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L15:
       test      rsi,rsi
       jne       short M02_L16
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE0E3AD998]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE0E175AB8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L16:
       call      qword ptr [7FFE0E3A4768]
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0E1E7570]
       mov       r14,rax
       mov       rbx,[rbx+10]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       r9,rax
       mov       rdx,r14
       mov       r8,rbx
       mov       rcx,rbp
       call      qword ptr [7FFE0E3A4078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE0DECF708]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L17:
       call      qword ptr [7FFE0DEC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M02_L18:
       lea       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rbp
       xor       r9d,r9d
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 625
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M03_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M03_L02
M03_L01:
       mov       rax,rdx
       ret
M03_L02:
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L01
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L01
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L01
       test      rax,rax
       jne       short M03_L00
M03_L03:
       lea       rax,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
       jmp       qword ptr [rax]
; Total bytes of code 73
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.Expression()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE0E2BCC30]; PrivateAccessProof.Subjects.ReadExpression(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadExpression(PrivateAccessProof.Types.Secret)
       sub       rsp,28
       mov       rdx,1B693404538
       mov       rax,[rdx]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,28
       ret
; Total bytes of code 33
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.Emit()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE0E2FCEB8]; PrivateAccessProof.Subjects.ReadEmit(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadEmit(PrivateAccessProof.Types.Secret)
       sub       rsp,28
       mov       rdx,20BBCC04548
       mov       rax,[rdx]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,28
       ret
; Total bytes of code 33
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.Accessor()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE0E2FCED0]; PrivateAccessProof.Subjects.ReadAccessor(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadAccessor(PrivateAccessProof.Types.Secret)
       mov       rax,[rcx+8]
       ret
; Total bytes of code 5
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.Direct()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE0E1DEA90]; PrivateAccessProof.Subjects.ReadDirect(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadDirect(PrivateAccessProof.Types.Secret)
       mov       rax,[rcx+8]
       ret
; Total bytes of code 5
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.ReflectionFresh()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE0E20EB68]; PrivateAccessProof.Subjects.ReadReflectionFresh(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadReflectionFresh(PrivateAccessProof.Types.Secret)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFE0E20EB80]; PrivateAccessProof.Types.Reflectors.FindTokenField()
       mov       rsi,rax
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rsi],rcx
       jne       near ptr M01_L09
       cmp       qword ptr [rsi+30],0
       je        short M01_L03
M01_L00:
       mov       rcx,[rsi+30]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE0E17D4A0]; System.Reflection.FieldAccessor.GetValue(System.Object)
       mov       rdx,rax
M01_L01:
       mov       rax,rdx
       test      rax,rax
       je        short M01_L02
       mov       rcx,offset MT_System.String
       cmp       [rax],rcx
       jne       near ptr M01_L10
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       call      qword ptr [7FFE0E064900]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       short M01_L06
M01_L04:
       test      rcx,rcx
       je        short M01_L08
       call      System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0E06CF00]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       jne       short M01_L07
       mov       dword ptr [rdi+20],0F
M01_L05:
       lea       rcx,[rsi+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L06:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       short M01_L04
M01_L07:
       mov       dword ptr [rdi+20],11
       jmp       short M01_L05
M01_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE0E2FCAF8]
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE0E2FCB10]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,[rsi]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L10:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 323
```
```assembly
; PrivateAccessProof.Types.Reflectors.FindTokenField()
       push      rbx
       sub       rsp,20
       mov       rcx,169F4A19040
       mov       rdx,169F4A19068
       mov       r8d,24
       call      qword ptr [7FFE0DDAA348]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       test      rax,rax
       je        short M02_L00
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,8D
       mov       rdx,7FFE0E0E5CE0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0E176DD8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 107
```
```assembly
; System.Reflection.FieldAccessor.GetValue(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
M03_L00:
       mov       edi,[rbx+20]
       test      edi,edi
       jne       short M03_L02
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M03_L16
       cmp       [rsi],sil
       mov       rax,[rbx+10]
       mov       rax,[rsi+rax+8]
M03_L01:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L02:
       cmp       edi,11
       ja        short M03_L03
       mov       ecx,edi
       lea       rax,[7FFE0DF0F388]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M03_L00]
       add       rax,rdx
       jmp       rax
M03_L03:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0E1AF930]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M03_L04
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0E1AF930]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M03_L04
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE0E2FCC30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0E176DD8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L04:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0E1AF930]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M03_L06
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M03_L05
       call      qword ptr [7FFE0E17D440]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M03_L05:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE0E06CF00]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       je        short M03_L06
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0E2FCC48]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L06:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE0E2FCC60]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFE0E17D4B8]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M03_L07
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       jne       short M03_L07
       test      rsi,rsi
       jne       near ptr M03_L17
       jmp       near ptr M03_L18
M03_L07:
       mov       dword ptr [rsp+28],1
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M03_L08
       call      qword ptr [7FFE0E17D440]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M03_L08:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       jmp       near ptr M03_L01
       mov       rcx,rbx
       call      qword ptr [7FFE0E17D4B8]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M03_L09
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       jne       short M03_L09
       test      rsi,rsi
       jne       near ptr M03_L17
       jmp       near ptr M03_L18
M03_L09:
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M03_L10
       call      qword ptr [7FFE0E17D440]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M03_L10:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rsi,rax
       cmp       byte ptr [rsp+28],0
       je        short M03_L11
       mov       rcx,rbx
       call      qword ptr [7FFE0E17D4E8]; System.Reflection.FieldAccessor.Initialize()
M03_L11:
       mov       rax,rsi
       jmp       near ptr M03_L01
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M03_L12
       call      qword ptr [7FFE0E17D440]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M03_L12:
       mov       rcx,rsi
       call      qword ptr [7FFE0E2FCC78]
       jmp       near ptr M03_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx]
       cmp       [rdx],dl
       add       rdx,8
       call      CORINFO_HELP_BOX_NULLABLE
       jmp       near ptr M03_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       call      CORINFO_HELP_BOX_NULLABLE
       jmp       near ptr M03_L01
       mov       rax,[rbx+10]
       mov       rax,[rax]
       jmp       near ptr M03_L01
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        short M03_L14
       cmp       [rsi],sil
       mov       rcx,[rbx+10]
       mov       rsi,[rsi+rcx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M03_L13
       call      qword ptr [7FFE0E17D440]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M03_L13:
       mov       rcx,rsi
       call      qword ptr [7FFE0E2FCC78]
       jmp       near ptr M03_L01
M03_L14:
       test      rsi,rsi
       jne       short M03_L17
       jmp       short M03_L18
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        short M03_L15
       cmp       [rsi],sil
       mov       rdx,[rbx+10]
       lea       rdx,[rsi+rdx+8]
       mov       rcx,[rbx+18]
       call      CORINFO_HELP_BOX_NULLABLE
       jmp       near ptr M03_L01
M03_L15:
       test      rsi,rsi
       jne       short M03_L17
       jmp       short M03_L18
M03_L16:
       test      rsi,rsi
       je        short M03_L18
M03_L17:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFE0E2FCC90]
       int       3
M03_L18:
       call      qword ptr [7FFE0E2FCCA8]
       int       3
; Total bytes of code 887
```
```assembly
; System.Type.GetRootElementType()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
M04_L00:
       cmp       rsi,[rbx]
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFE6C9B2570]; System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,1D
       ja        short M04_L01
       mov       ecx,1FEF7FFF
       bt        ecx,eax
       jae       short M04_L03
M04_L01:
       cmp       eax,10
       sete      dl
       movzx     edx,dl
M04_L02:
       test      edx,edx
       jne       short M04_L04
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       edx,1
       jmp       short M04_L02
M04_L04:
       mov       rcx,rbx
       lea       r11,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M04_L00
M04_L05:
       mov       rcx,rbx
       lea       r11,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
       call      qword ptr [r11]
       mov       edx,eax
       jmp       short M04_L02
; Total bytes of code 110
```
```assembly
; System.RuntimeType.get_IsNullableOfT()
       mov       rax,[rcx+18]
       test      al,2
       jne       short M05_L01
       mov       eax,[rax]
       and       eax,0F0000
       cmp       eax,50000
       sete      dl
       movzx     edx,dl
M05_L00:
       movzx     eax,dl
       ret
M05_L01:
       xor       edx,edx
       jmp       short M05_L00
; Total bytes of code 34
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M06_L00
       cmp       [rdx],rcx
       jne       short M06_L01
M06_L00:
       mov       rax,rdx
       ret
M06_L01:
       jmp       qword ptr [7FFE0E064AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
**Extern method**
System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.ReflectionCached()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE0E1DEA90]; PrivateAccessProof.Subjects.ReadReflectionCached(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadReflectionCached(PrivateAccessProof.Types.Secret)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,243A4C01320
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+30],0
       je        short M01_L02
M01_L00:
       mov       rcx,[rsi+30]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE0E14D4A0]; System.Reflection.FieldAccessor.GetValue(System.Object)
       mov       rdx,rax
       mov       rax,rdx
       test      rax,rax
       je        short M01_L01
       mov       rcx,offset MT_System.String
       cmp       [rax],rcx
       jne       near ptr M01_L07
M01_L01:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       call      qword ptr [7FFE0E034900]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       short M01_L05
M01_L03:
       test      rcx,rcx
       je        short M01_L08
       call      System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0E03CF00]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       jne       short M01_L06
       mov       dword ptr [rdi+20],0F
M01_L04:
       lea       rcx,[rsi+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L05:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       short M01_L03
M01_L06:
       mov       dword ptr [rdi+20],11
       jmp       short M01_L04
M01_L07:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE0E2CC8D0]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE0E2CC8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 285
```
```assembly
; System.Reflection.FieldAccessor.GetValue(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
M02_L00:
       mov       edi,[rbx+20]
       test      edi,edi
       jne       short M02_L02
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M02_L16
       cmp       [rsi],sil
       mov       rax,[rbx+10]
       mov       rax,[rsi+rax+8]
M02_L01:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       cmp       edi,11
       ja        short M02_L03
       mov       ecx,edi
       lea       rax,[7FFE0DEDDDB8]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
M02_L03:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0E17F930]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M02_L04
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0E17F930]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L04
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE0E2CCA20]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0E146DD8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L04:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0E17F930]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M02_L06
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L05
       call      qword ptr [7FFE0E14D440]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L05:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE0E03CF00]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       je        short M02_L06
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE0E2CCA38]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L06:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE0E2CCA50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFE0E14D4B8]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M02_L07
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       jne       short M02_L07
       test      rsi,rsi
       jne       near ptr M02_L17
       jmp       near ptr M02_L18
M02_L07:
       mov       dword ptr [rsp+28],1
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L08
       call      qword ptr [7FFE0E14D440]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L08:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       jmp       near ptr M02_L01
       mov       rcx,rbx
       call      qword ptr [7FFE0E14D4B8]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M02_L09
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       jne       short M02_L09
       test      rsi,rsi
       jne       near ptr M02_L17
       jmp       near ptr M02_L18
M02_L09:
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L10
       call      qword ptr [7FFE0E14D440]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L10:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rsi,rax
       cmp       byte ptr [rsp+28],0
       je        short M02_L11
       mov       rcx,rbx
       call      qword ptr [7FFE0E14D4E8]; System.Reflection.FieldAccessor.Initialize()
M02_L11:
       mov       rax,rsi
       jmp       near ptr M02_L01
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L12
       call      qword ptr [7FFE0E14D440]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L12:
       mov       rcx,rsi
       call      qword ptr [7FFE0E2CCA68]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx]
       cmp       [rdx],dl
       add       rdx,8
       call      CORINFO_HELP_BOX_NULLABLE
       jmp       near ptr M02_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       call      CORINFO_HELP_BOX_NULLABLE
       jmp       near ptr M02_L01
       mov       rax,[rbx+10]
       mov       rax,[rax]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        short M02_L14
       cmp       [rsi],sil
       mov       rcx,[rbx+10]
       mov       rsi,[rsi+rcx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L13
       call      qword ptr [7FFE0E14D440]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L13:
       mov       rcx,rsi
       call      qword ptr [7FFE0E2CCA68]
       jmp       near ptr M02_L01
M02_L14:
       test      rsi,rsi
       jne       short M02_L17
       jmp       short M02_L18
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        short M02_L15
       cmp       [rsi],sil
       mov       rdx,[rbx+10]
       lea       rdx,[rsi+rdx+8]
       mov       rcx,[rbx+18]
       call      CORINFO_HELP_BOX_NULLABLE
       jmp       near ptr M02_L01
M02_L15:
       test      rsi,rsi
       jne       short M02_L17
       jmp       short M02_L18
M02_L16:
       test      rsi,rsi
       je        short M02_L18
M02_L17:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFE0E2CCA80]
       int       3
M02_L18:
       call      qword ptr [7FFE0E2CCA98]
       int       3
; Total bytes of code 887
```
```assembly
; System.Type.GetRootElementType()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
M03_L00:
       cmp       rsi,[rbx]
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE6C9B2570]; System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,1D
       ja        short M03_L01
       mov       ecx,1FEF7FFF
       bt        ecx,eax
       jae       short M03_L03
M03_L01:
       cmp       eax,10
       sete      dl
       movzx     edx,dl
M03_L02:
       test      edx,edx
       jne       short M03_L04
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       edx,1
       jmp       short M03_L02
M03_L04:
       mov       rcx,rbx
       lea       r11,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M03_L00
M03_L05:
       mov       rcx,rbx
       lea       r11,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
       call      qword ptr [r11]
       mov       edx,eax
       jmp       short M03_L02
; Total bytes of code 110
```
```assembly
; System.RuntimeType.get_IsNullableOfT()
       mov       rax,[rcx+18]
       test      al,2
       jne       short M04_L01
       mov       eax,[rax]
       and       eax,0F0000
       cmp       eax,50000
       sete      dl
       movzx     edx,dl
M04_L00:
       movzx     eax,dl
       ret
M04_L01:
       xor       edx,edx
       jmp       short M04_L00
; Total bytes of code 34
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L00
       cmp       [rdx],rcx
       jne       short M05_L01
M05_L00:
       mov       rax,rdx
       ret
M05_L01:
       jmp       qword ptr [7FFE0E034AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
**Extern method**
System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.Expression()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE0E1EEB68]; PrivateAccessProof.Subjects.ReadExpression(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadExpression(PrivateAccessProof.Types.Secret)
       sub       rsp,28
       mov       rdx,29E3C801338
       mov       rax,[rdx]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,28
       ret
; Total bytes of code 33
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.Emit()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE0E1FEA90]; PrivateAccessProof.Subjects.ReadEmit(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadEmit(PrivateAccessProof.Types.Secret)
       sub       rsp,28
       mov       rdx,14368C01348
       mov       rax,[rdx]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,28
       ret
; Total bytes of code 33
```

## .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.ReadBench.Accessor()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE0E1EEB50]; PrivateAccessProof.Subjects.ReadAccessor(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadAccessor(PrivateAccessProof.Types.Secret)
       mov       rax,[rcx+8]
       ret
; Total bytes of code 5
```

