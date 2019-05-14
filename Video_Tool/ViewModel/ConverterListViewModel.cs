using FFMpegCore;
using HEVC_H264_Converter.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video_Tool.Model;

namespace Video_Tool.ViewModel
{
    class ConverterListViewModel : BindableBase, IEditableObject
    {
        public ConverterListViewModel(HevcFile model = null) => Model = model ?? new HevcFile();

        public ConverterListViewModel()
        {
            this.Files = new List<HevcFile>();
        }

        private HevcFile _model;

        private List<HevcFile> _files = new List<HevcFile>();
        public HevcFile Model
        {
            get => _model;
            set
            {
                if (_model != value)
                {
                    _model = value;
                    OnPropertyChanged(string.Empty);
                }
            }
        }

        public string FileName
        {
            get => Model.FileName;
            set
            {
                if (value != Model.FileName)
                {
                    Model.FileName = value;
                    IsModified = true;
                    OnPropertyChanged("FileName");
                }
            }
        }

        public string FilePath
        {
            get => Model.FilePath;
            set
            {
                if (value != Model.FilePath)
                {
                    Model.FilePath = value;
                    IsModified = true;
                    OnPropertyChanged("FilePath");
                }
            }
        }

        public string Percentage
        {
            get => Model.Percentage.ToString();
            set
            {
                if (value != Model.Percentage.ToString())
                {
                    Model.Percentage = System.Convert.ToInt32(value);
                    IsModified = true;
                    OnPropertyChanged("Percentage");
                }
            }
        }

        public string Speed
        {
            get => Model.Speed.ToString();
            set
            {
                if (value != Model.Speed.ToString())
                {
                    Model.Speed = Convert.ToInt32(value);
                    IsModified = true;
                    OnPropertyChanged("Speed");
                }
            }
        }

        public string TargetPath
        {
            get => Model.TargetPath;
            set
            {
                if (value != Model.TargetPath)
                {
                    Model.TargetPath = value;
                    IsModified = true;
                    OnPropertyChanged("TargetPath");
                }
            }
        }

        public bool IsFinished
        {
            get => Model.IsFinished;
            set
            {
                if (value != Model.IsFinished)
                {
                    Model.IsFinished = value;
                    IsModified = true;
                    OnPropertyChanged("IsFinished");
                }
            }
        }

        public VideoInfo VInfo
        {
            get => Model.VInfo;
            set
            {
                if (value != Model.VInfo)
                {
                    Model.VInfo = value;
                    IsModified = true;
                    OnPropertyChanged();
                }
            }

        }

        public List<HevcFile> Files
        {
            get => _files;
            set
            {
                if (value != _files)
                {
                    OnPropertyChanged();
                }
            }
        }



        public bool IsModified { get; set; }

        public void BeginEdit()
        {

        }

        public void CancelEdit()
        {
        }

        public void EndEdit()
        {

        }
    }
}
