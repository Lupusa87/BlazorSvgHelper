﻿using System.Collections.Generic;

namespace BlazorSvgHelper.Classes.SubClasses
{
    public class line: strokeBase, IBaseElement
    {
        public string id { get; set; } = null;
        public bool CaptureRef { get; set; } = false;


        public double x1 { get; set; } = double.NaN;
        public double y1 { get; set; } = double.NaN;
        public double x2 { get; set; } = double.NaN;
        public double y2 { get; set; } = double.NaN;
        public string style { get; set; } = null;
        public string transform { get; set; } = null;
        public double opacity { get; set; } = double.NaN;
        public ICollection<object> Children { get; set; } = new List<object>();

        public string onclick { get; set; } = null;
    }
}
