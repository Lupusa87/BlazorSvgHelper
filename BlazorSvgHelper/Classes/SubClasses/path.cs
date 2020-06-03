using BlazorSvgHelper.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSvgHelper.Classes.SubClasses
{
    public class path: strokeBase, IBaseElement, IEventBase
    {
        public string id { get; set; } = null;
        public bool CaptureRef { get; set; } = false;


        public string d { get; set; } = null;

        public string fill { get; set; } = null;
        public string transform { get; set; } = null;

        public double opacity { get; set; } = double.NaN;

        public BoolOptionsEnum onclick { get; set; } = BoolOptionsEnum.none;
        public BoolOptionsEnum StopPropagation { get; set; } = BoolOptionsEnum.none;

    }
}
