using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELTE.Trainings.Lecture05.ImageViewer.Models
{
    #region 1. ImageInfo osztály
    
    public class ImageInfo
    {
        public ImageInfo(string fullPath)
        {
            if (string.IsNullOrWhiteSpace(fullPath))
                throw new ArgumentNullException("fullPath");

            FullPath = fullPath;
        }

        public string FullPath { get; protected set; }
    }
    
    #endregion
}
