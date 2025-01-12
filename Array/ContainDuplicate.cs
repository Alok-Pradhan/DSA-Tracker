public class Solution {
    public bool ContainsDuplicate(int[] nums) {

        // Using Brute force
        for(int i=0;i<nums.Length;i++){
            for(int j=i+1;j<nums.Length;j++){
                if(nums[i] == nums[j])
                    return true;
            }
        }
        return false;

        // Using Hashset
        HashSet<int> hashset = new HashSet<int>();
        foreach (int item in nums)
        {
            if(hashset.Contains(item)){
                return true;
            }else{
                hashset.Add(item);
            }
        }
        return false;

        // Using Sorting
        Array.Sort(nums);
        for(int i=1;i<nums.Length;i++){
            if(nums[i]== nums[i-1]){
                return true;
            }
        }
        return false;

        //Using Dictionary
        Dictionary<int, int> numbers = new Dictionary<int,  int>();
        foreach(int item in nums){
            if(numbers.ContainsKey(item)){
                return true;
            }
            else{
               numbers[item]=item;
            }
        }
        return false;       

    }
}
      