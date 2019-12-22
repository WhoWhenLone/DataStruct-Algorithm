## 题目：

给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。

有效字符串需满足：

左括号必须用相同类型的右括号闭合。

左括号必须以正确的顺序闭合。

注意空字符串可被认为是有效字符串。

#### 示例 1:

输入: "()" 输出: true

#### 示例 2:

输入: "()[]{}" 输出: true

#### 示例 3:

输入: "(]" 输出: false

#### 示例 4:

输入: "([)]" 输出: false

#### 示例 5:

输入: "{[]}" 输出: true

## 题解：

 利用栈属性，遍历字符串，左括号入栈，右括号出栈，判断括号是否匹配
```C#
public class Solution 
{
    public bool IsValid(string s)
    {
        if((s.Length %2) !=0)
        {
            return false;
        }
        Stack<char> st = new Stack<char>();
        int index = 0;
        while (index < s.Length)
        {
            //左括号入栈
            if ((s[index] == '(') 
                || (s[index] == '[') 
                || (s[index] == '{'))
            {
                st.Push(s[index]);
                index++;
            }
            //右括号 匹配成功出栈
            else if ((s[index] == ')') 
                || (s[index] == ']') 
                || (s[index] == '}'))
            {
                if(st.Count == 0)
                {
                    return false;
                }
                //匹配判断
                else if ((s[index] == ')' 
                    && st.Peek() == '(')|| (s[index] == ']' 
                    && st.Peek() == '[')|| (s[index] == '}' 
                    && st.Peek() == '{'))
                {
                    st.Pop();
                    index++;
                    continue;
                }
                else
                {
                    return false;
                }
            }
        }
        if(st.Count!=0)
        {
            return false;
        }
        return true;
    }
}
```