using FFMpegCore;
using FFMpegCore.Enums;
using FFMpegCore.FFMPEG;
using FFMpegCore.FFMPEG.Argument;
using FFMpegCore.FFMPEG.Enums;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Video_Tool.Model;
using Video_Tool.ViewModel;

namespace Video_Tool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ConverterListViewModel ViewModel { get; } = new ConverterListViewModel();


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = ViewModel;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (var item in openFileDialog.FileNames)
                {
                    HevcFile hevcFile = new HevcFile();
                    hevcFile.VInfo = new FFMpegCore.VideoInfo(item);

                    hevcFile.FileName = hevcFile.VInfo.Name;
                    hevcFile.FilePath = hevcFile.VInfo.FullName;
                    hevcFile.IsFinished = false;
                    string temp = hevcFile.FilePath;
                    hevcFile.TargetPath = temp.Insert(temp.Length - hevcFile.VInfo.Extension.Length, "_done");
                    hevcFile.TargetPath = temp.Substring(0, temp.Length - hevcFile.VInfo.Extension.Length);
                    hevcFile.TargetPath += ".mp4";
                    ViewModel.Files.Add(hevcFile);
                }
            }
        }
        private FFMpeg encoder = new FFMpeg();

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                foreach (var item in ViewModel.Files)
                {
                    if (item.IsFinished == false)
                    {

                        string inputFile = item.FilePath;



                        FileInfo outputFile = new FileInfo(item.TargetPath);

                        var video = item.VInfo;

                        // easily track conversion progress
                        encoder.OnProgress += (percentage) => item.Percentage = percentage.ToString();




                        // MP4 conversion
                        encoder.Convert(
                            video,
                            outputFile,
                            VideoType.Mp4,
                            Speed.Slow,
                            VideoSize.Original,
                            AudioQuality.Hd,
                            true
                        );

                        item.IsFinished = true;

                    }
                }
            });
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                encoder.Stop();
            });
        }
    }
}
