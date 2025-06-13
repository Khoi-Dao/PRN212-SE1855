using System.Text;

class Program
{
    public delegate int MyDelegate1(int x, int y);
    static int Add(int x, int y)
    {
        return x + y;
    }
    static int Subtract(int x, int y)
    {
        return x - y;
    }
    public delegate int[] MyDelegate2(int n);
    static int[]ListOfEvenNumbers(int n)
    {
        List<int> list = new List<int>();
        for (int i = 2;i <= n; i += 2)
        {
            list.Add(i);
            
        }
        return list.ToArray();
    }
    static int[]ListOfPrimeNumbers(int n)
    {
        List<int> list = new List<int>();
        for (int i =2; i <= n; i++)
        {
            int count = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    count++;
                }
                
            }
            if (count == 2)
            {
                list.Add(i);
            }
        }return list.ToArray();
    }
    public static void Main(string[] args)
    {
        Console.OutputEncoding=Encoding.UTF8;
        MyDelegate1 d1 = new MyDelegate1(Add);
        Console.WriteLine($"Sum of 5 and 8 is {d1(5, 8)}");
        d1 = new MyDelegate1(Subtract);
        Console.WriteLine($"Difference of 5 and 8 is {d1(5, 8)}");
        MyDelegate2 d2 = new MyDelegate2(ListOfEvenNumbers);
        int[] evenNumbers = d2(10);
        Console.WriteLine("List of even numbers up to 10:");
        foreach (int i in evenNumbers)
        {
            Console.Write(i + " ");
        }
        d2 = new MyDelegate2(ListOfPrimeNumbers);
        int[] primeNumbers = d2(10);
        Console.WriteLine("\nList of prime numbers up to 10:");
        foreach (int i in primeNumbers)
        {
            Console.Write(i + " ");
        }
    }
}