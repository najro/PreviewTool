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

|Files           |Description
|----------------|-------------------------------
|files|Folder containing samplefiles. Files with same name are consilidated into  one name in list. 
|highcharts/scripts/9.3.1|Contains offline version of all highcharts javascript files used on regjeringen.no. Files are referenced from view-template.htm
|preview/sample/sample.htm|Contains a simple html page displaying a Highchart figure and svg image. Open up in a browser to check it out. Reference to latest Highcharts JavaScript files online.
|preview/template/start.htm|Landingpage displayed to the right in tool (webview)
|preview/template/view-template.htm|Html template for dynamic building up an html page per figure. The template is loaded and used to create a new html page matching the name of clickable items. Depending of what formats the clickable items exist in it will display preview of figure as highchart (with help of json), svg, jpg or png. The file will be created under the Preview folder. Any .htm files under Preview folder will be deleted when the app is started.
|preview/view.css|Styling used in view-template.htm
|PreviewToolForm.cs|Code behind to read file, create dynamic html and hadle logic behind Windows form to display dynamic generated .htm files.

##  Technology used
- Visual Studio 2019 or Visual Studio 2022
- Forms Development (C#, .Net Framework 4.7.2)
- Version 9.3.1 of Higcharts locally downloaded
- Microsoft Edge WebView2 component to display Highcharts figures. 
	- https://docs.microsoft.com/en-us/microsoft-edge/webview2/
	- https://docs.microsoft.com/en-us/microsoft-edge/webview2/how-to/machine-setup
	- https://developer.microsoft.com/en-us/microsoft-edge/webview2/


## Additional information
Regarding Warning in Visual Studio about **microsoft.vclibs.desktop**
https://developercommunity.visualstudio.com/t/the-referenced-component-microsoftvclibs-could-not/849433
