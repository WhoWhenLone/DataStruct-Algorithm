## 题目：

编写一个函数来查找字符串数组中的最长公共前缀。

如果不存在公共前缀，返回空字符串 ""。

#### 示例 1:

输入: ["flower","flow","flight"] 输出: "fl"

#### 示例 2:

输入: ["dog","racecar","car"] 输出: "" 解释: 输入不存在公共前缀。

#### *说明:*

*所有输入只包含小写字母 a-z 。*

## 题解：

1.找出字符串数组中最短的字符串

2.根据最短的字符串，遍历字符串数组，依次比较最短字符串的字符，字符串数组中所有字符串的索引字符与当前字符相等，结果字符串便添加字符串，继续下一索引字符遍历，有一个不等的字符便return；

```C#
public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
        string shortItem = string.Empty;
        int shortItemLen = int.MaxValue;
        for (int i = 0; i < strs.Length; i++)
        {
            if(shortItemLen >= strs[i].Length)
            {
                shortItemLen = strs[i].Length;
                shortItem = strs[i];
            }
        }
        string result = string.Empty;
        for (int i = 0; i < shortItem.Length; i++)
        {
            char item = shortItem[i];
            for (int j = 0; j < strs.Length; j++)
            {
                if(strs[j][i] == item)
                {
                    continue;
                }
                else
                {
                    return result;
                }
            }
            result += item;
        }
        return result;
    }
}
```