public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var hash = new Dictionary<string , List<string>>();

        foreach(string str in strs)
        {
            var tempList = new string[27];
            foreach(char s in str)
            {
                tempList[s - 'a'] = tempList[s - 'a'] + 1;
            }
            var temp = string.Join("#",tempList);
            var res = hash.GetValueOrDefault(temp , new List<string>());
            res.Add(str);
            hash[temp] = res;
        }

        return hash.Values.ToList();
    }
}
