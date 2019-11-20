 using System;

namespace SortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = new int[]
            {
                2,8,7,8,3,7,55,78
            };
            MaoPaoSort(result);
            PrintArray(result);
            //Console.WriteLine("Hello World!");
        }
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_array"></param>
        static void MaoPaoSort<T>(T[] _array)
        {
            //Array.Sort(_array);
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

        static void SelectSort<T>(T[] _array)
        {

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
            Console.ReadKey();
        }
        #endregion

    }
}
