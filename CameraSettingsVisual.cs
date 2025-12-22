using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForSignalR
{
    public class CameraSettingsVisual
    {
            
            public string IDprocces { get; set; }
            public int Brightness { get; set; } = 0;
            public int Contrast { get; set; } = 0;
            public int Hue { get; set; } = 0;
            public int Saturation { get; set; } = 0;
            public int NoiseReduction { get; set; } = 0;
            public int EdgeEnhancement { get; set; } = 0;
            public int AnamorphicScaling { get; set; } = 0;
            public int StereoAdjustment { get; set; } = 0;
            public string Rotation { get; set; } = "";

        public  CameraSettingsVisual(string IDprocces, int Brightness, int Contrast,int Hue,int Saturation, int NoiseReduction, int EdgeEnhancement , int AnamorphicScaling, int StereoAdjustment,string Rotation)
        {   this.IDprocces = IDprocces;
            this.Brightness = Brightness;
            this.Contrast = Contrast;
            this.Hue = Hue;
            this.Saturation = Saturation;
            this.NoiseReduction = NoiseReduction;
            this.EdgeEnhancement = EdgeEnhancement;
            this.AnamorphicScaling = AnamorphicScaling;
            this.StereoAdjustment = StereoAdjustment;
            this.Rotation = Rotation;
        }

    }
}
