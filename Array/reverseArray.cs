using System;

class reverseArray{
    public static void revArr(int[] arr){
        int first=0; int last = arr.Length-1;
        while(first<last){
            int temp = arr[last];
            arr[last] = arr[first];
            arr[first] = temp;
            first++;
            last--;
        }
    }
    
    static void Main(){
        int[] arr = {1,2,3,4,5,6,7,8};
        revArr(arr);
        for(int i=0; i<arr.Length ; i++){
            Console.WriteLine(arr[i]);
        }
    }
}