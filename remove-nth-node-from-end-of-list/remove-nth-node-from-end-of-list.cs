/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        List<ListNode> nodes = new List<ListNode>();
            var item = head;
            while (item != null)
            {
                nodes.Add(item);
                item = item.next;
            }

            if (n == nodes.Count)
            {
                if (nodes.Count > 1)
                {
                    return nodes[1];
                }

                return null;
            }

            nodes[nodes.Count - 1 - n].next = nodes[nodes.Count - n].next;
            return head;
    }
}