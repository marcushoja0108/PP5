using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP5
{
    internal class Wand : IShopItem 
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public string SpellSound { get; private set; }

        public Wand(string name, int price, string sound)
        {
            Name = name;
            Price = price;
            SpellSound = sound;
        }

        public void Use()
        {
            Console.WriteLine(SpellSound);
        }
    }
}
