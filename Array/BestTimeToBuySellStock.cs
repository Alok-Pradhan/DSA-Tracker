using System;
class Stocks
{
    static void BestTime(int[] arr)
    {
        int maxProfit = 0;
        int buyPrice =int.MaxValue;;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < buyPrice)
            {
                buyPrice = arr[i];
            }
            else
            {
                maxProfit = Math.Max(maxProfit, (arr[i]-buyPrice));
                
            }
        }
        Console.WriteLine("Maximum Profit: " + maxProfit);
    }

    static void Main(string[] args)
    {
        int[] arr={7,1,5,3,6,4};
        BestTime(arr);
    }
}