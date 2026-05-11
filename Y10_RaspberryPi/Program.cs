using System.Device.Gpio;
using System.Threading;

namespace Y10_RaspberryPi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GpioController controller = new GpioController(PinNumberingScheme.Board);
            int pin = 36;
            int lightTime = 500;

            for (int i = 0; i < 10; i++)
            {
                controller.OpenPin(pin, PinMode.Output);

                Console.WriteLine("On "); // Output to console for debugging 
                controller.Write(pin, PinValue.High);

                Thread.Sleep(lightTime);
                Console.WriteLine("Off ");
                controller.Write(pin, PinValue.Low);
                controller.ClosePin(pin);
                Thread.Sleep(lightTime);
            }

            Console.WriteLine("Press a key:");
            Console.ReadLine();


        }
    }
}
