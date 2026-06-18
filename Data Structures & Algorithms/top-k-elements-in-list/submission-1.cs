public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var hash = new Dictionary<int, int >();

        foreach(int i in nums)
        {
            hash[i]=hash.GetValueOrDefault(i,0)+1;
        }

        var res = new List<List<int>>();
        foreach(int i in nums)
        { 
            res.Add(new List<int>());
        }
        res.Add(new List<int>());
        foreach(var (key,v) in hash)
        {
            res[v].Add(key);
        }

        var result = new List<int>();

        for(int i=nums.Length;i>=0;i--)
        {
            if(res[i].Count > 0)
            {
                result.AddRange(res[i]);
            }
        }
        return result.GetRange(0,k).ToArray();
    }
}
