using System;
class  Test{
    static void Kadanes(int[] arr){
        int MaxSubArray = int.MinValue;
        int minValue = 0;
        
        for(int i=0; i<arr.Length;i++){
            minValue+= arr[i];
            if(minValue<0){
                minValue=0;
            }else{
                MaxSubArray = Math.Max(minValue, MaxSubArray);
            }
        }
        Console.Write(MaxSubArray);
    }
    static void Main(){
        int[] ARR = {-1,-2,-3,4,-5,6};
        Kadanes(ARR);
    }
}