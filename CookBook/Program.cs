using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace CookBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var controller = new Controller();
            controller.Run();
        }
        
    }
}
