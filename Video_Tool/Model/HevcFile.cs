using FFMpegCore;
using HEVC_H264_Converter.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Tool.Model
{
    public class HevcFile : BindableBase
    {
        private string _FileName;
        private string _FilePath;
        private double _Percentage;
        private double _Speed;
        private string _TargetPath;
        private bool _IsFinished;
        private VideoInfo _VInfo;

        public string FileName
        {
            get => _FileName;
            set
            {
                if (value != _FileName)
                {
                    _FileName = value;
                    OnPropertyChanged("FileName");
                }
            }
        }

        public string FilePath
        {
            get => _FilePath;
            set
            {
                if (value != _FilePath)
                {
                    _FilePath = value;
                    OnPropertyChanged("FilePath");
                }
            }
        }

        public string Percentage
        {
            get => _Percentage.ToString();
            set
            {
                if (value != _Percentage.ToString())
                {
                    _Percentage = System.Convert.ToDouble(value);
                    OnPropertyChanged("Percentage");
                }
            }
        }

        public string Speed
        {
            get => _Speed.ToString();
            set
            {
                if (value != _Speed.ToString())
                {
                    _Speed = Convert.ToInt32(value);
                    OnPropertyChanged("Speed");
                }
            }
        }

        public string TargetPath
        {
            get => _TargetPath;
            set
            {
                if (value != _TargetPath)
                {
                    _TargetPath = value;
                    OnPropertyChanged("TargetPath");
                }
            }
        }

        public bool IsFinished
        {
            get => _IsFinished;
            set
            {
                if (value != _IsFinished)
                {
                    _IsFinished = value;
                    OnPropertyChanged("IsFinished");
                }
            }
        }

        public VideoInfo VInfo
        {
            get => _VInfo;
            set
            {
                if (value != _VInfo)
                {
                    _VInfo = value;
                    OnPropertyChanged(string.Empty);
                }
            }

        }
    }
}
