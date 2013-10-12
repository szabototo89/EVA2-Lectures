using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ELTE.Trainings.Lecture05.ImageViewer.Models
{
    public static class ImageManager
    {
        public static IEnumerable<ImageInfo> GetImagesFromDirectory(string directory)
        {
            if (string.IsNullOrWhiteSpace(directory))
                throw new ArgumentNullException("directory");

            if (!Directory.Exists(directory))
                throw new Exception(string.Format("This directory ({0}) does not exist!", directory));

            var directoryInfo = new DirectoryInfo(directory);
            return directoryInfo.GetFiles("*.jpg", SearchOption.TopDirectoryOnly)
                .Select(file => new ImageInfo(file.FullName));
        }
    }
}