using System;
class  Test{
    static void SumOfSubArray(int[] arr){
        int LargestSum = int.MinValue;
        for(int i=0;i<arr.Length;i++){
            for(int j=i; j<arr.Length;j++){
                int currentSum=0;
                for(int k=i;k<=j;k++){
                    currentSum +=arr[k];
                }
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