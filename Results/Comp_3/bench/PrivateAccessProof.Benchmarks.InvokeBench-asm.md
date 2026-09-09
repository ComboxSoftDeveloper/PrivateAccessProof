## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Direct()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFDF2A3F960]; PrivateAccessProof.Subjects.InvokeDirect(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeDirect(PrivateAccessProof.Types.Secret, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       ebx,edx
       mov       rsi,[rcx+8]
       test      ebx,ebx
       jl        short M01_L02
       cmp       ebx,12C
       jb        short M01_L00
       mov       ecx,ebx
       call      qword ptr [7FFDF2A3D8C0]; System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
       mov       rdi,rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,28A82801238
       mov       rcx,[rcx]
       mov       eax,ebx
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       ecx,ebx
       call      qword ptr [7FFDF2A3D8A8]; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|50_0(UInt32)
       mov       rdi,rax
M01_L01:
       jmp       near ptr M01_L09
M01_L02:
       call      qword ptr [7FFDF266D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,[rax+28]
       mov       edx,ebx
       neg       edx
       mov       ecx,edx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rax,7FFE5065C108
       add       rdx,[rax+rcx*8]
       sar       rdx,20
       mov       ebp,1
       cmp       edx,1
       cmovg     ebp,edx
       add       ebp,[rdi+8]
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.String
       call      00007FFE522B8D20
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       [rsp+28],rdx
       mov       rdx,[rsp+28]
       jmp       short M01_L04
M01_L03:
       xor       edx,edx
M01_L04:
       movsxd    rcx,ebp
       lea       rdx,[rdx+rcx*2]
       mov       ecx,ebx
       neg       ecx
       mov       r8d,1
       cmp       ecx,64
       jb        short M01_L06
       jmp       near ptr M01_L13
M01_L05:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,ecx
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,ecx
       sub       r11d,r9d
       mov       ecx,r10d
       add       rdx,0FFFFFFFFFFFFFFFE
       add       r11d,30
       mov       [rdx],r11w
M01_L06:
       test      ecx,ecx
       jne       short M01_L05
       test      r8d,r8d
       jg        short M01_L05
       mov       ecx,[rdi+8]
       dec       ecx
       js        short M01_L08
       cmp       [rdi+8],ecx
       jle       near ptr M01_L14
M01_L07:
       add       rdx,0FFFFFFFFFFFFFFFE
       mov       r8d,ecx
       movzx     r8d,word ptr [rdi+r8*2+0C]
       mov       [rdx],r8w
       dec       ecx
       jns       short M01_L07
M01_L08:
       xor       edx,edx
       mov       [rsp+28],rdx
       mov       rdi,rax
M01_L09:
       test      rsi,rsi
       je        near ptr M01_L11
       mov       ebx,[rsi+8]
       test      ebx,ebx
       je        near ptr M01_L11
       test      rdi,rdi
       je        short M01_L10
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short M01_L10
       mov       r14d,ebx
       mov       edx,ebp
       lea       rdx,[r14+rdx+1]
       cmp       rdx,7FFFFFFF
       jg        near ptr M01_L15
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFE522B8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,ebx
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFDF2665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r13+r14*2]
       mov       word ptr [rcx],3A
       inc       ebx
       movsxd    rcx,ebx
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFDF2665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L12
M01_L10:
       mov       rcx,rsi
       mov       rdx,2CB171A0C68
       call      qword ptr [7FFDF266D9C8]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       jmp       short M01_L12
M01_L11:
       mov       rdx,rdi
       mov       rcx,2CB171A0C68
       call      qword ptr [7FFDF266D9C8]; System.String.Concat(System.String, System.String)
       mov       r15,rax
M01_L12:
       mov       rax,r15
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       add       rdx,0FFFFFFFFFFFFFFFC
       add       r8d,0FFFFFFFE
       mov       r10d,ecx
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       ecx,r9d
       mov       r9,2CB171A1B94
       shl       ecx,2
       mov       ecx,[r9+rcx]
       mov       [rdx],ecx
       cmp       r10d,64
       mov       ecx,r10d
       jae       short M01_L13
       jmp       near ptr M01_L06
M01_L14:
       add       rdx,0FFFFFFFFFFFFFFFE
       cmp       ecx,[rdi+8]
       jae       short M01_L16
       mov       r8d,ecx
       movzx     r8d,word ptr [rdi+r8*2+0C]
       mov       [rdx],r8w
       dec       ecx
       jns       short M01_L14
       jmp       near ptr M01_L08
M01_L15:
       call      qword ptr [7FFDF2AF5B90]
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
```
```assembly
; System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       ebx,ecx
       mov       ecx,ebx
       or        ecx,1
       bsr       ecx,ecx
       mov       eax,ebx
       cmp       ecx,20
       jae       near ptr M02_L06
       lea       rdx,[7FFE5065C108]
       add       rax,[rdx+rcx*8]
       sar       rax,20
       movsxd    rsi,eax
       mov       rcx,rsi
       call      qword ptr [7FFE512DAA50]; Precode of System.String.FastAllocateString(IntPtr)
       test      rax,rax
       je        short M02_L00
       lea       rcx,[rax+0C]
       mov       [rsp+20],rcx
       mov       rcx,[rsp+20]
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
       xor       ecx,ecx
M02_L01:
       lea       rcx,[rcx+rsi*2]
       cmp       ebx,0A
       jb        short M02_L05
       cmp       ebx,64
       jb        short M02_L03
       mov       rdx,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rdx]
       add       rdx,0C
M02_L02:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r8d,ebx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       ebx,r10d
       mov       r10,rdx
       shl       ebx,2
       mov       r9d,ebx
       mov       r10d,[r10+r9]
       mov       [rcx],r10d
       cmp       r8d,64
       mov       ebx,r8d
       jae       short M02_L02
M02_L03:
       cmp       ebx,0A
       jb        short M02_L05
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rdx]
       add       rdx,0C
       lea       r8d,[rbx*4]
       mov       edx,[rdx+r8]
       mov       [rcx],edx
M02_L04:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L05:
       lea       edx,[rbx+30]
       mov       [rcx-2],dx
       jmp       short M02_L04
M02_L06:
       call      qword ptr [7FFE512C7FC0]
       int       3
; Total bytes of code 231
```
```assembly
; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|50_0(UInt32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE512C86E8]
       mov       rsi,[rax]
       mov       ecx,ebx
       call      qword ptr [7FFE512DC468]; Precode of System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
       mov       rdi,rax
       cmp       ebx,[rsi+8]
       jae       short M03_L00
       mov       ecx,ebx
       lea       rcx,[rsi+rcx*8+10]
       mov       rdx,rdi
       call      qword ptr [7FFE512C7FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       call      qword ptr [7FFE512C7FC0]
       int       3
; Total bytes of code 68
```
```assembly
; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFE512DF9B0]; Precode of System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       cmp       byte ptr [rbx+61],0
       jne       short M04_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M04_L00
       add       rsp,20
       pop       rbx
       ret
M04_L00:
       mov       rcx,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       call      qword ptr [7FFE512C8040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       lea       r11,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       call      qword ptr [r11]
       mov       rcx,rax
       call      qword ptr [7FFE512D74D8]
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 80
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M05_L01
       test      r8b,18
       jne       short M05_L05
       test      r8b,4
       jne       short M05_L06
       test      r8,r8
       je        short M05_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M05_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
M05_L00:
       vzeroupper
       ret
M05_L01:
       cmp       r8,40
       ja        short M05_L07
M05_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M05_L04
M05_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M05_L00
M05_L04:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M05_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M05_L03
M05_L05:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M05_L00
M05_L06:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M05_L00
M05_L07:
       cmp       r8,800
       ja        short M05_L11
       cmp       r8,100
       jb        short M05_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M05_L08:
       mov       r9,r8
       shr       r9,6
M05_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M05_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M05_L02
       jmp       near ptr M05_L03
M05_L10:
       cmp       rcx,rdx
       jne       short M05_L11
       cmp       [rdx],dl
       jmp       near ptr M05_L00
M05_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFDF26666E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 317
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFE522B8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFDF2665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFDF2665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,2CB171A0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L04:
       call      qword ptr [7FFDF2AF5B90]
       int       3
; Total bytes of code 244
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Reflection()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFDF2A3F8A0]; PrivateAccessProof.Subjects.InvokeReflection(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeReflection(PrivateAccessProof.Types.Secret, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,offset MT_System.Object[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],esi
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],rdi
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,182BCC01320
       mov       rcx,[rcx]
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFDF290DD70]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       rdx,rax
       mov       rax,rdx
       test      rax,rax
       je        short M01_L00
       mov       rcx,offset MT_System.String
       cmp       [rax],rcx
       jne       short M01_L01
M01_L00:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 145
```
```assembly
; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       vzeroupper
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       [rbp+20],r8d
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r9
       mov       r14,[rbp+30]
M02_L00:
       cmp       qword ptr [rbx+48],0
       je        near ptr M02_L18
M02_L01:
       mov       rcx,[rbx+48]
       test      dword ptr [rcx+3C],102
       jne       near ptr M02_L30
       test      byte ptr [rbx+5C],10
       jne       short M02_L03
       test      rsi,rsi
       je        near ptr M02_L31
       mov       rcx,[rbx+8]
       cmp       byte ptr [rcx+9C],0
       jne       near ptr M02_L32
       mov       rcx,[rbx+38]
M02_L02:
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+0A0]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M02_L33
M02_L03:
       test      r14,r14
       je        near ptr M02_L34
       mov       r15d,[r14+8]
M02_L04:
       mov       rax,[rbx+30]
       test      rax,rax
       je        near ptr M02_L19
M02_L05:
       mov       rcx,[rax+8]
       cmp       [rcx+8],r15d
       jne       near ptr M02_L35
       cmp       r15d,1
       jne       near ptr M02_L36
       cmp       qword ptr [rbx+48],0
       je        near ptr M02_L20
M02_L06:
       mov       rbx,[rbx+48]
       mov       [rbp-90],rbx
       cmp       [rbx],bl
       mov       r9d,[r14+8]
       mov       r13d,r9d
       test      r13d,r13d
       je        near ptr M02_L73
       mov       [rbp+30],r14
       mov       r9,[r14+10]
       mov       [rbp-40],r9
       xor       r9d,r9d
       mov       [rbp-48],r9
       mov       byte ptr [rbp-4C],0
       test      byte ptr [rbx+38],2
       mov       r14,[rbp+30]
       je        near ptr M02_L39
M02_L07:
       xor       r12d,r12d
       jg        near ptr M02_L17
M02_L08:
       lea       rcx,[rbp-40]
       mov       eax,r12d
       mov       [rbp-88],rax
       mov       rcx,[rcx+rax*8]
       mov       [rbp-58],rcx
       mov       rcx,[rbx+28]
       cmp       r12d,[rcx+8]
       jae       near ptr M02_L73
       mov       r8,[rcx+rax*8+10]
       mov       [rbp-0A0],r8
       mov       rcx,[rbp-58]
       mov       rdx,182BCC002F0
       cmp       rcx,[rdx]
       je        near ptr M02_L40
M02_L09:
       cmp       qword ptr [rbp-58],0
       je        near ptr M02_L21
       mov       rcx,[rbp-58]
       call      qword ptr [7FFDF287D860]; System.Object.GetType()
       mov       rdx,[rbp-0A0]
       cmp       rax,rdx
       je        near ptr M02_L16
       mov       [rbp+18],rsi
       mov       [rbp+28],rdi
       mov       [rbp+30],r14
       mov       rcx,[rdx+18]
       mov       rax,7FFE522706C0
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-0A0]
       cmp       dword ptr [7FFE525CF778],0
       jne       near ptr M02_L42
M02_L10:
       cmp       ebx,10
       je        near ptr M02_L43
M02_L11:
       lea       rdi,[rbp-4C]
       mov       rbx,[rbp-88]
       add       rdi,rbx
       mov       rdx,[rbp-58]
       mov       rcx,[rsi+18]
       test      rdx,rdx
       je        short M02_L12
       mov       rax,[rdx]
       cmp       rax,rcx
       jne       near ptr M02_L45
M02_L12:
       test      rdx,rdx
       setne     r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        near ptr M02_L54
       mov       r8,[rsi+18]
       test      r8b,2
       jne       near ptr M02_L52
       mov       r8d,[r8]
       and       r8d,0F0000
       cmp       r8d,50000
       sete      r8b
       movzx     r8d,r8b
M02_L13:
       test      r8d,r8d
       mov       r15,[rbp+28]
       jne       near ptr M02_L53
M02_L14:
       xor       eax,eax
M02_L15:
       mov       [rdi],al
       mov       rdi,r15
       mov       rbx,[rbp-90]
       mov       rsi,[rbp+18]
       mov       r14,[rbp+30]
M02_L16:
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-88]
       lea       rcx,[rdx+rcx*8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       test      r12d,r12d
       jle       near ptr M02_L08
M02_L17:
       xor       r8d,r8d
       mov       [rbp-58],r8
       mov       rax,[rbx+10]
       test      rax,rax
       je        near ptr M02_L65
       jmp       near ptr M02_L22
M02_L18:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFDF287D5A8]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L01
M02_L19:
       mov       rcx,rbx
       call      qword ptr [7FFDF287D5C0]; System.Reflection.RuntimeMethodInfo.<get_Signature>g__LazyCreateSignature|25_0()
       jmp       near ptr M02_L05
M02_L20:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,rbx
       call      qword ptr [7FFDF287D5A8]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L06
M02_L21:
       mov       r8,[rbp-0A0]
       mov       r15,[rbp+38]
       mov       rdx,[rbx+20]
       cmp       r12d,[rdx+8]
       jae       near ptr M02_L73
       mov       rax,[rbp-88]
       test      byte ptr [rdx+rax*4+10],2
       jne       near ptr M02_L41
       mov       [rbp+38],r15
       jmp       near ptr M02_L16
M02_L22:
       lea       r8,[rbp-48]
       mov       [rbp-80],r8
       mov       dword ptr [rbp-78],1
       lea       r8,[rbp-80]
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
M02_L23:
       xor       esi,esi
       cmp       r13d,1
       jg        short M02_L28
M02_L24:
       lea       rcx,[rbp-4C]
       mov       eax,esi
       cmp       byte ptr [rcx+rax],0
       jne       near ptr M02_L66
M02_L25:
       inc       esi
       cmp       r13d,esi
       jg        short M02_L24
M02_L26:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rcx
       mov       rax,rdi
M02_L27:
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L28:
       cmp       esi,1
       jae       near ptr M02_L73
       lea       rcx,[rbp-4C]
       mov       eax,esi
       cmp       byte ptr [rcx+rax],0
       jne       near ptr M02_L68
M02_L29:
       inc       esi
       cmp       r13d,esi
       jg        short M02_L28
       jmp       short M02_L26
M02_L30:
       mov       rcx,rbx
       call      qword ptr [7FFDF2B1D608]
       int       3
M02_L31:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDF2B1D620]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFDF2B1D638]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L32:
       xor       ecx,ecx
       jmp       near ptr M02_L02
M02_L33:
       call      qword ptr [7FFDF2B1D650]
       mov       r14,rax
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFDF290DCB8]
       mov       rbx,rax
       mov       rcx,rsi
       call      qword ptr [7FFDF287D860]; System.Object.GetType()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FFDF2B1D668]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFDF2B1D638]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L34:
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L35:
       call      qword ptr [7FFDF2B1D680]
       int       3
M02_L36:
       cmp       r15d,4
       ja        short M02_L37
       mov       ecx,r15d
       lea       rax,[7FFDF270F940]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
M02_L37:
       cmp       qword ptr [rbx+48],0
       jne       near ptr M02_L72
       jmp       near ptr M02_L71
       cmp       qword ptr [rbx+48],0
       jne       short M02_L38
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FFDF287D5A8]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L38:
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF2996EE0]; System.Reflection.MethodBaseInvoker.InvokeWithNoArgs(System.Object, System.Reflection.BindingFlags)
       jmp       near ptr M02_L27
M02_L39:
       mov       dword ptr [rsp+20],1
       movzx     r9d,byte ptr [rbx+44]
       mov       r8,[rbx+30]
       lea       rdx,[rbx+10]
       lea       rcx,[rbx+38]
       call      qword ptr [7FFDF287D7A0]; System.Reflection.MethodInvokerCommon.DetermineStrategy_ObjSpanArgs(InvokerStrategy ByRef, InvokeFunc_ObjSpanArgs ByRef, System.Reflection.MethodBase, Boolean, Boolean)
       jmp       near ptr M02_L07
M02_L40:
       mov       rcx,[rbx+30]
       lea       rdx,[rbp-68]
       mov       r10,[rcx]
       mov       r10,[r10+50]
       call      qword ptr [r10+10]
       cmp       r12d,[rbp-60]
       jae       near ptr M02_L73
       mov       rcx,[rbp-68]
       mov       rax,[rbp-88]
       mov       rcx,[rcx+rax*8]
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FFDF2B1D710]
       mov       [rbp-58],rax
       lea       rcx,[rbp-4C]
       mov       rax,[rbp-88]
       mov       byte ptr [rcx+rax],1
       mov       rbx,[rbp-90]
       jmp       near ptr M02_L09
M02_L41:
       lea       r10,[rbp-4C]
       mov       [rbp-0A8],r10
       mov       r11d,[rbp+20]
       mov       [rsp+20],r11d
       lea       rdx,[rbp-58]
       mov       rcx,r8
       mov       r8,rdi
       mov       r9,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFDF287D890]; System.RuntimeType.CheckValue(System.Object ByRef, System.Reflection.Binder, System.Globalization.CultureInfo, System.Reflection.BindingFlags)
       mov       r10,[rbp-0A8]
       mov       rcx,[rbp-88]
       mov       [r10+rcx],al
       mov       [rbp+38],r15
       jmp       near ptr M02_L16
M02_L42:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L10
M02_L43:
       mov       rcx,rsi
       call      qword ptr [7FFDF287E250]; System.RuntimeTypeHandle.GetElementType(System.RuntimeType)
       mov       rbx,rax
       mov       rcx,[rbp-58]
       call      qword ptr [7FFDF287D860]; System.Object.GetType()
       cmp       rax,rbx
       jne       near ptr M02_L11
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF25AA438]; Precode of System.RuntimeType.IsValueTypeImpl()
       test      eax,eax
       je        short M02_L44
       mov       rcx,rbx
       mov       rdx,[rbp-58]
       call      qword ptr [7FFDF2B1D728]
       mov       [rbp-58],rax
M02_L44:
       lea       rcx,[rbp-4C]
       mov       rbx,[rbp-88]
       mov       byte ptr [rcx+rbx],1
       mov       rbx,[rbp-90]
       mov       rsi,[rbp+18]
       mov       rdi,[rbp+28]
       mov       r14,[rbp+30]
       jmp       near ptr M02_L16
M02_L45:
       mov       r8,182BCC00038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
       cmp       r9d,8
       jge       short M02_L49
M02_L46:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       r14d,[r11]
       mov       r15,[r11+8]
       and       r14d,0FFFFFFFE
       cmp       r15,rax
       jne       short M02_L47
       mov       r15,rcx
       xor       r15,[r11+10]
       cmp       r15,1
       jbe       short M02_L48
M02_L47:
       test      r14d,r14d
       je        short M02_L49
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M02_L46
       jmp       short M02_L49
M02_L48:
       cmp       r14d,[r11]
       jne       short M02_L49
       jmp       short M02_L50
M02_L49:
       mov       r15d,2
M02_L50:
       cmp       r15d,1
       je        near ptr M02_L12
       test      r15d,r15d
       jne       short M02_L51
       xor       edx,edx
       jmp       near ptr M02_L12
M02_L51:
       call      qword ptr [7FFDF266FA98]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M02_L12
M02_L52:
       xor       r8d,r8d
       jmp       near ptr M02_L13
M02_L53:
       mov       rcx,[rbp-58]
       mov       rdx,rsi
       call      qword ptr [7FFDF2B1DA40]
       mov       [rbp-58],rax
       jmp       near ptr M02_L59
M02_L54:
       mov       byte ptr [rbp-70],0
       lea       r8,[rbp-70]
       lea       rdx,[rbp-58]
       mov       rcx,rsi
       call      qword ptr [7FFDF2B1DA58]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M02_L56
       mov       r15,[rbp+28]
M02_L55:
       movzx     eax,byte ptr [rbp-70]
       jmp       near ptr M02_L15
M02_L56:
       cmp       r14d,1
       jne       short M02_L58
       test      dword ptr [rbp+20],10000
       jne       short M02_L57
       mov       r15,[rbp+28]
       test      r15,r15
       je        near ptr M02_L61
       call      qword ptr [7FFDF2B1DA70]
       cmp       rax,r15
       je        short M02_L61
       mov       rcx,r15
       mov       rdx,[rbp-58]
       mov       r8,rsi
       mov       r9,[rbp+38]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-58],rax
       mov       rcx,rsi
       mov       rdx,[rbp-58]
       call      qword ptr [7FFDF25AA578]; System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       je        short M02_L60
       mov       rcx,rsi
       call      qword ptr [7FFDF287D8A8]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       je        short M02_L59
       jmp       near ptr M02_L53
M02_L57:
       mov       r15,[rbp+28]
       jmp       short M02_L61
M02_L58:
       mov       r15,[rbp+28]
       jmp       short M02_L61
M02_L59:
       mov       eax,1
       jmp       near ptr M02_L15
M02_L60:
       lea       r8,[rbp-70]
       lea       rdx,[rbp-58]
       mov       rcx,rsi
       call      qword ptr [7FFDF2B1DA58]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M02_L55
M02_L61:
       cmp       r14d,1
       je        short M02_L62
       cmp       r14d,2
       jne       near ptr M02_L14
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDF2B1DA88]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDF266F228]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L62:
       mov       rcx,1C3513E2218
       call      qword ptr [7FFDF2B1DAA0]
       mov       r13,rax
       mov       rcx,[rbp-58]
       test      rcx,rcx
       jne       short M02_L63
       xor       r14d,r14d
       jmp       short M02_L64
M02_L63:
       call      qword ptr [7FFDF287D860]; System.Object.GetType()
       mov       r14,rax
M02_L64:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r13
       mov       rdx,r14
       mov       r8,rsi
       call      qword ptr [7FFDF2B1D668]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFDF2995BA8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M02_L65:
       lea       r8,[rbp-48]
       mov       [rbp-80],r8
       mov       dword ptr [rbp-78],1
       lea       r8,[rbp-80]
       mov       rdx,rsi
       mov       rcx,rbx
       mov       r9d,[rbp+20]
       call      qword ptr [7FFDF287D8C0]; System.Reflection.MethodBaseInvoker.InvokeDirectByRefWithFewArgs(System.Object, System.Span`1<System.Object>, System.Reflection.BindingFlags)
       mov       rdi,rax
       jmp       near ptr M02_L23
M02_L66:
       mov       r15,[rbx+20]
       cmp       esi,[r15+8]
       jae       near ptr M02_L73
       mov       ecx,esi
       test      byte ptr [r15+rcx*4+10],4
       je        short M02_L67
       lea       rcx,[rbp-48]
       mov       eax,esi
       mov       rcx,[rcx+rax*8]
       call      qword ptr [7FFDF2B1D740]
       mov       r8,rax
       mov       edx,esi
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M02_L25
M02_L67:
       lea       r8,[rbp-48]
       mov       edx,esi
       mov       r8,[r8+rdx*8]
       mov       edx,esi
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M02_L25
M02_L68:
       mov       r15,[rbx+20]
       cmp       esi,[r15+8]
       jae       near ptr M02_L73
       mov       ecx,esi
       test      byte ptr [r15+rcx*4+10],4
       jne       short M02_L69
       cmp       esi,1
       jae       near ptr M02_L73
       lea       r8,[rbp-48]
       mov       edx,esi
       mov       r8,[r8+rdx*8]
       movsxd    rdx,esi
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M02_L29
M02_L69:
       cmp       esi,1
       jae       near ptr M02_L73
       lea       rcx,[rbp-48]
       mov       eax,esi
       mov       rcx,[rcx+rax*8]
       call      qword ptr [7FFDF2B1D740]
       mov       r8,rax
       movsxd    rdx,esi
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M02_L29
       cmp       qword ptr [rbx+48],0
       jne       short M02_L70
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFDF287D5A8]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M02_L70:
       mov       [rsp+20],r14
       mov       r15,[rbp+38]
       mov       [rsp+28],r15
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,[rbp+20]
       mov       r9,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFDF287D740]; System.Reflection.MethodBaseInvoker.InvokeWithFewArgs(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       jmp       near ptr M02_L27
M02_L71:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFDF287D5A8]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M02_L72:
       mov       [rsp+20],r14
       mov       r15,[rbp+38]
       mov       [rsp+28],r15
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,[rbp+20]
       mov       r9,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFDF2B1D698]
       jmp       near ptr M02_L27
M02_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       vzeroupper
       mov       rdx,rcx
       mov       rcx,offset MT_System.Exception
       call      qword ptr [7FFDF2666850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdx,rax
       test      rdx,rdx
       jne       short M02_L74
       xor       eax,eax
       jmp       short M02_L75
M02_L74:
       mov       [rbp-98],rdx
       test      dword ptr [rbp+20],2000000
       sete      al
       movzx     eax,al
M02_L75:
       add       rsp,38
       ret
       sub       rsp,38
       vzeroupper
       mov       rcx,offset MT_System.Reflection.TargetInvocationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp-98]
       call      qword ptr [7FFDF2B1D6B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 2624
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L00
       cmp       [rdx],rcx
       jne       short M03_L01
M03_L00:
       mov       rax,rdx
       ret
M03_L01:
       jmp       qword ptr [7FFDF2874D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Delegate()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFDF2A3F960]; PrivateAccessProof.Subjects.InvokeDelegate(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeDelegate(PrivateAccessProof.Types.Secret, Int32)
       sub       rsp,28
       mov       r8d,edx
       mov       rdx,29A91001348
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
; PrivateAccessProof.Benchmarks.InvokeBench.Accessor()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFDF2A3F978]; PrivateAccessProof.Subjects.InvokeAccessor(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeAccessor(PrivateAccessProof.Types.Secret, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       ebx,edx
       mov       rsi,[rcx+8]
       test      ebx,ebx
       jl        short M01_L02
       cmp       ebx,12C
       jb        short M01_L00
       mov       ecx,ebx
       call      qword ptr [7FFDF2A3D8C0]; System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
       mov       rdi,rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,1F742801238
       mov       rcx,[rcx]
       mov       eax,ebx
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       ecx,ebx
       call      qword ptr [7FFDF2A3D8A8]; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|50_0(UInt32)
       mov       rdi,rax
M01_L01:
       jmp       near ptr M01_L09
M01_L02:
       call      qword ptr [7FFDF266D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,[rax+28]
       mov       edx,ebx
       neg       edx
       mov       ecx,edx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rax,7FFE5065C108
       add       rdx,[rax+rcx*8]
       sar       rdx,20
       mov       ebp,1
       cmp       edx,1
       cmovg     ebp,edx
       add       ebp,[rdi+8]
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.String
       call      00007FFE522B8D20
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       [rsp+28],rdx
       mov       rdx,[rsp+28]
       jmp       short M01_L04
M01_L03:
       xor       edx,edx
M01_L04:
       movsxd    rcx,ebp
       lea       rdx,[rdx+rcx*2]
       mov       ecx,ebx
       neg       ecx
       mov       r8d,1
       cmp       ecx,64
       jb        short M01_L06
       jmp       near ptr M01_L13
M01_L05:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,ecx
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,ecx
       sub       r11d,r9d
       mov       ecx,r10d
       add       rdx,0FFFFFFFFFFFFFFFE
       add       r11d,30
       mov       [rdx],r11w
M01_L06:
       test      ecx,ecx
       jne       short M01_L05
       test      r8d,r8d
       jg        short M01_L05
       mov       ecx,[rdi+8]
       dec       ecx
       js        short M01_L08
       cmp       [rdi+8],ecx
       jle       near ptr M01_L14
M01_L07:
       add       rdx,0FFFFFFFFFFFFFFFE
       mov       r8d,ecx
       movzx     r8d,word ptr [rdi+r8*2+0C]
       mov       [rdx],r8w
       dec       ecx
       jns       short M01_L07
M01_L08:
       xor       edx,edx
       mov       [rsp+28],rdx
       mov       rdi,rax
M01_L09:
       test      rsi,rsi
       je        near ptr M01_L11
       mov       ebx,[rsi+8]
       test      ebx,ebx
       je        near ptr M01_L11
       test      rdi,rdi
       je        short M01_L10
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short M01_L10
       mov       r14d,ebx
       mov       edx,ebp
       lea       rdx,[r14+rdx+1]
       cmp       rdx,7FFFFFFF
       jg        near ptr M01_L15
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFE522B8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,ebx
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFDF2665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r13+r14*2]
       mov       word ptr [rcx],3A
       inc       ebx
       movsxd    rcx,ebx
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFDF2665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L12
M01_L10:
       mov       rcx,rsi
       mov       rdx,237D7200C68
       call      qword ptr [7FFDF266D9C8]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       jmp       short M01_L12
M01_L11:
       mov       rdx,rdi
       mov       rcx,237D7200C68
       call      qword ptr [7FFDF266D9C8]; System.String.Concat(System.String, System.String)
       mov       r15,rax
M01_L12:
       mov       rax,r15
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L13:
       add       rdx,0FFFFFFFFFFFFFFFC
       add       r8d,0FFFFFFFE
       mov       r10d,ecx
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       ecx,r9d
       mov       r9,237D7201B94
       shl       ecx,2
       mov       ecx,[r9+rcx]
       mov       [rdx],ecx
       cmp       r10d,64
       mov       ecx,r10d
       jae       short M01_L13
       jmp       near ptr M01_L06
M01_L14:
       add       rdx,0FFFFFFFFFFFFFFFE
       cmp       ecx,[rdi+8]
       jae       short M01_L16
       mov       r8d,ecx
       movzx     r8d,word ptr [rdi+r8*2+0C]
       mov       [rdx],r8w
       dec       ecx
       jns       short M01_L14
       jmp       near ptr M01_L08
M01_L15:
       call      qword ptr [7FFDF2AF5B90]
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
```
```assembly
; System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       ebx,ecx
       mov       ecx,ebx
       or        ecx,1
       bsr       ecx,ecx
       mov       eax,ebx
       cmp       ecx,20
       jae       near ptr M02_L06
       lea       rdx,[7FFE5065C108]
       add       rax,[rdx+rcx*8]
       sar       rax,20
       movsxd    rsi,eax
       mov       rcx,rsi
       call      qword ptr [7FFE512DAA50]; Precode of System.String.FastAllocateString(IntPtr)
       test      rax,rax
       je        short M02_L00
       lea       rcx,[rax+0C]
       mov       [rsp+20],rcx
       mov       rcx,[rsp+20]
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
       xor       ecx,ecx
M02_L01:
       lea       rcx,[rcx+rsi*2]
       cmp       ebx,0A
       jb        short M02_L05
       cmp       ebx,64
       jb        short M02_L03
       mov       rdx,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rdx]
       add       rdx,0C
M02_L02:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r8d,ebx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       ebx,r10d
       mov       r10,rdx
       shl       ebx,2
       mov       r9d,ebx
       mov       r10d,[r10+r9]
       mov       [rcx],r10d
       cmp       r8d,64
       mov       ebx,r8d
       jae       short M02_L02
M02_L03:
       cmp       ebx,0A
       jb        short M02_L05
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rdx]
       add       rdx,0C
       lea       r8d,[rbx*4]
       mov       edx,[rdx+r8]
       mov       [rcx],edx
M02_L04:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L05:
       lea       edx,[rbx+30]
       mov       [rcx-2],dx
       jmp       short M02_L04
M02_L06:
       call      qword ptr [7FFE512C7FC0]
       int       3
; Total bytes of code 231
```
```assembly
; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|50_0(UInt32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE512C86E8]
       mov       rsi,[rax]
       mov       ecx,ebx
       call      qword ptr [7FFE512DC468]; Precode of System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
       mov       rdi,rax
       cmp       ebx,[rsi+8]
       jae       short M03_L00
       mov       ecx,ebx
       lea       rcx,[rsi+rcx*8+10]
       mov       rdx,rdi
       call      qword ptr [7FFE512C7FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       call      qword ptr [7FFE512C7FC0]
       int       3
; Total bytes of code 68
```
```assembly
; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFE512DF9B0]; Precode of System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       cmp       byte ptr [rbx+61],0
       jne       short M04_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M04_L00
       add       rsp,20
       pop       rbx
       ret
M04_L00:
       mov       rcx,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       call      qword ptr [7FFE512C8040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       lea       r11,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       call      qword ptr [r11]
       mov       rcx,rax
       call      qword ptr [7FFE512D74D8]
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 80
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M05_L01
       test      r8b,18
       jne       short M05_L05
       test      r8b,4
       jne       short M05_L06
       test      r8,r8
       je        short M05_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M05_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
M05_L00:
       vzeroupper
       ret
M05_L01:
       cmp       r8,40
       ja        short M05_L07
M05_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M05_L04
M05_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M05_L00
M05_L04:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M05_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M05_L03
M05_L05:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M05_L00
M05_L06:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M05_L00
M05_L07:
       cmp       r8,800
       ja        short M05_L11
       cmp       r8,100
       jb        short M05_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M05_L08:
       mov       r9,r8
       shr       r9,6
M05_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M05_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M05_L02
       jmp       near ptr M05_L03
M05_L10:
       cmp       rcx,rdx
       jne       short M05_L11
       cmp       [rdx],dl
       jmp       near ptr M05_L00
M05_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFDF26666E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 317
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFE522B8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFDF2665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFDF2665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,237D7200008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L04:
       call      qword ptr [7FFDF2AF5B90]
       int       3
; Total bytes of code 244
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Direct()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFDC8E3EA60]; PrivateAccessProof.Subjects.InvokeDirect(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeDirect(PrivateAccessProof.Types.Secret, Int32)
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+8]
       mov       ecx,edx
       call      qword ptr [7FFDC8B7FC90]; System.Number.Int32ToDecStr(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,21231BA0A40
       call      qword ptr [7FFDC8A36B20]; System.String.Concat(System.String, System.String, System.String)
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 46
```
```assembly
; System.Number.Int32ToDecStr(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       ebx,ecx
       test      ebx,ebx
       jl        near ptr M02_L09
       cmp       ebx,12C
       jae       short M02_L01
       mov       rcx,1912D000260
       mov       rcx,[rcx]
       mov       eax,ebx
       mov       rax,[rcx+rax*8+10]
       test      rax,rax
       jne       short M02_L00
       mov       ecx,ebx
       call      qword ptr [7FFDC8BA4900]; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|70_0(UInt32)
M02_L00:
       jmp       near ptr M02_L08
M02_L01:
       mov       esi,ebx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rax,7FFE26A487A0
       add       rsi,[rax+rcx*8]
       sar       rsi,20
       mov       ecx,esi
       call      00007FFDC8A31E60
       test      rax,rax
       je        near ptr M02_L05
       lea       rcx,[rax+0C]
       mov       [rsp+20],rcx
       mov       rcx,[rsp+20]
M02_L02:
       movsxd    rdx,esi
       lea       rcx,[rcx+rdx*2]
       cmp       ebx,0A
       jb        short M02_L06
       cmp       ebx,64
       jb        short M02_L04
       mov       rdx,1912D000290
       mov       rdx,[rdx]
M02_L03:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r8d,ebx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       ebx,r10d
       mov       r10,rdx
       shl       ebx,2
       mov       r9d,ebx
       mov       r10d,[r10+r9+10]
       mov       [rcx],r10d
       cmp       r8d,64
       mov       ebx,r8d
       jae       short M02_L03
M02_L04:
       cmp       ebx,0A
       jb        short M02_L06
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,1912D000290
       mov       rdx,[rdx]
       lea       r8d,[rbx*4]
       mov       edx,[rdx+r8+10]
       mov       [rcx],edx
       jmp       short M02_L07
M02_L05:
       xor       ecx,ecx
       jmp       short M02_L02
M02_L06:
       lea       edx,[rbx+30]
       mov       [rcx-2],dx
M02_L07:
       xor       ecx,ecx
       mov       [rsp+20],rcx
M02_L08:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L09:
       call      qword ptr [7FFDC8B5F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r8,[rax+28]
       mov       ecx,ebx
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDC8B7FCA8]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 307
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M03_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M03_L02
       test      rsi,rsi
       je        near ptr M03_L03
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M03_L03
       test      rdi,rdi
       je        near ptr M03_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M03_L00
       mov       r13d,ebp
       mov       ecx,r14d
       add       rcx,r13
       mov       eax,r15d
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M03_L01
       call      00007FFDC8A31E60
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFDC8AE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFDC8AE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFDC8AE5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDC8A36B08]; System.String.Concat(System.String, System.String)
M03_L01:
       call      qword ptr [7FFDC8BCEF40]
       int       3
M03_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDC8A36B08]; System.String.Concat(System.String, System.String)
M03_L03:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDC8A36B08]; System.String.Concat(System.String, System.String)
; Total bytes of code 320
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Reflection()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFDC8E5E538]; PrivateAccessProof.Subjects.InvokeReflection(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeReflection(PrivateAccessProof.Types.Secret, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,23FC9C04530
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],esi
       lea       rcx,[rbp+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],rbp
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFDC8C33238]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       rdx,rax
       mov       rax,rdx
       test      rax,rax
       je        short M01_L00
       mov       rcx,offset MT_System.String
       cmp       [rax],rcx
       jne       short M01_L01
M01_L00:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      qword ptr [7FFDC8A543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 151
```
```assembly
; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rbp,r9
       mov       r14,[rsp+80]
M02_L00:
       cmp       qword ptr [rbx+48],0
       je        near ptr M02_L11
M02_L01:
       mov       rcx,[rbx+48]
       test      dword ptr [rcx+3C],102
       jne       near ptr M02_L20
M02_L02:
       test      byte ptr [rbx+5C],10
       jne       short M02_L04
       test      rsi,rsi
       je        near ptr M02_L21
       mov       rcx,[rbx+8]
       cmp       byte ptr [rcx+94],0
       je        near ptr M02_L08
       xor       ecx,ecx
M02_L03:
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+0A0]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M02_L12
M02_L04:
       test      r14,r14
       je        near ptr M02_L13
       mov       r15d,[r14+8]
M02_L05:
       mov       rax,[rbx+30]
       test      rax,rax
       je        near ptr M02_L10
M02_L06:
       mov       rcx,[rax+8]
       cmp       [rcx+8],r15d
       jne       near ptr M02_L14
       cmp       r15d,1
       jne       near ptr M02_L15
       cmp       qword ptr [rbx+48],0
       je        short M02_L09
M02_L07:
       mov       [rsp+80],r14
       mov       r15,[rsp+88]
       mov       [rsp+88],r15
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,rbp
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDC8C478D0]; System.Reflection.MethodBaseInvoker.InvokeWithOneArg(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M02_L08:
       mov       rcx,[rbx+38]
       jmp       near ptr M02_L03
M02_L09:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFDC8C47810]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L07
M02_L10:
       mov       rcx,rbx
       call      qword ptr [7FFDC8C45890]; System.Reflection.RuntimeMethodInfo.<get_Signature>g__LazyCreateSignature|25_0()
       jmp       near ptr M02_L06
M02_L11:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFDC8C47810]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L01
M02_L12:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC8F1F000]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFDC8D05AB8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L13:
       xor       eax,eax
       mov       r15d,eax
       jmp       near ptr M02_L05
M02_L14:
       call      qword ptr [7FFDC8C478A0]
       int       3
M02_L15:
       cmp       r15d,4
       ja        near ptr M02_L18
       mov       ecx,r15d
       lea       rax,[7FFDC8A8D410]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
       cmp       qword ptr [rbx+48],0
       jne       short M02_L16
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FFDC8C47810]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L16:
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,edi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDC8C478B8]
       cmp       qword ptr [rbx+48],0
       jne       short M02_L17
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFDC8C47810]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M02_L17:
       mov       [rsp+80],r14
       mov       r15,[rsp+88]
       mov       [rsp+88],r15
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,rbp
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDC8C478E8]; System.Reflection.MethodBaseInvoker.InvokeWithFewArgs(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M02_L18:
       cmp       qword ptr [rbx+48],0
       jne       short M02_L19
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFDC8C47810]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M02_L19:
       mov       [rsp+80],r14
       mov       r15,[rsp+88]
       mov       [rsp+88],r15
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,rbp
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDC8C47918]
M02_L20:
       mov       rcx,rbx
       call      qword ptr [7FFDC8C45860]
       jmp       near ptr M02_L02
M02_L21:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDC8F1F030]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFDC8D05AB8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 798
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

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Delegate()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFDC8E6EA30]; PrivateAccessProof.Subjects.InvokeDelegate(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeDelegate(PrivateAccessProof.Types.Secret, Int32)
       sub       rsp,28
       mov       r8d,edx
       mov       rdx,26A14404558
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
; PrivateAccessProof.Benchmarks.InvokeBench.Accessor()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFDC8E5EA48]; PrivateAccessProof.Subjects.InvokeAccessor(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeAccessor(PrivateAccessProof.Types.Secret, Int32)
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+8]
       mov       ecx,edx
       call      qword ptr [7FFDC8B9FC90]; System.Number.Int32ToDecStr(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,226FB7D0A40
       call      qword ptr [7FFDC8A56B20]; System.String.Concat(System.String, System.String, System.String)
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 46
```
```assembly
; System.Number.Int32ToDecStr(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       ebx,ecx
       test      ebx,ebx
       jl        near ptr M02_L09
       cmp       ebx,12C
       jae       short M02_L01
       mov       rcx,1A5F6C00260
       mov       rcx,[rcx]
       mov       eax,ebx
       mov       rax,[rcx+rax*8+10]
       test      rax,rax
       jne       short M02_L00
       mov       ecx,ebx
       call      qword ptr [7FFDC8BC4900]; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|70_0(UInt32)
M02_L00:
       jmp       near ptr M02_L08
M02_L01:
       mov       esi,ebx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rax,7FFE26A487A0
       add       rsi,[rax+rcx*8]
       sar       rsi,20
       mov       ecx,esi
       call      00007FFDC8A51E60
       test      rax,rax
       je        near ptr M02_L05
       lea       rcx,[rax+0C]
       mov       [rsp+20],rcx
       mov       rcx,[rsp+20]
M02_L02:
       movsxd    rdx,esi
       lea       rcx,[rcx+rdx*2]
       cmp       ebx,0A
       jb        short M02_L06
       cmp       ebx,64
       jb        short M02_L04
       mov       rdx,1A5F6C00290
       mov       rdx,[rdx]
M02_L03:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r8d,ebx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       ebx,r10d
       mov       r10,rdx
       shl       ebx,2
       mov       r9d,ebx
       mov       r10d,[r10+r9+10]
       mov       [rcx],r10d
       cmp       r8d,64
       mov       ebx,r8d
       jae       short M02_L03
M02_L04:
       cmp       ebx,0A
       jb        short M02_L06
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,1A5F6C00290
       mov       rdx,[rdx]
       lea       r8d,[rbx*4]
       mov       edx,[rdx+r8+10]
       mov       [rcx],edx
       jmp       short M02_L07
M02_L05:
       xor       ecx,ecx
       jmp       short M02_L02
M02_L06:
       lea       edx,[rbx+30]
       mov       [rcx-2],dx
M02_L07:
       xor       ecx,ecx
       mov       [rsp+20],rcx
M02_L08:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L09:
       call      qword ptr [7FFDC8B7F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r8,[rax+28]
       mov       ecx,ebx
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDC8B9FCA8]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 307
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M03_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M03_L02
       test      rsi,rsi
       je        near ptr M03_L03
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M03_L03
       test      rdi,rdi
       je        near ptr M03_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M03_L00
       mov       r13d,ebp
       mov       ecx,r14d
       add       rcx,r13
       mov       eax,r15d
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M03_L01
       call      00007FFDC8A51E60
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFDC8B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFDC8B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFDC8B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDC8A56B08]; System.String.Concat(System.String, System.String)
M03_L01:
       call      qword ptr [7FFDC8BEEF40]
       int       3
M03_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDC8A56B08]; System.String.Concat(System.String, System.String)
M03_L03:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFDC8A56B08]; System.String.Concat(System.String, System.String)
; Total bytes of code 320
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Direct()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFD92DDEB08]; PrivateAccessProof.Subjects.InvokeDirect(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeDirect(PrivateAccessProof.Types.Secret, Int32)
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+8]
       mov       ecx,edx
       call      qword ptr [7FFD92DDEB68]; System.Number.Int32ToDecStr(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,2CBCDF00C68
       call      qword ptr [7FFD92C3E3B8]; System.String.Concat(System.String, System.String, System.String)
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 46
```
```assembly
; System.Number.Int32ToDecStr(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       ebx,ecx
       test      ebx,ebx
       jl        near ptr M02_L09
       cmp       ebx,12C
       jb        near ptr M02_L07
       mov       esi,ebx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rax,7FFDA43A8AB0
       add       rsi,[rax+rcx*8]
       sar       rsi,20
       mov       ecx,esi
       call      00007FFD92A22520
       test      rax,rax
       je        short M02_L03
       lea       rcx,[rax+0C]
       mov       [rsp+20],rcx
       mov       rcx,[rsp+20]
M02_L00:
       movsxd    rdx,esi
       lea       rcx,[rcx+rdx*2]
       cmp       ebx,0A
       jb        short M02_L06
       jmp       short M02_L02
M02_L01:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       edx,ebx
       imul      rdx,51EB851F
       shr       rdx,25
       imul      r8d,edx,64
       sub       ebx,r8d
       mov       r8,24AC94002D0
       mov       r8,[r8]
       shl       ebx,2
       mov       r10d,ebx
       mov       r8d,[r8+r10+10]
       mov       [rcx],r8d
       mov       ebx,edx
M02_L02:
       cmp       ebx,64
       jae       short M02_L01
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M02_L00
M02_L04:
       cmp       ebx,0A
       jb        short M02_L06
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,24AC94002D0
       mov       rdx,[rdx]
       lea       r8d,[rbx*4]
       mov       edx,[rdx+r8+10]
       mov       [rcx],edx
M02_L05:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       jmp       short M02_L08
M02_L06:
       add       rcx,0FFFFFFFFFFFFFFFE
       lea       edx,[rbx+30]
       mov       [rcx],dx
       jmp       short M02_L05
M02_L07:
       mov       rcx,24AC94002C8
       mov       rcx,[rcx]
       mov       eax,ebx
       mov       rax,[rcx+rax*8+10]
       test      rax,rax
       jne       short M02_L08
       mov       ecx,ebx
       call      qword ptr [7FFD92DDCDF8]; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|47_0(UInt32)
M02_L08:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L09:
       call      qword ptr [7FFD92A2D110]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r8,[rax+28]
       mov       ecx,ebx
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFD92EA4E58]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 303
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M03_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M03_L03
       test      rsi,rsi
       je        near ptr M03_L02
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M03_L02
       test      rdi,rdi
       je        near ptr M03_L01
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M03_L01
       mov       r13d,ebp
       mov       ecx,r14d
       add       rcx,r13
       mov       eax,r15d
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        short M03_L00
       call      00007FFD92A22520
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD92A257B8]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD92A257B8]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[rbx+rcx*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFD92A257B8]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
       call      qword ptr [7FFD92EA4E88]
       int       3
M03_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD92A2D878]; System.String.Concat(System.String, System.String)
M03_L02:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD92A2D878]; System.String.Concat(System.String, System.String)
M03_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD92A2D878]; System.String.Concat(System.String, System.String)
; Total bytes of code 316
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Reflection()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFD92DEEBE0]; PrivateAccessProof.Subjects.InvokeReflection(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeReflection(PrivateAccessProof.Types.Secret, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,24E7D001330
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],esi
       lea       rcx,[rbp+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],rbp
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFD92CC94A0]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       rdx,rax
       mov       rax,rdx
       test      rax,rax
       je        short M01_L00
       mov       rcx,offset MT_System.String
       cmp       [rax],rcx
       jne       short M01_L01
M01_L00:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 150
```
```assembly
; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rbp,r9
       mov       r14,[rsp+90]
M02_L00:
       cmp       qword ptr [rbx+48],0
       je        near ptr M02_L08
M02_L01:
       mov       rcx,[rbx+48]
       test      dword ptr [rcx+3C],102
       jne       near ptr M02_L14
M02_L02:
       test      byte ptr [rbx+5C],10
       jne       short M02_L03
       test      rsi,rsi
       je        near ptr M02_L16
       mov       rcx,rbx
       call      qword ptr [7FFD92CC93E8]; System.Reflection.RuntimeMethodInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+0A0]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M02_L15
M02_L03:
       test      r14,r14
       je        near ptr M02_L17
       mov       r15d,[r14+8]
M02_L04:
       mov       rax,[rbx+30]
       test      rax,rax
       je        near ptr M02_L09
M02_L05:
       mov       rcx,[rax+8]
       cmp       [rcx+8],r15d
       jne       near ptr M02_L21
       cmp       r15d,1
       jne       near ptr M02_L10
       cmp       qword ptr [rbx+48],0
       je        near ptr M02_L13
M02_L06:
       mov       [rsp+20],r14
       mov       r13,[rsp+98]
       mov       [rsp+28],r13
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFD92ED63B8]; System.Reflection.MethodBaseInvoker.InvokeWithOneArg(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M02_L07:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L08:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFD92C4CD20]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rbx
       call      qword ptr [7FFD92C4CD38]; System.Reflection.RuntimeMethodInfo.<get_Signature>g__LazyCreateSignature|25_0()
       jmp       near ptr M02_L05
M02_L10:
       cmp       r15d,4
       ja        near ptr M02_L18
       mov       ecx,r15d
       lea       rax,[7FFD92AEEA60]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
       cmp       qword ptr [rbx+48],0
       je        short M02_L12
M02_L11:
       mov       [rsp+20],r14
       mov       r13,[rsp+98]
       mov       [rsp+28],r13
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFD92C4CEB8]; System.Reflection.MethodBaseInvoker.InvokeWithFewArgs(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       jmp       near ptr M02_L07
M02_L12:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFD92C4CD20]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L11
M02_L13:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFD92C4CD20]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L06
M02_L14:
       mov       rcx,rbx
       call      qword ptr [7FFD92EDCB88]
       jmp       near ptr M02_L02
M02_L15:
       call      qword ptr [7FFD92EDCBA0]
       mov       r14,rax
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,rbx
       call      qword ptr [7FFD92CC93E8]; System.Reflection.RuntimeMethodInfo.get_DeclaringType()
       mov       rbx,rax
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FFD92EDCBB8]
       mov       rdx,rax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FFD92EDCBD0]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD92EDCBE8]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD92EDCBD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L17:
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L18:
       cmp       qword ptr [rbx+48],0
       jne       short M02_L19
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFD92C4CD20]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M02_L19:
       mov       [rsp+20],r14
       mov       r13,[rsp+98]
       mov       [rsp+28],r13
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFD92EDCB70]
       jmp       near ptr M02_L07
       cmp       qword ptr [rbx+48],0
       jne       short M02_L20
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      qword ptr [7FFD92C4CD20]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L20:
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,edi
       cmp       [rcx],ecx
       call      qword ptr [7FFD92D56388]; System.Reflection.MethodBaseInvoker.InvokeWithNoArgs(System.Object, System.Reflection.BindingFlags)
       jmp       near ptr M02_L07
M02_L21:
       call      qword ptr [7FFD92EDCC00]
       int       3
; Total bytes of code 795
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L00
       cmp       [rdx],rcx
       jne       short M03_L01
M03_L00:
       mov       rax,rdx
       ret
M03_L01:
       jmp       qword ptr [7FFD92C44BE8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Delegate()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFD92DEEBE0]; PrivateAccessProof.Subjects.InvokeDelegate(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeDelegate(PrivateAccessProof.Types.Secret, Int32)
       sub       rsp,28
       mov       r8d,edx
       mov       rdx,270C4801358
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
; PrivateAccessProof.Benchmarks.InvokeBench.Accessor()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFD92DDEBC8]; PrivateAccessProof.Subjects.InvokeAccessor(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeAccessor(PrivateAccessProof.Types.Secret, Int32)
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+8]
       mov       ecx,edx
       call      qword ptr [7FFD92DDEC28]; System.Number.Int32ToDecStr(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,2B4B47E0C68
       call      qword ptr [7FFD92C3E3B8]; System.String.Concat(System.String, System.String, System.String)
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 46
```
```assembly
; System.Number.Int32ToDecStr(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       ebx,ecx
       test      ebx,ebx
       jl        near ptr M02_L09
       cmp       ebx,12C
       jb        near ptr M02_L07
       mov       esi,ebx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rax,7FFDA43A8AB0
       add       rsi,[rax+rcx*8]
       sar       rsi,20
       mov       ecx,esi
       call      00007FFD92A22520
       test      rax,rax
       je        short M02_L03
       lea       rcx,[rax+0C]
       mov       [rsp+20],rcx
       mov       rcx,[rsp+20]
M02_L00:
       movsxd    rdx,esi
       lea       rcx,[rcx+rdx*2]
       cmp       ebx,0A
       jb        short M02_L06
       jmp       short M02_L02
M02_L01:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       edx,ebx
       imul      rdx,51EB851F
       shr       rdx,25
       imul      r8d,edx,64
       sub       ebx,r8d
       mov       r8,233AFC002D0
       mov       r8,[r8]
       shl       ebx,2
       mov       r10d,ebx
       mov       r8d,[r8+r10+10]
       mov       [rcx],r8d
       mov       ebx,edx
M02_L02:
       cmp       ebx,64
       jae       short M02_L01
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M02_L00
M02_L04:
       cmp       ebx,0A
       jb        short M02_L06
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,233AFC002D0
       mov       rdx,[rdx]
       lea       r8d,[rbx*4]
       mov       edx,[rdx+r8+10]
       mov       [rcx],edx
M02_L05:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       jmp       short M02_L08
M02_L06:
       add       rcx,0FFFFFFFFFFFFFFFE
       lea       edx,[rbx+30]
       mov       [rcx],dx
       jmp       short M02_L05
M02_L07:
       mov       rcx,233AFC002C8
       mov       rcx,[rcx]
       mov       eax,ebx
       mov       rax,[rcx+rax*8+10]
       test      rax,rax
       jne       short M02_L08
       mov       ecx,ebx
       call      qword ptr [7FFD92DDCDF8]; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|47_0(UInt32)
M02_L08:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L09:
       call      qword ptr [7FFD92A2D110]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r8,[rax+28]
       mov       ecx,ebx
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFD92EA4E58]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 303
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M03_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M03_L03
       test      rsi,rsi
       je        near ptr M03_L02
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M03_L02
       test      rdi,rdi
       je        near ptr M03_L01
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M03_L01
       mov       r13d,ebp
       mov       ecx,r14d
       add       rcx,r13
       mov       eax,r15d
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        short M03_L00
       call      00007FFD92A22520
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD92A257B8]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD92A257B8]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[rbx+rcx*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFD92A257B8]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
       call      qword ptr [7FFD92EA4E88]
       int       3
M03_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD92A2D878]; System.String.Concat(System.String, System.String)
M03_L02:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD92A2D878]; System.String.Concat(System.String, System.String)
M03_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD92A2D878]; System.String.Concat(System.String, System.String)
; Total bytes of code 316
```

