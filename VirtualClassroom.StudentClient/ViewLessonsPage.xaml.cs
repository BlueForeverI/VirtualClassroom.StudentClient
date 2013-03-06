using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using VirtualClassroom.StudentClient.StudentServiceReference;

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
            try
            {
                InitializeComponent();

                this.dataGridLessons.ItemsSource = client.GetLessonViewsByStudent(MainWindow.Student.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDownloadContent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(this.dataGridLessons.SelectedIndex < 0)
                {
                    MessageBox.Show("Не сте избрали урок");
                }
                else if (this.dataGridLessons.SelectedItems.Count > 1)
                {
                    MessageBox.Show("Трябва да изберете точно един урок");
                }
                else
                {
                    int lessonId = int.Parse((this.dataGridLessons.SelectedItem as dynamic).Id.ToString());
                    File lesson = client.DownloadLessonContent(lessonId);

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

                        MessageBox.Show("Урокът беше изтеглен успешно");
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
                    MessageBox.Show("Не сте избрали урок");
                }
                else if (this.dataGridLessons.SelectedItems.Count > 1)
                {
                    MessageBox.Show("Трябва да изберете точно един урок");
                }
                else if (!(this.dataGridLessons.SelectedItem as dynamic).HasHomework)
                {
                    MessageBox.Show("Този урок няма домашно");
                }
                else
                {
                    int lessonId = int.Parse((this.dataGridLessons.SelectedItem as dynamic).Id.ToString());
                    File homework = client.DownloadLessonHomework(lessonId);

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

                        MessageBox.Show("Домашното беше изтеглено успешно");
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
                    MessageBox.Show("Не сте избрали урок");
                }
                else if (this.dataGridLessons.SelectedItems.Count > 1)
                {
                    MessageBox.Show("Трябва да изберете точно един урок");
                }
                else if(!(this.dataGridLessons.SelectedItem as dynamic).HasHomework)
                {
                    MessageBox.Show("Този урок няма домашно");
                }
                else if((this.dataGridLessons.SelectedItem as dynamic).SentHomework)
                {
                    MessageBox.Show("Вече сте изпратили домашно за този урок");
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
                        MessageBox.Show("Домашното беше изпратено успешно");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDownloadSentHomework_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.dataGridLessons.SelectedIndex < 0)
                {
                    MessageBox.Show("Не сте избрали урок");
                }
                else if (this.dataGridLessons.SelectedItems.Count > 1)
                {
                    MessageBox.Show("Трябва да изберете точно един урок");
                }
                else
                {
                    dynamic lesson = this.dataGridLessons.SelectedItem;

                    if (!lesson.HasHomework)
                    {
                        MessageBox.Show("Този урок няма домашно");
                    }
                    else if(!lesson.SentHomework)
                    {
                        MessageBox.Show("Не сте изпратили домашно за този урок");
                    }
                    else
                    {
                        File homework = client.DownloadSentHomework(MainWindow.Student.Id, lesson.Id);

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

                            MessageBox.Show("Домашното беше изтеглено успешно");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
