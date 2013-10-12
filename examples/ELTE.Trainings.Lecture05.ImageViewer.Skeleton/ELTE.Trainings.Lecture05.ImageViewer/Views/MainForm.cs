using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ELTE.Trainings.Lecture05.ImageViewer.Models;
using ELTE.Trainings.Lecture05.ImageViewer.Views;

namespace ELTE.Trainings.Lecture05.ImageViewer
{
    public partial class MainForm : Form
    {
        #region 1. Inicializálás
      
        private string _currentDirectory;

        /// <summary>
        /// Az éppen használt könyvtárat tudjuk beállítani segítségével
        /// </summary>
        public string CurrentDirectory
        {
            get { return _currentDirectory; }
            set
            {
                _currentDirectory = value;
                _DirectoryLabel.Text = value;
                UpdateImageList(_ImagesListBox, value);
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }
        

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            CurrentDirectory = @"C:\";
        } 
       
        #endregion

        #region 2. Új kép megnyitása
        
        private MainForm AddImageViewPage(TabControl tabControl, ImageInfo info)
        {
            if (tabControl == null)
                throw new ArgumentNullException("tabControl");

            if (info == null)
                throw new ArgumentNullException("info");

            var tabPage = new TabPage(info.FullPath);   //készítünk egy új fület
            // Példányosítjuk a saját vezérlőnket
            var image = new ImageViewerBox { 
                ImageInfo = info, 
                Dock = DockStyle.Fill
            };
            tabPage.Controls.Add(image);    //majd hozzáadjuk a beállított vezérlőnket az új oldal tartalmához

            tabControl.TabPages.Add(tabPage); 
            tabControl.SelectedTab = tabPage; 

            return this;
        }
        
        #endregion

        #region 3. Képlista frissítése
       
        private MainForm UpdateImageList(ListBox listBox, string directory)
        {
            if (listBox == null)
                throw new ArgumentNullException("listBox");

            listBox.Items.Clear();

            //Lekérjük a képeket az adott könyvtárból
            var images = ImageManager.GetImagesFromDirectory(directory);

            listBox.Items.AddRange(images.ToArray());  //hozzáadjuk a megjelenítendő listához a képek információit

            listBox.DisplayMember = "FullPath"; //viszont nem akarjuk az egészet megjeleníteni, hanem csak a FullPath tulajdonságát

            return this;
        }
        
        #endregion

        #region 4. Kép kiválasztása
        
        private void _ImagesListView_DoubleClick(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;
            if (listBox == null)
                return;

            foreach (ImageInfo item in listBox.SelectedItems) {
                AddImageViewPage(_MainTabControl, item);    //megnyitjuk a képet egy új fülön
            }
        }
        
        #endregion

        #region 5. Új mappa választása
       
        private void _ChangeDirectoryButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())  // a könyvtár váltásához segítségül hívunk egy dialógus ablakot
            {
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (dialog.ShowDialog() == DialogResult.OK) //ha a felhasználó elfogadta az adott könyvtárat, akkor belépünk az elágazásba
                {
                    CurrentDirectory = dialog.SelectedPath; // kinyerjük a kiválasztott könyvtár elérési útját
                    _MainTabControl.TabPages.Clear();   // az eddig megnyitott képeket bezárjuk
                }
            }
        }
        
        #endregion
    }
}
