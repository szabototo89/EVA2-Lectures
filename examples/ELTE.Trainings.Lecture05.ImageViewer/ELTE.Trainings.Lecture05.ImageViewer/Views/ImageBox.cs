using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ELTE.Trainings.Lecture05.ImageViewer.Models;

namespace ELTE.Trainings.Lecture05.ImageViewer.Views
{
    public class ImageBox : Control
    {
        private bool _showImageInformation;
        private ImageInfo _imageInfo;

        protected Image Image { get; set; }

        public ImageInfo ImageInfo
        {
            get { return _imageInfo; }
            set
            {
                _imageInfo = value;
                if (value != null)
                    Image = LoadImage(value);
            }
        }

        public bool ShowImageInformation
        {
            get { return _showImageInformation; }
            set
            {
                _showImageInformation = value;
                Refresh();
            }
        }

        public ImageBox()
        {
            //DoubleBuffered = true;
            ShowImageInformation = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var graphics = e.Graphics;

            if (ImageInfo == null)
                return;

            var height = ((double)Width / Image.Width) * Image.Height;


            graphics.DrawImage(Image, new Rectangle(0, 0, Width, (int)height));

            if (ShowImageInformation) {
                var informations = new[]
                {
                    string.Format("Path: {0}", ImageInfo.FullPath),
                    string.Format("Width: {0}", Image.Width),
                    string.Format("Height: {0}", Image.Height)
                };

                const int linePadding = 5;

                var infoBoxSize = informations.Select(info => graphics.MeasureString(info, Font))
                    .Aggregate(new Size(),
                        (left, right) => new Size((int)Math.Max(left.Width, right.Width) + 10,
                            (int)(left.Height + right.Height + linePadding)));

                var rectangle = new Rectangle(new Point(10, 10), infoBoxSize);
                graphics.FillRectangle(Brushes.LimeGreen, rectangle);
                graphics.DrawRectangle(Pens.White, rectangle);

                for (var i = 0; i < informations.Length; i++) {
                    var size = graphics.MeasureString(informations[i], Font);
                    graphics.DrawString(informations[i], Font, Brushes.White, 15, size.Height * i + linePadding + 10);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Refresh();
        }

        private Image LoadImage(ImageInfo info)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            if (!File.Exists(info.FullPath))
                throw new Exception("Image is not found!");

            return Image.FromFile(info.FullPath);
        }
    }
}
