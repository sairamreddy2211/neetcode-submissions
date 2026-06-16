class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        st = set(nums)
        mx = 0
        c = 1
        for i in range(len(nums)):
            c = 1
            if nums[i]-1 not in st:
                lp = nums[i]
                while lp+1 in st:
                    lp=lp+1
                    c=c+1
                mx = max(mx,c)
        return mx






        