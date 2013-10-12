namespace ELTE.Trainings.Lecture05.ImageViewer
{
    partial class MainForm
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
            this._MainTabControl = new System.Windows.Forms.TabControl();
            this._SplitContainer = new System.Windows.Forms.SplitContainer();
            this._ImagesListBox = new System.Windows.Forms.ListBox();
            this._LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._ChangeDirectoryButton = new System.Windows.Forms.Button();
            this._DirectoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._SplitContainer)).BeginInit();
            this._SplitContainer.Panel1.SuspendLayout();
            this._SplitContainer.Panel2.SuspendLayout();
            this._SplitContainer.SuspendLayout();
            this._LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _MainTabControl
            // 
            this._MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._MainTabControl.Location = new System.Drawing.Point(0, 0);
            this._MainTabControl.Name = "_MainTabControl";
            this._MainTabControl.SelectedIndex = 0;
            this._MainTabControl.Size = new System.Drawing.Size(436, 416);
            this._MainTabControl.TabIndex = 0;
            // 
            // _SplitContainer
            // 
            this._SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._SplitContainer.Location = new System.Drawing.Point(0, 0);
            this._SplitContainer.Name = "_SplitContainer";
            // 
            // _SplitContainer.Panel1
            // 
            this._SplitContainer.Panel1.Controls.Add(this._LayoutPanel);
            // 
            // _SplitContainer.Panel2
            // 
            this._SplitContainer.Panel2.Controls.Add(this._MainTabControl);
            this._SplitContainer.Size = new System.Drawing.Size(660, 416);
            this._SplitContainer.SplitterDistance = 220;
            this._SplitContainer.TabIndex = 1;
            // 
            // _ImagesListBox
            // 
            this._ImagesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ImagesListBox.FormattingEnabled = true;
            this._ImagesListBox.Location = new System.Drawing.Point(3, 23);
            this._ImagesListBox.Name = "_ImagesListBox";
            this._ImagesListBox.Size = new System.Drawing.Size(214, 361);
            this._ImagesListBox.TabIndex = 1;
            this._ImagesListBox.DoubleClick += new System.EventHandler(this._ImagesListView_DoubleClick);
            // 
            // _LayoutPanel
            // 
            this._LayoutPanel.ColumnCount = 1;
            this._LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._LayoutPanel.Controls.Add(this._ImagesListBox, 0, 1);
            this._LayoutPanel.Controls.Add(this._ChangeDirectoryButton, 0, 2);
            this._LayoutPanel.Controls.Add(this._DirectoryLabel, 0, 0);
            this._LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._LayoutPanel.Name = "_LayoutPanel";
            this._LayoutPanel.RowCount = 3;
            this._LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._LayoutPanel.Size = new System.Drawing.Size(220, 416);
            this._LayoutPanel.TabIndex = 2;
            // 
            // _ChangeDirectoryButton
            // 
            this._ChangeDirectoryButton.AutoSize = true;
            this._ChangeDirectoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ChangeDirectoryButton.Location = new System.Drawing.Point(3, 390);
            this._ChangeDirectoryButton.Name = "_ChangeDirectoryButton";
            this._ChangeDirectoryButton.Size = new System.Drawing.Size(214, 23);
            this._ChangeDirectoryButton.TabIndex = 2;
            this._ChangeDirectoryButton.Text = "Change Directory";
            this._ChangeDirectoryButton.UseVisualStyleBackColor = true;
            this._ChangeDirectoryButton.Click += new System.EventHandler(this._ChangeDirectoryButton_Click);
            // 
            // _DirectoryLabel
            // 
            this._DirectoryLabel.AutoSize = true;
            this._DirectoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._DirectoryLabel.Location = new System.Drawing.Point(3, 0);
            this._DirectoryLabel.Name = "_DirectoryLabel";
            this._DirectoryLabel.Size = new System.Drawing.Size(214, 20);
            this._DirectoryLabel.TabIndex = 3;
            this._DirectoryLabel.Text = "[ Current directory information ]";
            this._DirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 416);
            this.Controls.Add(this._SplitContainer);
            this.Name = "MainForm";
            this.Text = "Image Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this._SplitContainer.Panel1.ResumeLayout(false);
            this._SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._SplitContainer)).EndInit();
            this._SplitContainer.ResumeLayout(false);
            this._LayoutPanel.ResumeLayout(false);
            this._LayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _MainTabControl;
        private System.Windows.Forms.SplitContainer _SplitContainer;
        private System.Windows.Forms.ListBox _ImagesListBox;
        private System.Windows.Forms.TableLayoutPanel _LayoutPanel;
        private System.Windows.Forms.Button _ChangeDirectoryButton;
        private System.Windows.Forms.Label _DirectoryLabel;

    }
}

