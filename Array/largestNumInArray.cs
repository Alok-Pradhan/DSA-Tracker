using System;
class HelloWorld{
    public static int LargestNum(int[] arr){
        int largestNumber = int.MinValue;
        for(int i =0; i<arr.Length ; i++){
            if(arr[i] > largestNumber){
                largestNumber= arr[i];
            }
        }
        return largestNumber;
        
    }
    static void Main(){
        int[] arr = {5,4,3,2,1};
        int larNum = LargestNum(arr);
        Console.WriteLine(larNum);
    }
}