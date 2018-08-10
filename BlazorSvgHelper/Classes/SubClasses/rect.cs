using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSvgHelper.Classes.SubClasses
{
    public class rect: strokeBase, IBaseElement
    {
        public string id { get; set; } = null;
        public bool CaptureRef { get; set; } = false;


        public double x { get; set; } = double.NaN;
        public double y { get; set; } = double.NaN;
        public double rx { get; set; } = double.NaN;
        public double ry { get; set; } = double.NaN;
        public double width { get; set; } = double.NaN;
        public double height { get; set; } = double.NaN;
        public string style { get; set; } = null;
        public string fill { get; set; } = null;
        public string onclick { get; set; } = null;

    }
}
