module Start

open System
open FSharpTest
open FSharpTest.UI

[<EntryPoint>]
[<STAThread>]
let main argv = 
    
    let app = new App()
    let shell = Boot.root()
    
    app.Run(new Shell(shell)) |> ignore
    
    0
