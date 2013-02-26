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
using Microsoft.Win32;
using VirtualClassroom.StudentClient.StudentServiceReference;
using System.IO;
using File = System.IO.File;

namespace VirtualClassroom.StudentClient
{
    /// <summary>
    /// Interaction logic for ViewLessonsPage.xaml
    /// </summary>
    public partial class ViewLessonsPage : Page
    {
        private StudentServiceClient client = ClientManager.GetClient();

        public ViewLessonsPage()
        {
            InitializeComponent();

            this.dataGridLessons.ItemsSource = client.GetLessonViewsByStudent(MainWindow.StudentId);
        }

        private void btnDownloadContent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(this.dataGridLessons.SelectedIndex < 0)
                {
                    MessageBox.Show("You have not selected any lessons!");
                }
                else if (this.dataGridLessons.SelectedItems.Count > 1)
                {
                    MessageBox.Show("You must select a single lesson!");
                }
                else
                {
                    int lessonId = int.Parse((this.dataGridLessons.SelectedItem as dynamic).Id.ToString());
                    StudentServiceReference.File file = client.DownloadLessonContent(lessonId);

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.FileName = file.Filename;
                    if (saveFileDialog.ShowDialog() == true)
                    {
                        File.WriteAllText(saveFileDialog.FileName, 
                                          new UTF8Encoding(true).GetString(file.Content),
                                          new UTF8Encoding(true));

                        MessageBox.Show("Lesson content downloaded successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDownloadHomework_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(this.dataGridLessons.SelectedIndex < 0)
                {
                    MessageBox.Show("You have not selected any lessons!");
                }
                else if (this.dataGridLessons.SelectedItems.Count > 1)
                {
                    MessageBox.Show("You must select a single lesson!");
                }
                else if (!(this.dataGridLessons.SelectedItem as dynamic).HasHomework)
                {
                    MessageBox.Show("This lesson does not have a homework!");
                }
                else
                {
                    int lessonId = int.Parse((this.dataGridLessons.SelectedItem as dynamic).Id.ToString());
                    StudentServiceReference.File file = client.DownloadLessonHomework(lessonId);

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.FileName = file.Filename;
                    if (saveFileDialog.ShowDialog() == true)
                    {
                        File.WriteAllText(saveFileDialog.FileName, new UTF8Encoding(true).GetString(file.Content),
                                          new UTF8Encoding(true));
                        MessageBox.Show("Lesson homework downloaded successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddHomework_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(this.dataGridLessons.SelectedIndex < 0)
                {
                    MessageBox.Show("You have not selected any lessons!");
                }
                else if (this.dataGridLessons.SelectedItems.Count > 1)
                {
                    MessageBox.Show("You must select a single lesson!");
                }
                else if(!(this.dataGridLessons.SelectedItem as dynamic).HasHomework)
                {
                    MessageBox.Show("This lesson does not have a homework!");
                }
                else if((this.dataGridLessons.SelectedItem as dynamic).SentHomework)
                {
                    MessageBox.Show("You have already sent a homework for this lesson!");
                }
                else
                {
                    AddHomeworkWindow window = new AddHomeworkWindow();
                    if(window.ShowDialog() == true)
                    {
                        Homework homework = new Homework();
                        homework.Filename = window.HomeworkFilename;
                        homework.Content = window.HomeworkContent;
                        homework.StudentId = MainWindow.StudentId;
                        homework.LessonId = int.Parse((this.dataGridLessons.SelectedItem as dynamic).Id.ToString());
                        client.AddHomework(homework);

                        this.dataGridLessons.ItemsSource = client.GetLessonViewsByStudent(MainWindow.StudentId);
                        MessageBox.Show("Homework added successfully!");
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
