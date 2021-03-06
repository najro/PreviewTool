using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPreviewTool
{
    public partial class PreviewToolForm : Form
    {

        private const string FilesFolder = "files";
        private const string PreviewFolder = "preview";
        public PreviewToolForm()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            webView2.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;

            InitializeListViewAndLoadFiles();

            Debug.WriteLine("before InitializeAsync");
            await InitializeAsync();
            Debug.WriteLine("after InitializeAsync");

            if ((webView2 == null) || (webView2.CoreWebView2 == null))
            {
                Debug.WriteLine("webview not ready");
            }

            webView2.Source = new Uri(Directory.GetCurrentDirectory() + $"\\{PreviewFolder}\\template\\start.htm");

            labelSelectedDirectory.Text = GetFilesToPreviewFolder;
        }

        private async Task InitializeAsync()
        {
            Debug.WriteLine("InitializeAsync");
            await webView2.EnsureCoreWebView2Async(null);
            Debug.WriteLine("WebView2 Runtime version: " + webView2.CoreWebView2.Environment.BrowserVersionString);
        }


        private void InitializeListViewAndLoadFiles()
        {
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.View = View.List;

            // read all files from preview folder to build up unique list of file names
            var files = Directory.GetFiles(GetFilesToPreviewFolder, "*.*", SearchOption.AllDirectories);
            var fileNames = new List<string>();

            foreach (string file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file);

                if (fileNames.Contains(fileName))
                    continue;

                fileNames.Add(fileName);
                var item = new ListViewItem(fileName)
                {
                    Tag = file
                };
                listView1.Items.Add(item);
            }

            // Remove all previous preview files
            DirectoryInfo di = new DirectoryInfo($"{Directory.GetCurrentDirectory()}\\{PreviewFolder}");
            foreach (FileInfo file in di.EnumerateFiles())
            {
                file.Delete();
            }
        }

        private string GetFilesToPreviewFolder
        {
            get
            {
                return $"{Directory.GetCurrentDirectory()}\\{FilesFolder}";
            }
        }

        private void WebView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            Debug.WriteLine("WebView_CoreWebView2InitializationCompleted");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                var fileName = listView1.SelectedItems[0].Text;
                Debug.WriteLine(fileName + " is selected");

              


                // read json file
                var jsonFile = $"{GetFilesToPreviewFolder}\\{fileName}.json";
                var jsonFileContent = "";

                if (File.Exists(jsonFile))
                {
                    jsonFileContent = string.Join("", File.ReadAllLines(jsonFile, Encoding.UTF8));
                }

                // read svg file
                var svgFile = $"{GetFilesToPreviewFolder}\\{fileName}.svg";

                if (!File.Exists(svgFile))
                {
                    svgFile = string.Empty;
                }

                //// read jpg file
                var jpgFile = $"{GetFilesToPreviewFolder}\\{fileName}.jpg";

                if (!File.Exists(jpgFile))
                {
                    jpgFile = string.Empty;
                }


                //// read png file
                var pngFile = $"{GetFilesToPreviewFolder}\\{fileName}.png";

                if (!File.Exists(pngFile))
                {
                    pngFile = string.Empty;
                }

                BuildPreviewView(jsonFileContent, svgFile, jpgFile, pngFile, fileName);
            }
        }
        private void BuildPreviewView(string jsonData, string svgUrl, string jpgUrl, string pngFile, string fileName)
        {
            var templateFilePath = Directory.GetCurrentDirectory() + $"\\{PreviewFolder}\\template\\view-template.htm";

            var previewHtml = File.ReadAllText(templateFilePath, Encoding.UTF8);

            previewHtml = previewHtml.Replace("#chartJson#", !string.IsNullOrEmpty(jsonData) ? jsonData : "undefined");
            previewHtml = previewHtml.Replace("#jpgFile#", !string.IsNullOrEmpty(jpgUrl) ? $"\"{jpgUrl.Replace("\\", "\\\\")}\"" : "undefined");
            previewHtml = previewHtml.Replace("#svgFile#", !string.IsNullOrEmpty(svgUrl) ? $"\"{svgUrl.Replace("\\", "\\\\")}\"" : "undefined");
            previewHtml = previewHtml.Replace("#pngFile#", !string.IsNullOrEmpty(pngFile) ? $"\"{pngFile.Replace("\\", "\\\\")}\"" : "undefined");

            var viewPath = Directory.GetCurrentDirectory() + $"\\preview\\{fileName}.htm";
            File.WriteAllText(viewPath, previewHtml, Encoding.UTF8);

            webView2.Source = new Uri(viewPath);
        }
    }
}