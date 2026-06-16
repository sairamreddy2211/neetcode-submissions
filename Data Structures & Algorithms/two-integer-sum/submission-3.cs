public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> hash = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        { 
            int temp = target - nums[i];
            if(hash.TryGetValue(temp,out int res))
            { 
                return [res,i];
            }
            hash[nums[i]] = i;
        }
        return [0,0];
    }
}
