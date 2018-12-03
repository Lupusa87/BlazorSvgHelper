namespace BlazorSvgHelper.Classes.SubClasses
{
    public class strokeBase
    {
        public string stroke { get; set; } = null;
        public double stroke_width { get; set; } = double.NaN;
        public strokeLinecap stroke_linecap { get; set; } = strokeLinecap.none;
        public string stroke_dasharray { get; set; } = null;
    }
}
