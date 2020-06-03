﻿using BlazorSvgHelper.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSvgHelper.Classes.SubClasses
{
    public class circle : strokeBase, IBaseElement, IEventBase
    {
        public string id { get; set; } = null;
        public bool CaptureRef { get; set; } = false;

        public double cx { get; set; } = double.NaN;
        public double cy { get; set; } = double.NaN;
        public double r { get; set; } = double.NaN;
        public string fill { get; set; } = null;
        public string transform { get; set; } = null;
        public ICollection<object> Children { get; set; } = new List<object>();
        public BoolOptionsEnum onclick { get; set; } = BoolOptionsEnum.none;
        public BoolOptionsEnum StopPropagation { get; set; } =  BoolOptionsEnum.none;

    }
}
