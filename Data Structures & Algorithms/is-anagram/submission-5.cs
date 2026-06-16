public class Solution {
    public bool IsAnagram(string s, string t) {

        // HashSet<char> map = new HashSet<char>();

        // for(int i = 0;i<s.Length;i++)
        // {
        //     if(map.Contains(s[i]))
        //     {
        //         map.Remove(s[i]);
        //     }else{
        //         map.Add(s[i]);
        //     }
        // }
        // for(int i = 0;i<t.Length;i++)
        // {
        //     if(map.Contains(t[i]))
        //     {
        //         map.Remove(t[i]);
        //     }else{
        //         map.Add(t[i]);
        //     }
        // }

        // return map.Count == 0;

        // Dictionary<char,int> dict = new Dictionary<char,int>();

        // for(int i= 0;i<s.Length;i++)
        // { 
        //     if(dict.TryGetValue(s[i],out int val))
        //     { 
        //     dict[s[i]] = val+1;
        //     }else{
        //     dict.Add(s[i],1);
        //     }
        // }


        // for(int i= 0;i<t.Length;i++)
        // { 
        //     if(dict.TryGetValue(t[i],out int val))
        //     { 
        //         dict[t[i]] = val-1;
        //     }else{
        //         return false;
        //     }
        // }

        // foreach(var i in dict.Values)
        // { 
        //     if(i!=0)
        //     {
        //         return false;
        //     }
        // }
        // return true;

        if(s.Length != t.Length)
        {
            return false;
        }

        var dict = new Dictionary<char,int>();

        foreach(char c in s){ 
            dict[c] = dict.GetValueOrDefault(c,0)+1;
        }

        foreach(char c in t){
            // if(dict.TryGetValue(c,out int value))
            // {
            //     dict[c]=value-1;
            // }else{ 
            //     return false;
            // }

            if(!dict.ContainsKey(c))
            {
                return false;
            }
            dict[c]--;
            if(dict[c]<0)
            {
                return false;
            }
        }
        return true;
        
    }
}
