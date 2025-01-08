using System;
// Simple Binary Search
class BinarySearch{
    
    static int IndexFind(int num, int[] arr){
        
        int start = 0;
        int end = arr.Length-1;
        
        
        while(start <= end){
            int mid= (start+end)/2;
            if(arr[mid] == num){
                return mid;
            }
        if(arr[mid] < num){
                start = mid+1;
            }
            else{
                end = mid-1;
            }
        }
        return -1;
        
    }
    static void Main(){
        int[] arr= {1,2,3,4,5,6,7,8,9,10,11};
        int indexofVal = IndexFind(5,arr);
        Console.WriteLine(indexofVal);
    }
}