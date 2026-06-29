public class Solution {
    public int MajorityElement(int[] nums) {
        var candidate = 0;
        var count = 0;
        foreach(int i in nums)
        {
            if (count == 0)
                candidate = i;
            
            count += (i == candidate) ? 1:-1;
        }
       return candidate;
    }
}