using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChartReader;



namespace MCDesigner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IReader _reader;

        public MainWindow()
        {
            InitializeComponent();
            _reader = new Reader();

        }

        public string GetFileLocation()
        {
            var path = string.Empty;
            var dialog = new OpenFileDialog { InitialDirectory = "C:\\" };

            var result = dialog.ShowDialog();
            if (result.ToString() == "OK")
            {
                path = dialog.FileName;
            }

            //var folderDialog = new FolderBrowserDialog {SelectedPath = "C:\\"};

            //var result = folderDialog.ShowDialog();
            //if (result.ToString() == "OK")
            //{
            //    path = folderDialog.SelectedPath;
            //}
            return path;
        }



        private void btnGetFile_Click(object sender, RoutedEventArgs e)
        {
            var loc = GetFileLocation();

            var content = _reader.ReadLines(loc);
            fileContents.Text = content.LinesToRawString();
        }
    }

    
}
