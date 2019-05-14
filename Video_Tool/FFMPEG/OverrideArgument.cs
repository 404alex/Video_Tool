using FFMpegCore.FFMPEG.Argument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Tool.FFMPEG
{
    public class OverrideArgument : Argument
    {
        public override string GetStringValue()
        {
            return "-crf 20";
        }
    }
}
