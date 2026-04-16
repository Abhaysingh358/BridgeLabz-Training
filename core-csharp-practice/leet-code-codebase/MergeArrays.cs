using System;

public class MergeArrays {
    


    public void merge(int[] nums1, int m, int[] nums2, int n) {
        int idx = m; 
        
      
        for (int i = 0; i < n; i++) {
            // Copy elements from nums2 to nums1
            // This will place all elements of nums2 after the valid elements of nums1
            nums1[idx] = nums2[i];
            idx++;
        }

        Array.Sort(nums1); 

        Console.WriteLine("[" + string.Join(", ", nums1) + "]"); 
    }
}