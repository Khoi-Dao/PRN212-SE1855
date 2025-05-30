using OOP4_Generic_Collection;
using OOP5_Dictionary;
using System.Text;

Console.OutputEncoding=Encoding.UTF8;
Category c1 = new Category();
{
    c1.Id = 1;
    c1.Name = "Nước ngọt";
}

Product p1 = new Product();

p1.Id = 1;
p1.Name = "Pepsi";
p1.Quantity = 20;
    p1.Price = 12;
    c1.AddProduct(p1);

Product p2 = new Product();
p2.Id = 2;
p2.Name = "Coke";
p2.Quantity = 30;
p2.Price = 15;
c1.AddProduct(p2);

Product p3 = new Product();
p3.Id = 3;
p3.Name = "String";
p3.Quantity = 8;
p3.Price = 20;
c1.AddProduct(p3);

Product p4 = new Product();
p4.Id = 4;
p4.Name = "Redbull";
p4.Quantity = 5;
p4.Price = 18;
c1.AddProduct(p4);

Product p5 = new Product();
p5.Id = 5;
p5.Name = "Sprite";
p5.Quantity = 12;
p5.Price = 20;
c1.AddProduct(p5);


Console.WriteLine("=====================================");
c1.PrintAllProducts();
Console.WriteLine("=====================================");

//var filteredProducts = c1.FilterProductByPrice(15, 18);
//-------------------------------

Dictionary<int,Product> filteredProducts = c1.FilterProductByPrice(15, 18);
foreach (KeyValuePair<int, Product> kvp in filteredProducts)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Console.WriteLine("=====================================");

Dictionary<int, Product> sortedProducts = c1.SortProductByPriceAscending();
foreach (KeyValuePair<int, Product> kvp in sortedProducts)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Console.WriteLine("=====================================");

Dictionary<int, Product> sortedUnitPriceProducts = c1.ComplexSort();
foreach (KeyValuePair<int, Product> kvp in sortedUnitPriceProducts)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}
p1.Name= "Pepsi Zero";
p1.Quantity = 25;
p1.Price = 28;
c1.UpdateProduct(p1);
Console.WriteLine("=====================================");
c1.PrintAllProducts();

int id = 3;
bool ret = c1.DeleteProduct(id);
if (ret)
{
    Console.WriteLine($"Product with ID {id} deleted successfully.");
}
else
{
    Console.WriteLine($"Product with ID {id} not found.");
}

c1.PrintAllProducts();
Category c2 = new Category();
{
    c2.Id = 2;
    c2.Name = "Bia";
}

c2.AddProduct(new Product() { Id = 6, Name = "Seven", Quantity = 10, Price = 300 });
c2.AddProduct(new Product() { Id = 7, Name = "Sài Gòn", Quantity = 15, Price = 200 });
c2.AddProduct(new Product() { Id = 8, Name = "Ken", Quantity = 7, Price = 400 });

LinkedList<Category> ss = new LinkedList<Category>();
ss.AddLast(c1);
ss.AddLast(c2);
Console.WriteLine("=====================================");

foreach (Category c in ss)
{
    Console.WriteLine($"{c.Name}");
    Console.WriteLine("======================================");
    c.PrintAllProducts();
    Console.WriteLine("======================================");
}