namespace ELTE.Trainings.Lecture04.CustomerRegister.Views
{
	partial class AddressDetailsView
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
			this._CountryLabel = new System.Windows.Forms.Label();
			this._CityLabel = new System.Windows.Forms.Label();
			this._PostCodeLabel = new System.Windows.Forms.Label();
			this._StreetLabel = new System.Windows.Forms.Label();
			this._CountryTextBox = new System.Windows.Forms.TextBox();
			this._CityTextBox = new System.Windows.Forms.TextBox();
			this._PostCodeTextBox = new System.Windows.Forms.TextBox();
			this._StreetTextBox = new System.Windows.Forms.TextBox();
			this._MainLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _MainLayoutPanel
			// 
			this._MainLayoutPanel.AutoSize = true;
			this._MainLayoutPanel.ColumnCount = 2;
			this._MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._MainLayoutPanel.Controls.Add(this._CountryLabel, 0, 0);
			this._MainLayoutPanel.Controls.Add(this._CityLabel, 0, 1);
			this._MainLayoutPanel.Controls.Add(this._PostCodeLabel, 0, 2);
			this._MainLayoutPanel.Controls.Add(this._StreetLabel, 0, 3);
			this._MainLayoutPanel.Controls.Add(this._CountryTextBox, 1, 0);
			this._MainLayoutPanel.Controls.Add(this._CityTextBox, 1, 1);
			this._MainLayoutPanel.Controls.Add(this._PostCodeTextBox, 1, 2);
			this._MainLayoutPanel.Controls.Add(this._StreetTextBox, 1, 3);
			this._MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this._MainLayoutPanel.Name = "_MainLayoutPanel";
			this._MainLayoutPanel.RowCount = 5;
			this._MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._MainLayoutPanel.Size = new System.Drawing.Size(583, 231);
			this._MainLayoutPanel.TabIndex = 0;
			// 
			// _CountryLabel
			// 
			this._CountryLabel.AutoSize = true;
			this._CountryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CountryLabel.Location = new System.Drawing.Point(3, 0);
			this._CountryLabel.Name = "_CountryLabel";
			this._CountryLabel.Size = new System.Drawing.Size(55, 26);
			this._CountryLabel.TabIndex = 0;
			this._CountryLabel.Text = "Country:";
			this._CountryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _CityLabel
			// 
			this._CityLabel.AutoSize = true;
			this._CityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CityLabel.Location = new System.Drawing.Point(3, 26);
			this._CityLabel.Name = "_CityLabel";
			this._CityLabel.Size = new System.Drawing.Size(55, 26);
			this._CityLabel.TabIndex = 1;
			this._CityLabel.Text = "City:";
			this._CityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _PostCodeLabel
			// 
			this._PostCodeLabel.AutoSize = true;
			this._PostCodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._PostCodeLabel.Location = new System.Drawing.Point(3, 52);
			this._PostCodeLabel.Name = "_PostCodeLabel";
			this._PostCodeLabel.Size = new System.Drawing.Size(55, 26);
			this._PostCodeLabel.TabIndex = 2;
			this._PostCodeLabel.Text = "Postcode:";
			this._PostCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _StreetLabel
			// 
			this._StreetLabel.AutoSize = true;
			this._StreetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._StreetLabel.Location = new System.Drawing.Point(3, 78);
			this._StreetLabel.Name = "_StreetLabel";
			this._StreetLabel.Size = new System.Drawing.Size(55, 26);
			this._StreetLabel.TabIndex = 3;
			this._StreetLabel.Text = "Street:";
			this._StreetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _CountryTextBox
			// 
			this._CountryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CountryTextBox.Location = new System.Drawing.Point(64, 3);
			this._CountryTextBox.Name = "_CountryTextBox";
			this._CountryTextBox.Size = new System.Drawing.Size(516, 20);
			this._CountryTextBox.TabIndex = 4;
			this._CountryTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CountryTextBoxValidating);
			// 
			// _CityTextBox
			// 
			this._CityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CityTextBox.Location = new System.Drawing.Point(64, 29);
			this._CityTextBox.Name = "_CityTextBox";
			this._CityTextBox.Size = new System.Drawing.Size(516, 20);
			this._CityTextBox.TabIndex = 5;
			// 
			// _PostCodeTextBox
			// 
			this._PostCodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._PostCodeTextBox.Location = new System.Drawing.Point(64, 55);
			this._PostCodeTextBox.Name = "_PostCodeTextBox";
			this._PostCodeTextBox.Size = new System.Drawing.Size(516, 20);
			this._PostCodeTextBox.TabIndex = 6;
			// 
			// _StreetTextBox
			// 
			this._StreetTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._StreetTextBox.Location = new System.Drawing.Point(64, 81);
			this._StreetTextBox.Name = "_StreetTextBox";
			this._StreetTextBox.Size = new System.Drawing.Size(516, 20);
			this._StreetTextBox.TabIndex = 7;
			// 
			// AddressDetailsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this._MainLayoutPanel);
			this.Name = "AddressDetailsView";
			this.Size = new System.Drawing.Size(583, 231);
			this._MainLayoutPanel.ResumeLayout(false);
			this._MainLayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel _MainLayoutPanel;
		private System.Windows.Forms.Label _CountryLabel;
		private System.Windows.Forms.Label _CityLabel;
		private System.Windows.Forms.Label _PostCodeLabel;
		private System.Windows.Forms.Label _StreetLabel;
		private System.Windows.Forms.TextBox _CountryTextBox;
		private System.Windows.Forms.TextBox _CityTextBox;
		private System.Windows.Forms.TextBox _PostCodeTextBox;
		private System.Windows.Forms.TextBox _StreetTextBox;
	}
}
