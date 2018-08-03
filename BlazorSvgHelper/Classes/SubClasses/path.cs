using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSvgHelper.Classes.SubClasses
{
    public class path:strokeBase
    {
        public string id { get; set; } = null;
        public string d { get; set; } = null;

        public string fill { get; set; } = null;

        public double opacity { get; set; } = double.NaN;

    }
}
