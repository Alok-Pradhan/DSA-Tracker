// for calculate trappped rain water we can follow this steps:
// 1. find the left max value of array 
// 2. find the right max value of array
// 3. then take the min value of both right and left arrary
// 5. the substarct the building height with min values

using System;

public class TrappedRainWater
{
    static void trappedWaterCal(int[] heights){
        int len = heights.Length;
        int[] leftArr = new int[len];
        int[] rightArr = new int[len];
        int trappedWater = 0;
        
        // assigning left and right max value
        leftArr[0] = heights[0];
        rightArr[len - 1] = heights[len-1];

        for(int i =1;i<len;i++){
            leftArr[i] = Math.Max(leftArr[i-1], heights[i]);
        }
        for(int i=len-2; i>=0;i--){
          rightArr[i] = Math.Max(rightArr[i+1], heights[i]);
        }
        
        for(int k=0;k<len;k++){
            trappedWater += (Math.Min(leftArr[k], rightArr[k]))- heights[k];
        }
        
        Console.WriteLine(trappedWater);
    }
    public static void Main(string[] args)
    {
        int[] arr={4,2,0,6,3,2,5};
        trappedWaterCal(arr);
    }
}