using FFMpegCore;
using HEVC_H264_Converter.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video_Tool.Model;

namespace Video_Tool.ViewModel
{
    class ConverterListViewModel : BindableBase, IEditableObject
    {

        public ObservableCollection<HevcFile> Files { get; set; }

        public ConverterListViewModel()
        {
            this.Files = new ObservableCollection<HevcFile>();
        }
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
