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
    /// Interaction logic for ViewMarksPage.xaml
    /// </summary>
    public partial class ViewMarksPage : Page
    {
        private StudentServiceClient client = ClientManager.GetClient();

        public ViewMarksPage()
        {
            InitializeComponent();

            var subjects = client.GetSubjectsByStudent(MainWindow.StudentId).ToList();
            var lessons = client.GetLessonsByStudent(MainWindow.StudentId);
            var items = (from h in client.GetHomeworksByStudent(MainWindow.StudentId)
                         from s in subjects
                         from l in lessons
                         where h.LessonId == l.Id && l.SubjectId == s.Id && h.Mark != null
                         select new
                                    {
                                        Date = h.Date,
                                        Subject = s.Name,
                                        Mark = h.Mark
                                    });

            this.dataGridMarks.ItemsSource = items;
        }
    }
}
