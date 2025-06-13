using DemoLINQ2Object2;
using System.Text;

Console.OutputEncoding= Encoding.UTF8;

ListProduct lp = new ListProduct();
lp.gen_products();
//câu 1: lọc ra các sản phẩm có giá từ a tới b
// sử dụng method syntax và query syntax

var result1 = lp.FilterProductsByPrice(200, 500);
Console.WriteLine("List of Products with Price between 200 and 500 (Method Syntax):");
//foreach (var product in result1)
//{
//    Console.WriteLine(product);
//}
result1.ForEach(x => Console.WriteLine(x));

//câu 2: sấp xếp các sp theo giá giảm dần
var result2 = lp.SortProductsByPriceDescending();
Console.WriteLine("List of products sorted by price Descending: ");
result2.ForEach(x => Console.WriteLine(x));

//câu 3 : Tình tổng giá trị sản phẩm trong kho hàng
var totalValue = lp.SumOfValue();
Console.WriteLine($"Total value of products in stock: {totalValue}");