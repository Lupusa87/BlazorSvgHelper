﻿using BlazorSvgHelper.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSvgHelper.Classes.SubClasses
{
    public class g:strokeBase, IEventBase
    {
        public string id { get; set; } = null;
        public double font_size { get; set; } = double.NaN;
        public string font_family { get; set; } = null;
        public string text_anchor { get; set; } = null;

        public string fill { get; set; } = null;
        public string transform { get; set; } = null;
        public ICollection<object> Children { get; set; } = new List<object>();

        public BoolOptionsEnum onclick { get; set; } = BoolOptionsEnum.none;
        public BoolOptionsEnum StopPropagation { get; set; } = BoolOptionsEnum.none;

    }
}
