using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSvgHelper.Classes.SubClasses
{
    public class image : IBaseElement
    {
        public string id { get; set; } = null;
        public bool CaptureRef { get; set; } = false;


        public double x { get; set; } = double.NaN;
        public double y { get; set; } = double.NaN;
        public double width { get; set; } = double.NaN;
        public double height { get; set; } = double.NaN;
        public string href { get; set; } = null;
        public string transform { get; set; } = null;
        public double opacity { get; set; } = double.NaN;
        public ICollection<object> Children { get; set; } = new List<object>();
        public string onclick { get; set; } = null;
    }
}
