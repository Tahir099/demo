﻿using demo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //  MainPage = new MainPage();
            MainPage = new NavigationPage(new MainView());
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
