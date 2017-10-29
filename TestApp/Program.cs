using DS4Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DS4Devices.findControllers();
            IEnumerable<DS4Device> devices = DS4Devices.getDS4Controllers();
            if (devices.Count() == 0)
            {
                Console.WriteLine("No device found");
                return;
            }
            DS4Device device = devices.ElementAt(0);
        }
    }
}
