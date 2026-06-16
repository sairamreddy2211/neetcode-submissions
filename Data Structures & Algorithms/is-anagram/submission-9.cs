public class Solution {
    public bool IsAnagram(string s, string t) {

        int[] anghooky = new int[26];

        foreach(char val in s)
        {
            anghooky[val-'a'] += 1;
        }

        foreach(char val in t)
        {
            anghooky[val-'a'] -= 1;
            if(anghooky[val-'a'] < 0)
            {
                return false;
            }
        }

        foreach(int val in anghooky)
        {
            if(val != 0)
            { 
                return false;
            }
        }

        return true;
    }
}
