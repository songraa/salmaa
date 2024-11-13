using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Faculty_System
{
    /// <summary>
    /// Interaction logic for Application.xaml
    /// </summary>
    public partial class Application : Page
    {
        FacultyEntities1 fe = new FacultyEntities1();
        public Application()
        {
            InitializeComponent();
            DataGrid.
        }

        private void SaveBA_Click(object sender, RoutedEventArgs e)
        {

            student student = new student
            {
                StudentName = AppName.Text,
                Address = AppAddress.Text,
                age = int.Parse(AppAge.Text),
            };
            department department = new department
            {
                DepartmentName=AppDep.Text,
            };
            student student1 = new student();
            department department1 = new department();
            student1.DepId = department1.DepartmentId;

            fe.departments.Add(department);
            fe.students.Add(student);
            fe.SaveChanges();
            MessageBox.Show("save data successed!");
        }
    }
}
