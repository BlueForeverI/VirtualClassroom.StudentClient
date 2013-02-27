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

            this.dataGridLessons.ItemsSource = client.GetLessonViewsByStudent(MainWindow.Student.Id);
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
                    StudentServiceReference.File lesson = client.DownloadLessonContent(lessonId);

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.FileName = lesson.Filename;
                    if (saveFileDialog.ShowDialog() == true)
                    {
                        if (lesson.Filename.EndsWith(".html"))
                        {
                            System.IO.File.WriteAllText(saveFileDialog.FileName,
                                                        Encoding.UTF8.GetString(lesson.Content),
                                                        Encoding.UTF8);
                        }
                        else
                        {
                            System.IO.File.WriteAllBytes(saveFileDialog.FileName, lesson.Content);
                        }

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
                    StudentServiceReference.File homework = client.DownloadLessonHomework(lessonId);

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.FileName = homework.Filename;
                    if (saveFileDialog.ShowDialog() == true)
                    {
                        if (homework.Filename.EndsWith(".html"))
                        {
                            System.IO.File.WriteAllText(saveFileDialog.FileName,
                                                       Encoding.UTF8.GetString(homework.Content),
                                                       Encoding.UTF8);
                        }
                        else
                        {
                            System.IO.File.WriteAllBytes(saveFileDialog.FileName, homework.Content);
                        }

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
                    window.Lesson = this.dataGridLessons.SelectedItem as LessonView;
                    if(window.ShowDialog() == true)
                    {
                        Homework homework = new Homework();
                        homework.Filename = window.HomeworkFilename;
                        homework.Content = window.HomeworkContent;
                        homework.StudentId = MainWindow.Student.Id;
                        homework.LessonId = int.Parse((this.dataGridLessons.SelectedItem as dynamic).Id.ToString());
                        client.AddHomework(homework);

                        this.dataGridLessons.ItemsSource = client.GetLessonViewsByStudent(MainWindow.Student.Id);
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
