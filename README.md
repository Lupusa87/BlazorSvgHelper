# Blazor Svg Helper

![](https://placehold.it/15/4747d1/000000?text=+) 
If you like my blazor works and want to see more open sourced repos please support me with [paypal donation](https://www.paypal.me/VakhtangiAbashidze/10)
![](https://placehold.it/15/4747d1/000000?text=+) 

![](https://placehold.it/15/00e600/000000?text=+) 
Please send [email](mailto:VakhtangiAbashidze@gmail.com) if you consider to **hire me**.
![](https://placehold.it/15/00e600/000000?text=+)     


![](https://placehold.it/15/ffffff/000000?text=+)  



This repo contains svg classes for using in blazor.

[Project](https://www.nuget.org/packages/BlazorSvgHelper/) is available on nuget.

For install use command - **Install-Package BlazorSvgHelper**

You can create svg element and add children (circle, rectangle, image, text and etc) and finally render this svg with blazor RenderTreeBuilder.


![image](https://raw.githubusercontent.com/Lupusa87/BlazorSvgHelper/master/Untitled.png)


Usage:
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
                      transform = "translate(50,50)",
                  });
                  
   return _svg;
 }
```

 When you done composing svg you can render it.
 
 ```
  protected override void BuildRenderTree(RenderTreeBuilder builder)
  {
      svg _svg = ComposeSVG();
      new SvgHelper().Cmd_Render(_svg, 0, builder);
  }
  ```

**SVG helper works only for dynamic component and not for markup.**
You should create cs file and inside BuildRenderTree method render svg.
```
public class SomeComponent:BlazorComponent
{
  protected override void BuildRenderTree(RenderTreeBuilder builder)
  {
      svg _svg = ComposeSVG();
      new SvgHelper().Cmd_Render(_svg, 0, builder);
  }
}
```

Before use SvgHeler you need to have basic understanding what is and how works dynamic component.

You can compose more complex svg.

For example this helper was used [here](https://lupusablazordemos.azurewebsites.net/)

You can see code how this svg was composed [here](https://github.com/Lupusa87/LupusaBlazorDemos/blob/master/BlazorClockSvgComponent/CompClockSVG.cs)


For any questions please email me at VakhtangiAbashidze@gmail.com

Any PRs are welcome.
