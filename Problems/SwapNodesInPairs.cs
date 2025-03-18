
using LeetCodeSolutions.Helper;

namespace LeetCodeSolutions.Problems {
    public class SwapNodesInPairs {
        public ListNode SwapPairs(ListNode head) {
            if(head == null || head.next == null)
                return head; //If there are less than 2 nodes in the given nodes, then no need to do anything just return the list as it is.

            ListNode dummyNode = new ListNode();

            ListNode prevNode = dummyNode;
            ListNode currNode = head;

            while(currNode != null && currNode.next != null) {
                prevNode.next = currNode.next;
                currNode.next = prevNode.next.next;
                prevNode.next.next = currNode;

                prevNode = currNode;
                currNode = currNode.next;
            }

            return dummyNode.next;
        }
    }
}