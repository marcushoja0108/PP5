using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP5
{
    internal class MagicShop
    {
        public List<IShopItem> Inventory;

        public MagicShop()
        {
            Inventory = new List<IShopItem>
            {
                new Wand("Elder wand", 200, "Bzzzzzz"),
                new Wand("Walnut wand", 100, "Woosh"),
                new Wand("Ash wand", 50, "Bop"),
                new Pet("Owl", 150),
                new Pet("Rat", 90),
                new Pet("Cat", 120),
            };
        }


        public void AltShopMenu(Character character)
        {
            Console.WriteLine("Store inventory");
            foreach (var item in Inventory) 
            {
                Console.WriteLine($"{item.Name}     Price: {item.Price}");
            }
            Console.WriteLine("Type the name of the item you want to buy");
            IShopItem selection = FindItemByName();

            if (selection != null) 
            {
                character.Buy(selection);
            }
            else
            {
                Console.WriteLine("Not a valid name");
            }

        }

        public IShopItem FindItemByName()
        {
            string userinput = Console.ReadLine();

            return Inventory.FirstOrDefault(item => item.Name == userinput);
        }
        public void ShopMenu(Character character)
        {
            //Wand elder = new Wand("Elder wand", 200, "Bzzzzzz");
            //Wand walnut = new Wand("Walnut wand", 100, "Woosh");
            //Wand ash = new Wand("Ash wand", 50, "Bop");
            //    while (true)
            //    {
            //        Console.WriteLine("Welcome too the magic shop please chose what too buy");
            //        Console.WriteLine("1. Elder Wand");
            //        Console.WriteLine("2. Walnut Wand");
            //        Console.WriteLine("3. Ash Wand");
            //        Console.WriteLine("4. Owl");
            //        Console.WriteLine("5. Rat");
            //        Console.WriteLine("6. Cat");
            //        Console.WriteLine("7. Exit Shop");


            //        string choice = Console.ReadLine();

            //        switch (choice)
            //        {
            //            case "1":
            //                character.Inventory.Add("Elder Wand");
            //                character.Buy(elder);
            //                break;
            //            case "2":
            //                character.Buy(walnut);
            //                character.Inventory.Add("Walnut Wand");
            //                break;
            //            case "3":
            //                character.Buy(ash);
            //                character.Inventory.Add("Ash Wand");
            //                break;
            //            case "4":
            //                character.Inventory.Add("Owl");
            //                break;
            //            case "5":
            //                character.Inventory.Add("Rat");
            //                break;
            //            case "6":
            //                character.Inventory.Add("Cat");
            //                break;
            //            case "7":
            //                return;
            //            default:
            //                Console.WriteLine("not a proper choice");
            //                break;
            //        }
            //    }
        }
    }
}
