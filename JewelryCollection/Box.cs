using JewelryCollection;

public class Box
{
    public List<Jewelry> NecklaceL = new List<Jewelry>();
    public List<Jewelry> RingL = new List<Jewelry>();
    public List<Jewelry> EarringsL = new List<Jewelry>();
    public List<Jewelry> BraceletL = new List<Jewelry>();
    public Box()
    {
        Jewelry Necklace = new Jewelry();
        Necklace.model = "Love Wedding Band";
        Necklace.brand = "Cartier";
        Necklace.description = "Yellow Gold. Width: 3.6 mm";
        NecklaceL.Add(Necklace);

        Jewelry Ring = new Jewelry();
        Ring.model = "Sparkling Bow Necklace,";
        Ring.brand = "Pandora";
        Ring.description = "Sterling silver. size: 50";
        RingL.Add(Ring);

        Jewelry Earrings = new Jewelry();
        Earrings.model = "Tiffany Lock, White Gold with Diamonds";
        Earrings.brand = "Tiffany&Co";
        Earrings.description = "Medium";
        EarringsL.Add(Earrings);

        Jewelry Bracelet = new Jewelry();
        Bracelet.model = "Hole In One Statement Charm Bracelet";
        Bracelet.brand = "Katespade";
        Bracelet.description = "Chain length: 8 Weight: 35.95g";
        BraceletL.Add(Bracelet);
    }
    public void AddNecklace(Jewelry jewelry)
    {
        NecklaceL.Add(jewelry);
    }

    public void AddRing(Jewelry jewelry)
    {
        RingL.Add(jewelry);
    }

    public void AddEarrings(Jewelry jewelry)
    {
        EarringsL.Add(jewelry);
    }

    public void AddBracelet(Jewelry jewelry)
    {
        BraceletL.Add(jewelry);
    }

    public void RemoveNecklace(string model)
    {
        Jewelry jewelryToRemove = NecklaceL.Find(jewelry => jewelry.model == jewelry.model);
        if (jewelryToRemove != null)
            NecklaceL.Remove(jewelryToRemove);
        else
            Console.WriteLine("Necklace not found.");
    }

    public void RemoveRing(string model)
    {
        Jewelry jewelryToRemove = RingL.Find(j => j.model == model);
        if (jewelryToRemove != null)
            RingL.Remove(jewelryToRemove);
        else
            Console.WriteLine("Ring not found.");
    }

    public void RemoveEarrings(string model)
    {
        Jewelry jewelryToRemove = EarringsL.Find(j => j.model == model);
        if (jewelryToRemove != null)
            EarringsL.Remove(jewelryToRemove);
        else
            Console.WriteLine("Earrings not found.");
    }

    public void RemoveBracelet(string model)
    {
        Jewelry jewelryToRemove = BraceletL.Find(j => j.model == model);
        if (jewelryToRemove != null)
            BraceletL.Remove(jewelryToRemove);
        else
            Console.WriteLine("Bracelet not found.");
    }

    public void DisplayJewelryInfo(int choice)
    {
        switch (choice)
        {
            case 2:
                Console.WriteLine("Necklaces:");
                foreach (var jewelry in NecklaceL)
                {
                    Console.WriteLine($"Model: {jewelry.model}, Description: {jewelry.description}");
                }
                break;

            case 3:
                Console.WriteLine("Rings:");
                foreach (var jewelry in RingL)
                {
                    Console.WriteLine($"Model: {jewelry.model}, Description: {jewelry.description}");
                }
                break;

            case 4:
                Console.WriteLine("Earrings:");
                foreach (var jewelry in EarringsL)
                {
                    Console.WriteLine($"Model: {jewelry.model}, Description: {jewelry.description}");
                }
                break;

            case 5:
                Console.WriteLine("Bracelets:");
                foreach (var jewelry in BraceletL)
                {
                    Console.WriteLine($"Model: {jewelry.model}, Description: {jewelry.description}");
                }
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
    public void DisplayAddedJewelryInfo(int choice)
    {
        switch (choice)
        {
            case 2:
                Console.WriteLine("Necklaces:");
                foreach (var jewelry in NecklaceL)
                {
                    Console.WriteLine($"Model: {jewelry.model}, Description: {jewelry.description}");
                }
                break;

            case 3:
                Console.WriteLine("Rings:");
                foreach (var jewelry in RingL)
                {
                    Console.WriteLine($"Model: {jewelry.model}, Description: {jewelry.description}");
                }
                break;

            case 4:
                Console.WriteLine("Earrings:");
                foreach (var jewelry in EarringsL)
                {
                    Console.WriteLine($"Model: {jewelry.model}, Description: {jewelry.description}");
                }
                break;

            case 5:
                Console.WriteLine("Bracelets:");
                foreach (var jewelry in BraceletL)
                {
                    Console.WriteLine($"Model: {jewelry.model}, Description: {jewelry.description}");
                }
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;

        }

            }

        }
    
