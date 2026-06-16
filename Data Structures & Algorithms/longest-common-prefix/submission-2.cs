public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        // var prefixind =  double.PositiveInfinity;
        // for(int i =0;i<strs.Length;i++){
        //     var word = strs[i];
        //     for(int j=0;j<strs.Length;j++){
        //         var word2 = strs[j];
        //         int k=0;
        //         for(k=0;k<Math.Min(word.Length,word2.Length);k++)
        //         {
        //             if(word[k]!=word2[k]){
        //                 break;
        //             }

        //         }
        //         prefixind = Math.Min(prefixind , k);
                
        //     }

        // }
       
        // return strs[0].Substring(0,(int)prefixind);

        Array.Sort(strs);
        var word1 = strs[0];
        var word2 = strs[strs.Length-1];
        int k = 0;
        for(k=0;k<Math.Min(word1.Length,word2.Length);k++)
                {
                    if(word1[k]!=word2[k]){
                        break;
                    }

                }
        return word1.Substring(0,k);



        
    }
}