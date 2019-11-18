### 题目

　给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
　　你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。

示例:
　　给定 nums = [2, 7, 11, 15], target = 9
　　因为 nums[0] + nums[1] = 2 + 7 = 9

### 解题思路

1.暴力解题，两层for循环  时间复杂度为O(n*n) *执行用时:* *364 ms*

```c#
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i=0;i<nums.Length;i++){
            for(int j=0;j<nums.Length;j++){
                if((nums[i] + nums[j])==target && i!=j){
                
                    return new int[]{i,j};
                } 
            }
        }
        throw new NullReferenceException("not exsit");
    }
}
```

2.利用Array.FindIndex 时间复杂度为O(n*n)

```c#
public int[] TwoSum(int[] nums, int target) 
{
        for(int i=0;i<nums.Length;i++)
        {
            int index = Array.FindIndex(nums,(int m)=>
            {
                return m ==(target - nums[i]);
            });
            if(index >-1)
            {
                return new int[]{i,index};
            }
        }
        throw new NullReferenceException("not exsit");
}
```

  3.利用字典存储，<target-nums[i],i>存储当前元素与目标值得差值与当前的索引   

```c#
public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
       var dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                return new int[] { dict[nums[i]], i };
            }
            dict[target - nums[i]] = i;
        }
        return null;    
    }
}
```

