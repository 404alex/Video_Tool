using FFMpegCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Tool.Model
{
    public class HevcFile
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int Percentage { get; set; }
        public double Speed { get; set; }
        public string TargetPath { get; set; }
        public bool IsFinished { get; set; }
        public VideoInfo VInfo { get; set; }
    }
}
