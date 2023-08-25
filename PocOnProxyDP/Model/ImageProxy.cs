using System;
using System.Collections.Generic;
using System.Text;

namespace PocOnProxyDP.Model
{
    class ImageProxy : IImage
    {
        private RealImage realImage;
        private string fileName;

        public ImageProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.Display();
        }
    }
}
