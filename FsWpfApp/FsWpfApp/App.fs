namespace FsWpfApp

open System.Windows
open FsWpfApp.View

[<Class>]
type App() as this = 
    inherit Application() do
        this.Startup.Add <| fun e -> let w = MainWindow()
                                     w.Show()


