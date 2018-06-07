﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PetsApp
{
	public partial class App : Application
	{
        public static string urlBd;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public App(string url)
        {
            InitializeComponent();

            urlBd = url;

            //MainPage = new App1.MainPage();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
