public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> hash = new Dictionary<int,int>();
        int[] result = new int[2] {0,0};
        for(int i=0;i<nums.Length;i++)
        { 
            int temp = target - nums[i];
            if(hash.TryGetValue(temp,out int res))
            { 
                result[0]=res;
                result[1]=i;
                
                return result;
            }
            hash[nums[i]] = i;
        }
        return result;
    }
}
