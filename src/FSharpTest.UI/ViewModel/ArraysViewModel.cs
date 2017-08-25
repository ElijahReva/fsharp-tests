namespace FSharpTest.UI.ViewModel
{
    using ReactiveUI;

    public class ArraysViewModel : ReactiveObject, ITab
    {
        public string Title { get; } = "Arrays";
    }
}
