using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace forms_master_detail_page
{
    public partial class App : Application
    {
        public static INavigation CurrentNavigation { get { return (Current?.MainPage as MasterDetailPage)?.Detail?.Navigation; } }

        public App()
        {
            InitializeComponent();

            MainPage = new forms_master_detail_page.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
