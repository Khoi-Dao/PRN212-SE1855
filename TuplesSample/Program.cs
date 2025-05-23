//viết 1 cái hàm trả vể 2 tham số
(int,double) SumAndAverage(params int[] arr)
{
    int sum = 0;
    //foreach (int x in arr)
    //{
    //    sum += x;
    //}
    for (int i = 0; i<arr.Length; i++)
    {
        sum += arr[i];
    }
    double average = (double)sum / arr.Length;
    return (sum, average);
}

int []arr = { 1, 2, 3, 4, 5 };
(int s,double v) = SumAndAverage(arr);
Console.WriteLine($"Sum = {s}, Average = {v}");