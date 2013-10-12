namespace ELTE.Trainings.Lecture05.ImageViewer.Views
{
    partial class ImageViewerBox
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
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._ImageGroupBox = new System.Windows.Forms.GroupBox();
            this._ImageBox = new ELTE.Trainings.Lecture05.ImageViewer.Views.ImageBox();
            this._ImageBoxContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showHideInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ImagePanel = new System.Windows.Forms.Panel();
            this._ImageGroupBox.SuspendLayout();
            this._ImageBoxContextMenuStrip.SuspendLayout();
            this._ImagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ImageGroupBox
            // 
            this._ImageGroupBox.Controls.Add(this._ImagePanel);
            this._ImageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ImageGroupBox.Location = new System.Drawing.Point(0, 0);
            this._ImageGroupBox.Name = "_ImageGroupBox";
            this._ImageGroupBox.Size = new System.Drawing.Size(150, 150);
            this._ImageGroupBox.TabIndex = 0;
            this._ImageGroupBox.TabStop = false;
            this._ImageGroupBox.Text = "Image";
            // 
            // _ImageBox
            // 
            this._ImageBox.ContextMenuStrip = this._ImageBoxContextMenuStrip;
            this._ImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ImageBox.ImageInfo = null;
            this._ImageBox.Location = new System.Drawing.Point(0, 0);
            this._ImageBox.Name = "_ImageBox";
            this._ImageBox.ShowImageInformation = true;
            this._ImageBox.Size = new System.Drawing.Size(144, 131);
            this._ImageBox.TabIndex = 0;
            this._ImageBox.Text = "imageBox1";
            // 
            // _ImageBoxContextMenuStrip
            // 
            this._ImageBoxContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideInformationToolStripMenuItem});
            this._ImageBoxContextMenuStrip.Name = "_ImageBoxContextMenuStrip";
            this._ImageBoxContextMenuStrip.Size = new System.Drawing.Size(200, 26);
            // 
            // showHideInformationToolStripMenuItem
            // 
            this.showHideInformationToolStripMenuItem.Checked = true;
            this.showHideInformationToolStripMenuItem.CheckOnClick = true;
            this.showHideInformationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showHideInformationToolStripMenuItem.Name = "showHideInformationToolStripMenuItem";
            this.showHideInformationToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.showHideInformationToolStripMenuItem.Text = "Show/Hide information";
            this.showHideInformationToolStripMenuItem.Click += new System.EventHandler(this.showHideInformationToolStripMenuItem_Click);
            // 
            // _ImagePanel
            // 
            this._ImagePanel.AutoScroll = true;
            this._ImagePanel.Controls.Add(this._ImageBox);
            this._ImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ImagePanel.Location = new System.Drawing.Point(3, 16);
            this._ImagePanel.Name = "_ImagePanel";
            this._ImagePanel.Size = new System.Drawing.Size(144, 131);
            this._ImagePanel.TabIndex = 1;
            // 
            // ImageViewerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._ImageGroupBox);
            this.Name = "ImageViewerBox";
            this._ImageGroupBox.ResumeLayout(false);
            this._ImageBoxContextMenuStrip.ResumeLayout(false);
            this._ImagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _ImageGroupBox;
        private ImageBox _ImageBox;
        private System.Windows.Forms.ContextMenuStrip _ImageBoxContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showHideInformationToolStripMenuItem;
        private System.Windows.Forms.Panel _ImagePanel;
    }
}
