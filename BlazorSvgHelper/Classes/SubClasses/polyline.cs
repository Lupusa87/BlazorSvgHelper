﻿namespace BlazorSvgHelper.Classes.SubClasses
{
    public class polyline : IBaseElement
    {
        public string id { get; set; } = null;
        public bool CaptureRef { get; set; } = false;
        public string points { get; set; } = null;
        public string style { get; set; } = null;
    }
}
