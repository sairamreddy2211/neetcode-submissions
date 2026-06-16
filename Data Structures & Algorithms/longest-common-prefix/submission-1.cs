public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        var prefixind =  double.PositiveInfinity;
        for(int i =0;i<strs.Length;i++){
            var word = strs[i];
            for(int j=0;j<strs.Length;j++){
                var word2 = strs[j];
                int k=0;
                for(k=0;k<Math.Min(word.Length,word2.Length);k++)
                {
                    if(word[k]!=word2[k]){
                        break;
                    }

                }
                prefixind = Math.Min(prefixind , k);
                
            }

        }
        // if(prefixind >= strs[0].Length){
        //     return "";
        // }
            return strs[0].Substring(0,(int)prefixind);

        
    }
}