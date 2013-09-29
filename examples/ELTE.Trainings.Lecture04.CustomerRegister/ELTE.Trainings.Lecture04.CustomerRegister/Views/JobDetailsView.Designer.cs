namespace ELTE.Trainings.Lecture04.CustomerRegister.Views
{
	partial class JobDetailsView
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
			this._EmpoyeeTypeLayout = new System.Windows.Forms.TableLayoutPanel();
			this._EmployeeTypeLabel = new System.Windows.Forms.Label();
			this._EmployeeTypeComboxBox = new System.Windows.Forms.ComboBox();
			this._CompanyGroupBox = new System.Windows.Forms.GroupBox();
			this._CompanyLayout = new System.Windows.Forms.TableLayoutPanel();
			this._CompanyNameLabel = new System.Windows.Forms.Label();
			this._CompanyNameTextBox = new System.Windows.Forms.TextBox();
			this._CompanyAddressGroupBox = new System.Windows.Forms.GroupBox();
			this._CompanyAddressDetailsView = new ELTE.Trainings.Lecture04.CustomerRegister.Views.AddressDetailsView();
			this._MainLayoutPanel.SuspendLayout();
			this._EmpoyeeTypeLayout.SuspendLayout();
			this._CompanyGroupBox.SuspendLayout();
			this._CompanyLayout.SuspendLayout();
			this._CompanyAddressGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// _MainLayoutPanel
			// 
			this._MainLayoutPanel.ColumnCount = 1;
			this._MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._MainLayoutPanel.Controls.Add(this._EmpoyeeTypeLayout, 0, 0);
			this._MainLayoutPanel.Controls.Add(this._CompanyGroupBox, 0, 1);
			this._MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this._MainLayoutPanel.Name = "_MainLayoutPanel";
			this._MainLayoutPanel.RowCount = 2;
			this._MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._MainLayoutPanel.Size = new System.Drawing.Size(351, 316);
			this._MainLayoutPanel.TabIndex = 0;
			// 
			// _EmpoyeeTypeLayout
			// 
			this._EmpoyeeTypeLayout.AutoSize = true;
			this._EmpoyeeTypeLayout.ColumnCount = 2;
			this._EmpoyeeTypeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._EmpoyeeTypeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._EmpoyeeTypeLayout.Controls.Add(this._EmployeeTypeLabel, 0, 0);
			this._EmpoyeeTypeLayout.Controls.Add(this._EmployeeTypeComboxBox, 1, 0);
			this._EmpoyeeTypeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this._EmpoyeeTypeLayout.Location = new System.Drawing.Point(0, 0);
			this._EmpoyeeTypeLayout.Margin = new System.Windows.Forms.Padding(0);
			this._EmpoyeeTypeLayout.Name = "_EmpoyeeTypeLayout";
			this._EmpoyeeTypeLayout.RowCount = 1;
			this._EmpoyeeTypeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._EmpoyeeTypeLayout.Size = new System.Drawing.Size(351, 27);
			this._EmpoyeeTypeLayout.TabIndex = 0;
			// 
			// _EmployeeTypeLabel
			// 
			this._EmployeeTypeLabel.AutoSize = true;
			this._EmployeeTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._EmployeeTypeLabel.Location = new System.Drawing.Point(3, 0);
			this._EmployeeTypeLabel.Name = "_EmployeeTypeLabel";
			this._EmployeeTypeLabel.Size = new System.Drawing.Size(79, 27);
			this._EmployeeTypeLabel.TabIndex = 0;
			this._EmployeeTypeLabel.Text = "Employee type:";
			this._EmployeeTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _EmployeeTypeComboxBox
			// 
			this._EmployeeTypeComboxBox.Dock = System.Windows.Forms.DockStyle.Top;
			this._EmployeeTypeComboxBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._EmployeeTypeComboxBox.FormattingEnabled = true;
			this._EmployeeTypeComboxBox.Location = new System.Drawing.Point(88, 3);
			this._EmployeeTypeComboxBox.Name = "_EmployeeTypeComboxBox";
			this._EmployeeTypeComboxBox.Size = new System.Drawing.Size(260, 21);
			this._EmployeeTypeComboxBox.TabIndex = 1;
			// 
			// _CompanyGroupBox
			// 
			this._CompanyGroupBox.Controls.Add(this._CompanyLayout);
			this._CompanyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CompanyGroupBox.Location = new System.Drawing.Point(3, 30);
			this._CompanyGroupBox.Name = "_CompanyGroupBox";
			this._CompanyGroupBox.Size = new System.Drawing.Size(345, 283);
			this._CompanyGroupBox.TabIndex = 1;
			this._CompanyGroupBox.TabStop = false;
			this._CompanyGroupBox.Text = "Company";
			// 
			// _CompanyLayout
			// 
			this._CompanyLayout.ColumnCount = 2;
			this._CompanyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._CompanyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._CompanyLayout.Controls.Add(this._CompanyNameLabel, 0, 0);
			this._CompanyLayout.Controls.Add(this._CompanyNameTextBox, 1, 0);
			this._CompanyLayout.Controls.Add(this._CompanyAddressGroupBox, 0, 1);
			this._CompanyLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CompanyLayout.Location = new System.Drawing.Point(3, 16);
			this._CompanyLayout.Name = "_CompanyLayout";
			this._CompanyLayout.RowCount = 2;
			this._CompanyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._CompanyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._CompanyLayout.Size = new System.Drawing.Size(339, 264);
			this._CompanyLayout.TabIndex = 0;
			// 
			// _CompanyNameLabel
			// 
			this._CompanyNameLabel.AutoSize = true;
			this._CompanyNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CompanyNameLabel.Location = new System.Drawing.Point(3, 0);
			this._CompanyNameLabel.Name = "_CompanyNameLabel";
			this._CompanyNameLabel.Size = new System.Drawing.Size(38, 26);
			this._CompanyNameLabel.TabIndex = 1;
			this._CompanyNameLabel.Text = "Name:";
			this._CompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _CompanyNameTextBox
			// 
			this._CompanyNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CompanyNameTextBox.Location = new System.Drawing.Point(47, 3);
			this._CompanyNameTextBox.Name = "_CompanyNameTextBox";
			this._CompanyNameTextBox.Size = new System.Drawing.Size(289, 20);
			this._CompanyNameTextBox.TabIndex = 2;
			// 
			// _CompanyAddressGroupBox
			// 
			this._CompanyLayout.SetColumnSpan(this._CompanyAddressGroupBox, 2);
			this._CompanyAddressGroupBox.Controls.Add(this._CompanyAddressDetailsView);
			this._CompanyAddressGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CompanyAddressGroupBox.Location = new System.Drawing.Point(3, 29);
			this._CompanyAddressGroupBox.Name = "_CompanyAddressGroupBox";
			this._CompanyAddressGroupBox.Size = new System.Drawing.Size(333, 232);
			this._CompanyAddressGroupBox.TabIndex = 5;
			this._CompanyAddressGroupBox.TabStop = false;
			this._CompanyAddressGroupBox.Text = "Company address";
			// 
			// _CompanyAddressDetailsView
			// 
			this._CompanyAddressDetailsView.AutoSize = true;
			this._CompanyAddressDetailsView.Dock = System.Windows.Forms.DockStyle.Top;
			this._CompanyAddressDetailsView.Location = new System.Drawing.Point(3, 16);
			this._CompanyAddressDetailsView.Name = "_CompanyAddressDetailsView";
			this._CompanyAddressDetailsView.Size = new System.Drawing.Size(327, 104);
			this._CompanyAddressDetailsView.TabIndex = 0;
			// 
			// JobDetailsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._MainLayoutPanel);
			this.Name = "JobDetailsView";
			this.Size = new System.Drawing.Size(351, 316);
			this._MainLayoutPanel.ResumeLayout(false);
			this._MainLayoutPanel.PerformLayout();
			this._EmpoyeeTypeLayout.ResumeLayout(false);
			this._EmpoyeeTypeLayout.PerformLayout();
			this._CompanyGroupBox.ResumeLayout(false);
			this._CompanyLayout.ResumeLayout(false);
			this._CompanyLayout.PerformLayout();
			this._CompanyAddressGroupBox.ResumeLayout(false);
			this._CompanyAddressGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel _MainLayoutPanel;
		private System.Windows.Forms.TableLayoutPanel _EmpoyeeTypeLayout;
		private System.Windows.Forms.Label _EmployeeTypeLabel;
		private System.Windows.Forms.ComboBox _EmployeeTypeComboxBox;
		private System.Windows.Forms.GroupBox _CompanyGroupBox;
		private System.Windows.Forms.TableLayoutPanel _CompanyLayout;
		private System.Windows.Forms.Label _CompanyNameLabel;
		private System.Windows.Forms.TextBox _CompanyNameTextBox;
		private System.Windows.Forms.GroupBox _CompanyAddressGroupBox;
		private AddressDetailsView _CompanyAddressDetailsView;
	}
}
