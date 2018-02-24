using Nom011;
using Nom011.ModelDatabase;
using Nom011App.Database;
using Nom011App.GenericViews;
using Nom011App.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Nom011App
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            // Get an absolute path to the database file
            
            var con = BaseDatabase.GetDatabaseConnection();
            MainPage = new Catalog() {};



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
