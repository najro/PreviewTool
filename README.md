# Preview Tool for figures

![Preview of tool](/Preview/Sample/ToolSample.jpg "Preview of tool")


**Preview Tool for figures** is a POC windows form to illustrate how to render Highcharts files locally within a windows form.

Files added under the **files** folder will be visible in left side of tool as selectable items. 
Files with same name (without the file extension) will be merged as one entry in list. 
When an item is selected, a preview of the file will be shown in the right side window. 
Preview is done with help of an html page and supports preview of .json (Highcharts), svg, jpg and png.

When an item is seleted, the preview html pages is generated on-the-fly and displayed in the right side window with help of a WebView2 component.

##  Description of file structure



##  Technology used
- Visual Studio 2019
- Forms Development (C#)
- Version 9.3.1 of Higcharts locally downloaded
- Microsoft Edge WebView2 component to display Highcharts figures. 
	- https://docs.microsoft.com/en-us/microsoft-edge/webview2/
	- https://docs.microsoft.com/en-us/microsoft-edge/webview2/how-to/machine-setup
	- https://developer.microsoft.com/en-us/microsoft-edge/webview2/


## Additional information
Regarding Warning in Visual Studio about **microsoft.vclibs.desktop**
https://developercommunity.visualstudio.com/t/the-referenced-component-microsoftvclibs-could-not/849433
