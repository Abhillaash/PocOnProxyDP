using System;
using System.Collections.Generic;
using System.Text;

namespace PocOnProxyDP.Model
{
    class RealImage : IImage
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            LoadImageFromDisk();
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine("Loading image: " + fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying image: " + fileName);
        }
    }
}
