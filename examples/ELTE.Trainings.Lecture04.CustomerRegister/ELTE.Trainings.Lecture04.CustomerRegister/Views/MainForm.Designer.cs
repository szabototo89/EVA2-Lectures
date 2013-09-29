namespace ELTE.Trainings.Lecture04.CustomerRegister.Views
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
			this._MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this._CustomersGroupBox = new System.Windows.Forms.GroupBox();
			this._CustomerDetailsView = new ELTE.Trainings.Lecture04.CustomerRegister.Views.CustomerDetailsView();
			this._CustomerListView = new ELTE.Trainings.Lecture04.CustomerRegister.Views.CustomerListView();
			this._CustomerGroupBox = new System.Windows.Forms.GroupBox();
			this._MainLayoutPanel.SuspendLayout();
			this._CustomersGroupBox.SuspendLayout();
			this._CustomerGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// _MainLayoutPanel
			// 
			this._MainLayoutPanel.ColumnCount = 2;
			this._MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this._MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
			this._MainLayoutPanel.Controls.Add(this._CustomerGroupBox, 1, 0);
			this._MainLayoutPanel.Controls.Add(this._CustomersGroupBox, 0, 0);
			this._MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this._MainLayoutPanel.Name = "_MainLayoutPanel";
			this._MainLayoutPanel.RowCount = 1;
			this._MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._MainLayoutPanel.Size = new System.Drawing.Size(592, 500);
			this._MainLayoutPanel.TabIndex = 0;
			// 
			// _CustomersGroupBox
			// 
			this._CustomersGroupBox.Controls.Add(this._CustomerListView);
			this._CustomersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CustomersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._CustomersGroupBox.Location = new System.Drawing.Point(3, 3);
			this._CustomersGroupBox.Name = "_CustomersGroupBox";
			this._CustomersGroupBox.Size = new System.Drawing.Size(191, 494);
			this._CustomersGroupBox.TabIndex = 2;
			this._CustomersGroupBox.TabStop = false;
			this._CustomersGroupBox.Text = "Customers";
			// 
			// _CustomerDetailsView
			// 
			this._CustomerDetailsView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CustomerDetailsView.Location = new System.Drawing.Point(3, 16);
			this._CustomerDetailsView.Name = "_CustomerDetailsView";
			this._CustomerDetailsView.Size = new System.Drawing.Size(383, 475);
			this._CustomerDetailsView.TabIndex = 1;
			// 
			// _CustomerListView
			// 
			this._CustomerListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CustomerListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._CustomerListView.Location = new System.Drawing.Point(3, 16);
			this._CustomerListView.Name = "_CustomerListView";
			this._CustomerListView.Size = new System.Drawing.Size(185, 475);
			this._CustomerListView.TabIndex = 0;
			// 
			// _CustomerGroupBox
			// 
			this._CustomerGroupBox.Controls.Add(this._CustomerDetailsView);
			this._CustomerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CustomerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._CustomerGroupBox.Location = new System.Drawing.Point(200, 3);
			this._CustomerGroupBox.Name = "_CustomerGroupBox";
			this._CustomerGroupBox.Size = new System.Drawing.Size(389, 494);
			this._CustomerGroupBox.TabIndex = 3;
			this._CustomerGroupBox.TabStop = false;
			this._CustomerGroupBox.Text = "Customer";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 500);
			this.Controls.Add(this._MainLayoutPanel);
			this.Name = "MainForm";
			this.Text = "Customer Register";
			this._MainLayoutPanel.ResumeLayout(false);
			this._CustomersGroupBox.ResumeLayout(false);
			this._CustomerGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel _MainLayoutPanel;
		private CustomerListView _CustomerListView;
		private CustomerDetailsView _CustomerDetailsView;
		private System.Windows.Forms.GroupBox _CustomersGroupBox;
		private System.Windows.Forms.GroupBox _CustomerGroupBox;

	}
}

