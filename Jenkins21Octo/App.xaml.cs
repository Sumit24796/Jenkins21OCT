﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Jenkins21Octo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //testing
            MainPage = new MainPage();
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
