using System;

public class SingleNumber {
   
    public int singleNumber(int[] nums) {
        int ans = 0;
        
        foreach(int i in nums) {
          // Using XOR operation to find the single number in the array 
        ans^=i;
        }
        return ans;
    }
}