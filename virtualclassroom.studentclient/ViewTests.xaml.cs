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
using VirtualClassroom.StudentClient.StudentServiceReference;

namespace VirtualClassroom.StudentClient
{
    /// <summary>
    /// Interaction logic for ViewTests.xaml
    /// </summary>
    public partial class ViewTests : Page
    {
        private StudentServiceClient client = ClientManager.GetClient();

        public ViewTests()
        {
            try
            {
                InitializeComponent();
                this.dataGridTests.ItemsSource = client.GetTestViewsByStudent(MainWindow.Student.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    int testId = int.Parse((this.dataGridTests.SelectedItem as dynamic).Id.ToString());
                    Test test = client.GetTest(testId);
                    ViewTestWindow viewTestWindow = new ViewTestWindow(test);

                    if(viewTestWindow.ShowDialog() == true)
                    {
                        int result = client.EvaluateTest(viewTestWindow.Test, MainWindow.Student.Id);

                        MessageBox.Show(string.Format("Вие изкарахте {0} точки", result));
                        this.dataGridTests.ItemsSource = client.GetTestViewsByStudent(MainWindow.Student.Id);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
