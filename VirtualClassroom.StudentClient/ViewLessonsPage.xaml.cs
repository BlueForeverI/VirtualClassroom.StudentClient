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

            var subjects = client.GetSubjectsByStudent(MainWindow.StudentId);
            var lessons = (from l in client.GetLessonsByStudent(MainWindow.StudentId)
                           from s in subjects
                           where s.Id == l.SubjectId
                           select new
                                      {
                                          Id = l.Id,
                                          Name = l.Name,
                                          Subject = s.Name,
                                          Date = l.Date,
                                          HomeworkDeadline = l.HomeworkDeadline
                                      }).ToList();

            this.dataGridLessons.ItemsSource = lessons;
        }

        private void btnDownloadContent_Click(object sender, RoutedEventArgs e)
        {
            int lessonId = int.Parse((this.dataGridLessons.SelectedItem as dynamic).Id.ToString());
            StudentServiceReference.File file = client.DownloadLessonContent(lessonId);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = file.Filename;
            if(saveFileDialog.ShowDialog() == true)
            {
                System.IO.File.WriteAllBytes(saveFileDialog.FileName, file.Content);
                MessageBox.Show("Lesson content downloaded successfully!");
            }
        }

        private void btnDownloadHomework_Click(object sender, RoutedEventArgs e)
        {
            int lessonId = int.Parse((this.dataGridLessons.SelectedItem as dynamic).Id.ToString());
            StudentServiceReference.File file = client.DownloadLessonHomework(lessonId);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = file.Filename;
            if (saveFileDialog.ShowDialog() == true)
            {
                System.IO.File.WriteAllBytes(saveFileDialog.FileName, file.Content);
                MessageBox.Show("Lesson homework downloaded successfully!");
            }
        }

        private void btnAddHomework_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == true)
            {
                Homework homework = new Homework();
                homework.Filename = new FileInfo(openFileDialog.FileName).Name;
                homework.Content = File.ReadAllBytes(openFileDialog.FileName);
                homework.StudentId = MainWindow.StudentId;
                homework.LessonId = int.Parse((this.dataGridLessons.SelectedItem as dynamic).Id.ToString());
                client.AddHomework(homework);
                MessageBox.Show("Homework added successfully!");
            }
        }
    }
}
