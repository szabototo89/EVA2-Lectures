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
        private string _currentDirectory;

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
            CurrentDirectory = @"e:\Images\saját\";
        } 

        private MainForm AddImageViewPage(TabControl tabControl, ImageInfo info)
        {
            if (tabControl == null)
                throw new ArgumentNullException("tabControl");

            if (info == null)
                throw new ArgumentNullException("info");

            var tabPage = new TabPage(info.FullPath);
            var image = new ImageViewerBox { ImageInfo = info, Dock = DockStyle.Fill };
            tabPage.Controls.Add(image);

            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;

            return this;
        }

        private MainForm UpdateImageList(ListBox listView, string directory)
        {
            if (listView == null)
                throw new ArgumentNullException("listView");

            listView.Items.Clear();

            var images = ImageManager.GetImagesFromDirectory(directory);

            listView.Items.AddRange(
                images.ToArray()
            );

            listView.DisplayMember = "FullPath";

            return this;
        }

        private void _ImagesListView_DoubleClick(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;
            if (listBox == null)
                return;

            foreach (ImageInfo item in listBox.SelectedItems) {
                AddImageViewPage(_MainTabControl, item);
            }
        }

        private void _ChangeDirectoryButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    CurrentDirectory = dialog.SelectedPath;
                    _MainTabControl.TabPages.Clear();
                }
            }
        }
    }
}
