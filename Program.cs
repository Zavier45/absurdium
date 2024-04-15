string greeting = @"Welcome to the Reductio & Absurdum Emporium. 
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
},

List<ProductType> types = new List<ProductType>
{
new ProductType()
{
    ID = 1,
    Category = "Apparel"
},
new ProductType()
{
    ID = 2,
    Category = "Potion"
},
new ProductType()
{
    ID = 3,
    Category = "Enchanted Object"
},
new ProductType()
{
    ID = 4,
    Category = "Wand"
}
};


void ListCategories()
{

}

void ListProducts()
{

}