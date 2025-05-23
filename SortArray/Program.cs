#region forloop
//void swap (ref int a, ref int b)
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}
//void sort_array(int[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        for (int j = i + 1; j < arr.Length; j++)
//        {
//            if (arr[i] > arr[j])
//            {
//                swap(ref arr[i], ref arr[j]);
//            }
//        }
//    }
//}

//void createArray(int[] arr)
//{
//    Random rd = new Random();
//    for (int i = 0; i < arr.Length; i++)
//    {
//        arr[i] = rd.Next(1, 100);
//    }
//}
//void printArray(int[] arr)
//{
//    //for (int i = 0; i < arr.Length; i++)
//    //{
//    //    Console.Write(arr[i] + " ");
//    //}
//    foreach (int x in arr)
//    {
//        Console.Write($"{x} \t");
//    }
//}
//int[] arr = new int[10];
//createArray(arr);
//Console.WriteLine("Array before sorting: ");
//printArray(arr);
//sort_array(arr);
//Console.WriteLine("\n Array after sorting: ");
#endregion
void swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
void sort_array(int[] arr)
{
    int i=0;
    int j=i+1;
   
    do
    {
        
        while (arr[i] > arr[j])
        {
            swap(ref arr[i], ref arr[j]);
        }
    } while (i < arr.Length && j < arr.Length);
}
void createArray(int[] arr)
{
    int i = 0;
    while (i < arr.Length)
    {
        Random rd = new Random();
        arr[i] = rd.Next(1, 100);
        i++;
    }
}
void printArray(int[] arr)
{
    int i = 0;
    while ( i < arr.Length)
    {
        Console.Write($"{arr[i]} \t");
        i++;
    }
}

int[] arr = new int[10];
createArray(arr);
Console.WriteLine("Array before sorting: ");
printArray(arr);
sort_array(arr);
Console.WriteLine("\n Array after sorting: ");