# Preview Tool for figures

![Preview of tool](/Preview/Sample/ToolSample.jpg "Preview of tool")

> **Note:** The **Preview tool** is just implemented as a POC and is not production ready. Should only be used as input for a new implementation integrated in already existing system

**Preview Tool for figures** is a POC windows form to illustrate how to render Highcharts files locally within a windows form.

Files added under the **files** folder will be visible in left side of tool as selectable items. 
Files with same name (without the file extension) will be merged as one entry in list. 
When an item is selected, a preview of the file will be shown in the right side window. 
Preview is done with help of an html page and supports preview of .json (Highcharts), svg, jpg and png.

When an item is seleted, the preview html pages is generated on-the-fly and displayed in the right side window with help of a WebView2 component.

##  Description of file structure

![File structure of tool](/Preview/Sample/ToolFileStructure.jpg "File structure of tool")

|Files						|Description
|---------------------------|-------------------------------
|files 						| Folder containing  samlpe files. Files with same name are consilidated into  one name in list. 
|highcharts/scripts/9.3.1	| Contains offline version of highcharts javascript files. Same version as regjeringen.no are using.
|preview/sample/sample.htm	|Contains a simple html page displaying a highchart figure and svg image. Just open up in a browser to check it out. Reference to latest highcharts javascriopt online.
|XX|     XXX
|XX|     XXX
|XX|     XXX
|XX|     XXX

##  Technology used
- Visual Studio 2019
- Forms Development (C#, .Net Framework 4.7.2)
- Version 9.3.1 of Higcharts locally downloaded
- Microsoft Edge WebView2 component to display Highcharts figures. 
	- https://docs.microsoft.com/en-us/microsoft-edge/webview2/
	- https://docs.microsoft.com/en-us/microsoft-edge/webview2/how-to/machine-setup
	- https://developer.microsoft.com/en-us/microsoft-edge/webview2/


## Additional information
Regarding Warning in Visual Studio about **microsoft.vclibs.desktop**
https://developercommunity.visualstudio.com/t/the-referenced-component-microsoftvclibs-could-not/849433
