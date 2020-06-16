using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    public class computer
    {
        public string model;
        public int price;
        public int numberOfProcessors;
        public float screenSize;
        public bool isTurnOn;

        public int tellMeThePrice()
        {
            return price;
        }
        public float TellMeTheScreenSize()
        {
            return screenSize;
        }
        public void turnOn()
        {
           
        }
        public void turnOff()
        {
          
        }
        public void addProcessor()
        {
           
        }
        public override string ToString()
        {
            return $"[Computer] : Model:{model} Price:{price} Screen Size:{screenSize}";
        }
    }
}
