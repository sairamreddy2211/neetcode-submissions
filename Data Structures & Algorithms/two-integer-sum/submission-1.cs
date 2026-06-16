public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var map = new Dictionary<int , int >();

        for(int i = 0;i<nums.Length;i++)
        {
            if(map.TryGetValue(target - nums[i],out int pos))
            {
                return [pos,i];
            }
            map[nums[i]] = i;
        }

        return new int[2] {0,0};
    }
}
