using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Lumpkin_Dalton
{
    internal class Computer : IBootUp
    {
        string Brand { get; set; }
        string Type { get; set; }

        public bool IsOn { get; set; }

        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;

        }

        public void PowerOnOff()
        {
            IsOn = !IsOn;

            if (IsOn) { Console.WriteLine("The Computer is booting up..."); }
            else { Console.WriteLine("The Computer is shutting down..."); }
        }

        public override string ToString()
        {
            return $"This is a {Type} computer by {Brand}.";
        }
    }
}
