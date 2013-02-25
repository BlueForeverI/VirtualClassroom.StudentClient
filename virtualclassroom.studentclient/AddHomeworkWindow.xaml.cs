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

        public AddHomeworkWindow()
        {
            InitializeComponent();
        }

        private void btnBrowseHomework_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == true)
            {
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
                    this.txtHomeworkPath.Text = "[From Editor]";
                    this.txtHomeworkPath.IsEnabled = false;
                }
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (this.txtHomeworkPath.IsEnabled == false)
            {

                this.HomeworkContent = this.HomeworkContent;
                this.HomeworkFilename = "Homework.html"; //to refactor
            }
            else
            {

                this.HomeworkContent = System.IO.File.ReadAllBytes(txtHomeworkPath.Text);
                this.HomeworkFilename = new FileInfo(txtHomeworkPath.Text).Name;
            }

            this.DialogResult = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
