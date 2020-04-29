using BlazorSvgHelper.Classes;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorSvgHelper
{
    public class SvgHelper
    {
        public Action<MouseEventArgs> ActionClicked;


        public Action<int> ActionSelected;

        public Dictionary<string, ElementReference> Elementreferences_Dictionary = new Dictionary<string, ElementReference>();


        public void Reset_Dictionary()
        {
            this.Elementreferences_Dictionary = new Dictionary<string, ElementReference>();
        }


        public Dictionary<string, ElementReference> Get_Dictionary()
        {
            return this.Elementreferences_Dictionary;
        }

        public void Cmd_Render<T>(T _Item, int k, RenderTreeBuilder builder, int Par_ID = 0)
        {
            var act1 = new Action<MouseEventArgs>((s) =>
            {
                this.Cmd_Clicked(s);
            });


            var CaptureRef = false;
            var _value_id = string.Empty;

            if (_Item.GetType().GetProperties().Any(x => x.Name == "CaptureRef"))
            {

                var pi_captureref = _Item.GetType().GetProperty("CaptureRef");
                if ((bool)pi_captureref.GetValue(_Item, null))
                {
                    if (_Item.GetType().GetProperties().Any(x => x.Name == "id"))
                    {
                        var pi_id = _Item.GetType().GetProperty("id");
                        _value_id = pi_id.GetValue(_Item, null).ToString();

                        CaptureRef = _value_id != null && !string.IsNullOrEmpty(_value_id.ToString());
                    }

                }
            }



            object _value;
            var _attrName = string.Empty;

            var IsAllowed = true;


            builder.OpenElement(k++, _Item.GetType().Name);



            foreach (var pi in _Item.GetType().GetProperties().Where(x => !x.PropertyType.Name.Contains("ICollection") && !x.PropertyType.Name.Contains("CaptureRef")))
            {
                //list can't filter captureref??????
                if (pi.Name != "CaptureRef")
                {

                    IsAllowed = true;

                    _value = pi.GetValue(_Item, null);

                    if (pi.PropertyType == typeof(double))
                    {
                        if (double.IsNaN((double)_value))
                        {
                            IsAllowed = false;

                        }
                        else
                        {
                            _value = Math.Round((double)_value, 2);
                        }
                    }

                    if (IsAllowed)
                    {
                        IsAllowed = _value != null && !string.IsNullOrEmpty(_value.ToString());
                    }


                    if (IsAllowed)
                    {
                        if (pi.Name == "stroke_linecap")
                        {
                            IsAllowed = (strokeLinecap)_value != strokeLinecap.none;
                        }
                    }


                    if (IsAllowed)
                    {
                        _attrName = pi.Name;

                        if (_attrName.Equals("onclick"))
                        {

                            if (Par_ID == 0)
                            {
                                builder.AddAttribute(k++, _attrName, act1);
                            }
                            else
                            {
                                builder.AddAttribute(k++, _attrName, EventCallback.Factory.Create(this, e => this.ActionSelected?.Invoke(Par_ID)));
                            }
                        }
                        else
                        {
                            if (_attrName.Equals("content"))
                            {
                                builder.AddContent(k++, _value.ToString());

                            }
                            else
                            {
                                if (_attrName.Contains("_"))
                                {
                                    _attrName = _attrName.Replace("_", "-");
                                }

                                builder.AddAttribute(k++, _attrName, _value.ToString());

                            }

                        }
                    }
                }
            }


            var pi_Children = _Item.GetType().GetProperty("Children");

            if (pi_Children != null)
            {
                var children = pi_Children.GetValue(_Item) as List<object>;

                foreach (var item in children)
                {
                    this.Cmd_Render(item, k, builder, Par_ID);
                }
            }



            if (CaptureRef)
            {
                builder.AddElementReferenceCapture(k++, (elementReference) =>
                {

                    this.Elementreferences_Dictionary.Add(_value_id, elementReference);

                });
            }

            builder.CloseElement();

        }


        public void Cmd_Clicked(MouseEventArgs e)
        {
            this.ActionClicked?.Invoke(e);
        }

    }
}
