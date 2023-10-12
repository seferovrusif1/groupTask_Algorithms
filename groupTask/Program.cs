namespace groupTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int[] arr = {12, 12, 13, 14, 14,15, 16, 17,18, 18, 19, 19, 20, 20, 21 };
            //    int x = 18;
            //    int n= arr.Length;
            //    int index = -1;
            //    int pos = 0;
            //    int lo = 0;
            //    int hi = n-1;
            //    for (;true;)
            //    {
            //        if (lo <= hi && x >= arr[lo] && x <= arr[hi])
            //        {
            //            Console.WriteLine(pos + " " + hi + " " + lo);

            //            pos = lo + (((hi - lo) / (arr[hi] - arr[lo])) * (x - arr[lo]));
            //            Console.WriteLine(pos+" "+hi + " " + lo);
            //            if (arr[pos] == x)
            //            {
            //                index = pos;
            //                Console.WriteLine(pos + " " + hi + " " + lo);

            //                break;
            //            }
            //            if (arr[pos] < x)
            //            {
            //                lo = pos + 1; Console.WriteLine(pos + " " + hi + " " + lo);

            //                continue;
            //            }
            //            if (arr[pos] > x)
            //            {
            //                hi = pos - 1; Console.WriteLine(pos + " " + hi + " " + lo);

            //                continue;
            //            }

            //        }
            //        else
            //        {
            //            index = -1;
            //            break;
            //        }
            //    }
            //    if (index != -1)
            //        Console.WriteLine("Element found at index " +
            //                           index);
            //    else
            //        Console.WriteLine("Element not found.");



            // C# program to implement Jump Search.


            // Driver program to test function

            //    int[] arr = { 0, 0, 2, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610};
            //    int x = 3;
            //    int n = arr.Length;
            //    int index = -1;
            //    int step = (int)Math.Sqrt(n);
            //    int prev = 0;
            //for (int minStep = Math.Min(step, n) - 1; arr[minStep] < x; minStep = Math.Min(step, n) - 1)
            //{
            //    prev = step;
            //    step += (int)Math.Sqrt(n);
            //    if (prev >= n)
            //    {
            //        index = -1;
            //        break;
            //    }
            //}
            //    while (arr[prev] < x)
            //    {
            //        prev++;
            //        if (prev == Math.Min(step, n))
            //        {
            //            index = -1;
            //        break;
            //        }
            //    }
            //    if (arr[prev] == x)
            //    { index = prev;
            //                        }
                
        
            //    Console.Write("Number " + x +" is at index " + index);





            
        }

    }
}