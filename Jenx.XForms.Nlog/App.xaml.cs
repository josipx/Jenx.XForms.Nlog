using Xamarin.Forms;

namespace Jenx.XForms.Nlog
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NLogPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
