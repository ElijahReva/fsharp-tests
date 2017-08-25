namespace FSharpTest

module Boot = 

    open DryIoc
    open FSharpTest.UI.ViewModel
    open Serilog
    
    let createLog = (new LoggerConfiguration()).MinimumLevel.Debug().WriteTo.ColoredConsole().CreateLogger()

    let root() = 

        let container = new Container()

        Log.Logger <- createLog

        container.Register<ShellViewModel>()
        container.Register<ITab, ArraysViewModel>()
        container.Register<ITab, TreesViewModel>()
        container.RegisterInstance<ILogger>(Log.Logger)

        let validation = container.Validate()

        container.Resolve<ShellViewModel>()

    
                    
        


