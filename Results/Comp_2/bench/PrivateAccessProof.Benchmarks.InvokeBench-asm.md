## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Direct()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFADB64FAE0]; PrivateAccessProof.Subjects.InvokeDirect(PrivateAccessProof.Types.Secret, Int32)
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
       call      qword ptr [7FFADB64DA10]; System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
       mov       rdi,rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,2680B801238
       mov       rcx,[rcx]
       mov       eax,ebx
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       ecx,ebx
       call      qword ptr [7FFADB64D9F8]; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|50_0(UInt32)
       mov       rdi,rax
M01_L01:
       jmp       near ptr M01_L09
M01_L02:
       call      qword ptr [7FFADB2ED2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,[rax+28]
       mov       edx,ebx
       neg       edx
       mov       ecx,edx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rax,7FFB2C03C180
       add       rdx,[rax+rcx*8]
       sar       rdx,20
       mov       ebp,1
       cmp       edx,1
       cmovg     ebp,edx
       add       ebp,[rdi+8]
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.String
       call      00007FFB3AF74CA0
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
       call      00007FFB3AF74CA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,ebx
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFADB2E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r13+r14*2]
       mov       word ptr [rcx],3A
       inc       ebx
       movsxd    rcx,ebx
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFADB2E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L12
M01_L10:
       mov       rcx,rsi
       mov       rdx,2A894840C68
       call      qword ptr [7FFADB2ED9C8]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       jmp       short M01_L12
M01_L11:
       mov       rdx,rdi
       mov       rcx,2A894840C68
       call      qword ptr [7FFADB2ED9C8]; System.String.Concat(System.String, System.String)
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
       mov       r9,2A894841B94
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
       call      qword ptr [7FFADB6C5D88]
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
```
```assembly
; System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       ebx,ecx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       eax,ebx
       mov       rdx,7FFB2C03C180
       add       rax,[rdx+rcx*8]
       sar       rax,20
       movsxd    rsi,eax
       mov       rcx,rsi
       call      qword ptr [7FFADB2E6670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       test      rdi,rdi
       je        short M02_L00
       mov       rcx,7FFADB77E888
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rdi+0C]
       mov       [rsp+20],rcx
       mov       rbp,[rsp+20]
       jmp       short M02_L01
M02_L00:
       xor       edi,edi
       xor       ebp,ebp
M02_L01:
       mov       rcx,7FFADB77E88C
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rax,[rbp+rsi*2]
       cmp       ebx,0A
       jb        short M02_L05
       cmp       ebx,64
       jb        short M02_L03
       mov       rcx,2A894841B94
M02_L02:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       edx,ebx
       imul      rdx,51EB851F
       shr       rdx,25
       imul      r8d,edx,64
       sub       ebx,r8d
       mov       r8,rcx
       shl       ebx,2
       mov       r10d,ebx
       mov       r8d,[r8+r10]
       mov       [rax],r8d
       cmp       edx,64
       mov       ebx,edx
       jae       short M02_L02
M02_L03:
       cmp       ebx,0A
       jb        short M02_L05
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rcx,2A894841B94
       lea       edx,[rbx*4]
       mov       ecx,[rcx+rdx]
       mov       [rax],ecx
M02_L04:
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L05:
       lea       ecx,[rbx+30]
       mov       [rax-2],cx
       jmp       short M02_L04
; Total bytes of code 250
```
```assembly
; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|50_0(UInt32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       ebx,ecx
       mov       edx,ebx
       or        edx,1
       lzcnt     edx,edx
       xor       edx,1F
       mov       ecx,ebx
       mov       rax,7FFB2C03C180
       add       rcx,[rax+rdx*8]
       sar       rcx,20
       movsxd    rsi,ecx
       mov       rdx,rsi
       mov       rcx,offset MT_System.String
       call      00007FFB3AF74CA0
       mov       rdi,rax
       test      rdi,rdi
       je        short M03_L00
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rcx,[rsp+28]
       jmp       short M03_L01
M03_L00:
       xor       edi,edi
       xor       ecx,ecx
M03_L01:
       lea       rcx,[rcx+rsi*2]
       mov       edx,ebx
       cmp       edx,0A
       jb        near ptr M03_L05
       cmp       ebx,64
       jb        short M03_L03
       mov       rax,2A894841B94
M03_L02:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r8d,edx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       edx,r10d
       mov       r10,rax
       shl       edx,2
       mov       edx,[r10+rdx]
       mov       [rcx],edx
       cmp       r8d,64
       mov       edx,r8d
       jae       short M03_L02
M03_L03:
       cmp       edx,0A
       jb        short M03_L05
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rax,2A894841B94
       shl       edx,2
       mov       edx,[rax+rdx]
       mov       [rcx],edx
M03_L04:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,2680B801238
       mov       rcx,[rcx]
       cmp       ebx,12C
       jae       short M03_L06
       mov       edx,ebx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L05:
       add       edx,30
       mov       [rcx-2],dx
       jmp       short M03_L04
M03_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 269
```
```assembly
; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFB2CCBF928]; Precode of System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFB2CCA8040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       lea       r11,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       call      qword ptr [r11]
       mov       rcx,rax
       call      qword ptr [7FFB2CCB7430]
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
       jmp       qword ptr [7FFADB2E66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      00007FFB3AF74CA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFADB2E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFADB2E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2A894840008
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
       call      qword ptr [7FFADB6C5D88]
       int       3
; Total bytes of code 244
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Reflection()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFADB64FAC8]; PrivateAccessProof.Subjects.InvokeReflection(PrivateAccessProof.Types.Secret, Int32)
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
       mov       rcx,2A528001320
       mov       rcx,[rcx]
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFADB52A340]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
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
       je        near ptr M02_L25
M02_L01:
       mov       rcx,[rbx+48]
       test      dword ptr [rcx+3C],102
       jne       near ptr M02_L28
       test      byte ptr [rbx+5C],10
       jne       short M02_L03
       test      rsi,rsi
       je        near ptr M02_L29
       mov       rcx,[rbx+8]
       cmp       byte ptr [rcx+9C],0
       jne       near ptr M02_L30
       mov       rcx,[rbx+38]
M02_L02:
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+0A0]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M02_L31
M02_L03:
       test      r14,r14
       je        near ptr M02_L32
       mov       r15d,[r14+8]
M02_L04:
       mov       rax,[rbx+30]
       test      rax,rax
       je        near ptr M02_L26
M02_L05:
       mov       rcx,[rax+8]
       cmp       [rcx+8],r15d
       jne       near ptr M02_L33
       cmp       r15d,1
       jne       near ptr M02_L34
       cmp       qword ptr [rbx+48],0
       je        near ptr M02_L27
M02_L06:
       mov       rbx,[rbx+48]
       mov       [rbp-90],rbx
       cmp       [rbx],bl
       mov       r9d,[r14+8]
       mov       r13d,r9d
       test      r13d,r13d
       je        near ptr M02_L72
       mov       [rbp+30],r14
       mov       r9,[r14+10]
       mov       [rbp-40],r9
       xor       r9d,r9d
       mov       [rbp-48],r9
       mov       byte ptr [rbp-4C],0
       test      byte ptr [rbx+38],2
       mov       r14,[rbp+30]
       je        near ptr M02_L37
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
       jae       near ptr M02_L72
       mov       r8,[rcx+rax*8+10]
       mov       [rbp-0A0],r8
       mov       rcx,[rbp-58]
       mov       rdx,2A5280002F0
       cmp       rcx,[rdx]
       je        near ptr M02_L38
M02_L09:
       cmp       qword ptr [rbp-58],0
       je        near ptr M02_L39
       mov       rcx,[rbp-58]
       call      qword ptr [7FFADB4BD878]; System.Object.GetType()
       mov       rdx,[rbp-0A0]
       cmp       rax,rdx
       je        near ptr M02_L16
       mov       [rbp+18],rsi
       mov       [rbp+28],rdi
       mov       [rbp+30],r14
       mov       rcx,[rdx+18]
       mov       rax,7FFB3AF09D00
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-0A0]
       cmp       dword ptr [7FFB3B233B10],0
       jne       near ptr M02_L41
M02_L10:
       cmp       ebx,10
       je        near ptr M02_L42
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
       jne       near ptr M02_L44
M02_L12:
       test      rdx,rdx
       setne     r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        near ptr M02_L53
       mov       r8,[rsi+18]
       test      r8b,2
       jne       near ptr M02_L51
       mov       r8d,[r8]
       and       r8d,0F0000
       cmp       r8d,50000
       sete      r8b
       movzx     r8d,r8b
M02_L13:
       test      r8d,r8d
       mov       r15,[rbp+28]
       jne       near ptr M02_L52
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
       je        near ptr M02_L64
       lea       r8,[rbp-48]
       mov       [rbp-80],r8
       mov       dword ptr [rbp-78],1
       lea       r8,[rbp-80]
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
M02_L18:
       xor       esi,esi
       cmp       r13d,1
       jg        short M02_L23
M02_L19:
       lea       rcx,[rbp-4C]
       mov       eax,esi
       cmp       byte ptr [rcx+rax],0
       jne       near ptr M02_L65
M02_L20:
       inc       esi
       cmp       r13d,esi
       jg        short M02_L19
M02_L21:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rcx
       mov       rax,rdi
M02_L22:
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
M02_L23:
       cmp       esi,1
       jae       near ptr M02_L72
       lea       rcx,[rbp-4C]
       mov       eax,esi
       cmp       byte ptr [rcx+rax],0
       jne       near ptr M02_L67
M02_L24:
       inc       esi
       cmp       r13d,esi
       jg        short M02_L23
       jmp       short M02_L21
M02_L25:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFADB4BD5A8]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L01
M02_L26:
       mov       rcx,rbx
       call      qword ptr [7FFADB4BD5C0]; System.Reflection.RuntimeMethodInfo.<get_Signature>g__LazyCreateSignature|25_0()
       jmp       near ptr M02_L05
M02_L27:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,rbx
       call      qword ptr [7FFADB4BD5A8]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L06
M02_L28:
       mov       rcx,rbx
       call      qword ptr [7FFADB6ED7A0]
       int       3
M02_L29:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFADB6ED7B8]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFADB6ED7D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L30:
       xor       ecx,ecx
       jmp       near ptr M02_L02
M02_L31:
       call      qword ptr [7FFADB6ED7E8]
       mov       r14,rax
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFADB52A288]
       mov       rbx,rax
       mov       rcx,rsi
       call      qword ptr [7FFADB4BD878]; System.Object.GetType()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FFADB6ED800]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFADB6ED7D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L32:
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L33:
       call      qword ptr [7FFADB6ED818]
       int       3
M02_L34:
       cmp       r15d,4
       ja        short M02_L35
       mov       ecx,r15d
       lea       rax,[7FFADB35FD98]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
M02_L35:
       cmp       qword ptr [rbx+48],0
       jne       near ptr M02_L71
       jmp       near ptr M02_L70
       cmp       qword ptr [rbx+48],0
       jne       short M02_L36
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FFADB4BD5A8]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L36:
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFADB5B6FE8]; System.Reflection.MethodBaseInvoker.InvokeWithNoArgs(System.Object, System.Reflection.BindingFlags)
       jmp       near ptr M02_L22
M02_L37:
       mov       dword ptr [rsp+20],1
       movzx     r9d,byte ptr [rbx+44]
       mov       r8,[rbx+30]
       lea       rdx,[rbx+10]
       lea       rcx,[rbx+38]
       call      qword ptr [7FFADB4BD7B8]; System.Reflection.MethodInvokerCommon.DetermineStrategy_ObjSpanArgs(InvokerStrategy ByRef, InvokeFunc_ObjSpanArgs ByRef, System.Reflection.MethodBase, Boolean, Boolean)
       jmp       near ptr M02_L07
M02_L38:
       mov       rcx,[rbx+30]
       lea       rdx,[rbp-68]
       mov       r10,[rcx]
       mov       r10,[r10+50]
       call      qword ptr [r10+10]
       cmp       r12d,[rbp-60]
       jae       near ptr M02_L72
       mov       rcx,[rbp-68]
       mov       rax,[rbp-88]
       mov       rcx,[rcx+rax*8]
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FFADB6ED8A8]
       mov       [rbp-58],rax
       lea       rcx,[rbp-4C]
       mov       rax,[rbp-88]
       mov       byte ptr [rcx+rax],1
       mov       rbx,[rbp-90]
       jmp       near ptr M02_L09
M02_L39:
       mov       r8,[rbp-0A0]
       mov       r15,[rbp+38]
       mov       rdx,[rbx+20]
       cmp       r12d,[rdx+8]
       jae       near ptr M02_L72
       mov       rax,[rbp-88]
       test      byte ptr [rdx+rax*4+10],2
       je        short M02_L40
       lea       r10,[rbp-4C]
       mov       [rbp-0A8],r10
       mov       r11d,[rbp+20]
       mov       [rsp+20],r11d
       lea       rdx,[rbp-58]
       mov       rcx,r8
       mov       r8,rdi
       mov       r9,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFADB4BD8A8]; System.RuntimeType.CheckValue(System.Object ByRef, System.Reflection.Binder, System.Globalization.CultureInfo, System.Reflection.BindingFlags)
       mov       r10,[rbp-0A8]
       mov       rcx,[rbp-88]
       mov       [r10+rcx],al
       mov       [rbp+38],r15
       jmp       near ptr M02_L16
M02_L40:
       mov       [rbp+38],r15
       jmp       near ptr M02_L16
M02_L41:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L10
M02_L42:
       mov       rcx,rsi
       call      qword ptr [7FFADB4BE268]; System.RuntimeTypeHandle.GetElementType(System.RuntimeType)
       mov       rbx,rax
       mov       rcx,[rbp-58]
       call      qword ptr [7FFADB4BD878]; System.Object.GetType()
       cmp       rax,rbx
       jne       near ptr M02_L11
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFADB22A438]; Precode of System.RuntimeType.IsValueTypeImpl()
       test      eax,eax
       je        short M02_L43
       mov       rcx,rbx
       mov       rdx,[rbp-58]
       call      qword ptr [7FFADB6ED8C0]
       mov       [rbp-58],rax
M02_L43:
       lea       rcx,[rbp-4C]
       mov       rbx,[rbp-88]
       mov       byte ptr [rcx+rbx],1
       mov       rbx,[rbp-90]
       mov       rsi,[rbp+18]
       mov       rdi,[rbp+28]
       mov       r14,[rbp+30]
       jmp       near ptr M02_L16
M02_L44:
       mov       r8,2A528000038
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
       jge       short M02_L48
M02_L45:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       r14d,[r11]
       mov       r15,[r11+8]
       and       r14d,0FFFFFFFE
       cmp       r15,rax
       jne       short M02_L46
       mov       r15,rcx
       xor       r15,[r11+10]
       cmp       r15,1
       jbe       short M02_L47
M02_L46:
       test      r14d,r14d
       je        short M02_L48
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M02_L45
       jmp       short M02_L48
M02_L47:
       cmp       r14d,[r11]
       jne       short M02_L48
       jmp       short M02_L49
M02_L48:
       mov       r15d,2
M02_L49:
       cmp       r15d,1
       je        near ptr M02_L12
       test      r15d,r15d
       jne       short M02_L50
       xor       edx,edx
       jmp       near ptr M02_L12
M02_L50:
       call      qword ptr [7FFADB2EFA98]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M02_L12
M02_L51:
       xor       r8d,r8d
       jmp       near ptr M02_L13
M02_L52:
       mov       rcx,[rbp-58]
       mov       rdx,rsi
       call      qword ptr [7FFADB6EDBD8]
       mov       [rbp-58],rax
       jmp       near ptr M02_L58
M02_L53:
       mov       byte ptr [rbp-70],0
       lea       r8,[rbp-70]
       lea       rdx,[rbp-58]
       mov       rcx,rsi
       call      qword ptr [7FFADB6EDBF0]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M02_L55
       mov       r15,[rbp+28]
M02_L54:
       movzx     eax,byte ptr [rbp-70]
       jmp       near ptr M02_L15
M02_L55:
       cmp       r14d,1
       jne       short M02_L57
       test      dword ptr [rbp+20],10000
       jne       short M02_L56
       mov       r15,[rbp+28]
       test      r15,r15
       je        near ptr M02_L60
       call      qword ptr [7FFADB6EDC08]
       cmp       rax,r15
       je        short M02_L60
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
       call      qword ptr [7FFADB22A578]; System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       je        short M02_L59
       mov       rcx,rsi
       call      qword ptr [7FFADB4BD8C0]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       je        short M02_L58
       jmp       near ptr M02_L52
M02_L56:
       mov       r15,[rbp+28]
       jmp       short M02_L60
M02_L57:
       mov       r15,[rbp+28]
       jmp       short M02_L60
M02_L58:
       mov       eax,1
       jmp       near ptr M02_L15
M02_L59:
       lea       r8,[rbp-70]
       lea       rdx,[rbp-58]
       mov       rcx,rsi
       call      qword ptr [7FFADB6EDBF0]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M02_L54
M02_L60:
       cmp       r14d,1
       je        short M02_L61
       cmp       r14d,2
       jne       near ptr M02_L14
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFADB6EDC20]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFADB2EF228]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L61:
       mov       rcx,2E5B0F22218
       call      qword ptr [7FFADB6EDC38]
       mov       r13,rax
       mov       rcx,[rbp-58]
       test      rcx,rcx
       jne       short M02_L62
       xor       r14d,r14d
       jmp       short M02_L63
M02_L62:
       call      qword ptr [7FFADB4BD878]; System.Object.GetType()
       mov       r14,rax
M02_L63:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r13
       mov       rdx,r14
       mov       r8,rsi
       call      qword ptr [7FFADB6ED800]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFADB5B5CB0]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M02_L64:
       lea       r8,[rbp-48]
       mov       [rbp-80],r8
       mov       dword ptr [rbp-78],1
       lea       r8,[rbp-80]
       mov       rdx,rsi
       mov       rcx,rbx
       mov       r9d,[rbp+20]
       call      qword ptr [7FFADB4BD8D8]; System.Reflection.MethodBaseInvoker.InvokeDirectByRefWithFewArgs(System.Object, System.Span`1<System.Object>, System.Reflection.BindingFlags)
       mov       rdi,rax
       jmp       near ptr M02_L18
M02_L65:
       mov       r15,[rbx+20]
       cmp       esi,[r15+8]
       jae       near ptr M02_L72
       mov       ecx,esi
       test      byte ptr [r15+rcx*4+10],4
       je        short M02_L66
       lea       rcx,[rbp-48]
       mov       eax,esi
       mov       rcx,[rcx+rax*8]
       call      qword ptr [7FFADB6ED8D8]
       mov       r8,rax
       mov       edx,esi
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M02_L20
M02_L66:
       lea       r8,[rbp-48]
       mov       edx,esi
       mov       r8,[r8+rdx*8]
       mov       edx,esi
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M02_L20
M02_L67:
       mov       r15,[rbx+20]
       cmp       esi,[r15+8]
       jae       near ptr M02_L72
       mov       ecx,esi
       test      byte ptr [r15+rcx*4+10],4
       jne       short M02_L68
       cmp       esi,1
       jae       near ptr M02_L72
       lea       r8,[rbp-48]
       mov       edx,esi
       mov       r8,[r8+rdx*8]
       movsxd    rdx,esi
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M02_L24
M02_L68:
       cmp       esi,1
       jae       near ptr M02_L72
       lea       rcx,[rbp-48]
       mov       eax,esi
       mov       rcx,[rcx+rax*8]
       call      qword ptr [7FFADB6ED8D8]
       mov       r8,rax
       movsxd    rdx,esi
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M02_L24
       cmp       qword ptr [rbx+48],0
       jne       short M02_L69
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFADB4BD5A8]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M02_L69:
       mov       [rsp+20],r14
       mov       r15,[rbp+38]
       mov       [rsp+28],r15
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,[rbp+20]
       mov       r9,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFADB4BD758]; System.Reflection.MethodBaseInvoker.InvokeWithFewArgs(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       jmp       near ptr M02_L22
M02_L70:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFADB4BD5A8]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M02_L71:
       mov       [rsp+20],r14
       mov       r15,[rbp+38]
       mov       [rsp+28],r15
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,[rbp+20]
       mov       r9,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFADB6ED830]
       jmp       near ptr M02_L22
M02_L72:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       vzeroupper
       mov       rdx,rcx
       mov       rcx,offset MT_System.Exception
       call      qword ptr [7FFADB2E6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdx,rax
       test      rdx,rdx
       jne       short M02_L73
       xor       eax,eax
       jmp       short M02_L74
M02_L73:
       mov       [rbp-98],rdx
       test      dword ptr [rbp+20],2000000
       sete      al
       movzx     eax,al
M02_L74:
       add       rsp,38
       ret
       sub       rsp,38
       vzeroupper
       mov       rcx,offset MT_System.Reflection.TargetInvocationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp-98]
       call      qword ptr [7FFADB6ED848]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 2616
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
       jmp       qword ptr [7FFADB4B4D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Delegate()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFADB64FAE0]; PrivateAccessProof.Subjects.InvokeDelegate(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeDelegate(PrivateAccessProof.Types.Secret, Int32)
       sub       rsp,28
       mov       r8d,edx
       mov       rdx,23FA9401348
       mov       rax,[rdx]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,28
       ret
; Total bytes of code 36
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Accessor()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFADB64F9F0]; PrivateAccessProof.Subjects.InvokeAccessor(PrivateAccessProof.Types.Secret, Int32)
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
       call      qword ptr [7FFADB64DA10]; System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
       mov       rdi,rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,1B379001238
       mov       rcx,[rcx]
       mov       eax,ebx
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       ecx,ebx
       call      qword ptr [7FFADB64D9F8]; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|50_0(UInt32)
       mov       rdi,rax
M01_L01:
       jmp       near ptr M01_L09
M01_L02:
       call      qword ptr [7FFADB2ED2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,[rax+28]
       mov       edx,ebx
       neg       edx
       mov       ecx,edx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rax,7FFB2C03C180
       add       rdx,[rax+rcx*8]
       sar       rdx,20
       mov       ebp,1
       cmp       edx,1
       cmovg     ebp,edx
       add       ebp,[rdi+8]
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.String
       call      00007FFB3AF74CA0
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
       call      00007FFB3AF74CA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,ebx
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFADB2E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r13+r14*2]
       mov       word ptr [rcx],3A
       inc       ebx
       movsxd    rcx,ebx
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFADB2E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L12
M01_L10:
       mov       rcx,rsi
       mov       rdx,1F401D90C68
       call      qword ptr [7FFADB2ED9C8]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       jmp       short M01_L12
M01_L11:
       mov       rdx,rdi
       mov       rcx,1F401D90C68
       call      qword ptr [7FFADB2ED9C8]; System.String.Concat(System.String, System.String)
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
       mov       r9,1F401D91B94
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
       call      qword ptr [7FFADB6C5D88]
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
```
```assembly
; System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       ebx,ecx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       eax,ebx
       mov       rdx,7FFB2C03C180
       add       rax,[rdx+rcx*8]
       sar       rax,20
       movsxd    rsi,eax
       mov       rcx,rsi
       call      qword ptr [7FFADB2E6670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       test      rdi,rdi
       je        short M02_L00
       mov       rcx,7FFADB77EB80
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rdi+0C]
       mov       [rsp+20],rcx
       mov       rbp,[rsp+20]
       jmp       short M02_L01
M02_L00:
       xor       edi,edi
       xor       ebp,ebp
M02_L01:
       mov       rcx,7FFADB77EB84
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rax,[rbp+rsi*2]
       cmp       ebx,0A
       jb        short M02_L05
       cmp       ebx,64
       jb        short M02_L03
       mov       rcx,1F401D91B94
M02_L02:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       edx,ebx
       imul      rdx,51EB851F
       shr       rdx,25
       imul      r8d,edx,64
       sub       ebx,r8d
       mov       r8,rcx
       shl       ebx,2
       mov       r10d,ebx
       mov       r8d,[r8+r10]
       mov       [rax],r8d
       cmp       edx,64
       mov       ebx,edx
       jae       short M02_L02
M02_L03:
       cmp       ebx,0A
       jb        short M02_L05
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rcx,1F401D91B94
       lea       edx,[rbx*4]
       mov       ecx,[rcx+rdx]
       mov       [rax],ecx
M02_L04:
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L05:
       lea       ecx,[rbx+30]
       mov       [rax-2],cx
       jmp       short M02_L04
; Total bytes of code 250
```
```assembly
; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|50_0(UInt32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       ebx,ecx
       mov       edx,ebx
       or        edx,1
       lzcnt     edx,edx
       xor       edx,1F
       mov       ecx,ebx
       mov       rax,7FFB2C03C180
       add       rcx,[rax+rdx*8]
       sar       rcx,20
       movsxd    rsi,ecx
       mov       rdx,rsi
       mov       rcx,offset MT_System.String
       call      00007FFB3AF74CA0
       mov       rdi,rax
       test      rdi,rdi
       je        short M03_L00
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rcx,[rsp+28]
       jmp       short M03_L01
M03_L00:
       xor       edi,edi
       xor       ecx,ecx
M03_L01:
       lea       rcx,[rcx+rsi*2]
       mov       edx,ebx
       cmp       edx,0A
       jb        near ptr M03_L05
       cmp       ebx,64
       jb        short M03_L03
       mov       rax,1F401D91B94
M03_L02:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r8d,edx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       edx,r10d
       mov       r10,rax
       shl       edx,2
       mov       edx,[r10+rdx]
       mov       [rcx],edx
       cmp       r8d,64
       mov       edx,r8d
       jae       short M03_L02
M03_L03:
       cmp       edx,0A
       jb        short M03_L05
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rax,1F401D91B94
       shl       edx,2
       mov       edx,[rax+rdx]
       mov       [rcx],edx
M03_L04:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,1B379001238
       mov       rcx,[rcx]
       cmp       ebx,12C
       jae       short M03_L06
       mov       edx,ebx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L05:
       add       edx,30
       mov       [rcx-2],dx
       jmp       short M03_L04
M03_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 269
```
```assembly
; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFB2CCBF928]; Precode of System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFB2CCA8040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       lea       r11,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       call      qword ptr [r11]
       mov       rcx,rax
       call      qword ptr [7FFB2CCB7430]
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
       jmp       qword ptr [7FFADB2E66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      00007FFB3AF74CA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFADB2E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFADB2E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F401D90008
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
       call      qword ptr [7FFADB6C5D88]
       int       3
; Total bytes of code 244
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Direct()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFAB81FCFD8]; PrivateAccessProof.Subjects.InvokeDirect(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeDirect(PrivateAccessProof.Types.Secret, Int32)
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+8]
       mov       ecx,edx
       call      qword ptr [7FFAB7F3FC90]; System.Number.Int32ToDecStr(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,187E5680A40
       call      qword ptr [7FFAB7DF6B20]; System.String.Concat(System.String, System.String, System.String)
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
       mov       rcx,14750C00260
       mov       rcx,[rcx]
       mov       eax,ebx
       mov       rax,[rcx+rax*8+10]
       test      rax,rax
       jne       short M02_L00
       mov       ecx,ebx
       call      qword ptr [7FFAB7F64900]; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|70_0(UInt32)
M02_L00:
       jmp       near ptr M02_L08
M02_L01:
       mov       esi,ebx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rax,7FFB16D287F8
       add       rsi,[rax+rcx*8]
       sar       rsi,20
       mov       ecx,esi
       call      00007FFAB7DF1E60
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
       mov       rdx,14750C00290
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
       mov       rdx,14750C00290
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
       call      qword ptr [7FFAB7F1F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r8,[rax+28]
       mov       ecx,ebx
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFAB7F3FCA8]
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
       call      00007FFAB7DF1E60
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFAB7EA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFAB7EA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFAB7EA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFAB7DF6B08]; System.String.Concat(System.String, System.String)
M03_L01:
       call      qword ptr [7FFAB7F8EF40]
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
       jmp       qword ptr [7FFAB7DF6B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFAB7DF6B08]; System.String.Concat(System.String, System.String)
; Total bytes of code 320
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Reflection()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFAC051CD20]; PrivateAccessProof.Subjects.InvokeReflection(PrivateAccessProof.Types.Secret, Int32)
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
       mov       rcx,1E4B5804530
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
       call      qword ptr [7FFAC02F3238]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       call      qword ptr [7FFAC01143F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       jmp       qword ptr [7FFAC03078D0]; System.Reflection.MethodBaseInvoker.InvokeWithOneArg(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M02_L08:
       mov       rcx,[rbx+38]
       jmp       near ptr M02_L03
M02_L09:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFAC0307810]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L07
M02_L10:
       mov       rcx,rbx
       call      qword ptr [7FFAC0305890]; System.Reflection.RuntimeMethodInfo.<get_Signature>g__LazyCreateSignature|25_0()
       jmp       near ptr M02_L06
M02_L11:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFAC0307810]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L01
M02_L12:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAC05FD980]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFAC03C5AB8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L13:
       xor       eax,eax
       mov       r15d,eax
       jmp       near ptr M02_L05
M02_L14:
       call      qword ptr [7FFAC03078A0]
       int       3
M02_L15:
       cmp       r15d,4
       ja        near ptr M02_L18
       mov       ecx,r15d
       lea       rax,[7FFAC014D420]
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
       call      qword ptr [7FFAC0307810]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
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
       jmp       qword ptr [7FFAC03078B8]
       cmp       qword ptr [rbx+48],0
       jne       short M02_L17
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFAC0307810]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
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
       jmp       qword ptr [7FFAC03078E8]; System.Reflection.MethodBaseInvoker.InvokeWithFewArgs(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M02_L18:
       cmp       qword ptr [rbx+48],0
       jne       short M02_L19
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFAC0307810]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
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
       jmp       qword ptr [7FFAC0307918]
M02_L20:
       mov       rcx,rbx
       call      qword ptr [7FFAC0305860]
       jmp       near ptr M02_L02
M02_L21:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC05FD9B0]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFAC03C5AB8]
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

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Delegate()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFAC050CFA8]; PrivateAccessProof.Subjects.InvokeDelegate(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeDelegate(PrivateAccessProof.Types.Secret, Int32)
       sub       rsp,28
       mov       r8d,edx
       mov       rdx,21AE6404558
       mov       rax,[rdx]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,28
       ret
; Total bytes of code 36
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Accessor()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFAC053CFC0]; PrivateAccessProof.Subjects.InvokeAccessor(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeAccessor(PrivateAccessProof.Types.Secret, Int32)
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+8]
       mov       ecx,edx
       call      qword ptr [7FFAC027FC90]; System.Number.Int32ToDecStr(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,25ECC070A40
       call      qword ptr [7FFAC0136B20]; System.String.Concat(System.String, System.String, System.String)
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
       mov       rcx,21E37400260
       mov       rcx,[rcx]
       mov       eax,ebx
       mov       rax,[rcx+rax*8+10]
       test      rax,rax
       jne       short M02_L00
       mov       ecx,ebx
       call      qword ptr [7FFAC02A4900]; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|70_0(UInt32)
M02_L00:
       jmp       near ptr M02_L08
M02_L01:
       mov       esi,ebx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rax,7FFB179987F8
       add       rsi,[rax+rcx*8]
       sar       rsi,20
       mov       ecx,esi
       call      00007FFAC0131E60
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
       mov       rdx,21E37400290
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
       mov       rdx,21E37400290
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
       call      qword ptr [7FFAC025F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r8,[rax+28]
       mov       ecx,ebx
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFAC027FCA8]
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
       call      00007FFAC0131E60
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFAC01E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFAC01E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    r8,ebp
       lea       rcx,[rbx+r8*2]
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFAC01E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFAC0136B08]; System.String.Concat(System.String, System.String)
M03_L01:
       call      qword ptr [7FFAC02CEF40]
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
       jmp       qword ptr [7FFAC0136B08]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFAC0136B08]; System.String.Concat(System.String, System.String)
; Total bytes of code 320
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Direct()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFAD1D5EB80]; PrivateAccessProof.Subjects.InvokeDirect(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeDirect(PrivateAccessProof.Types.Secret, Int32)
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+8]
       mov       ecx,edx
       call      qword ptr [7FFAD1D5EBE0]; System.Number.Int32ToDecStr(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,2951E600C68
       call      qword ptr [7FFAD1BBE2C8]; System.String.Concat(System.String, System.String, System.String)
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
       mov       rax,7FFB177F89B8
       add       rsi,[rax+rcx*8]
       sar       rsi,20
       mov       ecx,esi
       call      00007FFAD19A24D8
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
       mov       r8,25489C002C8
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
       mov       rdx,25489C002C8
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
       mov       rcx,25489C002C0
       mov       rcx,[rcx]
       mov       eax,ebx
       mov       rax,[rcx+rax*8+10]
       test      rax,rax
       jne       short M02_L08
       mov       ecx,ebx
       call      qword ptr [7FFAD1D5CDB0]; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|47_0(UInt32)
M02_L08:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L09:
       call      qword ptr [7FFAD19AD020]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r8,[rax+28]
       mov       ecx,ebx
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFAD1E24E10]
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
       call      00007FFAD19A24D8
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAD19A57B8]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAD19A57B8]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[rbx+rcx*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFAD19A57B8]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFAD1E24E40]
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
       jmp       qword ptr [7FFAD19AD788]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFAD19AD788]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFAD19AD788]; System.String.Concat(System.String, System.String)
; Total bytes of code 316
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Reflection()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFAD1D6EB98]; PrivateAccessProof.Subjects.InvokeReflection(PrivateAccessProof.Types.Secret, Int32)
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
       mov       rcx,1E7D3001330
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
       call      qword ptr [7FFAD1C47D00]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       jne       near ptr M02_L13
M02_L02:
       test      byte ptr [rbx+5C],10
       jne       short M02_L03
       test      rsi,rsi
       je        near ptr M02_L15
       mov       rcx,rbx
       call      qword ptr [7FFAD1C47C48]; System.Reflection.RuntimeMethodInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+0A0]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M02_L14
M02_L03:
       test      r14,r14
       je        near ptr M02_L16
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
       je        near ptr M02_L12
M02_L06:
       mov       [rsp+20],r14
       mov       r13,[rsp+98]
       mov       [rsp+28],r13
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFAD1E56370]; System.Reflection.MethodBaseInvoker.InvokeWithOneArg(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       call      qword ptr [7FFAD1BCCC30]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rbx
       call      qword ptr [7FFAD1BCCC48]; System.Reflection.RuntimeMethodInfo.<get_Signature>g__LazyCreateSignature|25_0()
       jmp       near ptr M02_L05
M02_L10:
       cmp       r15d,4
       ja        near ptr M02_L17
       mov       ecx,r15d
       lea       rax,[7FFAD1A6EA38]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
       cmp       qword ptr [rbx+48],0
       je        near ptr M02_L19
M02_L11:
       mov       [rsp+20],r14
       mov       r13,[rsp+98]
       mov       [rsp+28],r13
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFAD1BCCDC8]; System.Reflection.MethodBaseInvoker.InvokeWithFewArgs(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       jmp       near ptr M02_L07
M02_L12:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFAD1BCCC30]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L06
M02_L13:
       mov       rcx,rbx
       call      qword ptr [7FFAD1E5CB58]
       jmp       near ptr M02_L02
M02_L14:
       call      qword ptr [7FFAD1E5CB70]
       mov       r14,rax
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,rbx
       call      qword ptr [7FFAD1C47C48]; System.Reflection.RuntimeMethodInfo.get_DeclaringType()
       mov       rbx,rax
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FFAD1E5CB88]
       mov       rdx,rax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FFAD1E5CBA0]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M02_L15:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAD1E5CBB8]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFAD1E5CBA0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L17:
       cmp       qword ptr [rbx+48],0
       jne       short M02_L18
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFAD1BCCC30]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M02_L18:
       mov       [rsp+20],r14
       mov       r13,[rsp+98]
       mov       [rsp+28],r13
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFAD1E5CB40]
       jmp       near ptr M02_L07
M02_L19:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFAD1BCCC30]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L11
       cmp       qword ptr [rbx+48],0
       jne       short M02_L20
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      qword ptr [7FFAD1BCCC30]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L20:
       mov       rcx,[rbx+48]
       mov       rdx,rsi
       mov       r8d,edi
       cmp       [rcx],ecx
       call      qword ptr [7FFAD1CD62E0]; System.Reflection.MethodBaseInvoker.InvokeWithNoArgs(System.Object, System.Reflection.BindingFlags)
       jmp       near ptr M02_L07
M02_L21:
       call      qword ptr [7FFAD1E5CBD0]
       int       3
; Total bytes of code 802
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
       jmp       qword ptr [7FFAD1BC4AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Delegate()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFAD1D3EAC0]; PrivateAccessProof.Subjects.InvokeDelegate(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeDelegate(PrivateAccessProof.Types.Secret, Int32)
       sub       rsp,28
       mov       r8d,edx
       mov       rdx,2366F401358
       mov       rax,[rdx]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,28
       ret
; Total bytes of code 36
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; PrivateAccessProof.Benchmarks.InvokeBench.Accessor()
       mov       rcx,[rcx+8]
       mov       edx,3
       jmp       qword ptr [7FFAD1D7EB98]; PrivateAccessProof.Subjects.InvokeAccessor(PrivateAccessProof.Types.Secret, Int32)
; Total bytes of code 15
```
```assembly
; PrivateAccessProof.Subjects.InvokeAccessor(PrivateAccessProof.Types.Secret, Int32)
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+8]
       mov       ecx,edx
       call      qword ptr [7FFAD1D7EBF8]; System.Number.Int32ToDecStr(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,1F7D37B0C68
       call      qword ptr [7FFAD1BDE2C8]; System.String.Concat(System.String, System.String, System.String)
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
       mov       rax,7FFB177F89B8
       add       rsi,[rax+rcx*8]
       sar       rsi,20
       mov       ecx,esi
       call      00007FFAD19C24D8
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
       mov       r8,1B73EC002C8
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
       mov       rdx,1B73EC002C8
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
       mov       rcx,1B73EC002C0
       mov       rcx,[rcx]
       mov       eax,ebx
       mov       rax,[rcx+rax*8+10]
       test      rax,rax
       jne       short M02_L08
       mov       ecx,ebx
       call      qword ptr [7FFAD1D7CDB0]; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|47_0(UInt32)
M02_L08:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L09:
       call      qword ptr [7FFAD19CD020]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r8,[rax+28]
       mov       ecx,ebx
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFAD1E44E28]
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
       call      00007FFAD19C24D8
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFAD19C57B8]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAD19C57B8]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[rbx+rcx*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFAD19C57B8]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFAD1E44E58]
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
       jmp       qword ptr [7FFAD19CD788]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFAD19CD788]; System.String.Concat(System.String, System.String)
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
       jmp       qword ptr [7FFAD19CD788]; System.String.Concat(System.String, System.String)
; Total bytes of code 316
```

