namespace FsWpfApp.ViewModel

open System
open Prism.Mvvm
open Prism.Commands
open FsWpfApp.Model

[<Class>]
type MainWindowViewModel() =
    inherit BindableBase()

    let mutable answer = 0
    let mutable lhs = 0
    let mutable rhs = 0

    member this.Answer 
        with get () = answer
        and set (value) = answer <- value
                          base.RaisePropertyChanged("Answer")

    member this.Lhs 
        with get () = lhs
        and set (value) = lhs <- value
                          base.RaisePropertyChanged("Lhs")

    member this.Rhs 
        with get () = rhs
        and set (value) = rhs <- value
                          base.RaisePropertyChanged("Rhs")
    

    member this.CalcCommand with get() = DelegateCommand(fun () -> this.Answer  <- Calc.Add this.Lhs this.Rhs)



