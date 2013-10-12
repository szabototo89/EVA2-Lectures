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
            this._MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._SearchTextBox = new System.Windows.Forms.TextBox();
            this._SearchButton = new System.Windows.Forms.Button();
            this._CustomerListBox = new System.Windows.Forms.ListBox();
            this._AddButton = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this._ClearButton = new System.Windows.Forms.Button();
            this._MainLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _MainLayoutPanel
            // 
            this._MainLayoutPanel.ColumnCount = 1;
            this._MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._MainLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this._MainLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this._MainLayoutPanel.Controls.Add(this._CustomerListBox, 0, 1);
            this._MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._MainLayoutPanel.Name = "_MainLayoutPanel";
            this._MainLayoutPanel.RowCount = 3;
            this._MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._MainLayoutPanel.Size = new System.Drawing.Size(346, 302);
            this._MainLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this._SearchTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._SearchButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 29);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this._AddButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Remove, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this._ClearButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 270);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(340, 29);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // _SearchTextBox
            // 
            this._SearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._SearchTextBox.Location = new System.Drawing.Point(3, 3);
            this._SearchTextBox.Name = "_SearchTextBox";
            this._SearchTextBox.Size = new System.Drawing.Size(253, 20);
            this._SearchTextBox.TabIndex = 0;
            // 
            // _SearchButton
            // 
            this._SearchButton.Location = new System.Drawing.Point(262, 3);
            this._SearchButton.Name = "_SearchButton";
            this._SearchButton.Size = new System.Drawing.Size(75, 23);
            this._SearchButton.TabIndex = 1;
            this._SearchButton.Text = "Search";
            this._SearchButton.UseVisualStyleBackColor = true;
            this._SearchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // _CustomerListBox
            // 
            this._CustomerListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._CustomerListBox.FormattingEnabled = true;
            this._CustomerListBox.Location = new System.Drawing.Point(10, 45);
            this._CustomerListBox.Margin = new System.Windows.Forms.Padding(10);
            this._CustomerListBox.Name = "_CustomerListBox";
            this._CustomerListBox.Size = new System.Drawing.Size(326, 212);
            this._CustomerListBox.TabIndex = 2;
            // 
            // _AddButton
            // 
            this._AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._AddButton.Location = new System.Drawing.Point(3, 3);
            this._AddButton.Name = "_AddButton";
            this._AddButton.Size = new System.Drawing.Size(107, 23);
            this._AddButton.TabIndex = 0;
            this._AddButton.Text = "Add";
            this._AddButton.UseVisualStyleBackColor = true;
            this._AddButton.Click += new System.EventHandler(this.AddCustomerButtonClick);
            // 
            // Remove
            // 
            this.Remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Remove.Location = new System.Drawing.Point(116, 3);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(107, 23);
            this.Remove.TabIndex = 1;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.RemoveButtonClick);
            // 
            // _ClearButton
            // 
            this._ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ClearButton.Location = new System.Drawing.Point(229, 3);
            this._ClearButton.Name = "_ClearButton";
            this._ClearButton.Size = new System.Drawing.Size(108, 23);
            this._ClearButton.TabIndex = 2;
            this._ClearButton.Text = "Clear";
            this._ClearButton.UseVisualStyleBackColor = true;
            this._ClearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // CustomerListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._MainLayoutPanel);
            this.Name = "CustomerListView";
            this.Size = new System.Drawing.Size(346, 302);
            this._MainLayoutPanel.ResumeLayout(false);
            this._MainLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.TableLayoutPanel _MainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox _SearchTextBox;
        private System.Windows.Forms.Button _SearchButton;
        private System.Windows.Forms.Button _AddButton;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button _ClearButton;
        private System.Windows.Forms.ListBox _CustomerListBox;

    }
}
