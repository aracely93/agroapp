using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;


namespace Agroseller
{
	public partial class App : Application
	{
        
		public App ()
		{
            //InitializeComponent();
            //MainPage = new NavigationPage( new PageHome());

            //MainPage = new NavigationPage(new MainPage());
            
            MainPage = new NavigationPage(new MenuPage());
            
            /*
            MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new MainPage()),
                    new NavigationPage(new MenuPage())                     
                }
            };
            */

            //MainPage = new Agroseller.MainPage();            
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
