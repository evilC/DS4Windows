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
            var tester = new Tester();
            Console.ReadLine();
        }

        private class Tester
        {
            public Tester()
            {
                DS4Devices.findControllers();
                IEnumerable<DS4Device> devices = DS4Devices.getDS4Controllers();
                if (devices.Count() == 0)
                {
                    Console.WriteLine("No device found");
                    return;
                }
                else
                {
                    Console.WriteLine("Found a DS4 device");
                }
                DS4Device device = devices.ElementAt(0);
                device.Report += On_Report;
                device.Touchpad.TouchesMoved += touchesMoved;
                device.StartUpdate();
            }

            protected virtual void On_Report(object sender, EventArgs e)
            {
                DS4Device device = (DS4Device)sender;
                var currentState = new DS4State();
                device.getCurrentState(currentState);
                var previousState = new DS4State();
                device.getPreviousState(previousState);
                if (currentState.LX != previousState.LX || currentState.LY != previousState.LY)
                {
                    Console.WriteLine("LSX: {0}, LSY: {1}", currentState.LX, currentState.LY);
                }
            }

            protected virtual void touchesMoved(object sender, EventArgs e)
            {
                var args = (TouchpadEventArgs)e;
                Console.WriteLine("TouchX: {0}, TouchY: {1}", args.touches[0].deltaX, args.touches[0].deltaY);
            }
        }
    }
}
