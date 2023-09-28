using HelperObjects;
public partial class Medium{
    public class AddTwoNumbers{
        public static void Run(){
            ListNode n3 = new (3, null);
            ListNode n2 = new (4, n3);
            ListNode head1 = new (2, n2);

            ListNode n6 = new ListNode(4, null);
            ListNode n5 = new ListNode(6, n6);
            ListNode n4 = new ListNode(1, n5);
            ListNode head2 = new ListNode(5, n5);

            ListNode? l = Solution1(head1, head2);
        }
        public static ListNode? Solution1(ListNode? l1, ListNode? l2, int carry = 0){
            if(l1 == null && l2 == null && carry == 0) return null;

            int total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0);
            carry = total/10;
            return new ListNode(total%10, Solution1(l1?.next, l2?.next, carry));
        }
    }
}