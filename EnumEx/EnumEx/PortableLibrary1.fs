namespace EnumEx

open System
open System.Linq
open System.Runtime.CompilerServices


[<Extension>]
type EnumEx() = 
    [<Extension>]
    static member IsFlaged<'T when 'T : struct and 'T : (new : unit -> 'T) and 'T :> Enum> (enum : 'T) (test : 'T) : bool =
        enum.HasFlag test
    [<Extension>]
    static member IsAnyFlaged<'T when 'T : struct and 'T : (new : unit -> 'T) and 'T :> Enum> (enum : 'T, [<ParamArray>] test : 'T array) : bool =
        test.Any(fun (x : 'T) -> enum.HasFlag x)
    [<Extension>]
    static member IsAllFlaged<'T when 'T : struct and 'T : (new : unit -> 'T) and 'T :> Enum> (enum : 'T, [<ParamArray>] test : 'T array) : bool =
        test.All(fun (x : 'T) -> enum.HasFlag x)
    
