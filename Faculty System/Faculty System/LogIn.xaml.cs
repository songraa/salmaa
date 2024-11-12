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
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        facultyEntities fe = new facultyEntities();
        private const string AdminEmail = "songra787@gmail.com";
        private const string AdminPassword = "songra787";

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogInBL_Click(object sender, RoutedEventArgs e)
        {
            var recordData = fe.students.FirstOrDefault(x => x.Password == LogInPass.Text && x.Email == LogInEmail.Text);

            string enteredEmail = LogInEmail.Text;
            string enteredPassword = LogInPass.Text;
            if (enteredEmail == AdminEmail && enteredPassword == AdminPassword)
            {
                Admin adminPage = new Admin();
                this.NavigationService.Navigate(adminPage);
            }
            else if (recordData != null)
            {
                Application application = new Application();
                this.NavigationService.Navigate(application);
            }
            else
            {
                MessageBox.Show("Not found! You should sign up first");
                return;
            }
        }

        private void SignUpBL_Click(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            NavigationService.Navigate(signUp);
        }
    }
}
