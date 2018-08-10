using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSvgHelper.Classes.SubClasses
{
    public interface IBaseElement
    {
        string id { get; set; }
        bool CaptureRef { get; set; }
    }
}
