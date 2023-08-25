using System;
using PocOnProxyDP.Model;
namespace PocOnProxyDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IImage image1 = new ImageProxy("image1.jpg");
            IImage image2 = new ImageProxy("image2.jpg");

            image1.Display(); 
            image2.Display(); 
        }
    }
}
