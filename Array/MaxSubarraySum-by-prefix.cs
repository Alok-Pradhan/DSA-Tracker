using System;
class  Test{
    static void SumOfSubArray(int[] arr){
        int LargestSum = int.MinValue;
        int[] PreFix =new int[arr.Length];
        PreFix[0] = arr[0];
        for(int h=1; h<arr.Length;h++){
            PreFix[h] = PreFix[h-1]+arr[h];
        }
        for(int i=0;i<arr.Length;i++){
            for(int j=i; j<arr.Length;j++){
                int currentSum= i==0? PreFix[j]:PreFix[j] - PreFix[i-1];
                if(currentSum > LargestSum){
                    LargestSum = currentSum;
                }
            }
        }
        Console.Write(LargestSum);
    }
    static void Main(){
        int[] ARR = {1,2,3,4,5,6};
        SumOfSubArray(ARR);
    }
}