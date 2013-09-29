namespace ELTE.Trainings.Lecture04.CustomerRegister.Tests.Utils
{
	partial class UserControlTestForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._MainMenuStrip = new System.Windows.Forms.MenuStrip();
			this._ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._CreateSnapshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._ControlGroupBox = new System.Windows.Forms.GroupBox();
			this._MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this._StatusStrip = new System.Windows.Forms.StatusStrip();
			this._StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this._MainMenuStrip.SuspendLayout();
			this._MainLayoutPanel.SuspendLayout();
			this._StatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// _MainMenuStrip
			// 
			this._MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ToolsToolStripMenuItem});
			this._MainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this._MainMenuStrip.Name = "_MainMenuStrip";
			this._MainMenuStrip.Size = new System.Drawing.Size(782, 24);
			this._MainMenuStrip.TabIndex = 0;
			this._MainMenuStrip.Text = "menuStrip1";
			// 
			// _ToolsToolStripMenuItem
			// 
			this._ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._CreateSnapshotToolStripMenuItem});
			this._ToolsToolStripMenuItem.Name = "_ToolsToolStripMenuItem";
			this._ToolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this._ToolsToolStripMenuItem.Text = "Tools";
			// 
			// _CreateSnapshotToolStripMenuItem
			// 
			this._CreateSnapshotToolStripMenuItem.Name = "_CreateSnapshotToolStripMenuItem";
			this._CreateSnapshotToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this._CreateSnapshotToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this._CreateSnapshotToolStripMenuItem.Text = "Create snapshot";
			this._CreateSnapshotToolStripMenuItem.Click += new System.EventHandler(this.CreateSnapshotToolStripMenuItemClick);
			// 
			// _ControlGroupBox
			// 
			this._ControlGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._ControlGroupBox.Location = new System.Drawing.Point(3, 3);
			this._ControlGroupBox.Name = "_ControlGroupBox";
			this._ControlGroupBox.Size = new System.Drawing.Size(776, 458);
			this._ControlGroupBox.TabIndex = 1;
			this._ControlGroupBox.TabStop = false;
			this._ControlGroupBox.Text = "Control";
			this._ControlGroupBox.UseCompatibleTextRendering = true;
			// 
			// _MainLayoutPanel
			// 
			this._MainLayoutPanel.ColumnCount = 1;
			this._MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._MainLayoutPanel.Controls.Add(this._StatusStrip, 0, 1);
			this._MainLayoutPanel.Controls.Add(this._ControlGroupBox, 0, 0);
			this._MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._MainLayoutPanel.Location = new System.Drawing.Point(0, 24);
			this._MainLayoutPanel.Name = "_MainLayoutPanel";
			this._MainLayoutPanel.RowCount = 2;
			this._MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._MainLayoutPanel.Size = new System.Drawing.Size(782, 486);
			this._MainLayoutPanel.TabIndex = 0;
			// 
			// _StatusStrip
			// 
			this._StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._StatusLabel});
			this._StatusStrip.Location = new System.Drawing.Point(0, 464);
			this._StatusStrip.Name = "_StatusStrip";
			this._StatusStrip.Size = new System.Drawing.Size(782, 22);
			this._StatusStrip.TabIndex = 2;
			this._StatusStrip.Text = "statusStrip1";
			// 
			// _StatusLabel
			// 
			this._StatusLabel.Name = "_StatusLabel";
			this._StatusLabel.Size = new System.Drawing.Size(0, 17);
			this._StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// UserControlTestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(782, 510);
			this.Controls.Add(this._MainLayoutPanel);
			this.Controls.Add(this._MainMenuStrip);
			this.MainMenuStrip = this._MainMenuStrip;
			this.Name = "UserControlTestForm";
			this.Text = "UserControl testing form";
			this._MainMenuStrip.ResumeLayout(false);
			this._MainMenuStrip.PerformLayout();
			this._MainLayoutPanel.ResumeLayout(false);
			this._MainLayoutPanel.PerformLayout();
			this._StatusStrip.ResumeLayout(false);
			this._StatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip _MainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem _ToolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _CreateSnapshotToolStripMenuItem;
		private System.Windows.Forms.GroupBox _ControlGroupBox;
		private System.Windows.Forms.TableLayoutPanel _MainLayoutPanel;
		private System.Windows.Forms.StatusStrip _StatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel _StatusLabel;
	}
}