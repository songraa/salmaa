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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        facultyEntities fe = new facultyEntities();
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpBS_Click(object sender, RoutedEventArgs e)
        {

            var recordData = fe.students.FirstOrDefault(x => x.StudentName == SignUpName.Text && x.Email == SignUpEmail.Text && x.Password == SignUpPass.Text);
            if(SignUpCoPass.Text!= SignUpPass.Text)
            {
                MessageBox.Show("Confirm Pass must match the pass");
                return;
            }
            if (recordData != null)
            {
                MessageBox.Show("you already signed up, try to log in");
            }
            else
            {
                student student = new student
                {
                    StudentName = SignUpName.Text,
                    Email = SignUpEmail.Text,
                    Password = SignUpPass.Text,
                };
                fe.students.Add(student);
                fe.SaveChanges();
                MessageBox.Show("Sign up successed!");
            }

            LogIn logIn = new LogIn();
            this.NavigationService.Navigate(logIn);
        }
    }
}
