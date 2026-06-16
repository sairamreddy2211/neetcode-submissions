public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        Dictionary<int,int> hash = new Dictionary<int,int>();
        foreach(int num in nums)
        {   
            if(hash.TryGetValue(num,out int _val))
            {
                return true;
            }
            hash[num] = 1;
        }
        return false;
    }
}