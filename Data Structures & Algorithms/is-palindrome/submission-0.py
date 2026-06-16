class Solution:
    def isPalindrome(self, s: str) -> bool:
        i =0
        s = s.lower()
        j = len(s)-1
        while(i<=j):
            if(s[i]==" " or not s[i].isalnum()):
                i+=1
                continue
            if(s[j]==" " or not s[j].isalnum()):
                j-=1
                continue
            # print(s[i],s[j])
            if (s[i]!=s[j]):
                return False
            i+=1
            j-=1
        return True

        