using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VirtualClassroom.StudentClient.StudentServiceReference;

namespace VirtualClassroom.StudentClient
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private StudentServiceClient client = ClientManager.GetClient();

        public LoginWindow()
        {
            InitializeComponent();
        }

        public Student Student { get; private set; }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            Student student = new Student();

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            worker.DoWork += (o, ea) =>
            {
                student = client.LoginStudent(username, password);
            };

            worker.RunWorkerCompleted += (o, ea) =>
            {
                this.busyIndicator.IsBusy = false;
                if (student == null)
                {
                    MessageBox.Show("Wrong username or password!", "Invalid login",
                                    MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    this.Student = student;
                    this.DialogResult = true;
                    this.Close();
                }
            };

            busyIndicator.IsBusy = true;
            worker.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
