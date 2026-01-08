public class Solution {
    public int FindPeakElement(int[] nums) {
        int peak = 0;
        int n = nums.Length;
        if(n==1) return 0;
        
        for(int i = 0; i<n;i++){

            if(i==0 && nums[i+1]>nums[i]){
                peak = i;
            }

             else if ((i==n-1) && nums[i]>nums[i-1])
            {
                peak = i;
            }

            else if ((i!= 0 && i<n-1) && nums[i]>nums[i+1] && nums[i]>nums[i-1]){
                peak = i;
            }
           
            else{
                continue;
            }
        }
        
        return peak;
    }
}