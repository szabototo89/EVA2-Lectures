using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ELTE.Trainings.Lecture04.CustomerRegister.Tests.Utils
{
	public partial class UserControlTestForm : Form
	{
		public Control Control { get; protected set; }

		public UserControlTestForm(Control control)
		{
			InitializeComponent();
			InitializeTestForm(control);
		}

		private void InitializeTestForm(Control control)
		{
			if (control == null)
				throw new ArgumentNullException("control");

			Control = control;
			Control.Dock = DockStyle.Fill;
			Control.AutoSize = true;
			_ControlGroupBox.Controls.Add(control);
			_ControlGroupBox.Text = string.Format("Control - {0}", control.GetType().FullName);
			AutoSize = true;
			Text = string.Format("UserControl testing form - {0}", control.GetType().Name);
			LogStatusMessage("Control is initialized ...");
		}

		private void CreateSnapshotToolStripMenuItemClick(object sender, EventArgs e)
		{
			FormUtils.SaveBitmapToClipboard(
				FormUtils.TakeSnapshotFromControl(Control)
			);

			LogStatusMessage("Control is copied to clipboard successful!");
		}

		private UserControlTestForm ClearStatusMessage()
		{
			_StatusLabel.Text = string.Empty;
			return this;
		}

		private UserControlTestForm LogStatusMessage(string message)
		{
			_StatusLabel.Text = message;
			return this;
		}
	}
}
