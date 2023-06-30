using LABORATORIO14C.Models;
using LABORATORIO14C.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LABORATORIO14C.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseList : ContentPage
    {
        public CourseList()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            CourseService service = new CourseService();
            List<Course> course = new List<Course>();

            for (int i = 0; i < 3; i++)
                course.Add(new Course { Name = txtName.Text, Description = txtDescription.Text });

            //service.Create(new Person { LastName = txtLastName.Text, FirstName = txtName.Text });

            service.CreateRange(course);


        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            CourseService service = new CourseService();
            lvCourses.ItemsSource = service.Get();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            CourseService service = new CourseService();
            lvCourses.ItemsSource = service.GetByText(txtFilter.Text.Trim());
        }
    }
}
