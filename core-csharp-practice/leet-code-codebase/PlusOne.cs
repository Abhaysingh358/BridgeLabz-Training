using System;

public class PlusOne {
    
    public int[] plusOne(int[] digits) {
        // Starting from the last digit, we check if it is 9.

        int n = digits.Length;
        for(int i = n-1; i>=0; i--){
            // Check if the current digit is 9
            // If it is, set it to 0
            // If it is not, increment it by 1 and return the array
            if(digits[i]==9){
                digits[i] = 0;
            }
            // If the digit is not 9, we can simply increment it and return the result
            else{
                digits[i]++;
                return digits;
            }
        }
        int[] j = new int[n+ 1];
        j[0] = 1;
        return j;

    }
}