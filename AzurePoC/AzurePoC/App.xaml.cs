using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AzurePoC.Services;
using AzurePoC.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;

namespace AzurePoC
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            AppCenter.Start("ios=4564d633-791f-4c8e-96f4-e08a7b143980;" +
                              "android=c10516e0-4465-4730-8338-9cfc8f04a531",
                              typeof(Analytics), typeof(Crashes));

            AppCenter.Start("c10516e0-4465-4730-8338-9cfc8f04a531", typeof(Push));

            MainPage = new MainPage();
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
