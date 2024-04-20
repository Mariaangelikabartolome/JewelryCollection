using JewelryCollection;
using JewelryCollectionBL;
namespace JewelryCollectionMainUI;
public class Program
{
    public static void Main(string[] args)
    {
        Box box = new Box();

        Console.WriteLine("Enter username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Enter password: ");
        string password = Console.ReadLine();

        BusinessLogic userService = new BusinessLogic();
        bool result = userService.VerifyUserLogin(username, password);

        if (result)
        {
            Console.WriteLine("Login Successful");
        }
        else
        {
            Console.WriteLine("Login Unsuccessful");
        }

        {
            while (true)
            {
                Console.WriteLine("Welcome to Maria's Jewelry Box!");
                Console.WriteLine("Select an accessory:");
                Console.WriteLine("1, Display List: ");
                Console.WriteLine("2. Necklace");
                Console.WriteLine("3. Ring");
                Console.WriteLine("4. Earring");
                Console.WriteLine("5. Bracelet");
                Console.WriteLine("6. Add Jewelry");
                Console.WriteLine("7. Remove Jewelry");
                Console.WriteLine("8. Exit");
                Console.Write("Select from 1-8: ");

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 8)
                {
                    Console.WriteLine("Invalid input. Please select from numbers between 1 and 8.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(
                             "\n Necklace " +
                             "\n Model: Sparkling Bow Necklace" +
                             "\n Brand: Pandora" +
                             "" +
                             "\n Ring  " +
                             "\n Model: Love Wedding Band" +
                             "\n Brand: Cartier" +
                             "" +
                             "\n Earrings " +
                             "\n Model:  Tiffany Lock, White Gold with Diamonds" +
                             "\n Brand: Tiffany&Co" +
                             "" +
                             "\n Bracelet " +
                             "\n Model: Hole In One Statement Charm Bracelet" +
                             "\n Brand: KateSpade",
                             "     ");
                        break;
                    case 2:
                        box.DisplayJewelryInfo(choice);
                        break;
                    case 3:
                        box.DisplayJewelryInfo(choice);
                        break;
                    case 4:
                        box.DisplayJewelryInfo(choice);
                        break;
                    case 5:
                        box.DisplayJewelryInfo(choice);
                        break;
                    case 6:
                        AddJewelry(box);
                        break;
                    case 7:
                        RemoveJewelry(box); ;
                        break;
                    case 8:
                        Console.WriteLine("Close");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                
            }
           
        }

        static void AddJewelry(Box box)
        {
            Console.WriteLine("Enter the details of the jewelry:");
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Jewelry newJewelry = new Jewelry() { model = model, brand = brand, description = description };

            Console.WriteLine("Select the type of jewelry to add:");
            Console.WriteLine("1. Necklace");
            Console.WriteLine("2. Ring");
            Console.WriteLine("3. Earrings");
            Console.WriteLine("4. Bracelet");
            Console.Write("Enter your choice (1-4): ");

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                return;
            }

            switch (choice)
            {
                case 2:
                    box.AddNecklace(newJewelry);
                    break;
                case 3:
                    box.AddRing(newJewelry);
                    break;
                case 4:
                    box.AddEarrings(newJewelry);
                    break;
                case 5:
                    box.AddBracelet(newJewelry);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
           
            Console.WriteLine("Jewelry added successfully.");
            Console.WriteLine("\nUpdated List of Added Jewelry:");
            box.DisplayJewelryInfo(choice);

            return;
        }

        static void RemoveJewelry(Box box)
        {
            Console.WriteLine("Enter the model of the jewelry to remove:");
            string model = Console.ReadLine();

            Console.WriteLine("Select the type of jewelry to remove from:");
            Console.WriteLine("1. Necklace");
            Console.WriteLine("2. Ring");
            Console.WriteLine("3. Earrings");
            Console.WriteLine("4. Bracelet");
            Console.Write("Enter your choice (1-4): ");

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                return;
            }

            switch (choice)
            {
                case 1:
                    box.RemoveNecklace(model);
                    break;
                case 2:
                    box.RemoveRing(model);
                    break;
                case 3:
                    box.RemoveEarrings(model);
                    break;
                case 4:
                    box.RemoveBracelet(model);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            return;
            }
        }


    }
