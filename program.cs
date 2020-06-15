using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Program
    {
        static void Main(string[] args)
        {
            computer Asus = new computer()
            {
                model = "123",
                screenSize = 22.0f,
                numberOfProcessors = 4,
                price = 2500
            };

            computer Dell = new computer()
            {
                model = "didi",
                screenSize = 21.2f,
                numberOfProcessors = 2,
                price = 1800
            };

            computer Mac = new computer()
            {
                model = "MacBook",
                screenSize = 24.0f,
                numberOfProcessors = 4,
                price = 6000
            };

            int MacPrice = Mac.tellMeThePrice();
            float screenSize = Mac.TellMeTheScreenSize();
            Mac.turnOn();
            Mac.addProcessor();
            string TS = Mac.ToString();
            Console.WriteLine($"My MacBook\n price:{MacPrice} \nScreen Size:{screenSize} \nIs turn on?:");
           
        }
    }
}
