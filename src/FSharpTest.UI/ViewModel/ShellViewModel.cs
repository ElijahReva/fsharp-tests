namespace FSharpTest.UI.ViewModel
{
    using System.Collections.Generic;
    using System.Linq;
    using ReactiveUI;
    public class ShellViewModel: ReactiveObject
    {
        public ShellViewModel(IEnumerable<ITab> tabs)
        {
            this.Tabs = tabs;
            this.CurrentScreen = tabs.First();
        }

        public IEnumerable<ITab> Tabs { get; set; }

        private ITab currentScreen;
        public ITab CurrentScreen
        {
            get { return this.currentScreen; }
            set { this.RaiseAndSetIfChanged(ref this.currentScreen, value); }
        }
    }

    public interface ITab
    {
        string Title { get; }
    }
}
