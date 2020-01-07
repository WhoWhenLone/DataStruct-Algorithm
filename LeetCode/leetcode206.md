### 题目：

　　反转一个单链表。

　　输入: 1->2->3->4->5->NULL 输出: 5->4->3->2->1->NULL 

#### 进阶:

　　你可以迭代或递归地反转链表。你能否用两种方法解决这道题？

### 题解：

从前向后依次反转即可，如下所示

第一次：2->1->3->4->5 第二次：3->2->1->4->5 第三次：4->3->2->1->5 第四次：5->4->3->2->1 

　　*注意：在反转链表节点是保存节点*

```C#
public class ListNode 
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}
public class Solution 
{
    public ListNode ReverseList(ListNode head) 
    {
        if(head == null)
        {
            return null;
        }
        ListNode preNode = head;
        while(head.next != null)
        {
            ListNode tempNode = head.next;
            head.next = tempNode.next;
            tempNode.next = preNode;
            preNode = tempNode;
        }
        return preNode;
    }
}
```