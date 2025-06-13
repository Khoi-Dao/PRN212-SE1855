using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 11, 10 };
/* Câu 1: lọc ra các số chẳn
 */
//Cách 1 : Dùng Entention Method - Method syntax

var ar_even =array.Where(x => x % 2 == 0).ToArray();
Console.WriteLine("List of even numbers using Method syntax:");
ar_even.ToList().ForEach(x => Console.Write(x + " "));
//cách 2 : Dùng Extension Method - Query syntax
var ar_even2 = from x in array
                where x % 2 == 0
                select x;
Console.WriteLine("\nList of even numbers using Query syntax:");
ar_even2.ToList().ForEach(x => Console.Write(x + " "));
/* Câu 2: Tăng các phần tử lẻ lên 2 đơn vị
 */

//Cách 1 : Dùng Entention Method - Method syntax
var array2 = array.Where(x => x%2 !=0)
    .Select(x => x + 2)
                    /*.ToArray()*/;
Console.WriteLine("List before incrementing odd numbers:");
//array.ToList().ForEach(x => Console.Write(x + " "));
foreach (var x in array)
    Console.Write(x + " ");
Console.WriteLine("List after incrementing odd numbers using Method syntax:");
//array2.ToList().ForEach(x => Console.Write(x + " "));
foreach (var x in array2)
    Console.Write(x + " ");

/* Câu 3: sấp xếp các phần tử tăng dần:
 */
//var array3 = array.OrderBy(x => x).ToArray();
var array3 = array.OrderBy(x => x);
var array4 = from x in array
             orderby x
             select x;
Console.WriteLine("\nList of numbers sorted in ascending order using Method syntax:");
foreach (var x in array4)
    Console.Write(x + " ");

/* Câu 4 : sắp xếp các phần tử giảm dần:
 */
var array5 = array.OrderByDescending(x => x);
var array6 = from x in array
             orderby x descending
             select x;

Console.WriteLine("\nList of numbers sorted in descending order using Method syntax:");
foreach (var x in array6)
    Console.Write(x + " ");

/* Câu 5: Đếm các phần tử lẻ trong mảng
 */
Console.WriteLine($"odd number is {array.Where(x=>x%2!=0).Count()}");
int sole = (from x in array
            where x % 2 != 0
            select x).Count();
Console.WriteLine($"odd number is {sole}");