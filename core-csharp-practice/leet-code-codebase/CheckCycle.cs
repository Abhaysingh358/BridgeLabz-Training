using System;

/* public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
} */

public class CheckCycle {
    
    public bool hasCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        // Using Floyd's Tortoise and Hare algorithm to detect cycle in a linked list . 
        // it is based on two pointers moving at different speeds.
        // If there is a cycle, the fast pointer will eventually meet the slow pointer.
        // If there is no cycle, the fast pointer will reach the end of the list.

            while(fast != null && fast.next!=null){
                
                slow = slow.next;
                fast = fast.next.next;
                if(slow==fast){

                    return true;
                }
            }
        
        return false;
    }
}