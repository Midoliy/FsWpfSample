// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System
open FsWpfApp

[<STAThread>]
do
    let app = App()
    app.Run() |> ignore