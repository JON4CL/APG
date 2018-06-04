using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APG
{
    class ImageTools
    {
        private ImageTools() { }

        static public Image ImageFromBase64(string base64String)
        {
            Image image;
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                image = Image.FromStream(ms, true);
            }
            return image;
        }

        static public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            string base64String;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                base64String = Convert.ToBase64String(imageBytes);
            }
            return base64String;
        }
    }
}
