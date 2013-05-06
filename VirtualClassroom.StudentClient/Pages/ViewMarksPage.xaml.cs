using System;
using System.Threading;
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
                Thread thread = new Thread(() => Dispatcher.BeginInvoke(
                new Action(() =>
                {
                    var marks = client.GetMarksByStudent(MainWindow.Student.Id);
                    this.dataGridMarks.ItemsSource = marks;
                })));
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Application.Current.Resources["defaultErrorMessage"].ToString(), 
                    "Грешка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
