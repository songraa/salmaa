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
        facultyEntities fe = new facultyEntities();
        public Application()
        {
            InitializeComponent();
        }

        private void SaveBA_Click(object sender, RoutedEventArgs e)
        {

            student student = new student
            {
                Address = AppAddress.Text,
                Age = int.Parse(AppAge.Text),
                //departmant = AppDep.Text
            };
            fe.students.Add(student);
            fe.SaveChanges();
            MessageBox.Show("save data successed!");
        }
    }
}
