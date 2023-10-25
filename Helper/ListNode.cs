public class ListNode {
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null) {
        this.val = val;
        this.next = next;
    }

    public static ListNode FromArray(int[] arr) {
        ListNode l = new(arr[0]);
        ListNode head = l;
        for(int i = 1; i < arr.Length; i++) {
            l.next = new(arr[i]);
            l = l.next;
        }
        return head;
    }

}