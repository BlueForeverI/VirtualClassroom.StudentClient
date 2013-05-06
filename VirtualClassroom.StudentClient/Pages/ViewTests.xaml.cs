using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VirtualClassroom.StudentClient.StudentServiceReference;

namespace VirtualClassroom.StudentClient
{
    /// <summary>
    /// Interaction logic for ViewTests.xaml
    /// </summary>
    public partial class ViewTests : Page
    {
        private StudentServiceClient client = ClientManager.GetClient();

        private void UpdateTestViews()
        {
            Thread thread = new Thread(() => Dispatcher.BeginInvoke(
                new Action(() =>
                {
                    var tests = client.GetTestViewsByStudent(MainWindow.Student.Id);
                    this.dataGridTests.ItemsSource = tests;
                })));
            thread.Start();
        }

        public ViewTests()
        {
            try
            {
                InitializeComponent();
                UpdateTestViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Application.Current.Resources["defaultErrorMessage"].ToString(), 
                    "Грешка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSolveTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(this.dataGridTests.SelectedIndex < 0)
                {
                    MessageBox.Show("Не сте избрали тест");
                }
                else if(this.dataGridTests.SelectedItems.Count > 1)
                {
                    MessageBox.Show("Трябва да изберете точно един тест");
                }
                else
                {
                    int testId = int.Parse((this.dataGridTests.SelectedItem as dynamic)
                        .Id.ToString());
                    Test test = client.GetTest(testId);
                    ViewTestWindow viewTestWindow = new ViewTestWindow(test);

                    if(viewTestWindow.ShowDialog() == true)
                    {
                        int result = client.EvaluateTest(viewTestWindow.Test, MainWindow.Student.Id);
                        UpdateTestViews();
                        MessageBox.Show(string.Format("Вие изкарахте {0} точки", result));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Application.Current.Resources["defaultErrorMessage"].ToString(), 
                    "Грешка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
