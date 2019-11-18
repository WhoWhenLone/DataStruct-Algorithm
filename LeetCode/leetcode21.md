## **题目**

将两个有序链表合并为一个新的有序链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 
示例：
输入：1->2->4, 1->3->4输出：1->1->2->3->4->4

### **结题思路**

**本人思路**

a1,b1,c1a2,b2,c2创建一个新的头结点result与临时节点temp，对两个链表进行遍历,比较当前链表节点大小，temp = 小的节点，小节点指向nextnode，当一个链表的为空后，另一个链表直接链接即可

**leetcode给出的详细解释**

首先，我们设定一个哨兵节点 "prehead" ，这可以在最后让我们比较容易地返回合并后的链表。我们维护一个 prev 指针，我们需要做的是调整它的 next 指针。然后，我们重复以下过程，直到 l1 或者 l2 指向了 null ：如果 l1 当前位置的值小于等于 l2 ，我们就把 l1 的值接在 prev 节点的后面同时将 l1 指针往后移一个。否则，我们对 l2 做同样的操作。不管我们将哪一个元素接在了后面，我们都把 prev 向后移一个元素。

在循环终止的时候， l1 和 l2 至多有一个是非空的。由于输入的两个链表都是有序的，所以不管哪个链表是非空的，它包含的所有元素都比前面已经合并链表中的所有元素都要大。这意味着我们只需要简单地将非空链表接在合并链表的后面，并返回合并链表。

### **源代码**

```C#
public class Solution 
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) 
    {      
        ListNode curr = new ListNode(-1);
        ListNode head = curr;
        while (l1 != null && l2 != null)
        {
            if(l1.val <= l2.val)
            {
                head.next = l1;
                l1 = l1.next;           
            }
            else
            {
                head.next = l2;
                l2 = l2.next;
            }
            head = head.next;
        }
        head.next = l1 ==null ?l2:l1;
        return curr.next;
    }
}
```

