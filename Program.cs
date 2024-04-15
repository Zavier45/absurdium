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
    ProductTypeId = 3
},
new Product()
{
    Name = "Potion of Climbing",
    Price = 845.95M,
    Sold = false,
    ProductTypeId = 2
},
new Product()
{
    Name = "Wand of Animal Messenger",
    Price = 682.93M,
    Sold = false,
    ProductTypeId = 4
},
new Product()
{
    Name = "Potion of Stone Giant Strength",
    Price = 517.12M,
    Sold = false,
    ProductTypeId = 2
},
new Product()
{
    Name = "Wand of Conjure Fey",
    Price = 75.73M,
    Sold = false,
    ProductTypeId = 4
},
new Product()
{
    Name = "Universal Solvent",
    Price = 211.21M,
    Sold = true,
    ProductTypeId = 2
},
new Product()
{
    Name = "Adamantine Scale Mail Armour",
    Price = 1272.22M,
    Sold = false,
    ProductTypeId = 1
},
new Product()
{
    Name = "Amulet of Health",
    Price = 613.05M,
    Sold = false,
    ProductTypeId = 1
},
new Product()
{
    Name = "Figurine of Wondrous Power, Obsidian Steed",
    Price = 691.04M,
    Sold = false,
    ProductTypeId = 3
},
new Product()
{
    Name = "Ring of Earth Elemental Command",
    Price = 202.30M,
    Sold = false,
    ProductTypeId = 1
},
new Product()
{
    Name = "Potion of Doxylamine",
    Price = 433.16M,
    Sold = false,
    ProductTypeId = 2
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
1. Browse All Goods
2. Search by Type");
    choice = Console.ReadLine().Trim();

    if (choice == "0")
    {
        Console.WriteLine("Have a magical day!");
    }
    else if (choice == "1")
    {
        ListProducts();
    }
    else if (choice == "2")
    {
        InventorySearch();
    }
}


void ListProductTypes()
{
    foreach (ProductType type in types)
    {
        Console.WriteLine($"{type.ID}. {type.Type}");
    }
}

void ListProducts()
{
    foreach (Product product in inventory)
    {
        Console.WriteLine($"{product.Name} costs {product.Price}.\n");
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