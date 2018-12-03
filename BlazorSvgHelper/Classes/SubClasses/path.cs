﻿namespace BlazorSvgHelper.Classes.SubClasses
{
    public class path: strokeBase, IBaseElement
    {
        public string id { get; set; } = null;
        public bool CaptureRef { get; set; } = false;
        public string d { get; set; } = null;
        public string fill { get; set; } = null;
        public double opacity { get; set; } = double.NaN;
    }
}
