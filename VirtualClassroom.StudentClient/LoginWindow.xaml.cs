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
using VirtualClassroom.Services.Services;
using VirtualClassroom.StudentClient.StudentServiceReference;

namespace VirtualClassroom.StudentClient
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private StudentServiceClient client;

        public LoginWindow()
        {
            ClientManager.CloseClient();
            client = ClientManager.GetClient();
            InitializeComponent();
        }

        public Student Student { get; private set; }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            Student student = new Student();

            string username = txtUsername.Text;
            string password = txtPassword.Password;

            worker.DoWork += (o, ea) =>
            {
                string secret = Crypto.GenerateRandomSecret(30);
                student = client.LoginStudent(Crypto.EncryptStringAES(username, secret),
                    Crypto.EncryptStringAES(password, secret), secret);
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
