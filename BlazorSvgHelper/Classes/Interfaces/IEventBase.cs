using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorSvgHelper.Classes.Interfaces
{
    public interface IEventBase
    {
        public BoolOptionsEnum onclick { get; set; }

        public BoolOptionsEnum StopPropagation { get; set; } 
    }
}
