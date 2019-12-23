## 题目：

给定一个链表，判断链表中是否有环。

　　为了表示给定链表中的环，我们使用整数 pos 来表示链表尾连接到链表中的位置（索引从 0 开始）。 如果 pos 是 -1，则在该链表中没有环。

#### 示例 1：

![img](/image/141/1.jpg)

输入：head = [3,2,0,-4], pos = 1
输出：true 解释：链表中有一个环，其尾部连接到第二个节点。

#### 示例 2：

![img](/image/141/2.jpg)

输入：head = [1,2], pos = 0 输出：true 
解释：链表中有一个环，其尾部连接到第一个节点。

#### 示例 3：

![img](/image/141/3.jpg)

输入：head = [1], pos = -1 输出：false 解释：链表中没有环。

## 题解：

　　利用操场跑圈赛跑思想，使用两个指针，快指针走两步，慢指针走一步，链表不存在环的话，快指针先到头，若存在环，快指针会追上慢指针，即指向的节点相同。

```C#
public class ListNode 
{
    public int val;
    public ListNode next;
    public ListNode(int x) 
    {
      val = x;
      next = null;
    }
}
public class Solution 
{
    public bool HasCycle(ListNode head) 
    {
        ListNode slowNode = head;
        ListNode fastNode = head;
        while(fastNode != null && fastNode.next != null)
        {
            slowNode = slowNode.next;
            fastNode = fastNode.next.next;
            if(slowNode == fastNode)
            {
                return true;
            }
        }
        return false;
    }
}
```

