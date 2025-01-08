using System;

class Pair{
    public static void FindPair(int[] arr){
        for(int i=0; i< arr.Length ; i++){
            int curr = arr[i];
            for(int j=i+1; j<arr.Length;j++){
                Console.Write("(" + curr + " " + arr[j] + ")");
                
            }
            Console.WriteLine();
        }
    }
    
    static void Main(){
        int[] arr = {1,2,3,4,5,6,7};
        FindPair(arr);
    }
}