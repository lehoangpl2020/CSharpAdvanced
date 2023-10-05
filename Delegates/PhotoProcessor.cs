using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path)
        {
            var photo = Photo.Load(path);

            var photoFilters = new PhotoFilters();
            photoFilters.ApplyBrightness(photo);
            photoFilters.ApplyHue(photo);
            photoFilters.ApplySaturation(photo);

            photo.Save();
        }

        public void Process_UsingDelegate(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }

        public void Process_UsingAction(string path, Action<Photo> filter)
        {
            var photo = Photo.Load(path);

            filter(photo);

            photo.Save();
        }
    }
}
