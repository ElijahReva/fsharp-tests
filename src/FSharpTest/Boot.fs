namespace FSharpTest

module Boot = 

    open DryIoc
    open FSharpTest.UI.ViewModel

    let root() = 

        let container = new Container()

        container.Register<ShellViewModel>()
        container.Register<ITab, ArraysViewModel>()
        container.Register<ITab, TreesViewModel>()

        let validation = container.Validate()

        container.Resolve<ShellViewModel>()
        


