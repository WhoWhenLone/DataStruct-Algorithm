 using System;

namespace SortDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[] result = new int[]
            {
                2,8,7,8,3,7,55,78
            };
            Console.WriteLine("after sort");
            PrintArray(result);
            //冒泡排序
            //BubbleSort(result);
            //选择排序
            //SelectSort(result);
            //插入排序
            //InsertSort(result);
            //快速排序
            //QuickSort(result,0,result.Length-1);
            Console.WriteLine("before sort");
            PrintArray(result);
        }
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_array"></param>
        static void BubbleSort<T>(T[] _array)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = i; j < _array.Length; j++)
                {
                    if (float.Parse(_array[i].ToString()) > float.Parse(_array[j].ToString()))
                    {
                        Swap(ref _array[i], ref _array[j]);
                    }
                } 
            }
        }
        /// <summary>
        /// 选择排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_array"></param>
        static void SelectSort<T>(T[] _array)
        {                
            for (int i = 0; i < _array.Length; i++)
            {
                int index = i;
                T MIN_NUM = _array[i];
                for (int j = i+1; j < _array.Length; j++)
                {
                    if (float.Parse(_array[j].ToString()) < float.Parse(MIN_NUM.ToString()))
                    {
                        index = j;
                        MIN_NUM = _array[j];
                    }
                }
                if (index != i)
                {
                    Swap(ref _array[i], ref _array[index]);
                }
            }
        }
        /// <summary>
        /// 插入排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_array"></param>
        static void InsertSort<T>(T[] _array)
        {
            for (int i = 1; i < _array.Length; i++)
            {
                T current = _array[i];
                for (int j = i-1; j >= 0; j--)
                {
                    if(float.Parse(current.ToString()) < float.Parse( _array[j].ToString()))
                    {
                        _array[j + 1] = _array[j];
                        if (j == 0)
                        {
                            _array[j] = current;
                            break;
                        }   
                    }
                    else
                    {
                        _array[j + 1] = current;
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// 快速排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_array"></param>
        static void QuickSort<T>(T[] _array,int left,int right)
        {
            if(left < right)
            {
                T middle = _array[left];
                int i = left, j = right;
                while (i < j)
                {
                    while(i<j)
                    {
                        //从后向前找到比标杆小的值 交换
                        if(float.Parse(middle.ToString()) >= float.Parse(_array[j].ToString()))
                        {
                            _array[i] = _array[j];
                            break;
                        }
                        //前移 
                        else
                        {
                            j--;
                        }
                    }
                    while (i < j)
                    {
                        //从前向后找到比标杆大的值 交换
                        if (float.Parse(middle.ToString()) < float.Parse(_array[i].ToString()))
                        {
                            _array[j] = _array[i];
                            break;
                        }
                        //后移
                        else
                        {
                            i++;
                        }
                    }
                }
                _array[i] = middle;
                QuickSort(_array, left, i - 1);
                QuickSort(_array, i+1, right);
            }
            
        }

        #region 工具函数
        /// <summary>
        /// 交换方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="itema"></param>
        /// <param name="itemb"></param>
        static void Swap<T>(ref T itema, ref T itemb)
        {
            T temp = itema;
            itema = itemb;
            itemb = temp;
        }
        /// <summary>
        /// 打印数组
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_array"></param>
        static void PrintArray<T>(T[] _array)
        {
            foreach (var item in _array)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }
        #endregion

    }
}
