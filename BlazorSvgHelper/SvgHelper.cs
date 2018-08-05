using Microsoft.AspNetCore.Blazor.RenderTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BlazorSvgHelper
{
    public class SvgHelper
    {
        public static void Cmd_Render<T>(T _Item, int k, RenderTreeBuilder builder)
        {
            object _value;
            string _attrName = string.Empty;

            bool IsAllowed = true;


            builder.OpenElement(k++, _Item.GetType().Name);


            foreach (PropertyInfo pi in _Item.GetType().GetProperties().Where(x => !x.PropertyType.Name.Contains("ICollection")))
            {
                IsAllowed = true;
                //Console.WriteLine("prop name - " + pi.Name +" ; type- " + pi.PropertyType.Name + " isclass = "+ pi.PropertyType.IsClass.ToString());
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
                    _attrName = pi.Name;


                    if (_attrName.Equals("content"))
                    {
                        builder.AddContent(k++, _value.ToString());
                        //Console.WriteLine("add content - " + _value.ToString());
                    }
                    else
                    {
                        if (_attrName.Contains("_"))
                        {
                            _attrName = _attrName.Replace("_", "-");
                        }

                        //if (_attrName.Contains("99"))
                        //{
                        //    _attrName = _attrName.Replace("99", ":");
                        //}

                        builder.AddAttribute(k++, _attrName, _value.ToString());
                        // Console.WriteLine("set attribute - " + _attrName + " = " + _value.ToString());
                    }


                }
            }


            PropertyInfo pi_Children = _Item.GetType().GetProperty("Children");

            if (pi_Children != null)
            {
                List<object> children = pi_Children.GetValue(_Item) as List<object>;

                foreach (object item in children)
                {
                    Cmd_Render(item, k, builder);
                }
            }

            builder.CloseElement();
            //Console.WriteLine("close element " + _Item.GetType().Name.ToLower());

            
        }
    }
}
