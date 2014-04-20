﻿namespace FsBulletML.MonoGame

open System
open System.Runtime.CompilerServices

[<Extension; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module Action =
  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc0 (f: Action) = f.Invoke

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc1 (f: Action<'T1>) = fun t1 -> f.Invoke(t1)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc2 (f: Action<'T1, 'T2>) = fun t1 t2 -> f.Invoke(t1, t2)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc3 (f: Action<'T1, 'T2, 'T3>) = fun t1 t2 t3 -> f.Invoke(t1, t2, t3)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc4 (f: Action<'T1, 'T2, 'T3, 'T4>) = fun t1 t2 t3 t4 -> f.Invoke(t1, t2, t3, t4)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc5 (f: Action<'T1, 'T2, 'T3, 'T4, 'T5>) = fun t1 t2 t3 t4 t5 -> f.Invoke(t1, t2, t3, t4, t5)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc6 (f: Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6>) = fun t1 t2 t3 t4 t5 t6 -> f.Invoke(t1, t2, t3, t4, t5, t6)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc7 (f: Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7>) = fun t1 t2 t3 t4 t5 t6 t7 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc8 (f: Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8>) = fun t1 t2 t3 t4 t5 t6 t7 t8 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc9 (f: Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9>) = fun t1 t2 t3 t4 t5 t6 t7 t8 t9 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc10 (f: Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10>) = fun t1 t2 t3 t4 t5 t6 t7 t8 t9 t10 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc11 (f: Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11>) = fun t1 t2 t3 t4 t5 t6 t7 t8 t9 t10 t11 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc12 (f: Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12>) = fun t1 t2 t3 t4 t5 t6 t7 t8 t9 t10 t11 t12 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc13 (f: Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13>) = fun t1 t2 t3 t4 t5 t6 t7 t8 t9 t10 t11 t12 t13 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc14 (f: Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14>) = fun t1 t2 t3 t4 t5 t6 t7 t8 t9 t10 t11 t12 t13 t14 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc15 (f: Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15>) = fun t1 t2 t3 t4 t5 t6 t7 t8 t9 t10 t11 t12 t13 t14 t15 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc16 (f: Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16>) = fun t1 t2 t3 t4 t5 t6 t7 t8 t9 t10 t11 t12 t13 t14 t15 t16 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16)


[<Extension; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module Func =
  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc0 (f: Func<'TResult>) = fun () -> f.Invoke()

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc1 (f: Func<'T1, 'TResult>) = fun t1 -> f.Invoke(t1)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc2 (f: Func<'T1, 'T2, 'TResult>) = fun t1 t2 -> f.Invoke(t1, t2)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc3 (f: Func<'T1, 'T2, 'T3, 'TResult>) = fun t1 t2 t3 -> f.Invoke(t1, t2, t3)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc4 (f: Func<'T1, 'T2, 'T3, 'T4, 'TResult>) = fun t1 t2 t3 t4 -> f.Invoke(t1, t2, t3, t4)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc5 (f: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'TResult>) = fun t1 t2 t3 t4 t5 -> f.Invoke(t1, t2, t3, t4, t5)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc6 (f: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TResult>) = fun t1 t2 t3 t4 t5 t6 -> f.Invoke(t1, t2, t3, t4, t5, t6)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc7 (f: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TResult>) = fun t1 t2 t3 t4 t5 t6 t7 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc8 (f: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TResult>) = fun t1 t2 t3 t4 t5 t6 t7 t8 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc9 (f: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TResult>) = fun t1 t2 t3 t4 t5 t6 t7 t8 t9 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc10 (f: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TResult>) = fun t1 t2 t3 t4 t5 t6 t7 t8 t9 t10 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc11 (f: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TResult>) = fun t1 t2 t3 t4 t5 t6 t7 t8 t9 t10 t11 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc12 (f: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TResult>) = fun t1 t2 t3 t4 t5 t6 t7 t8 t9 t10 t11 t12 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc13 (f: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TResult>) = fun t1 t2 t3 t4 t5 t6 t7 t8 t9 t10 t11 t12 t13 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc14 (f: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TResult>) = fun t1 t2 t3 t4 t5 t6 t7 t8 t9 t10 t11 t12 t13 t14 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc15 (f: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TResult>) = fun t1 t2 t3 t4 t5 t6 t7 t8 t9 t10 t11 t12 t13 t14 t15 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15)

  [<Extension; CompiledName "ToFSharpFunc">]
  let toFSharpFunc16 (f: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TResult>) = fun t1 t2 t3 t4 t5 t6 t7 t8 t9 t10 t11 t12 t13 t14 t15 t16 -> f.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16)

[<Extension; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module FSharpFunc =
  [<Extension; CompiledName "ToAction">]
  let toAction (f: unit -> unit) = Action(f)

  [<Extension; CompiledName "ToAction">]
  let toAction1 (f: 'T1 -> unit) = Action<'T1>(f)

  [<Extension; CompiledName "ToAction">]
  let ToAction2 (f: 'T1 -> 'T2 -> unit) = Action<'T1, 'T2>(f)

  [<Extension; CompiledName "ToAction">]
  let ToAction3 (f: 'T1 -> 'T2 -> 'T3 -> unit) = Action<'T1, 'T2, 'T3>(f)

  [<Extension; CompiledName "ToAction">]
  let ToAction4 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> unit) = Action<'T1, 'T2, 'T3, 'T4>(f)

  [<Extension; CompiledName "ToAction">]
  let ToAction5 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> unit) = Action<'T1, 'T2, 'T3, 'T4, 'T5>(f)

  [<Extension; CompiledName "ToAction">]
  let ToAction6 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> unit) = Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6>(f)

  [<Extension; CompiledName "ToAction">]
  let ToAction7 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> unit) = Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7>(f)

  [<Extension; CompiledName "ToAction">]
  let ToAction8 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> unit) = Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8>(f)

  [<Extension; CompiledName "ToAction">]
  let ToAction9 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> unit) = Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9>(f)

  [<Extension; CompiledName "ToAction">]
  let ToAction10 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> unit) = Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10>(f)

  [<Extension; CompiledName "ToAction">]
  let ToAction11 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> unit) = Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11>(f)

  [<Extension; CompiledName "ToAction">]
  let ToAction12 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> unit) = Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12>(f)

  [<Extension; CompiledName "ToAction">]
  let ToAction13 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> unit) = Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13>(f)

  [<Extension; CompiledName "ToAction">]
  let ToAction14 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> unit) = Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14>(f)

  [<Extension; CompiledName "ToAction">]
  let ToAction15 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'T15 -> unit) = Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15>(f)

  [<Extension; CompiledName "ToAction">]
  let ToAction16 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'T15 -> 'T16 -> unit) = Action<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc0 (f: unit -> 'TResult) = Func<'TResult>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc1 (f: 'T1 -> 'TResult) = Func<'T1, 'TResult>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc2 (f: 'T1 -> 'T2 -> 'TResult) = Func<'T1, 'T2, 'TResult>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc3 (f: 'T1 -> 'T2 -> 'T3 -> 'TResult) = Func<'T1, 'T2, 'T3, 'TResult>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc4 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'TResult) = Func<'T1, 'T2, 'T3, 'T4, 'TResult>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc5 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'TResult) = Func<'T1, 'T2, 'T3, 'T4, 'T5, 'TResult>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc6 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'TResult) = Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TResult>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc7 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'TResult) = Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TResult>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc8 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'TResult) = Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TResult>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc9 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'TResult) = Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TResult>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc10 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'TResult) = Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TResult>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc11 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'TResult) = Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TResult>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc12 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'TResult) = Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TResult>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc13 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'TResult) = Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TResult>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc14 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'TResult) = Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TResult>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc15 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'T15 -> 'TResult) = Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TResult>(f)

  [<Extension; CompiledName "ToFunc">]
  let toFunc16 (f: 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'T15 -> 'T16 -> 'TResult) = Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TResult>(f)
