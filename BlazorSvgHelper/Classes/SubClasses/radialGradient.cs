﻿using System.Collections.Generic;

namespace BlazorSvgHelper.Classes.SubClasses
{
    public class radialGradient
    {
        public string id { get; set; } = null;
        public string cx { get; set; } = null;
        public string cy { get; set; } = null;
        public string r { get; set; } = null;
        public string fx { get; set; } = null;
        public string fy { get; set; } = null;
        public string fr { get; set; } = null;
        public ICollection<object> Children { get; set; } = new List<object>();
    }
}
