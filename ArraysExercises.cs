using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExSheet
{
    public class ArraysExercises
    {
        public int GetSumValOfArray(object[] arr)
        {
            int sum = 0;

            foreach (var item in arr)
            {
                if (item is int v1)
                {
                    sum += v1;
                }
                else if (item is float v)
                {
                    sum += (int)v;
                }
            }

            return sum;
        }

        public int GetSumOfIntNum(int num)
        {
            int sum = 0;
            string arr = num.ToString();
            foreach (char item in arr)
            {
                sum += int.Parse(item.ToString());
            }
            
            return sum;
        }


        public bool IsAPalindrome(string word)
        {
            string str = word.ToLower();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string reverseWord = new string(arr);
            return str.Equals(reverseWord);
        }


        public int[] ReverseOrderInts(int[] arr)
        {
            int[] ints = new int[arr.Length];
            for (int i = 0; i < arr.Length;i++)
            {
                ints[i] = arr[arr.Length - 1 - i];
            }
            return ints;

        }
    }
}
