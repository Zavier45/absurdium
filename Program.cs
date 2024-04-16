Console.Clear();
string greeting = @"Welcome to the Reductio & Absurdum Emporium!
All your magic needs met in one place!";

List<Product> inventory = new List<Product>
{
new Product()
{
    Name = "Defensive Greataxe",
    Price = 710.73M,
    Sold = true,
    ProductTypeId = 3,
    DateStocked = new DateTime(2023, 8, 15)
},
new Product()
{
    Name = "Potion of Climbing",
    Price = 845.95M,
    Sold = false,
    ProductTypeId = 2,
    DateStocked = new DateTime(2022,6, 4)
},
new Product()
{
    Name = "Wand of Animal Messenger",
    Price = 682.93M,
    Sold = false,
    ProductTypeId = 4,
    DateStocked = new DateTime(2022, 6, 21)
},
new Product()
{
    Name = "Potion of Stone Giant Strength",
    Price = 517.12M,
    Sold = false,
    ProductTypeId = 2,
    DateStocked = new DateTime(2022, 8, 13)
},
new Product()
{
    Name = "Wand of Conjure Fey",
    Price = 75.73M,
    Sold = false,
    ProductTypeId = 4,
    DateStocked = new DateTime(2023, 12, 18)
},
new Product()
{
    Name = "Universal Solvent",
    Price = 211.21M,
    Sold = true,
    ProductTypeId = 2,
    DateStocked = new DateTime(2023, 4, 26)
},
new Product()
{
    Name = "Adamantine Scale Mail Armour",
    Price = 1272.22M,
    Sold = false,
    ProductTypeId = 1,
    DateStocked = new DateTime(2023, 6, 19)
},
new Product()
{
    Name = "Amulet of Health",
    Price = 613.05M,
    Sold = false,
    ProductTypeId = 1,
    DateStocked = new DateTime(2024, 1, 9)
},
new Product()
{
    Name = "Figurine of Wondrous Power, Obsidian Steed",
    Price = 691.04M,
    Sold = false,
    ProductTypeId = 3,
    DateStocked = new DateTime(2023, 5, 9)
},
new Product()
{
    Name = "Ring of Earth Elemental Command",
    Price = 202.30M,
    Sold = false,
    ProductTypeId = 1,
    DateStocked = new DateTime(2024, 1, 29)
},
new Product()
{
    Name = "Potion of Doxylamine",
    Price = 433.16M,
    Sold = false,
    ProductTypeId = 2,
    DateStocked = new DateTime(2024, 3, 24)
}
};

List<ProductType> types = new List<ProductType>
{
new ProductType()
{
    ID = 1,
    Type = "Apparel"
},
new ProductType()
{
    ID = 2,
    Type = "Potion"
},
new ProductType()
{
    ID = 3,
    Type = "Enchanted Object"
},
new ProductType()
{
    ID = 4,
    Type = "Wand"
}
};

string choice = null;
Console.WriteLine(greeting);

while (choice != "0")
{

    Console.WriteLine(@"What would you like to do?
0. Exit
1. Browse All Available Inventory
2. Search by Type
3. Add New Item");
    choice = Console.ReadLine().Trim();

    if (choice == "0")
    {
        Console.WriteLine("Have a magical day!");
    }
    else if (choice == "1")
    {
        ListAvailableProducts();
    }
    else if (choice == "2")
    {
        InventorySearch();
    }
    else if (choice == "3")
    {
        AddNewItem();
    }
}


void ListProductTypes()
{

    foreach (ProductType type in types)
    {
        Console.WriteLine($"{type.ID}. {type.Type}");
    }
}

void ListAvailableProducts()
{
    List<Product> availableItems = inventory.Where(item => !item.Sold).ToList();
    foreach (Product item in availableItems)
    {
        Console.WriteLine(@$"{item.Name}
    This {item.Name} costs {item.Price}.
    It has been on the shelves for {item.DaysOnShelf} days.
    ");
    }
}

void InventorySearch()
{
    int requestedType = 0;
    while (requestedType == 0)
    {
        try
        {
            Console.WriteLine("What type of item can we find for you today?\n");
            ListProductTypes();
            requestedType = int.Parse(Console.ReadLine());
            if (requestedType >= 1 && requestedType <= 4)
            {
                List<Product> requestedProducts = inventory.Where(product => product.ProductTypeId == requestedType).ToList();
                Console.WriteLine(@$"Here are all products that fit your requested type:");
                foreach (Product product in requestedProducts)
                {
                    Console.WriteLine(@$"{product.Name}.
                This item costs {product.Price}.");
                }
            }

        }
        catch (FormatException)
        {
            Console.WriteLine("Beloved patron, that was not a number. Please select the appropriate number option.");
        }
    }
}

void AddNewItem()
{
    Console.WriteLine(@"Whipped up something new in the lab or cauldron? 
Fill out the following information and we'll get it added to the shelves!");
    string name = null;
    decimal price = 0M;
    int productTypeId = 0;
    int year = 0;
    int month = 0;
    int day = 0;

    while (name == null)
    {
        try
        {
            Console.WriteLine("What is the name of the item?");
            name = Console.ReadLine();
        }
        catch (FormatException)
        {
            Console.WriteLine("That is not a name in any recognized language, and we speak all 700. Try again.");
        }
    }
    while (price == 0M)
    {
        try
        {
            Console.Write("Price: ");
            price = decimal.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("That was not a value for any known monetary amount. Please try again.");
        }
    }
    while (productTypeId == 0)
    {
        try
        {
            Console.Write("Please select a type from the following list:\n");
            ListProductTypes();
            productTypeId = int.Parse(Console.ReadLine().Trim());

        }
        catch (FormatException)
        {
            Console.WriteLine("That was not an option. Try again.");
        }
    }
    while (year == 0)
    {
        try
        {
            Console.Write("Year: ");
            year = int.Parse(Console.ReadLine().Trim());
        }
        catch (FormatException)
        {
            Console.WriteLine("Not a valid year. Try again.");
        }
    }
    while (month == 0)
    {
        try
        {
            Console.Write("Month: ");
            month = int.Parse(Console.ReadLine().Trim());
        }
        catch (FormatException)
        {
            Console.WriteLine("Not a valid month. Please try again.");
        }
    }
    while (day == 0)
    {
        try
        {
            Console.Write("Day:");
            day = int.Parse(Console.ReadLine().Trim());
        }
        catch (FormatException)
        {
            Console.WriteLine("Not a valid day. Please try again.");
        }
    }
    DateTime dateStocked = new DateTime(year, month, day);
    inventory.Add(new Product()
    {
        Name = name,
        Price = price,
        Sold = false,
        ProductTypeId = productTypeId,
        DateStocked = dateStocked
    }
    );

}