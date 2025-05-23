void image1(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j==0 || j==n-1 || i==j)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
void image2(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j == 0 || j == n - 1 || (i + j) == n - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
void image3(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n;j++)
        {
            if(j == 0 || j == n - 1 || (j == i && i <= n/2) || (j == n - 1 - i && i <= n/2) )
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
int n = 9;
image3(n);