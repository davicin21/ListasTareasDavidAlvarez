using ListaTareasDavidAlvarez.MVVM.Vista;

namespace ListaTareasDavidAlvarez
{
    public partial class App : Application
    {
        public App(Principal principal)
        {
            InitializeComponent();

            MainPage = new NavigationPage(principal);
        }
    }
}
