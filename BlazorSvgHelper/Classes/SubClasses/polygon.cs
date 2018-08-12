using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSvgHelper.Classes.SubClasses
{
    public class polygon : IBaseElement
    {
        public string id { get; set; } = null;
        public bool CaptureRef { get; set; } = false;

        public string points { get; set; } = null;
        public string style { get; set; } = null;
    }
}
