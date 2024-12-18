// See https://aka.ms/new-console-template for more information
using PP5;


main();
static void main()
{
    Character marcus = new Character("Marcus the wise", "Ravenclaw");


    while (true)
    {
        Console.WriteLine("Pick your choice");
        Console.WriteLine("1. Show Character");
        Console.WriteLine("2. Got too Magic Shop");
        Console.WriteLine("3. Cast a Spell");
        Console.WriteLine("4. quit");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                marcus.Show();
                break;
            case "2":
                MagicShop shop = new MagicShop();
                shop.AltShopMenu(marcus);
                //shop.ShopMenu(marcus);
                break;
            case "3":
                marcus.CastSpell();
                break;
            case "4":
                return;
                break;
            default:
                Console.WriteLine("not a proper choice");
                break;
        }

    }
}
