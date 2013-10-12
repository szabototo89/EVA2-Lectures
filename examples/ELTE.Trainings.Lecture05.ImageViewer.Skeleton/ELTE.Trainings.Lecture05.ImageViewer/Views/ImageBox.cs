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
        #region 1. Adattagok
        private bool _showImageInformation;
        private ImageInfo _imageInfo;

        /// <summary>
        /// Itt tároljuk a megjelenítendő képet 
        /// </summary>
        protected Image Image { get; set; } 

        /// <summary>
        /// Itt tároljuk a megjelenítendő kép információit tároló  
        /// </summary>
        public ImageInfo ImageInfo
        {
            get { return _imageInfo; }
            set
            {
                _imageInfo = value;
                if (value != null) {
                    Image = LoadImage(value); // Azonnal frissítjuk a megjelenítendő képet
                    Refresh();
                } 
            }
        }

        /// <summary>
        /// Igazzal tér vissza, ha szeretnénk megjeleníteni az információs dobozunkat 
        /// </summary>
        public bool ShowImageInformation
        {
            get { return _showImageInformation; }
            set
            {
                _showImageInformation = value;
                Refresh();  // ahhoz, hogy a felhasználó egyből láthassa a változást, frissíteni kell a vezérlőt
            }
        }
       
        #endregion

        #region 2. Konstruktor
       
        public ImageBox()
        {
            DoubleBuffered = true;  //ahhoz, hogy a kép átméretezéskor nem villogjon dupla bufferelést kell használnunk
            ShowImageInformation = true; 
        }
        #endregion

        #region 3. Kirajzolásért felelős metódus
       
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var graphics = e.Graphics;  // lekérjük a Graphics objektumot

            if (ImageInfo == null)
                return;

            var height = ((double)Width / Image.Width) * Image.Height;  //kiszámítjuk a képünk magasságát

            graphics.DrawImage(Image, new Rectangle(0, 0, Width, (int)height)); //megjelenítjük a képet
            
         #region Információs doboz megjelenítése
            if (ShowImageInformation) { 
                var informations = new[]
                {
                    string.Format("Path: {0}", ImageInfo.FullPath),
                    string.Format("Width: {0}", Image.Width),
                    string.Format("Height: {0}", Image.Height),
                };  //meghatározzuk a, hogy milyen információkat szeretnénk megjeleníteni

                const int linePadding = 5;  //sorok közötti távolságot is beállítjuk

                var infoBoxSize = informations.Select(info => graphics.MeasureString(info, Font))   //kiszámoljuk, hogy pontosan mennyi helyet is fog foglalni a szövegünk
                    .Aggregate(new Size(),
                        (left, right) => new Size((int)Math.Max(left.Width, right.Width) + 10,
                            (int)(left.Height + right.Height + linePadding)));

                var rectangle = new Rectangle(new Point(10, 10), infoBoxSize);  //miután megvan az információs dobozunk mérete, azután az információs doboz helyét és méretét eltároljuk egy változóba
                graphics.FillRectangle(Brushes.LimeGreen, rectangle);   //zölddel kifestjük a téglalapunkat
                graphics.DrawRectangle(Pens.White, rectangle);          //adunk neki egy fehér keretet

                //és a legvégén kiírjuk az információkat
                for (var i = 0; i < informations.Length; i++) {
                    var size = graphics.MeasureString(informations[i], Font);  
                    graphics.DrawString(informations[i], Font, Brushes.White, 15, size.Height * i + linePadding + 10);
                }
            }
           #endregion
        }
        
        #endregion

        #region 4. Kép betöltése
        
        private Image LoadImage(ImageInfo info)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            if (!File.Exists(info.FullPath))
                throw new Exception("Image is not found!");

            return Image.FromFile(info.FullPath);   //egyszerűen betöltjük a fájlból a képet
        }
       
        #endregion

        #region 5. Méretezésért felelős metódus
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Refresh();  //átméretezés után frissítjük a vezérlőnket, emiatt újra meghívja a rajzolásért felelős metódust
        }
       
        #endregion
    }
}
