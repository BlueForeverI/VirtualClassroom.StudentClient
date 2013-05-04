using System;
using System.Windows;
using VirtualClassroom.StudentClient.StudentServiceReference;

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
                Student = loginWindow.Student;
                InitializeComponent();
            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// Holds information about the logged in student
        /// </summary>
        public static Student Student { get; private set; }

        private void btnViewLessons_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.frameMainContent.Source = new Uri("Pages/ViewLessonsPage.xaml", UriKind.Relative);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewMarks_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.frameMainContent.Source = new Uri("Pages/ViewMarksPage.xaml", UriKind.Relative);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ClientManager.CloseClient();
        }

        private void btnTests_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.frameMainContent.Source = new Uri("Pages/ViewTests.xaml", UriKind.Relative);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
