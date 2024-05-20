using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace С_7
{
    public struct Sword : IWeapon
    {
        public string Quality {  get; set; }
        public static string Name { get; set; }
        public int Force { get; set; }
        public string Properties { get; set; }
        public Sword(string name, int force,string properies, string quality)
        {
            Name = name;
            Force = force;
            Properties = properies;
            Quality = quality;
        }
        public void Print()
        {
            System.Console.WriteLine($"{Name}, {Force}, {Quality}, {Properties}");
        }
    }
}
