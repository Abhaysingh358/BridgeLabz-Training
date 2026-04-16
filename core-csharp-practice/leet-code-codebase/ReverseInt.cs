using System;

class ReverseInt {
    public int ReverseInteger(int x) {

        // This variable will store the reversed number
        int rev = 0;

        // Loop until all digits of x are processed
        while (x != 0) {

            // Extract the last digit of x
            int digit = x % 10;

            // Remove the last digit from x
            x /= 10;

            /*
             * Before adding the digit to rev, check for overflow.
             * If rev * 10 exceeds the maximum value of int,
             * or equals max/10 but the digit is greater than 7,
             * the reversed number will overflow.
             */
            if (rev > int.MaxValue / 10 ||
               (rev == int.MaxValue / 10 && digit > 7)) {
                return 0;
            }

            /*
             * Check for underflow (negative overflow).
             * If rev * 10 goes below int.MinValue,
             * or equals min/10 but the digit is less than -8,
             * the reversed number will underflow.
             */
            if (rev < int.MinValue / 10 ||
               (rev == int.MinValue / 10 && digit < -8)) {
                return 0;
            }

            // Append the extracted digit to the reversed number
            rev = rev * 10 + digit;
        }

        // Return the final reversed number
        return rev;
    }
}