using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSvgHelper.Classes.SubClasses
{
    public class svg : IBaseElement
    {
        public string id { get; set; } = null;
        public bool CaptureRef { get; set; } = false;

        public double width { get; set; } = double.NaN;
        public double height { get; set; } = double.NaN;
        public string xmlns { get; set; } = null;
        public ICollection<object> Children { get; set; } = new List<object>();
        public string style { get; set; } = null;

        public string transform { get; set; } = null;
        public string onclick { get; set; } = null;
    }
}
