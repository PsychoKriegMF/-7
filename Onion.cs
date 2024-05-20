using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_7
{
    public struct Onion : IWeapon
    {
        public int Range {  get; set; }
        public int Accuracy {  get; set; }
        public static string Name { get; set; }
        public int Force { get; set; }
        public string Properties { get; set; }
        public Onion(string name, int force, string properies, int range, int accuracy)
        {
            Name = name;
            Force = force;
            Properties = properies;
            Range = range;
            Accuracy = accuracy;
        }
        public void Print()
        {
            System.Console.WriteLine($"{Name}, {Force}, {Range}, {Properties}, {Accuracy}");
        }

    }
}
