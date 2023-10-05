using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }
        public void ApplyHue(Photo photo)
        {
            Console.WriteLine("Apply Hue");
        }
        public void ApplySaturation(Photo photo)
        {
            Console.WriteLine("Apply saturation");
        }
    }
}
