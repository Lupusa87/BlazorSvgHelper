using BlazorSvgHelper.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSvgHelper.Classes.SubClasses
{
    public class polyline : IBaseElement, IEventBase
    {
        public string id { get; set; } = null;
        public bool CaptureRef { get; set; } = false;


        public string points { get; set; } = null;
        public string style { get; set; } = null;

        public BoolOptionsEnum onclick { get; set; } = BoolOptionsEnum.none;
        public BoolOptionsEnum StopPropagation { get; set; } = BoolOptionsEnum.none;
    }
}
