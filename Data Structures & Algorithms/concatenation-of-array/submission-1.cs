public class Solution {
    public int[] GetConcatenation(int[] nums) {

        List<int> result = new List<int>();
        for(int i=0;i<nums.Length;i++)
        { 
            result.Add(nums[i]);
        }
        for(int i=0;i<nums.Length;i++)
        { 
            result.Add(nums[i]);
        }

        return result.ToArray();
    }
}