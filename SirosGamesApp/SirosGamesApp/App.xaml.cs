using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace SirosGamesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            AppCenter.Start("26f10be2-8008-4fdf-a795-02d75b3e22f1",
                   typeof(Analytics), typeof(Crashes));

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
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
