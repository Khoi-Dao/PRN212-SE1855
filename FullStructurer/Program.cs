namespace FullStructurer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Roses are \"Red\", Violets are \"Blue\"");
            Console.WriteLine("Why is it so \"easy\"");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            Console.ReadLine();
        }
    }
}