using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP5
{
    internal class Pet : IShopItem
    {
        public string Name { get; set; }
        public string Petname { get; set; }
        public int Price {  get; set; }

        public Pet(string name, int price)
        {
            Name = name;
            Petname = null;
            Price = price;
        }

        public void Rename()
        {
            string newPetName = Console.ReadLine();
            Petname = newPetName;
        }
    }
}
