using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELTE.Trainings.Lecture04.CustomerRegister.Tests.Utils
{
	public static class FormUtils
	{
		public static Bitmap TakeSnapshotFromControl(Control control)
		{
			if (control == null) throw new ArgumentNullException("control");

			var bitmap = new Bitmap(control.Width, control.Height);
			control.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Size.Width, bitmap.Size.Height));
			return bitmap;
		}

		public static void SaveBitmapToClipboard(Bitmap bitmap)
		{
			if (bitmap == null) throw new ArgumentNullException("bitmap");
			Clipboard.SetImage(bitmap);
		}
	}
}
