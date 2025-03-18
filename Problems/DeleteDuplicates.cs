using LeetCodeSolutions.Helper;

namespace LeetCodeSolutions.Problems {
    public class DeleteDuplicates {
        public ListNode Solution(ListNode head) {
            var first = head;
            var second = head.next;
            while(second != null) {
                while(first.val == second.val) {
                    second = second.next;
                }
                first = first.next;
                second = second.next;
            }
            return head;
        }
    }
}