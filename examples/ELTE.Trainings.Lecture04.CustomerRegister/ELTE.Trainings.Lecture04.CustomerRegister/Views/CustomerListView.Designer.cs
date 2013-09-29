namespace ELTE.Trainings.Lecture04.CustomerRegister.Views
{
	partial class CustomerListView
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
			this._LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this._SearchBoxLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this._SearchTextBox = new System.Windows.Forms.TextBox();
			this._SearchButton = new System.Windows.Forms.Button();
			this._ListBox = new System.Windows.Forms.ListBox();
			this._ToolsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this._ClearButton = new System.Windows.Forms.Button();
			this._RemoveButton = new System.Windows.Forms.Button();
			this._AddCustomerButton = new System.Windows.Forms.Button();
			this._LayoutPanel.SuspendLayout();
			this._SearchBoxLayoutPanel.SuspendLayout();
			this._ToolsLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _LayoutPanel
			// 
			this._LayoutPanel.ColumnCount = 1;
			this._LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._LayoutPanel.Controls.Add(this._SearchBoxLayoutPanel, 0, 0);
			this._LayoutPanel.Controls.Add(this._ListBox, 0, 1);
			this._LayoutPanel.Controls.Add(this._ToolsLayoutPanel, 0, 2);
			this._LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._LayoutPanel.Location = new System.Drawing.Point(0, 0);
			this._LayoutPanel.Name = "_LayoutPanel";
			this._LayoutPanel.RowCount = 3;
			this._LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this._LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._LayoutPanel.Size = new System.Drawing.Size(346, 302);
			this._LayoutPanel.TabIndex = 0;
			// 
			// _SearchBoxLayoutPanel
			// 
			this._SearchBoxLayoutPanel.ColumnCount = 2;
			this._SearchBoxLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._SearchBoxLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._SearchBoxLayoutPanel.Controls.Add(this._SearchTextBox, 0, 0);
			this._SearchBoxLayoutPanel.Controls.Add(this._SearchButton, 1, 0);
			this._SearchBoxLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this._SearchBoxLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this._SearchBoxLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this._SearchBoxLayoutPanel.Name = "_SearchBoxLayoutPanel";
			this._SearchBoxLayoutPanel.RowCount = 1;
			this._SearchBoxLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._SearchBoxLayoutPanel.Size = new System.Drawing.Size(346, 25);
			this._SearchBoxLayoutPanel.TabIndex = 0;
			// 
			// _SearchTextBox
			// 
			this._SearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._SearchTextBox.Location = new System.Drawing.Point(3, 3);
			this._SearchTextBox.Name = "_SearchTextBox";
			this._SearchTextBox.Size = new System.Drawing.Size(259, 20);
			this._SearchTextBox.TabIndex = 1;
			this._SearchTextBox.Enter += new System.EventHandler(this.SearchTextBoxEnter);
			// 
			// _SearchButton
			// 
			this._SearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this._SearchButton.Location = new System.Drawing.Point(268, 3);
			this._SearchButton.Name = "_SearchButton";
			this._SearchButton.Size = new System.Drawing.Size(75, 20);
			this._SearchButton.TabIndex = 2;
			this._SearchButton.Text = "Search";
			this._SearchButton.UseVisualStyleBackColor = true;
			this._SearchButton.Click += new System.EventHandler(this.SearchButtonClick);
			// 
			// _ListBox
			// 
			this._ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._ListBox.FormattingEnabled = true;
			this._ListBox.Location = new System.Drawing.Point(3, 28);
			this._ListBox.Name = "_ListBox";
			this._ListBox.Size = new System.Drawing.Size(340, 242);
			this._ListBox.TabIndex = 1;
			// 
			// _ToolsLayoutPanel
			// 
			this._ToolsLayoutPanel.AutoSize = true;
			this._ToolsLayoutPanel.ColumnCount = 3;
			this._ToolsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this._ToolsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this._ToolsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this._ToolsLayoutPanel.Controls.Add(this._ClearButton, 2, 0);
			this._ToolsLayoutPanel.Controls.Add(this._RemoveButton, 1, 0);
			this._ToolsLayoutPanel.Controls.Add(this._AddCustomerButton, 0, 0);
			this._ToolsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._ToolsLayoutPanel.Location = new System.Drawing.Point(0, 273);
			this._ToolsLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this._ToolsLayoutPanel.Name = "_ToolsLayoutPanel";
			this._ToolsLayoutPanel.RowCount = 1;
			this._ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._ToolsLayoutPanel.Size = new System.Drawing.Size(346, 29);
			this._ToolsLayoutPanel.TabIndex = 2;
			// 
			// _ClearButton
			// 
			this._ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this._ClearButton.Location = new System.Drawing.Point(233, 3);
			this._ClearButton.Name = "_ClearButton";
			this._ClearButton.Size = new System.Drawing.Size(110, 23);
			this._ClearButton.TabIndex = 2;
			this._ClearButton.Text = "Clear";
			this._ClearButton.UseVisualStyleBackColor = true;
			this._ClearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// _RemoveButton
			// 
			this._RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this._RemoveButton.Location = new System.Drawing.Point(118, 3);
			this._RemoveButton.Name = "_RemoveButton";
			this._RemoveButton.Size = new System.Drawing.Size(109, 23);
			this._RemoveButton.TabIndex = 1;
			this._RemoveButton.Text = "Remove";
			this._RemoveButton.UseVisualStyleBackColor = true;
			this._RemoveButton.Click += new System.EventHandler(this.RemoveButtonClick);
			// 
			// _AddCustomerButton
			// 
			this._AddCustomerButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this._AddCustomerButton.Location = new System.Drawing.Point(3, 3);
			this._AddCustomerButton.Name = "_AddCustomerButton";
			this._AddCustomerButton.Size = new System.Drawing.Size(109, 23);
			this._AddCustomerButton.TabIndex = 0;
			this._AddCustomerButton.Text = "Add";
			this._AddCustomerButton.UseVisualStyleBackColor = true;
			this._AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButtonClick);
			// 
			// CustomerListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._LayoutPanel);
			this.Name = "CustomerListView";
			this.Size = new System.Drawing.Size(346, 302);
			this._LayoutPanel.ResumeLayout(false);
			this._LayoutPanel.PerformLayout();
			this._SearchBoxLayoutPanel.ResumeLayout(false);
			this._SearchBoxLayoutPanel.PerformLayout();
			this._ToolsLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel _LayoutPanel;
		private System.Windows.Forms.TableLayoutPanel _SearchBoxLayoutPanel;
		private System.Windows.Forms.TextBox _SearchTextBox;
		private System.Windows.Forms.ListBox _ListBox;
		private System.Windows.Forms.Button _SearchButton;
		private System.Windows.Forms.TableLayoutPanel _ToolsLayoutPanel;
		private System.Windows.Forms.Button _ClearButton;
		private System.Windows.Forms.Button _RemoveButton;
		private System.Windows.Forms.Button _AddCustomerButton;
	}
}
