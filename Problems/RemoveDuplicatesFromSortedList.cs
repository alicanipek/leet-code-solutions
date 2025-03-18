using LeetCodeSolutions.Helper;

namespace LeetCodeSolutions.Problems {
    public class RemoveDuplicatesFromSortedList {
        public ListNode DeleteDuplicates(ListNode head) {
            ListNode currNode = head;
            ListNode nav = currNode;
            while(nav != null) {
                ListNode next = nav.next;
                while(next != null && nav.val == next.val) {
                    next = next.next;
                }
                nav.next = next;
                nav = nav.next;
            }

            return currNode;

        }
        public ListNode DeleteDuplicates2(ListNode head) {
            ListNode dummyNode = new() {
                next = head
            };
            ListNode prev = dummyNode;
            while(head != null) {
                if(head.next != null && head.val == head.next.val) {
                    while(head.next != null && head.val == head.next.val) {
                        head = head.next;
                    }
                    prev.next = head.next;
                } else {
                    prev = prev.next;
                }
                head = head.next;
            }

            return dummyNode.next;

        }
    }
}