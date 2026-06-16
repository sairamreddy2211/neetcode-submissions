public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var hshMap = new Dictionary<string, List<string>>();
        for(int i =0;i<strs.Length;i++)
        { 
            var lst = new int[27];

            foreach(char ch in strs[i])
            { 
                lst[ch-'a'] = lst[ch-'a'] + 1;
            }
            var key = string.Join('#',lst);
            hshMap[key] = hshMap.GetValueOrDefault(key,new List<string>());
            hshMap[key].Add(strs[i]);
        }
        return hshMap.Values.ToList();
    }
}
