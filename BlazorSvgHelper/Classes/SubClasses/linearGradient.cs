using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IaIRazorComponents.SvgHelper.Classes.SubClasses
{
    public class linearGradient
    {
        public string id { get; set; } = null;
        public string x1 { get; set; } = null;
        public string x2 { get; set; } = null;
        public string y1 { get; set; } = null;
        public string y2 { get; set; } = null;
        public ICollection<object> Children { get; set; } = new List<object>();
    }
}
