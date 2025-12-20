using System;

public class RemovingDuplicatesFromASortedArray {
    public static void Main(string[] args) {
        // Equivalent to Scanner in Java
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        // taking input of an array 
        for(int i = 0; i < n; i++) {
            nums[i] = int.Parse(Console.ReadLine());
        }

        // using two pointers to count the duplicates 
        int i_ptr = 0; // renamed slightly from 'i' to avoid confusion with loop index if needed, but kept logic same
        for(int j = 1; j < n; j++) {
            if(nums[i_ptr] != nums[j]) {
                i_ptr++;
                nums[i_ptr] = nums[j];
            }
        }
        Console.WriteLine(i_ptr + 1);
    }
}