public class Solution {
    public int MajorityElement(int[] nums) {
        var temp = new Dictionary<int ,int>();
        for(int i = 0;i<nums.Length;i++)
        {
            temp[nums[i]] = temp.GetValueOrDefault(nums[i],0) + 1;
        }
        var res = 0;
        foreach(var (k,v) in temp)
        { 
            if(v>nums.Length/2)
            {
                res = k;
            }
        }
        return res;
        
    }
}