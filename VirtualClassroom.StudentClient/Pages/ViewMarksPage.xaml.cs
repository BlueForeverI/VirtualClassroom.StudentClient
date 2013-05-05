using System;
using System.Windows;
using System.Windows.Controls;
using VirtualClassroom.StudentClient.StudentServiceReference;

namespace VirtualClassroom.StudentClient
{
    /// <summary>
    /// Interaction logic for ViewMarksPage.xaml
    /// </summary>
    public partial class ViewMarksPage : Page
    {
        private StudentServiceClient client = ClientManager.GetClient();

        public ViewMarksPage()
        {
            try
            {
                InitializeComponent();
                this.dataGridMarks.ItemsSource = client.GetMarksByStudent(MainWindow.Student.Id); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Application.Current.Resources["defaultErrorMessage"].ToString(), 
                    "Грешка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
