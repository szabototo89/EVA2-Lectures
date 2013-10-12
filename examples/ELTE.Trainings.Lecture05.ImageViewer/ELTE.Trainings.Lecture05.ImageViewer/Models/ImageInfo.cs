using System.Text;
using System.Threading.Tasks;

namespace ELTE.Trainings.Lecture05.ImageViewer.Models
{
    public class ImageInfo
    {
        public ImageInfo(string fullPath)
        {
            FullPath = fullPath;
        }

        public string FullPath { get; protected set; }
    }
}
