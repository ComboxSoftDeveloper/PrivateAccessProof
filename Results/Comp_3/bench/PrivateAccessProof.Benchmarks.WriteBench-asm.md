## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.WriteBench.Reflection()
       mov       rcx,[rcx+8]
       mov       rdx,2734E8A8AF0
       jmp       qword ptr [7FFDF2A6F888]; PrivateAccessProof.Subjects.WriteReflection(PrivateAccessProof.Types.Secret, System.String)
; Total bytes of code 20
```
```assembly
; PrivateAccessProof.Subjects.WriteReflection(PrivateAccessProof.Types.Secret, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rax,232BA001308
       mov       rdi,[rax]
       mov       rbp,rdi
       call      qword ptr [7FFDF2B46E98]; System.Type.get_DefaultBinder()
       mov       r14,rax
       cmp       qword ptr [rbp+30],0
       jne       near ptr M01_L03
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+10]
       cmp       [rcx],cl
       call      qword ptr [7FFDF28A4B58]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M01_L04
M01_L00:
       test      rcx,rcx
       je        near ptr M01_L05
       call      00007FFE52272E70
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r15+8]
       mov       rcx,[rcx+10]
       mov       rdx,[rcx+18]
       test      dl,2
       jne       near ptr M01_L06
       mov       edx,[rdx]
       and       edx,0F0000
       cmp       edx,50000
       sete      dl
       movzx     edx,dl
M01_L01:
       test      edx,edx
       jne       near ptr M01_L07
       mov       dword ptr [r15+20],0F
M01_L02:
       lea       rcx,[rbp+30]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       mov       [rsp+20],r14
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFDF2B46F58]; System.Reflection.FieldAccessor.SetValue(System.Object, System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDF2B4D620]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFDF2B4D638]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L06:
       xor       edx,edx
       jmp       near ptr M01_L01
M01_L07:
       mov       dword ptr [r15+20],11
       jmp       near ptr M01_L02
; Total bytes of code 344
```
```assembly
; System.Type.get_DefaultBinder()
       sub       rsp,28
       mov       rcx,232BA0002E0
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       mov       rcx,offset MT_System.DefaultBinder
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       rcx,232BA0002E0
       xor       r8d,r8d
       call      00007FFE5226FBA0
       mov       rcx,232BA0002E0
       test      rax,rax
       cmove     rax,[rcx]
       jmp       short M02_L00
; Total bytes of code 82
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
       call      qword ptr [7FFE512DA818]; Precode of System.RuntimeType.GetCorElementType()
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
; System.Reflection.FieldAccessor.SetValue(System.Object, System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+90],r8
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r9d
M04_L00:
       mov       ecx,[rbx+20]
       test      ecx,ecx
       jne       near ptr M04_L08
       mov       rbp,[rsp+0A8]
       mov       r14,[rsp+0A0]
M04_L01:
       mov       rcx,[rbx+8]
       mov       r15,[rcx+10]
       mov       rcx,[r15+18]
       mov       r13,rsi
       test      r13,r13
       je        short M04_L02
       mov       rdx,[r13]
       cmp       rdx,rcx
       jne       near ptr M04_L11
M04_L02:
       mov       rax,r13
M04_L03:
       test      rax,rax
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M04_L18
       cmp       qword ptr [rsp+90],0
       je        near ptr M04_L20
       mov       rcx,[rsp+90]
       call      qword ptr [7FFDF28AD860]; System.Object.GetType()
       mov       r15,rax
       mov       rcx,[rbx+8]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M04_L07
M04_L04:
       cmp       r15,rax
       jne       near ptr M04_L23
M04_L05:
       cmp       [rsi],sil
       mov       rcx,[rbx+10]
       lea       rcx,[rsi+rcx+8]
       mov       rdx,[rsp+90]
       call      CORINFO_HELP_ASSIGN_REF
M04_L06:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L07:
       call      qword ptr [7FFDF29CE268]; System.Reflection.RtFieldInfo.InitializeFieldType()
       jmp       short M04_L04
M04_L08:
       cmp       ecx,11
       ja        short M04_L09
       mov       ecx,ecx
       lea       rax,[7FFDF273E898]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M04_L00]
       add       rax,rdx
       jmp       rax
       mov       r14,[rsp+0A0]
       jmp       short M04_L10
       mov       rbp,[rsp+0A8]
       mov       r14,[rsp+0A0]
       jmp       near ptr M04_L01
M04_L09:
       mov       r14,[rsp+0A0]
M04_L10:
       mov       rcx,rbx
       call      qword ptr [7FFDF29CE2F8]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       je        near ptr M04_L30
       jmp       near ptr M04_L29
M04_L11:
       mov       rax,232BA000038
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
       jge       short M04_L15
M04_L12:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       lea       r9,[r9+r9*2]
       lea       r9,[rax+r9*8]
       mov       r11d,[r9]
       mov       r12,[r9+8]
       and       r11d,0FFFFFFFE
       cmp       r12,rdx
       jne       short M04_L13
       mov       r12,rcx
       xor       r12,[r9+10]
       cmp       r12,1
       jbe       short M04_L14
M04_L13:
       test      r11d,r11d
       je        short M04_L15
       inc       r10d
       add       r8d,r10d
       and       r8d,[rax+4]
       cmp       r10d,8
       jl        short M04_L12
       jmp       short M04_L15
M04_L14:
       cmp       r11d,[r9]
       jne       short M04_L15
       jmp       short M04_L16
M04_L15:
       mov       r12d,2
M04_L16:
       cmp       r12d,1
       je        near ptr M04_L02
       test      r12d,r12d
       jne       short M04_L17
       xor       r13d,r13d
       jmp       near ptr M04_L02
M04_L17:
       mov       rdx,rsi
       call      qword ptr [7FFDF269FA98]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
       jmp       near ptr M04_L03
M04_L18:
       test      rsi,rsi
       jne       short M04_L19
       call      qword ptr [7FFDF2B4D740]
       int       3
M04_L19:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFDF2B4D758]
       int       3
M04_L20:
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M04_L21
       call      qword ptr [7FFDF29CE268]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M04_L21:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFDF2696328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFDF28ACF48]; System.RuntimeType.get_IsActualValueType()
       test      eax,eax
       je        near ptr M04_L05
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M04_L22
       call      qword ptr [7FFDF29CE268]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M04_L22:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFDF2696328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       [rsp+20],edi
       lea       rdx,[rsp+90]
       mov       r8,r14
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFDF28AD890]; System.RuntimeType.CheckValue(System.Object ByRef, System.Reflection.Binder, System.Globalization.CultureInfo, System.Reflection.BindingFlags)
       jmp       near ptr M04_L05
M04_L23:
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M04_L24
       call      qword ptr [7FFDF29CE268]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M04_L24:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFDF2696328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       [rsp+20],edi
       lea       rdx,[rsp+90]
       mov       r8,r14
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFDF28AD890]; System.RuntimeType.CheckValue(System.Object ByRef, System.Reflection.Binder, System.Globalization.CultureInfo, System.Reflection.BindingFlags)
       jmp       near ptr M04_L05
       mov       r14,[rsp+0A0]
       mov       [rsp+20],r14
       mov       rbp,[rsp+0A8]
       mov       [rsp+28],rbp
       lea       r8,[rsp+90]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r9d,edi
       call      qword ptr [7FFDF2B46F70]; System.Reflection.FieldAccessor.VerifyInstanceField(System.Object, System.Object ByRef, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
       cmp       [rsi],sil
       mov       rcx,[rbx+10]
       lea       rcx,[rsi+rcx+8]
       mov       rdx,[rsp+90]
       movzx     edx,byte ptr [rdx+8]
       mov       [rcx],dl
       jmp       near ptr M04_L06
       mov       r14,[rsp+0A0]
       mov       [rsp+20],r14
       mov       rbp,[rsp+0A8]
       mov       [rsp+28],rbp
       lea       r8,[rsp+90]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r9d,edi
       call      qword ptr [7FFDF2B46F70]; System.Reflection.FieldAccessor.VerifyInstanceField(System.Object, System.Object ByRef, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
       cmp       [rsi],sil
       mov       r8,[rbx+10]
       lea       r8,[rsi+r8+8]
       mov       rcx,[rsp+90]
       movsx     rcx,word ptr [rcx+8]
       mov       [r8],cx
       jmp       near ptr M04_L06
       mov       r14,[rsp+0A0]
       mov       [rsp+20],r14
       mov       rbp,[rsp+0A8]
       mov       [rsp+28],rbp
       lea       r8,[rsp+90]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r9d,edi
       call      qword ptr [7FFDF2B46F70]; System.Reflection.FieldAccessor.VerifyInstanceField(System.Object, System.Object ByRef, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
       cmp       [rsi],sil
       mov       r8,[rbx+10]
       lea       r8,[rsi+r8+8]
       mov       rcx,[rsp+90]
       mov       ecx,[rcx+8]
       mov       [r8],ecx
       jmp       near ptr M04_L06
       mov       r14,[rsp+0A0]
       mov       [rsp+20],r14
       mov       rbp,[rsp+0A8]
       mov       [rsp+28],rbp
       lea       r8,[rsp+90]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r9d,edi
       call      qword ptr [7FFDF2B46F70]; System.Reflection.FieldAccessor.VerifyInstanceField(System.Object, System.Object ByRef, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
       cmp       [rsi],sil
       mov       r8,[rbx+10]
       lea       r8,[rsi+r8+8]
       mov       rcx,[rsp+90]
       mov       rcx,[rcx+8]
       mov       [r8],rcx
       jmp       near ptr M04_L06
       mov       r14,[rsp+0A0]
       mov       rbp,[rsp+0A8]
       mov       [rsp+20],rbp
       lea       rdx,[rsp+90]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r9,r14
       call      qword ptr [7FFDF2B4D6E0]
       mov       rcx,[rbx+10]
       mov       rdx,[rsp+90]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M04_L06
       mov       r14,[rsp+0A0]
       mov       rbp,[rsp+0A8]
       mov       [rsp+20],rbp
       lea       rdx,[rsp+90]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r9,r14
       call      qword ptr [7FFDF2B4D6E0]
       mov       rdx,[rbx+10]
       mov       rcx,[rsp+90]
       movzx     ecx,byte ptr [rcx+8]
       mov       [rdx],cl
       jmp       near ptr M04_L06
       mov       r14,[rsp+0A0]
       mov       rbp,[rsp+0A8]
       mov       [rsp+20],rbp
       lea       rdx,[rsp+90]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r9,r14
       call      qword ptr [7FFDF2B4D6E0]
       mov       rdx,[rbx+10]
       mov       rcx,[rsp+90]
       movsx     rcx,word ptr [rcx+8]
       mov       [rdx],cx
       jmp       near ptr M04_L06
       mov       r14,[rsp+0A0]
       mov       rbp,[rsp+0A8]
       mov       [rsp+20],rbp
       lea       rdx,[rsp+90]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r9,r14
       call      qword ptr [7FFDF2B4D6E0]
       mov       rdx,[rbx+10]
       mov       rcx,[rsp+90]
       mov       ecx,[rcx+8]
       mov       [rdx],ecx
       jmp       near ptr M04_L06
       mov       r14,[rsp+0A0]
       mov       rbp,[rsp+0A8]
       mov       [rsp+20],rbp
       lea       rdx,[rsp+90]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r9,r14
       call      qword ptr [7FFDF2B4D6E0]
       mov       rdx,[rbx+10]
       mov       rcx,[rsp+90]
       mov       rcx,[rcx+8]
       mov       [rdx],rcx
       jmp       near ptr M04_L06
       mov       rcx,rbx
       call      qword ptr [7FFDF29CE2F8]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       je        short M04_L25
       mov       rbp,[rsp+0A8]
       mov       [rsp+20],rbp
       lea       rdx,[rsp+90]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r9,[rsp+0A0]
       call      qword ptr [7FFDF2B4D6E0]
       jmp       short M04_L26
M04_L25:
       mov       r14,[rsp+0A0]
       mov       [rsp+20],r14
       mov       rbp,[rsp+0A8]
       mov       [rsp+28],rbp
       lea       r8,[rsp+90]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r9d,edi
       call      qword ptr [7FFDF2B46F70]; System.Reflection.FieldAccessor.VerifyInstanceField(System.Object, System.Object ByRef, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
M04_L26:
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       rbp,[rbx+8]
       mov       rdi,[rsp+90]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M04_L27
       call      qword ptr [7FFDF29CE268]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M04_L27:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFDF2696328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r9,rax
       mov       rdx,[rbx+8]
       mov       rdx,[rdx+10]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+30]
       mov       [rsp+28],rdx
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,rbp
       call      qword ptr [7FFDF2B46F88]; System.RuntimeFieldHandle.SetValue(System.Reflection.RtFieldInfo, System.Object, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        near ptr M04_L06
       mov       rcx,rbx
       call      qword ptr [7FFDF29CE328]; System.Reflection.FieldAccessor.Initialize()
       jmp       near ptr M04_L06
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF2A223A0]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M04_L28
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF2A223A0]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M04_L28
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDF2B4D710]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDF29C7A38]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L28:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFDF2B4D728]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M04_L29:
       mov       rbp,[rsp+0A8]
       mov       [rsp+20],rbp
       lea       rdx,[rsp+90]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r9,r14
       call      qword ptr [7FFDF2B4D6E0]
       jmp       short M04_L31
M04_L30:
       mov       [rsp+20],r14
       mov       rbp,[rsp+0A8]
       mov       [rsp+28],rbp
       lea       r8,[rsp+90]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r9d,edi
       call      qword ptr [7FFDF2B46F70]; System.Reflection.FieldAccessor.VerifyInstanceField(System.Object, System.Object ByRef, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
M04_L31:
       mov       dword ptr [rsp+30],1
       mov       rdi,[rbx+8]
       mov       rbp,[rsp+90]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M04_L32
       call      qword ptr [7FFDF29CE268]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M04_L32:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFDF2696328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r9,rax
       mov       rdx,[rbx+8]
       mov       rdx,[rdx+10]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+30]
       mov       [rsp+28],rdx
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,rdi
       call      qword ptr [7FFDF2B46F88]; System.RuntimeFieldHandle.SetValue(System.Reflection.RtFieldInfo, System.Object, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       jmp       near ptr M04_L06
; Total bytes of code 1908
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.WriteBench.Expression()
       mov       rcx,[rcx+8]
       mov       rdx,28293778AF0
       jmp       qword ptr [7FFDF2A6F960]; PrivateAccessProof.Subjects.WriteExpression(PrivateAccessProof.Types.Secret, System.String)
; Total bytes of code 20
```
```assembly
; PrivateAccessProof.Subjects.WriteExpression(PrivateAccessProof.Types.Secret, System.String)
       sub       rsp,28
       mov       r8,rdx
       mov       rdx,241FF001328
       mov       rax,[rdx]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,28
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.WriteBench.Emit()
       mov       rcx,[rcx+8]
       mov       rdx,2349EE98AF0
       jmp       qword ptr [7FFDF2A4F948]; PrivateAccessProof.Subjects.WriteEmit(PrivateAccessProof.Types.Secret, System.String)
; Total bytes of code 20
```
```assembly
; PrivateAccessProof.Subjects.WriteEmit(PrivateAccessProof.Types.Secret, System.String)
       sub       rsp,28
       mov       r8,rdx
       mov       rdx,1F40A401338
       mov       rax,[rdx]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,28
       ret
; Total bytes of code 36
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.WriteBench.Accessor()
       mov       rcx,[rcx+8]
       mov       rdx,287CBA98AF0
       jmp       qword ptr [7FFDF2A5F960]; PrivateAccessProof.Subjects.WriteAccessor(PrivateAccessProof.Types.Secret, System.String)
; Total bytes of code 20
```
```assembly
; PrivateAccessProof.Subjects.WriteAccessor(PrivateAccessProof.Types.Secret, System.String)
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 11
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.WriteBench.Reflection()
       mov       rcx,[rcx+8]
       mov       rdx,27614A38D90
       jmp       qword ptr [7FFDC8E4E160]; PrivateAccessProof.Subjects.WriteReflection(PrivateAccessProof.Types.Secret, System.String)
; Total bytes of code 20
```
```assembly
; PrivateAccessProof.Subjects.WriteReflection(PrivateAccessProof.Types.Secret, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rax,1F50FC04520
       mov       rdi,[rax]
       call      qword ptr [7FFDC8995FC8]; System.Type.get_DefaultBinder()
       xor       edx,edx
       mov       [rsp+28],rdx
       mov       [rsp+20],rax
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,rdi
       xor       r9d,r9d
       call      qword ptr [7FFDC8D799A0]; System.Reflection.RtFieldInfo.SetValue(System.Object, System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 71
```
```assembly
; System.Type.get_DefaultBinder()
       push      rbx
       sub       rsp,20
       mov       rbx,1F50FC00108
       cmp       qword ptr [rbx],0
       je        short M02_L01
M02_L00:
       mov       rax,[rbx]
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       rcx,offset MT_System.DefaultBinder
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       rcx,1F50FC00108
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       jmp       short M02_L00
; Total bytes of code 68
```
```assembly
; System.Reflection.RtFieldInfo.SetValue(System.Object, System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+80],r8
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r9d
       test      byte ptr [rbx+38],1
       je        near ptr M03_L09
       mov       eax,[rbx+38]
M03_L00:
       mov       rcx,[rbx+8]
       cmp       byte ptr [rcx+94],0
       jne       near ptr M03_L15
       mov       rbp,[rbx+10]
M03_L01:
       test      rbp,rbp
       je        short M03_L02
       mov       rcx,offset MT_System.RuntimeType
       xor       edx,edx
       cmp       [rbp],rcx
       cmovne    rbp,rdx
M03_L02:
       test      al,2
       jne       near ptr M03_L14
       test      byte ptr [rbx+1C],10
       jne       short M03_L03
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M03_L17
M03_L03:
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        near ptr M03_L10
M03_L04:
       mov       r14,rdx
       test      r14,r14
       je        short M03_L05
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       jne       near ptr M03_L19
M03_L05:
       cmp       qword ptr [rsp+80],0
       je        near ptr M03_L13
       mov       rcx,[rsp+80]
       call      System.Object.GetType()
       cmp       rax,r14
       jne       near ptr M03_L20
M03_L06:
       xor       ecx,ecx
       mov       [rsp+38],ecx
       test      rbp,rbp
       je        near ptr M03_L21
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        near ptr M03_L11
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L11
M03_L07:
       movzx     ecx,byte ptr [rax+95]
       mov       [rsp+38],ecx
       mov       ecx,[rbx+1C]
       mov       [rsp+20],ecx
       mov       [rsp+28],rbp
       lea       rcx,[rsp+38]
       mov       [rsp+30],rcx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,[rsp+80]
       mov       r9,r14
       call      System.RuntimeFieldHandle.SetValue(System.Reflection.RtFieldInfo, System.Object, System.Object, System.RuntimeType, System.Reflection.FieldAttributes, System.RuntimeType, Boolean ByRef)
       movzx     ebx,byte ptr [rsp+38]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M03_L12
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L12
M03_L08:
       mov       [rax+95],bl
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L09:
       mov       rcx,rbx
       call      qword ptr [7FFDC8D57AC8]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       jmp       near ptr M03_L00
M03_L10:
       mov       rcx,rbx
       call      qword ptr [7FFDC8D57C90]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
       jmp       near ptr M03_L04
M03_L11:
       mov       rcx,rbp
       call      qword ptr [7FFDC8996658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M03_L07
M03_L12:
       mov       rcx,rbp
       call      qword ptr [7FFDC8996658]; System.RuntimeType.InitializeCache()
       jmp       short M03_L08
M03_L13:
       mov       rcx,r14
       call      System.RuntimeTypeHandle.IsValueType(System.RuntimeType)
       test      eax,eax
       je        near ptr M03_L06
       jmp       near ptr M03_L20
M03_L14:
       test      rbp,rbp
       je        short M03_L16
       mov       rcx,rbp
       call      qword ptr [7FFDC898A790]; Precode of System.RuntimeType.get_ContainsGenericParameters()
       test      eax,eax
       je        short M03_L16
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC8F06E08]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFDC8C06718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L15:
       xor       ebp,ebp
       jmp       near ptr M03_L01
M03_L16:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC8D5EB08]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L17:
       test      rsi,rsi
       jne       short M03_L18
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDC8F0F810]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFDC8CF5AB8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L18:
       call      qword ptr [7FFDC8F06070]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC8D79948]
       mov       rbp,rax
       mov       rbx,[rbx+10]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rbx
       mov       rcx,rdi
       call      qword ptr [7FFDC8F05980]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFDC8A4F708]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L19:
       call      qword ptr [7FFDC8A443F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L20:
       mov       [rsp+20],edi
       lea       rdx,[rsp+80]
       mov       rcx,r14
       mov       r8,[rsp+90]
       mov       r9,[rsp+98]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC89973C0]; System.RuntimeType.CheckValue(System.Object ByRef, System.Reflection.Binder, System.Globalization.CultureInfo, System.Reflection.BindingFlags)
       jmp       near ptr M03_L06
M03_L21:
       mov       ecx,[rbx+1C]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+38]
       mov       [rsp+30],rcx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,[rsp+80]
       mov       r9,r14
       call      System.RuntimeFieldHandle.SetValue(System.Reflection.RtFieldInfo, System.Object, System.Object, System.RuntimeType, System.Reflection.FieldAttributes, System.RuntimeType, Boolean ByRef)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 764
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.WriteBench.Expression()
       mov       rcx,[rcx+8]
       mov       rdx,26CD24A8D90
       jmp       qword ptr [7FFDC8E3E988]; PrivateAccessProof.Subjects.WriteExpression(PrivateAccessProof.Types.Secret, System.String)
; Total bytes of code 20
```
```assembly
; PrivateAccessProof.Subjects.WriteExpression(PrivateAccessProof.Types.Secret, System.String)
       sub       rsp,28
       mov       r8,rdx
       mov       rdx,1EBCD804540
       mov       rax,[rdx]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,28
       ret
; Total bytes of code 36
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.WriteBench.Emit()
       mov       rcx,[rcx+8]
       mov       rdx,32EE7038D90
       jmp       qword ptr [7FFDC8E6E190]; PrivateAccessProof.Subjects.WriteEmit(PrivateAccessProof.Types.Secret, System.String)
; Total bytes of code 20
```
```assembly
; PrivateAccessProof.Subjects.WriteEmit(PrivateAccessProof.Types.Secret, System.String)
       sub       rsp,28
       mov       r8,rdx
       mov       rdx,2ADE2404550
       mov       rax,[rdx]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,28
       ret
; Total bytes of code 36
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.WriteBench.Accessor()
       mov       rcx,[rcx+8]
       mov       rdx,2477B518D90
       jmp       qword ptr [7FFDC8E3E1A8]; PrivateAccessProof.Subjects.WriteAccessor(PrivateAccessProof.Types.Secret, System.String)
; Total bytes of code 20
```
```assembly
; PrivateAccessProof.Subjects.WriteAccessor(PrivateAccessProof.Types.Secret, System.String)
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 11
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.WriteBench.Reflection()
       mov       rcx,[rcx+8]
       mov       rdx,1A2018E9040
       jmp       qword ptr [7FFD93DDEBB0]; PrivateAccessProof.Subjects.WriteReflection(PrivateAccessProof.Types.Secret, System.String)
; Total bytes of code 20
```
```assembly
; PrivateAccessProof.Subjects.WriteReflection(PrivateAccessProof.Types.Secret, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rax,1A280001318
       mov       rdi,[rax]
       mov       rbp,rdi
       call      qword ptr [7FFD93EC63A0]; System.Type.get_DefaultBinder()
       mov       r14,rax
       cmp       qword ptr [rbp+30],0
       je        short M01_L01
M01_L00:
       mov       [rsp+20],r14
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFD93EC6460]; System.Reflection.FieldAccessor.SetValue(System.Object, System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+10]
       cmp       [rcx],cl
       call      qword ptr [7FFD93C349F0]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       short M01_L04
M01_L02:
       test      rcx,rcx
       je        short M01_L06
       call      System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)
       test      eax,eax
       jne       short M01_L05
       mov       rcx,[r15+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD93C3CFF0]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       jne       short M01_L05
       mov       dword ptr [r15+20],0F
M01_L03:
       lea       rcx,[rbp+30]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       short M01_L02
M01_L05:
       mov       dword ptr [r15+20],11
       jmp       short M01_L03
M01_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD93ECCA50]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD93ECCA68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 291
```
```assembly
; System.Type.get_DefaultBinder()
       sub       rsp,28
       mov       rax,1A2800002F0
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       mov       rcx,offset MT_System.DefaultBinder
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       rcx,1A2800002F0
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchangeObject(System.Object ByRef, System.Object, System.Object)
       mov       rcx,1A2800002F0
       test      rax,rax
       cmove     rax,[rcx]
       jmp       short M02_L00
; Total bytes of code 82
```
```assembly
; System.Reflection.FieldAccessor.SetValue(System.Object, System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+80],r8
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r9d
M03_L00:
       mov       ebp,[rbx+20]
       test      ebp,ebp
       jne       near ptr M03_L05
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M03_L19
       cmp       qword ptr [rsp+80],0
       je        near ptr M03_L16
       mov       rcx,[rsp+80]
       call      System.Object.GetType()
       mov       rbp,rax
       mov       rcx,[rbx+8]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M03_L04
M03_L01:
       cmp       rbp,rax
       jne       near ptr M03_L14
M03_L02:
       cmp       [rsi],sil
       mov       rcx,[rbx+10]
       lea       rcx,[rsi+rcx+8]
       mov       rdx,[rsp+80]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       call      qword ptr [7FFD93D4D500]; System.Reflection.RtFieldInfo.InitializeFieldType()
       jmp       short M03_L01
M03_L05:
       cmp       ebp,11
       ja        near ptr M03_L10
       mov       ecx,ebp
       lea       rax,[7FFD93ADE420]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M03_L00]
       add       rax,rdx
       jmp       rax
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD93D936C8]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M03_L06
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD93D936C8]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M03_L06
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD93ECCBD0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD93D46E98]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L06:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFD93ECCBE8]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFD93D4D578]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       je        short M03_L07
       mov       r14,[rsp+98]
       mov       [rsp+20],r14
       lea       rdx,[rsp+80]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r9,[rsp+90]
       call      qword ptr [7FFD93ECCC18]
       jmp       short M03_L08
M03_L07:
       mov       r15,[rsp+90]
       mov       [rsp+20],r15
       mov       r14,[rsp+98]
       mov       [rsp+28],r14
       lea       r8,[rsp+80]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r9d,edi
       call      qword ptr [7FFD93EC6478]; System.Reflection.FieldAccessor.VerifyInstanceField(System.Object, System.Object ByRef, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
M03_L08:
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       r14,[rbx+8]
       mov       rdi,[rsp+80]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M03_L09
       call      qword ptr [7FFD93D4D500]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M03_L09:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFD93A261C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r9,rax
       mov       rdx,[rbx+8]
       mov       rdx,[rdx+10]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+30]
       mov       [rsp+28],rdx
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,r14
       call      System.RuntimeFieldHandle.SetValue(System.Reflection.RtFieldInfo, System.Object, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       cmp       byte ptr [rsp+30],0
       je        near ptr M03_L03
       mov       rcx,rbx
       call      qword ptr [7FFD93D4D5A8]; System.Reflection.FieldAccessor.Initialize()
       jmp       near ptr M03_L03
       mov       r15,[rsp+90]
       mov       r14,[rsp+98]
       mov       [rsp+20],r14
       lea       rdx,[rsp+80]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r9,r15
       call      qword ptr [7FFD93ECCC18]
       mov       rdx,[rbx+10]
       mov       rcx,[rsp+80]
       mov       rcx,[rcx+8]
       mov       [rdx],rcx
       jmp       near ptr M03_L03
       mov       r15,[rsp+90]
       mov       r14,[rsp+98]
       mov       [rsp+20],r14
       lea       rdx,[rsp+80]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r9,r15
       call      qword ptr [7FFD93ECCC18]
       mov       rdx,[rbx+10]
       mov       rcx,[rsp+80]
       mov       ecx,[rcx+8]
       mov       [rdx],ecx
       jmp       near ptr M03_L03
       mov       r15,[rsp+90]
       mov       r14,[rsp+98]
       mov       [rsp+20],r14
       lea       rdx,[rsp+80]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r9,r15
       call      qword ptr [7FFD93ECCC18]
       mov       rdx,[rbx+10]
       mov       rcx,[rsp+80]
       movsx     rcx,word ptr [rcx+8]
       mov       [rdx],cx
       jmp       near ptr M03_L03
       mov       r15,[rsp+90]
       mov       r14,[rsp+98]
       mov       [rsp+20],r14
       lea       rdx,[rsp+80]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r9,r15
       call      qword ptr [7FFD93ECCC18]
       mov       rdx,[rbx+10]
       mov       rcx,[rsp+80]
       movzx     ecx,byte ptr [rcx+8]
       mov       [rdx],cl
       jmp       near ptr M03_L03
       mov       r15,[rsp+90]
       mov       r14,[rsp+98]
       mov       [rsp+20],r14
       lea       rdx,[rsp+80]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r9,r15
       call      qword ptr [7FFD93ECCC18]
       mov       rcx,[rbx+10]
       mov       rdx,[rsp+80]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L03
       mov       r15,[rsp+90]
       mov       [rsp+20],r15
       mov       r14,[rsp+98]
       mov       [rsp+28],r14
       lea       r8,[rsp+80]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r9d,edi
       call      qword ptr [7FFD93EC6478]; System.Reflection.FieldAccessor.VerifyInstanceField(System.Object, System.Object ByRef, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
       cmp       [rsi],sil
       mov       r8,[rbx+10]
       lea       r8,[rsi+r8+8]
       mov       rcx,[rsp+80]
       mov       rcx,[rcx+8]
       mov       [r8],rcx
       jmp       near ptr M03_L03
       mov       r15,[rsp+90]
       mov       [rsp+20],r15
       mov       r14,[rsp+98]
       mov       [rsp+28],r14
       lea       r8,[rsp+80]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r9d,edi
       call      qword ptr [7FFD93EC6478]; System.Reflection.FieldAccessor.VerifyInstanceField(System.Object, System.Object ByRef, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
       cmp       [rsi],sil
       mov       r8,[rbx+10]
       lea       r8,[rsi+r8+8]
       mov       rcx,[rsp+80]
       mov       ecx,[rcx+8]
       mov       [r8],ecx
       jmp       near ptr M03_L03
       mov       r15,[rsp+90]
       mov       [rsp+20],r15
       mov       r14,[rsp+98]
       mov       [rsp+28],r14
       lea       r8,[rsp+80]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r9d,edi
       call      qword ptr [7FFD93EC6478]; System.Reflection.FieldAccessor.VerifyInstanceField(System.Object, System.Object ByRef, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
       cmp       [rsi],sil
       mov       r8,[rbx+10]
       lea       r8,[rsi+r8+8]
       mov       rcx,[rsp+80]
       movsx     rcx,word ptr [rcx+8]
       mov       [r8],cx
       jmp       near ptr M03_L03
       mov       r15,[rsp+90]
       mov       [rsp+20],r15
       mov       r14,[rsp+98]
       mov       [rsp+28],r14
       lea       r8,[rsp+80]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r9d,edi
       call      qword ptr [7FFD93EC6478]; System.Reflection.FieldAccessor.VerifyInstanceField(System.Object, System.Object ByRef, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
       cmp       [rsi],sil
       mov       rax,[rbx+10]
       lea       rax,[rsi+rax+8]
       mov       rcx,[rsp+80]
       movzx     ecx,byte ptr [rcx+8]
       mov       [rax],cl
       jmp       near ptr M03_L03
M03_L10:
       mov       rcx,rbx
       call      qword ptr [7FFD93D4D578]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       je        short M03_L11
       mov       r14,[rsp+98]
       mov       [rsp+20],r14
       lea       rdx,[rsp+80]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r9,[rsp+90]
       call      qword ptr [7FFD93ECCC18]
       jmp       short M03_L12
M03_L11:
       mov       r15,[rsp+90]
       mov       [rsp+20],r15
       mov       r14,[rsp+98]
       mov       [rsp+28],r14
       lea       r8,[rsp+80]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r9d,edi
       call      qword ptr [7FFD93EC6478]; System.Reflection.FieldAccessor.VerifyInstanceField(System.Object, System.Object ByRef, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
M03_L12:
       mov       dword ptr [rsp+30],1
       mov       rdi,[rbx+8]
       mov       r15,[rsp+80]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M03_L13
       call      qword ptr [7FFD93D4D500]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M03_L13:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFD93A261C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r9,rax
       mov       rdx,[rbx+8]
       mov       rdx,[rdx+10]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+30]
       mov       [rsp+28],rdx
       mov       rdx,rsi
       mov       r8,r15
       mov       rcx,rdi
       call      System.RuntimeFieldHandle.SetValue(System.Reflection.RtFieldInfo, System.Object, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       jmp       near ptr M03_L03
M03_L14:
       mov       r14,[rsp+98]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M03_L15
       call      qword ptr [7FFD93D4D500]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M03_L15:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFD93A261C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       [rsp+20],edi
       lea       rdx,[rsp+80]
       mov       r8,[rsp+90]
       mov       r9,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFD93C3CFC0]; System.RuntimeType.CheckValue(System.Object ByRef, System.Reflection.Binder, System.Globalization.CultureInfo, System.Reflection.BindingFlags)
       jmp       near ptr M03_L02
M03_L16:
       mov       r14,[rsp+98]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M03_L17
       call      qword ptr [7FFD93D4D500]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M03_L17:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFD93A261C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFD93C3CA50]; System.RuntimeType.get_IsActualValueType()
       test      eax,eax
       je        near ptr M03_L02
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M03_L18
       call      qword ptr [7FFD93D4D500]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M03_L18:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFD93A261C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       [rsp+20],edi
       lea       rdx,[rsp+80]
       mov       r8,[rsp+90]
       mov       r9,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFD93C3CFC0]; System.RuntimeType.CheckValue(System.Object ByRef, System.Reflection.Binder, System.Globalization.CultureInfo, System.Reflection.BindingFlags)
       jmp       near ptr M03_L02
M03_L19:
       test      rsi,rsi
       je        short M03_L20
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFD93ECCC30]
       int       3
M03_L20:
       call      qword ptr [7FFD93ECCC48]
       int       3
; Total bytes of code 1675
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
       call      qword ptr [7FFDA4F92578]; System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
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
**Extern method**
System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.WriteBench.Expression()
       mov       rcx,[rcx+8]
       mov       rdx,2D6C7D49040
       jmp       qword ptr [7FFD93DCEAF0]; PrivateAccessProof.Subjects.WriteExpression(PrivateAccessProof.Types.Secret, System.String)
; Total bytes of code 20
```
```assembly
; PrivateAccessProof.Subjects.WriteExpression(PrivateAccessProof.Types.Secret, System.String)
       sub       rsp,28
       mov       r8,rdx
       mov       rdx,255C3001338
       mov       rax,[rdx]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,28
       ret
; Total bytes of code 36
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.WriteBench.Emit()
       mov       rcx,[rcx+8]
       mov       rdx,2D8F9E69040
       jmp       qword ptr [7FFD93DDEBC8]; PrivateAccessProof.Subjects.WriteEmit(PrivateAccessProof.Types.Secret, System.String)
; Total bytes of code 20
```
```assembly
; PrivateAccessProof.Subjects.WriteEmit(PrivateAccessProof.Types.Secret, System.String)
       sub       rsp,28
       mov       r8,rdx
       mov       rdx,257F5001348
       mov       rax,[rdx]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,28
       ret
; Total bytes of code 36
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.WriteBench.Accessor()
       mov       rcx,[rcx+8]
       mov       rdx,3192B689040
       jmp       qword ptr [7FFD93DDEAF0]; PrivateAccessProof.Subjects.WriteAccessor(PrivateAccessProof.Types.Secret, System.String)
; Total bytes of code 20
```
```assembly
; PrivateAccessProof.Subjects.WriteAccessor(PrivateAccessProof.Types.Secret, System.String)
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 11
```

