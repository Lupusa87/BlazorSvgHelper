# Blazor Svg Helper

This repo contains svg classes for using in blazor.

[Project](https://www.nuget.org/packages/BlazorSvgHelper/) is available on nuget.

For install use command - **Install-Package BlazorSvgHelper -Version 1.0.0**

You can create svg element and add children (circle, rectangle, image, text and etc) and finaly render this svg with blazor RenderTreeBuilder.

Examples:
```
 public svg ComposeSVG()
  {
   _svg = new svg
    {
        id = "svgclock",
        width = 100,
        height = 100,
        xmlns = "http://www.w3.org/2000/svg",
    };


   _svg.Children.Add(new circle
                  {
                      cx = 0,
                      cy = 0,
                      r = 30,
                      fill = "red",
                      transform = "translate("50,50")",
                  });
                  
   return _svg
 }
```

 When you done composing svg you can render it.
 
 ```
  protected override void BuildRenderTree(RenderTreeBuilder builder)
  {
      svg _svg = ComposeSVG();
      SvgHelper.Cmd_Render(_svg, 0, builder);
  }
  ```
