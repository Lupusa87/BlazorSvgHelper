﻿namespace BlazorSvgHelper.Classes.SubClasses
{
    public class animateTransform
    {
        public string id { get; set; } = null;
        public string attributeName { get; set; } = null;
        public string attributeType { get; set; } = null;
        public string type { get; set; } = null;
        public double by { get; set; } = double.NaN;
        public double dur { get; set; } = double.NaN;
        public string repeatCount { get; set; } = null;
        public string values { get; set; } = null;
        public string keyTimes { get; set; } = null;
    }
}
