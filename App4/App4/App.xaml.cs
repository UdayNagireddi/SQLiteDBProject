using App4.Data;
using App4.View;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App4
{
    public partial class App : Application
    {
        static DataBaseInitAndTransactions database;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SavedItems());
        }
        public static DataBaseInitAndTransactions Database
        {
            get
            {
                if (database == null)
                {
                    database = new DataBaseInitAndTransactions(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database;
            }
        }
        public int ResumeAtTodoId { get; set; }

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
