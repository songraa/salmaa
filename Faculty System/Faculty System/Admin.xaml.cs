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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        FacultyEntities1 fe = new FacultyEntities1();
        public Admin()
        {
            InitializeComponent();
            datagrid.ItemsSource = (from s in fe.students
                                    join d in fe.departments
                                    on s.DepId equals d.DepartmentId
                                    select new
                                    {
                                        s.StudentId,
                                        s.StudentName,
                                        s.Address,
                                        d.DepartmentName
                                    }).ToList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            int id=int .Parse(AdSID.Text);
            student ss = fe.students.Remove(fe.students.First(x => x.StudentId == id));
            MessageBox.Show("Record deleted");
            fe.SaveChanges();
            datagrid.ItemsSource = (from s in fe.students
                                    join d in fe.departments
                                    on s.DepId equals d.DepartmentId
                                    select new
                                    {
                                        s.StudentId,
                                        s.StudentName,
                                        s.Address,
                                        d.DepartmentName
                                    }).ToList();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(AdSID.Text);
            var Edit = fe.students.FirstOrDefault(x => x.StudentId == id);
            if (Edit != null)
            {
                var department = fe.departments.FirstOrDefault(d => d.DepartmentId == Edit.DepId);
                if (department != null)
                { 
                department.DepartmentName= ADDP.Text;
                }
            }
            MessageBox.Show("Record Edited");
            fe.SaveChanges();
            datagrid.ItemsSource = (from s in fe.students
                                    join d in fe.departments
                                    on s.DepId equals d.DepartmentId
                                    select new
                                    {
                                        s.StudentId,
                                        s.StudentName,
                                        s.Address,
                                        d.DepartmentName
                                    }).ToList();
        }
    }
}
