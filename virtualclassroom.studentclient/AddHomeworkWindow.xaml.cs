using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;
using VirtualClassroom.StudentClient.StudentServiceReference;

namespace VirtualClassroom.StudentClient
{
    /// <summary>
    /// Interaction logic for AddHomeworkWindow.xaml
    /// </summary>
    public partial class AddHomeworkWindow : Window
    {
        public byte[] HomeworkContent { get; set; }
        public string HomeworkFilename { get; set; }
        public LessonView Lesson { get; set; }

        public AddHomeworkWindow()
        {
            InitializeComponent();
        }

        private void ValidateInput()
        {
            if(string.IsNullOrEmpty(this.txtHomeworkPath.Text) 
                || string.IsNullOrEmpty(this.txtHomeworkPath.Text))
            {
                throw new Exception("Трябва да изберете съдържание за домашното");
            }
        }

        private void btnBrowseHomework_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == true)
            {
                this.txtHomeworkPath.IsEnabled = true;
                this.txtHomeworkPath.Text = dialog.FileName;
            }
        }

        private void btnOpenEditorHomework_Click(object sender, RoutedEventArgs e)
        {
            EditorWindow window = new EditorWindow();
            if (window.ShowDialog() == true)
            {
                if (window.HtmlContent.Length > 0)
                {
                    this.HomeworkContent = window.HtmlContent;
                    this.txtHomeworkPath.Text = "[От редактора]";
                    this.txtHomeworkPath.IsEnabled = false;
                }
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ValidateInput();

                if (this.txtHomeworkPath.IsEnabled == false)
                {

                    this.HomeworkContent = this.HomeworkContent;
                    this.HomeworkFilename = string.Format("{0}.{1} - {2}.{3}.{4}.html",
                                                          this.Lesson.Subject, this.Lesson.Name,
                                                          MainWindow.Student.FirstName, MainWindow.Student.MiddleName,
                                                          MainWindow.Student.LastName);
                }
                else
                {

                    this.HomeworkContent = System.IO.File.ReadAllBytes(txtHomeworkPath.Text);
                    this.HomeworkFilename = new FileInfo(txtHomeworkPath.Text).Name;
                }

                this.DialogResult = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Грешно въведена информация");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
