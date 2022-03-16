
namespace WindowsFormsPreviewTool
{
    partial class PreviewToolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.labelFileInfo = new System.Windows.Forms.Label();
            this.labelDirectoryInfo = new System.Windows.Forms.Label();
            this.labelSelectedDirectory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(209, 756);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // webView2
            // 
            this.webView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView2.BackColor = System.Drawing.Color.Black;
            this.webView2.CreationProperties = null;
            this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2.Location = new System.Drawing.Point(242, 59);
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(933, 756);
            this.webView2.Source = new System.Uri("https://www.microsoft.com", System.UriKind.Absolute);
            this.webView2.TabIndex = 2;
            this.webView2.UseWaitCursor = true;
            this.webView2.ZoomFactor = 1D;
            // 
            // labelFileInfo
            // 
            this.labelFileInfo.AutoSize = true;
            this.labelFileInfo.Location = new System.Drawing.Point(9, 43);
            this.labelFileInfo.Name = "labelFileInfo";
            this.labelFileInfo.Size = new System.Drawing.Size(114, 13);
            this.labelFileInfo.TabIndex = 3;
            this.labelFileInfo.Text = "Current files to preview";
            // 
            // labelDirectoryInfo
            // 
            this.labelDirectoryInfo.AutoSize = true;
            this.labelDirectoryInfo.Location = new System.Drawing.Point(12, 13);
            this.labelDirectoryInfo.Name = "labelDirectoryInfo";
            this.labelDirectoryInfo.Size = new System.Drawing.Size(143, 13);
            this.labelDirectoryInfo.TabIndex = 4;
            this.labelDirectoryInfo.Text = "Reading files from directory : ";
            // 
            // labelSelectedDirectory
            // 
            this.labelSelectedDirectory.AutoSize = true;
            this.labelSelectedDirectory.Location = new System.Drawing.Point(154, 13);
            this.labelSelectedDirectory.Name = "labelSelectedDirectory";
            this.labelSelectedDirectory.Size = new System.Drawing.Size(173, 13);
            this.labelSelectedDirectory.TabIndex = 5;
            this.labelSelectedDirectory.Text = "path info about files to be displayed";
            // 
            // PreviewToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 820);
            this.Controls.Add(this.labelSelectedDirectory);
            this.Controls.Add(this.labelDirectoryInfo);
            this.Controls.Add(this.labelFileInfo);
            this.Controls.Add(this.webView2);
            this.Controls.Add(this.listView1);
            this.Name = "PreviewToolForm";
            this.Text = "Preview tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private System.Windows.Forms.Label labelFileInfo;
        private System.Windows.Forms.Label labelDirectoryInfo;
        private System.Windows.Forms.Label labelSelectedDirectory;
    }
}

