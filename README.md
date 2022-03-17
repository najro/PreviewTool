# Preview Tool for figures

> **Note:** The **Preview Tool** is implemented as a POC and is **NOT production ready**. Should only be used as input for a better implementation, integrated in already existing system

![Preview of tool](/Preview/Sample/ToolSample.jpg "Preview of tool")

**Preview Tool for figures** is a windows form to illustrate how to render Highcharts files locally within a windows form.

Files added under **[Files](/Files)** folder will be visible in the left side of tool, as selectable items. 

Files with the same name (without the file extension) will be merged as one item entry in list. When an item is selected, a preview of the file will be shown in the right side window. 

Preview is done with help of an dynamic generated html page and supports preview of .json (Highcharts), svg, jpg and png. The example files under **[Files](/Files)** only contains .json and .svg files.

If jpg or png is added, they will be shown as preview in the tool. 

When an item is selected, the preview html pages is generated on-the-fly and displayed in the right side window with help of a WebView2 component.

##  Description of file structure

![File structure of preview tool](/Preview/Sample/ToolFileStructure.jpg "File structure of preview tool")

|Files           |Description
|----------------|-------------------------------
|[Files](/Files)|Folder containing samplefiles. Files with same name are consilidated into one name in a selectable list. 
|[Highcharts/scripts/9.3.1](/Highcharts/scripts/9.3.1)|Contains offline version of all highcharts JavaScript files used on regjeringen.no. Files are referenced from |[Preview/Template/view-template.htm](/Preview/Template/view-template.htm)
|[Preview/Sample/sample.htm](/Preview/Sample/sample.htm)|Contains a simple html page displaying a Highchart figure and svg image. Open up in a browser to check it out. Reference to latest Highcharts JavaScript files online.
|[Preview/Template/start.htm](/Preview/Template/start.htm)|Landingpage displayed in view, to the right in tool using webview.
|[Preview/Template/view-template.htm](/Preview/Template/view-template.htm)|Html template for dynamic building up an html page per figure. The template is loaded and used to create a new html page matching the name of clickable items. Depending of what file formats the clickable items exist in, it will display a preview of figure as highchart (with help of json), svg, jpg or png. The file will be created under the [Preview](/Preview) folder. Any .htm files under [Preview](/Preview) folder will be deleted when the app is started.
|[Preview/Template/view.css](/Preview/Template/view.css)|Styling used in [view-template.htm](/Preview/Template/view-template.htm)
|[PreviewToolForm.cs](/PreviewToolForm.cs)|Code behind to read files, handle logic for Windows form and to display dynamic generated .htm files.

##  Technology used
- Visual Studio 2019 or Visual Studio 2022
- Forms Development (C#, .Net Framework 4.7.2)
- Version 9.3.1 of Highcharts locally downloaded
- Microsoft Edge WebView2 component to display Highcharts figures. 
	- https://docs.microsoft.com/en-us/microsoft-edge/webview2/
	- https://docs.microsoft.com/en-us/microsoft-edge/webview2/how-to/machine-setup
	- https://developer.microsoft.com/en-us/microsoft-edge/webview2/


## Additional information
Regarding Warning in Visual Studio about **microsoft.vclibs.desktop**
https://developercommunity.visualstudio.com/t/the-referenced-component-microsoftvclibs-could-not/849433
