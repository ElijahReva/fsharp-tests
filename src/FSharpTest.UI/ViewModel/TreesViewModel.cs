using ReactiveUI;

namespace FSharpTest.UI.ViewModel
{
    public class TreesViewModel : ReactiveObject, ITab
    {
        /// <inheritdoc />
        public string Title { get; } = "Trees";
    }
}
