using LABORATORIO14C.DataContext;
using LABORATORIO14C.Interfaces;
using LABORATORIO14C.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LABORATORIO14C
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            GetContext().Database.EnsureCreated();
            MainPage = new CourseList();

        }

        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
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
