using NLog;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Jenx.XForms.Nlog
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NLogPage : ContentPage
    {
        public NLogPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var logger = LogManager.GetCurrentClassLogger();
            logger.Info("Jenx.si was here");
        }
    }
}