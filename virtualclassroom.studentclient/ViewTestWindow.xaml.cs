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
using System.Windows.Shapes;
using VirtualClassroom.StudentClient.StudentServiceReference;

namespace VirtualClassroom.StudentClient
{
    /// <summary>
    /// Interaction logic for ViewTest.xaml
    /// </summary>
    public partial class ViewTestWindow : Window
    {
        public Test Test { get; set; }

        public ViewTestWindow(Test test = null)
        {
            try
            {
                InitializeComponent();
                this.Test = test;

                for (int i = 0; i < this.Test.Questions.Length; i ++)
                {
                    this.listBoxQuestions.Items.Add(string.Format(" Въпрос #{0} ", i + 1));
                }

                this.stackPanelQuestion.Visibility = Visibility.Hidden;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSolve_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void listBoxQuestions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.stackPanelQuestion.Visibility = Visibility.Visible;
            this.stackPanelQuestion.DataContext =
                this.Test.Questions[this.listBoxQuestions.SelectedIndex];
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if(this.listBoxQuestions.SelectedIndex > 0)
            {
                this.listBoxQuestions.SelectedIndex--;
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if(this.listBoxQuestions.SelectedIndex < this.listBoxQuestions.Items.Count - 1)
            {
                this.listBoxQuestions.SelectedIndex++;
            }
        }
    }
}
