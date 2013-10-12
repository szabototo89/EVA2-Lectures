using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ELTE.Trainings.Lecture05.ImageViewer.Models;

namespace ELTE.Trainings.Lecture05.ImageViewer.Views
{
    public partial class ImageViewerBox : UserControl
    {
        public ImageInfo ImageInfo
        {
            get
            {
                if (_ImageBox == null)
                    return null;
                return _ImageBox.ImageInfo;
            }
            set
            {
                if (_ImageBox != null)
                    _ImageBox.ImageInfo = value;
            }
        }

        public ImageViewerBox()
        {
            InitializeComponent();
        }

        private void showHideInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = (sender as ToolStripMenuItem);

            if (menuItem != null)
                _ImageBox.ShowImageInformation = menuItem.Checked;
        }
    }
}
