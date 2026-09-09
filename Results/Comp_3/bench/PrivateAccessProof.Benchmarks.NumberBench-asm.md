## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.NumberBench.Direct()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFDF2A4F978]; PrivateAccessProof.Subjects.ReadNumberDirect(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadNumberDirect(PrivateAccessProof.Types.Secret)
       mov       eax,[rcx+10]
       ret
; Total bytes of code 4
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.NumberBench.Reflection()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFDF2A5F978]; PrivateAccessProof.Subjects.ReadNumberReflection(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadNumberReflection(PrivateAccessProof.Types.Secret)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,165C0C01318
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+30],0
       je        short M01_L02
M01_L00:
       mov       rcx,[rsi+30]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF29BE2F8]; System.Reflection.FieldAccessor.GetValue(System.Object)
       mov       rbx,rax
       mov       rdx,offset MT_System.Int32
       cmp       [rbx],rdx
       je        short M01_L01
       mov       rdx,rbx
       mov       rcx,offset MT_System.Int32
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
M01_L01:
       mov       eax,[rbx+8]
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
       call      qword ptr [7FFDF2894B58]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       short M01_L05
M01_L03:
       test      rcx,rcx
       je        short M01_L06
       call      00007FFE52272E70
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF289D8A8]; System.RuntimeType.get_IsNullableOfT()
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
       call      qword ptr [7FFDF2B3D548]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFDF2B3D560]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L07:
       mov       dword ptr [rdi+20],11
       jmp       short M01_L04
; Total bytes of code 288
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
       cmp       ecx,11
       ja        near ptr M02_L06
       lea       rax,[7FFDF272E758]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
       mov       rcx,[rbx+8]
       mov       rdi,[rcx+10]
       mov       rcx,[rdi+18]
       mov       rbp,rsi
       test      rbp,rbp
       je        short M02_L01
       mov       rdx,[rbp]
       cmp       rdx,rcx
       jne       near ptr M02_L08
M02_L01:
       mov       rax,rbp
M02_L02:
       test      rax,rax
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L15
       mov       rdi,[rbx+18]
       cmp       [rsi],sil
       mov       rcx,[rbx+10]
       lea       rsi,[rsi+rcx+8]
       mov       ecx,[rdi]
       and       ecx,0F0000
       cmp       ecx,50000
       je        near ptr M02_L28
       cmp       [rsi],sil
       mov       rcx,rdi
       call      00007FFE522801E0
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M02_L16
M02_L03:
       test      dword ptr [rdi],1000000
       jne       near ptr M02_L17
       cmp       [rbx],bl
       lea       rbp,[rbx+8]
       mov       r14,rsi
       mov       rcx,rdi
       call      00007FFE52294590
       mov       r8d,eax
       mov       rcx,rbp
       sub       rcx,r14
       cmp       rcx,r8
       jb        near ptr M02_L26
       mov       rcx,r14
       sub       rcx,rbp
       cmp       rcx,r8
       jb        near ptr M02_L26
       lea       rcx,[r14+r8]
       lea       rdx,[r8+rbp]
       cmp       r8,10
       ja        near ptr M02_L18
       test      r8b,18
       jne       near ptr M02_L20
       test      r8b,4
       je        near ptr M02_L21
       mov       r8d,[rsi]
       mov       [rbp],r8d
       mov       ecx,[rcx-4]
       mov       [rdx-4],ecx
M02_L04:
       mov       rax,rbx
M02_L05:
       vzeroupper
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L06:
       xor       eax,eax
       vzeroupper
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFDF25CA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L07
       test      rsi,rsi
       jne       near ptr M02_L36
       jmp       near ptr M02_L35
M02_L07:
       cmp       [rsi],sil
       mov       rax,[rbx+10]
       mov       rax,[rsi+rax+8]
       jmp       short M02_L05
M02_L08:
       mov       rax,165C0C00038
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
       jge       short M02_L12
M02_L09:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       lea       r9,[r9+r9*2]
       lea       r9,[rax+r9*8]
       mov       r11d,[r9]
       mov       r14,[r9+8]
       and       r11d,0FFFFFFFE
       cmp       r14,rdx
       jne       short M02_L10
       mov       r14,rcx
       xor       r14,[r9+10]
       cmp       r14,1
       jbe       short M02_L11
M02_L10:
       test      r11d,r11d
       je        short M02_L12
       inc       r10d
       add       r8d,r10d
       and       r8d,[rax+4]
       cmp       r10d,8
       jl        short M02_L09
       jmp       short M02_L12
M02_L11:
       cmp       r11d,[r9]
       jne       short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       r14d,2
M02_L13:
       cmp       r14d,1
       je        near ptr M02_L01
       test      r14d,r14d
       jne       short M02_L14
       xor       ebp,ebp
       jmp       near ptr M02_L01
M02_L14:
       mov       rdx,rsi
       call      qword ptr [7FFDF268FA98]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
       jmp       near ptr M02_L02
M02_L15:
       test      rsi,rsi
       jne       near ptr M02_L36
       jmp       near ptr M02_L35
M02_L16:
       mov       rcx,rdi
       call      qword ptr [7FFDF2B37120]; System.RuntimeTypeHandle.<InternalAllocNoChecks>g__InternalAllocNoChecksWorker|37_0(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,rax
       jmp       near ptr M02_L03
M02_L17:
       cmp       [rbx],bl
       lea       rcx,[rbx+8]
       mov       r8d,[rdi+4]
       add       r8d,0FFFFFFF0
       mov       rdx,rsi
       call      qword ptr [7FFDF26857A0]
       jmp       near ptr M02_L04
M02_L18:
       cmp       r8,40
       ja        short M02_L22
M02_L19:
       vmovups   xmm0,[r14]
       vmovups   [rbp],xmm0
       cmp       r8,20
       jbe       near ptr M02_L25
       vmovups   xmm0,[r14+10]
       vmovups   [rbp+10],xmm0
       cmp       r8,30
       jbe       near ptr M02_L25
       vmovups   xmm0,[r14+20]
       vmovups   [rbp+20],xmm0
       jmp       near ptr M02_L25
M02_L20:
       mov       r8,[rsi]
       mov       [rbp],r8
       mov       rcx,[rcx-8]
       mov       [rdx-8],rcx
       jmp       near ptr M02_L04
M02_L21:
       test      r8,r8
       je        near ptr M02_L04
       movzx     eax,byte ptr [rsi]
       mov       [rbp],al
       test      r8b,2
       je        near ptr M02_L04
       movsx     rcx,word ptr [rcx-2]
       mov       [rdx-2],cx
       jmp       near ptr M02_L04
M02_L22:
       cmp       r8,800
       ja        near ptr M02_L27
       cmp       r8,100
       jb        short M02_L23
       mov       rax,rbp
       and       rax,3F
       neg       rax
       add       rax,40
       vmovdqu   ymm0,ymmword ptr [rsi]
       vmovdqu   ymmword ptr [rbp],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+20]
       vmovdqu   ymmword ptr [rbp+20],ymm0
       lea       r14,[rsi+rax]
       add       rbp,rax
       sub       r8,rax
M02_L23:
       mov       rax,r8
       shr       rax,6
M02_L24:
       vmovdqu   ymm0,ymmword ptr [r14]
       vmovdqu   ymmword ptr [rbp],ymm0
       vmovdqu   ymm0,ymmword ptr [r14+20]
       vmovdqu   ymmword ptr [rbp+20],ymm0
       add       rbp,40
       add       r14,40
       dec       rax
       jne       short M02_L24
       and       r8,3F
       cmp       r8,10
       ja        near ptr M02_L19
M02_L25:
       vmovups   xmm0,[rcx-10]
       vmovups   [rdx-10],xmm0
       jmp       near ptr M02_L04
M02_L26:
       cmp       rbp,rsi
       je        near ptr M02_L04
M02_L27:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFDF26866E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L04
M02_L28:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFDF2685878]; System.Runtime.CompilerServices.CastHelpers.Box_Nullable(System.Runtime.CompilerServices.MethodTable*, Byte ByRef)
       mov       rbx,rax
       jmp       near ptr M02_L04
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFDF25CA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L29
       test      rsi,rsi
       jne       near ptr M02_L36
       jmp       near ptr M02_L35
M02_L29:
       cmp       [rsi],sil
       mov       rcx,[rbx+10]
       mov       rsi,[rsi+rcx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L30
       call      qword ptr [7FFDF29BE280]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L30:
       mov       rcx,rsi
       call      qword ptr [7FFDF2B3D5C0]
       jmp       near ptr M02_L05
       mov       rax,[rbx+10]
       mov       rax,[rax]
       jmp       near ptr M02_L05
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFDF2B3D5D8]
       jmp       near ptr M02_L05
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx]
       cmp       [rdx],dl
       add       rdx,8
       call      qword ptr [7FFDF2B3D5D8]
       jmp       near ptr M02_L05
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L31
       call      qword ptr [7FFDF29BE280]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L31:
       mov       rcx,rsi
       call      qword ptr [7FFDF2B3D5C0]
       jmp       near ptr M02_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF29BE310]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M02_L32
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFDF25CA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L32
       test      rsi,rsi
       jne       near ptr M02_L36
       jmp       near ptr M02_L35
M02_L32:
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L33
       call      qword ptr [7FFDF29BE280]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L33:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFDF2686328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFDF29BE328]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rsi,rax
       cmp       byte ptr [rsp+28],0
       je        short M02_L34
       mov       rcx,rbx
       call      qword ptr [7FFDF29BE340]; System.Reflection.FieldAccessor.Initialize()
M02_L34:
       mov       rax,rsi
       jmp       near ptr M02_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF29BE310]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M02_L37
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFDF25CA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L37
       test      rsi,rsi
       jne       short M02_L36
M02_L35:
       call      qword ptr [7FFDF2B3D5F0]
       int       3
M02_L36:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFDF2B3D608]
       int       3
M02_L37:
       mov       dword ptr [rsp+28],1
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L38
       call      qword ptr [7FFDF29BE280]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L38:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFDF2686328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFDF29BE328]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       jmp       near ptr M02_L05
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF2A12570]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M02_L39
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF2A12570]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L39
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDF2B3D620]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDF29B7A50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L39:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF2A12570]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M02_L41
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L40
       call      qword ptr [7FFDF29BE280]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L40:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFDF2686328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFDF289D8A8]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       je        short M02_L41
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDF2B3D638]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L41:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFDF2B3D650]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1624
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       cmp       [rdx],rcx
       jne       short M03_L00
       lea       rax,[rdx+8]
       ret
M03_L00:
       jmp       qword ptr [7FFDF2B3D428]; System.Runtime.CompilerServices.CastHelpers.Unbox_Helper(System.Runtime.CompilerServices.MethodTable*, System.Object)
; Total bytes of code 16
```
```assembly
; System.Type.GetRootElementType()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
M04_L00:
       cmp       rsi,[rbx]
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFE512DA818]; Precode of System.RuntimeType.GetCorElementType()
       cmp       eax,1D
       ja        short M04_L01
       mov       ecx,1FEF7FFF
       bt        ecx,eax
       jae       short M04_L04
M04_L01:
       cmp       eax,10
       sete      dil
       movzx     edi,dil
M04_L02:
       test      edi,edi
       jne       short M04_L03
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,rbx
       lea       r11,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M04_L00
M04_L04:
       mov       edi,1
       jmp       short M04_L02
M04_L05:
       mov       rcx,rbx
       lea       r11,[System.Reflection.MethodInfo.CreateDelegate[[System.__Canon, System.Private.CoreLib]]()]
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M04_L02
; Total bytes of code 114
```
```assembly
; System.RuntimeType.get_IsNullableOfT()
       mov       rax,[rcx+18]
       test      al,2
       jne       short M05_L01
       mov       eax,[rax]
       and       eax,0F0000
       cmp       eax,50000
       sete      al
       movzx     eax,al
M05_L00:
       ret
M05_L01:
       xor       eax,eax
       jmp       short M05_L00
; Total bytes of code 31
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.NumberBench.Accessor()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFDF2A3F8A0]; PrivateAccessProof.Subjects.ReadNumberAccessor(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadNumberAccessor(PrivateAccessProof.Types.Secret)
       mov       eax,[rcx+10]
       ret
; Total bytes of code 4
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.NumberBench.Direct()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFDC8E6E1F0]; PrivateAccessProof.Subjects.ReadNumberDirect(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadNumberDirect(PrivateAccessProof.Types.Secret)
       mov       eax,[rcx+10]
       ret
; Total bytes of code 4
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.NumberBench.Reflection()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFDC8E3E9D0]; PrivateAccessProof.Subjects.ReadNumberReflection(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadNumberReflection(PrivateAccessProof.Types.Secret)
       push      rbx
       sub       rsp,20
       mov       rdx,rcx
       mov       rcx,24143004528
       mov       rcx,[rcx]
       call      qword ptr [7FFDC8D69D60]; System.Reflection.RtFieldInfo.GetValue(System.Object)
       mov       rbx,rax
       mov       rdx,offset MT_System.Int32
       cmp       [rbx],rdx
       je        short M01_L00
       mov       rdx,rbx
       mov       rcx,offset MT_System.Int32
       call      qword ptr [7FFDC8A34408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
M01_L00:
       mov       eax,[rbx+8]
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 73
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
       call      qword ptr [7FFDC8D47AC8]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       jmp       near ptr M02_L00
M02_L09:
       mov       rcx,rbx
       call      qword ptr [7FFDC8D47C90]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
       jmp       near ptr M02_L04
M02_L10:
       mov       rcx,rdi
       call      qword ptr [7FFDC8986658]; System.RuntimeType.InitializeCache()
       jmp       short M02_L06
M02_L11:
       mov       rcx,rdi
       call      qword ptr [7FFDC8986658]; System.RuntimeType.InitializeCache()
       jmp       short M02_L07
M02_L12:
       test      rdi,rdi
       je        short M02_L14
       mov       rcx,rbx
       call      qword ptr [7FFDC8D695E8]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L14
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC8EF70F0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFDC8BF6718]
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
       call      qword ptr [7FFDC8D4EB08]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L15:
       test      rsi,rsi
       jne       short M02_L16
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDC8EFF810]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFDC8CE5AB8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L16:
       call      qword ptr [7FFDC8EF6358]
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC8D69D10]
       mov       r14,rax
       mov       rbx,[rbx+10]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       r9,rax
       mov       rdx,r14
       mov       r8,rbx
       mov       rcx,rbp
       call      qword ptr [7FFDC8EF5C68]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFDC8A3F708]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L17:
       call      qword ptr [7FFDC8A343F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       cmp       [rdx],rcx
       jne       short M03_L00
       lea       rax,[rdx+8]
       ret
M03_L00:
       jmp       near ptr 00007FFE28474AC0
; Total bytes of code 15
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.NumberBench.Accessor()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFDC8E3E1D8]; PrivateAccessProof.Subjects.ReadNumberAccessor(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadNumberAccessor(PrivateAccessProof.Types.Secret)
       mov       eax,[rcx+10]
       ret
; Total bytes of code 4
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.NumberBench.Direct()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFD92DFEBE0]; PrivateAccessProof.Subjects.ReadNumberDirect(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadNumberDirect(PrivateAccessProof.Types.Secret)
       mov       eax,[rcx+10]
       ret
; Total bytes of code 4
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.NumberBench.Reflection()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFD92E0EBE0]; PrivateAccessProof.Subjects.ReadNumberReflection(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadNumberReflection(PrivateAccessProof.Types.Secret)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,24A6BC01328
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+30],0
       je        short M01_L02
M01_L00:
       mov       rcx,[rsi+30]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFD92D7D578]; System.Reflection.FieldAccessor.GetValue(System.Object)
       mov       rsi,rax
       mov       rdx,offset MT_System.Int32
       cmp       [rsi],rdx
       je        short M01_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int32
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
M01_L01:
       mov       eax,[rsi+8]
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
       call      qword ptr [7FFD92C649F0]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       short M01_L05
M01_L03:
       test      rcx,rcx
       je        short M01_L07
       call      System.RuntimeTypeHandle.ContainsGenericVariables(System.RuntimeType)
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD92C6D008]; System.RuntimeType.get_IsNullableOfT()
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD92EFC930]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD92EFC948]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 288
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
       mov       ecx,[rbx+20]
       cmp       ecx,11
       ja        short M02_L02
       lea       rdx,[7FFD92B0DBD8]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M02_L00]
       add       rdx,rax
       jmp       rdx
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M02_L14
       cmp       [rsi],sil
       mov       rdx,[rbx+10]
       lea       rdx,[rsi+rdx+8]
       mov       rcx,[rbx+18]
       call      CORINFO_HELP_BOX_NULLABLE
M02_L01:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD92DC36C8]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M02_L03
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD92DC36C8]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L03
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD92EFCA68]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD92D76EB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD92DC36C8]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M02_L05
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L04
       call      qword ptr [7FFD92D7D518]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L04:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFD92A561D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFD92C6D008]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       je        short M02_L05
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD92EFCA80]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD92EFCA98]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFD92D7D590]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M02_L06
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       jne       short M02_L06
       test      rsi,rsi
       jne       near ptr M02_L16
       jmp       near ptr M02_L17
M02_L06:
       mov       dword ptr [rsp+28],1
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L07
       call      qword ptr [7FFD92D7D518]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L07:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFD92A561D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
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
       call      qword ptr [7FFD92D7D590]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M02_L08
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       jne       short M02_L08
       test      rsi,rsi
       jne       near ptr M02_L16
       jmp       near ptr M02_L17
M02_L08:
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L09
       call      qword ptr [7FFD92D7D518]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L09:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFD92A561D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
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
       je        short M02_L10
       mov       rcx,rbx
       call      qword ptr [7FFD92D7D5C0]; System.Reflection.FieldAccessor.Initialize()
M02_L10:
       mov       rax,rsi
       jmp       near ptr M02_L01
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L11
       call      qword ptr [7FFD92D7D518]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L11:
       mov       rcx,rsi
       call      qword ptr [7FFD92EFCAB0]
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
       je        short M02_L13
       cmp       [rsi],sil
       mov       rcx,[rbx+10]
       mov       rsi,[rsi+rcx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L12
       call      qword ptr [7FFD92D7D518]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L12:
       mov       rcx,rsi
       call      qword ptr [7FFD92EFCAB0]
       jmp       near ptr M02_L01
M02_L13:
       test      rsi,rsi
       jne       short M02_L16
       jmp       short M02_L17
M02_L14:
       test      rsi,rsi
       jne       short M02_L16
       jmp       short M02_L17
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        short M02_L15
       cmp       [rsi],sil
       mov       rdx,[rbx+10]
       mov       rax,[rsi+rdx+8]
       jmp       near ptr M02_L01
M02_L15:
       test      rsi,rsi
       je        short M02_L17
M02_L16:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFD92EFCAC8]
       int       3
M02_L17:
       call      qword ptr [7FFD92EFCAE0]
       int       3
; Total bytes of code 885
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       cmp       [rdx],rcx
       jne       short M03_L00
       lea       rax,[rdx+8]
       ret
M03_L00:
       jmp       near ptr 00007FFDF25B9F40
; Total bytes of code 15
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
; PrivateAccessProof.Benchmarks.NumberBench.Accessor()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFD92DEEB08]; PrivateAccessProof.Subjects.ReadNumberAccessor(PrivateAccessProof.Types.Secret)
; Total bytes of code 10
```
```assembly
; PrivateAccessProof.Subjects.ReadNumberAccessor(PrivateAccessProof.Types.Secret)
       mov       eax,[rcx+10]
       ret
; Total bytes of code 4
```

