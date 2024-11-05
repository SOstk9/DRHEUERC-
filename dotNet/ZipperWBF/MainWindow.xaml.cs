using System.IO;
using System.IO.Compression;
using System.Windows;
using System.Windows.Controls;

namespace ZipperWBF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filename = "";
        string foldername = "";
        string compFilename = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();


            bool? result = dialog.ShowDialog();
            filename = dialog.FileName;
            TextBoxOeffnen.Text = filename;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFolderDialog();

            bool? result = dialog.ShowDialog();
            foldername = dialog.FolderName;
            TextBox2.Text = dialog.FolderName;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {                
                compFilename = filename + ".rar";
                using FileStream originalFileStream = File.Open(filename, FileMode.OpenOrCreate);
                using FileStream compressedFileStream = File.Create(compFilename);
                using var compressor = new GZipStream(compressedFileStream, CompressionMode.Compress);
                originalFileStream.CopyTo(compressor);
                MessageBox.Show("Erfolgreich!!!");
            }
            catch
            {
                throw new Exception("Hat net geklappen tut");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}