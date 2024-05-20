using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_7
{
    public class GamePers<T> where T : IWeapon
    {
        string Name {  get; set; }
        string Raise {  get; set; }

        public T Weapon { get; set; }
       
        public GamePers(string name, string raise, T weapon)
        {
            Name = name;
            Raise = raise;
            Weapon = weapon;
        }

        public void Print()
        {
            Console.WriteLine($"Имя: {Name}, Расса: {Raise}, Оружие: ");
            Sword.
        }
    }
}
