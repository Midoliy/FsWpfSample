namespace FsWpfApp.ViewModels

open System
open FsWpfApp.Models
open MidSys

[<Class>]
type MainWindowViewModel() =
    // xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    // xxxxxx member properties for window binding
    // xxx
    member val Answer = NotifiableProperty<int>() with get, set
    member val Lhs = NotifiableProperty<int>() with get, set
    member val Rhs = NotifiableProperty<int>() with get, set

    // xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    // xxxxxx member command for window binding
    // xxx
    member this.CalcCommand 
        with get() = 
            DelegateCommand(fun () -> this.Answer.Value  <- Calc.Add this.Lhs.Value this.Rhs.Value)
