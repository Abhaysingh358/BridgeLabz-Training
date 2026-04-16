using System;

public class RemoveElement {
    public int removeElement(int[] nums, int val) {

        // idx will point to the position where the next valid element should go
        int idx = 0;

        // i is used to traverse through the entire array
        int i = 0;

        // Loop through all elements of the array
        while (i < nums.Length) {

            // If the current element is NOT equal to the value to be removed
            if (nums[i] != val) {

                // Place the current element at the idx position
                nums[idx] = nums[i];

                // Move idx forward for the next valid element
                idx++;
            }

            // Move to the next element in the array
            i++;
        }

        // idx represents the number of elements left after removal
        return idx;
    }
}