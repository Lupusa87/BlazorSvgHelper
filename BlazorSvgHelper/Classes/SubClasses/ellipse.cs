namespace BlazorSvgHelper.Classes.SubClasses
{
    public class ellipse: IBaseElement
    {
        public string id { get; set; } = null;
        public bool CaptureRef { get; set; } = false;
        public double cx { get; set; } = double.NaN;
        public double cy { get; set; } = double.NaN;
        public double rx { get; set; } = double.NaN;
        public double ry { get; set; } = double.NaN;
        public string style { get; set; } = null;
        public string fill { get; set; } = null;
    }
}
