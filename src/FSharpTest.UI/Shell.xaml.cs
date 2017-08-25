namespace FSharpTest.UI
{
    using FSharpTest.UI.ViewModel;

    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell
    {
        public Shell(ShellViewModel dataContext)
        {
            this.DataContext = dataContext;
            this.InitializeComponent();
        }
    }
}
