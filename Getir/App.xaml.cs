using Getir.Services;
using Getir.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DLToolkit.Forms.Controls;
using System.IO;

namespace Getir
{
    public partial class App : Application
    {
        
        public App()
        {
            MainPage = new Header(new Page1())
            {
                BarBackgroundColor = Color.FromHex("#5d3ebc"),
                BarTextColor = Color.White,
            };
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            FlowListView.Init();
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