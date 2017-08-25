namespace FSharpTest.UI.ViewModel
{
    using System.Collections.Generic;
    using System.Linq;
    using ReactiveUI;
    using Serilog;
    using System.Reactive;

    public class ShellViewModel : ReactiveObject
    {
        ILogger logger;
        public ShellViewModel(IEnumerable<ITab> tabs, ILogger logger)
        {
            this.Tabs = tabs;
            this.logger = logger;
            this.CurrentScreen = tabs.First();
            var log = this.WhenAnyValue(x => x.CurrentScreen);
            log.Subscribe(Observer.Create<ITab>(x => this.logger.Debug("{@Data}", x), _ => { }, () => { }));
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
