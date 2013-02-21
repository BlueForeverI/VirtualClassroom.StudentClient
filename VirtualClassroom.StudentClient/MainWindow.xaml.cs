using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VirtualClassroom.StudentClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            LoginWindow loginWindow = new LoginWindow();
            if(loginWindow.ShowDialog() == true)
            {
                MessageBox.Show("Login successfull. Welcome!");
                StudentId = loginWindow.Student.Id;
                InitializeComponent();
            }
            else
            {
                this.Close();
            }
        }

        public static int StudentId { get; private set; }

        private void btnViewLessons_Click(object sender, RoutedEventArgs e)
        {
            this.frameMainContent.Source = new Uri("ViewLessonsPage.xaml", UriKind.Relative);
        }

        private void btnViewMarks_Click(object sender, RoutedEventArgs e)
        {
            this.frameMainContent.Source = new Uri("ViewMarksPage.xaml", UriKind.Relative);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ClientManager.CloseClient();
        }
    }
}
