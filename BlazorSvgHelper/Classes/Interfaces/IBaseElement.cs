using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorSvgHelper.Classes.Interfaces
{
    public interface IBaseElement
    {
        string id { get; set; }
        bool CaptureRef { get; set; }
    }
}
