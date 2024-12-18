using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PP5
{
    internal class Character
    {
        public string Name { get; set; }
        public string House { get; set; }
        public List<string> Inventory { get; set; }
        public Wand EquippedWand { get; set; }
        public int Money { get; set; }

        public Character(string name, string house)
        {
            Name = name;
            House = house;
            Inventory = new List<string>();
            EquippedWand = null;
            Money = 200;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name} ");
            Console.WriteLine($"House: {House} ");
            Console.WriteLine($"Money: {Money}");
            Console.WriteLine("Inventory: " + (Inventory.Count > 0 ? string.Join(", ", Inventory) : "Nothing"));
        }

        public void Buy(IShopItem shopItem)
        {
            if (Money >= shopItem.Price)
            {
                Money -= shopItem.Price;
                if (shopItem is Wand)
                {
                    EquippedWand = (Wand)shopItem;
                    Inventory.Add(shopItem.Name);
                }
                else if(shopItem is Pet)
                {
                    Console.WriteLine("Name your pet");
                    Pet newPet = (Pet)shopItem;
                    newPet.Rename();

                    Inventory.Add(newPet.Petname);
                }
                Console.WriteLine($"You have bought {shopItem.Name} for {shopItem.Price}");
            }
            else
            {
                Console.WriteLine("Poor");
            }

        }

        public void CastSpell()
        {
            if(EquippedWand != null) {
                while (true)
                {
                    Console.WriteLine("Type a spell");
                    string spellInput = Console.ReadLine();
                    EquippedWand.Use();
                    switch (spellInput.ToLower())
                    {
                        case "wingardium leviosa":
                            Console.WriteLine("Something flies away from your life");
                            break;
                        case "hokus pocus":
                            Console.WriteLine("Something blows up");
                            break;
                        case "accio":
                            Console.WriteLine("Something hits you in your face");
                            break;
                        case "obliviate":
                            Console.WriteLine("You forget what you were doing");
                            break;
                        case "motherload":
                            Money += 200;
                            Console.WriteLine("You got 200 money");
                            break;
                        default:
                            Console.WriteLine("Your wand sparkles. Wrong spell?");
                            return;
                    }
                }
            }
            else
            {
                Console.WriteLine("No wand, waving your hands didnt work");
            }
        }
    }
}
