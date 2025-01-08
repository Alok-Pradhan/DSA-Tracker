using System;

class Test{
    public static void subArr(int[] arr){
        int totalSubArray = 0;
        for(int i=0; i<arr.Length ;i++){
            for(int j=i; j<arr.Length ; j++){
                for(int k=i; k<=j;k++){
                    Console.Write(arr[k] + " ");
                }
                totalSubArray++;
                Console.WriteLine();
                
            }
            Console.WriteLine();
        }
        Console.WriteLine(totalSubArray);
    }
    static void Main(){
        int[] arr = {1,2,3,4,5,6,7,8};
        subArr(arr);
    }
}

// formula n=n(n+1)/2