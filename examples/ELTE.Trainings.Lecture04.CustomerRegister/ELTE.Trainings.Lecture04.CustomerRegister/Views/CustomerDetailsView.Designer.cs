namespace ELTE.Trainings.Lecture04.CustomerRegister.Views
{
	partial class CustomerDetailsView
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
			this._CustomerViewLayout = new System.Windows.Forms.TableLayoutPanel();
			this._SaveCustomerButton = new System.Windows.Forms.Button();
			this._CustomerEditLayer = new System.Windows.Forms.TableLayoutPanel();
			this._NameLabel = new System.Windows.Forms.Label();
			this._BirthDateLabel = new System.Windows.Forms.Label();
			this._NameTextBox = new System.Windows.Forms.TextBox();
			this._BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this._AddressGroupBox = new System.Windows.Forms.GroupBox();
			this._AddressDetailsView = new ELTE.Trainings.Lecture04.CustomerRegister.Views.AddressDetailsView();
			this._JobGroupBox = new System.Windows.Forms.GroupBox();
			this._JobDetailsView = new ELTE.Trainings.Lecture04.CustomerRegister.Views.JobDetailsView();
			this._CustomerViewLayout.SuspendLayout();
			this._CustomerEditLayer.SuspendLayout();
			this._AddressGroupBox.SuspendLayout();
			this._JobGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// _CustomerViewLayout
			// 
			this._CustomerViewLayout.ColumnCount = 1;
			this._CustomerViewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._CustomerViewLayout.Controls.Add(this._SaveCustomerButton, 0, 1);
			this._CustomerViewLayout.Controls.Add(this._CustomerEditLayer, 0, 0);
			this._CustomerViewLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CustomerViewLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._CustomerViewLayout.Location = new System.Drawing.Point(0, 0);
			this._CustomerViewLayout.Name = "_CustomerViewLayout";
			this._CustomerViewLayout.RowCount = 2;
			this._CustomerViewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._CustomerViewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._CustomerViewLayout.Size = new System.Drawing.Size(573, 437);
			this._CustomerViewLayout.TabIndex = 0;
			// 
			// _SaveCustomerButton
			// 
			this._SaveCustomerButton.Dock = System.Windows.Forms.DockStyle.Right;
			this._SaveCustomerButton.Location = new System.Drawing.Point(495, 411);
			this._SaveCustomerButton.Name = "_SaveCustomerButton";
			this._SaveCustomerButton.Size = new System.Drawing.Size(75, 23);
			this._SaveCustomerButton.TabIndex = 0;
			this._SaveCustomerButton.Text = "&Save";
			this._SaveCustomerButton.UseVisualStyleBackColor = true;
			this._SaveCustomerButton.Click += new System.EventHandler(this.SaveCustomerButtonClick);
			// 
			// _CustomerEditLayer
			// 
			this._CustomerEditLayer.ColumnCount = 2;
			this._CustomerEditLayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._CustomerEditLayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._CustomerEditLayer.Controls.Add(this._NameLabel, 0, 0);
			this._CustomerEditLayer.Controls.Add(this._BirthDateLabel, 0, 1);
			this._CustomerEditLayer.Controls.Add(this._NameTextBox, 1, 0);
			this._CustomerEditLayer.Controls.Add(this._BirthDateTimePicker, 1, 1);
			this._CustomerEditLayer.Controls.Add(this._AddressGroupBox, 1, 2);
			this._CustomerEditLayer.Controls.Add(this._JobGroupBox, 1, 3);
			this._CustomerEditLayer.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CustomerEditLayer.Location = new System.Drawing.Point(3, 3);
			this._CustomerEditLayer.Name = "_CustomerEditLayer";
			this._CustomerEditLayer.RowCount = 5;
			this._CustomerEditLayer.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._CustomerEditLayer.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._CustomerEditLayer.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._CustomerEditLayer.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._CustomerEditLayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._CustomerEditLayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._CustomerEditLayer.Size = new System.Drawing.Size(567, 402);
			this._CustomerEditLayer.TabIndex = 1;
			// 
			// _NameLabel
			// 
			this._NameLabel.AutoSize = true;
			this._NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._NameLabel.Location = new System.Drawing.Point(3, 0);
			this._NameLabel.Name = "_NameLabel";
			this._NameLabel.Size = new System.Drawing.Size(55, 26);
			this._NameLabel.TabIndex = 0;
			this._NameLabel.Text = "Name:";
			this._NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _BirthDateLabel
			// 
			this._BirthDateLabel.AutoSize = true;
			this._BirthDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._BirthDateLabel.Location = new System.Drawing.Point(3, 26);
			this._BirthDateLabel.Name = "_BirthDateLabel";
			this._BirthDateLabel.Size = new System.Drawing.Size(55, 26);
			this._BirthDateLabel.TabIndex = 2;
			this._BirthDateLabel.Text = "Birth date:";
			this._BirthDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _NameTextBox
			// 
			this._NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._NameTextBox.Location = new System.Drawing.Point(64, 3);
			this._NameTextBox.Name = "_NameTextBox";
			this._NameTextBox.Size = new System.Drawing.Size(500, 20);
			this._NameTextBox.TabIndex = 4;
			// 
			// _BirthDateTimePicker
			// 
			this._BirthDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
			this._BirthDateTimePicker.Location = new System.Drawing.Point(64, 29);
			this._BirthDateTimePicker.Name = "_BirthDateTimePicker";
			this._BirthDateTimePicker.Size = new System.Drawing.Size(500, 20);
			this._BirthDateTimePicker.TabIndex = 5;
			// 
			// _AddressGroupBox
			// 
			this._AddressGroupBox.AutoSize = true;
			this._CustomerEditLayer.SetColumnSpan(this._AddressGroupBox, 2);
			this._AddressGroupBox.Controls.Add(this._AddressDetailsView);
			this._AddressGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._AddressGroupBox.Location = new System.Drawing.Point(3, 55);
			this._AddressGroupBox.Name = "_AddressGroupBox";
			this._AddressGroupBox.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this._AddressGroupBox.Size = new System.Drawing.Size(561, 143);
			this._AddressGroupBox.TabIndex = 7;
			this._AddressGroupBox.TabStop = false;
			this._AddressGroupBox.Text = "Address";
			// 
			// _AddressDetailsView
			// 
			this._AddressDetailsView.AutoSize = true;
			this._AddressDetailsView.Dock = System.Windows.Forms.DockStyle.Top;
			this._AddressDetailsView.Location = new System.Drawing.Point(20, 16);
			this._AddressDetailsView.Margin = new System.Windows.Forms.Padding(0);
			this._AddressDetailsView.Name = "_AddressDetailsView";
			this._AddressDetailsView.Size = new System.Drawing.Size(538, 124);
			this._AddressDetailsView.TabIndex = 6;
			// 
			// _JobGroupBox
			// 
			this._CustomerEditLayer.SetColumnSpan(this._JobGroupBox, 2);
			this._JobGroupBox.Controls.Add(this._JobDetailsView);
			this._JobGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._JobGroupBox.Location = new System.Drawing.Point(3, 204);
			this._JobGroupBox.Name = "_JobGroupBox";
			this._JobGroupBox.Size = new System.Drawing.Size(561, 195);
			this._JobGroupBox.TabIndex = 8;
			this._JobGroupBox.TabStop = false;
			this._JobGroupBox.Text = "Job";
			// 
			// _JobDetailsView
			// 
			this._JobDetailsView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._JobDetailsView.Location = new System.Drawing.Point(3, 16);
			this._JobDetailsView.Name = "_JobDetailsView";
			this._JobDetailsView.Size = new System.Drawing.Size(555, 176);
			this._JobDetailsView.TabIndex = 0;
			// 
			// CustomerDetailsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._CustomerViewLayout);
			this.Name = "CustomerDetailsView";
			this.Size = new System.Drawing.Size(573, 437);
			this._CustomerViewLayout.ResumeLayout(false);
			this._CustomerEditLayer.ResumeLayout(false);
			this._CustomerEditLayer.PerformLayout();
			this._AddressGroupBox.ResumeLayout(false);
			this._AddressGroupBox.PerformLayout();
			this._JobGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel _CustomerViewLayout;
		private System.Windows.Forms.Button _SaveCustomerButton;
		private System.Windows.Forms.TableLayoutPanel _CustomerEditLayer;
		private System.Windows.Forms.Label _NameLabel;
		private System.Windows.Forms.Label _BirthDateLabel;
		private System.Windows.Forms.TextBox _NameTextBox;
		private System.Windows.Forms.DateTimePicker _BirthDateTimePicker;
		private AddressDetailsView _AddressDetailsView;
		private System.Windows.Forms.GroupBox _AddressGroupBox;
		private System.Windows.Forms.GroupBox _JobGroupBox;
		private JobDetailsView _JobDetailsView;
	}
}
