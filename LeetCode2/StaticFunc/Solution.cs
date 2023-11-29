﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode2.StaticFunc
{
    public static class Solution
    {
        public static int MySqrt(int x)
        {
            int left = 0, right = x;
            while (left < right)
            {
                int mid = left + right + 1 >> 1;
                if (mid <= x / mid)
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }
            Console.WriteLine(left + " " + right);
            return left;
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string result = "";

            if( strs==null || strs.Length==0)
                return result;  

            string shortStr = strs.OrderBy(name => name.Length).FirstOrDefault();

            for(int i = 0; i < shortStr.Length; i++)
            {
                var current = strs[0][i];

                for(int j = 0; j < strs.Length; j++)
                {
                    if (strs[j][i] != current)
                    {
                        return result;
                    }

                     
                }
                result += current;
            }

            return result;
        }


        public  class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode res = null;
            ListNode temp = null;
 
            int carry = 0;
            while (l1!=null||l2!=null)
            {
                int sum = carry;

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next; 
                }
                if (l1!=null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                carry = sum / 10;
                ListNode listNode = new ListNode(carry);

                if (temp == null)
                {
                    temp = res = listNode;
                    
                }
                else
                {
                    temp.next = listNode;
                    temp = temp.next;
                }

            }

            if(carry>0)
                temp.next = new ListNode(carry);


            return res;
        }


        public static int MyAtoi(string s)
        {
            if (s.Length==0 ||s.Length > 200)
                return 0;

            long result = 0;
            bool Negative;
            Stack<int> stack = new Stack<int>();

            s=s.Trim();
            Negative = (s[0] == '-')?true:false;

            var counter=0;
            if (Negative)
                counter = 1;

            while (counter<s.Length && (int)(s[counter]) >= 48 && (int)(s[counter]) <= 57)
            {
                    stack.Push(s[counter] - 48);   
               counter++;    
            }


            var len = stack.Count();
            counter = 0;

            while (stack.Count > 0)
            {
                result+= (long)Math.Pow(10,counter) * stack.Pop(); 
                counter++;

            }

            if (result > int.MaxValue)
            {
                result = int.MaxValue;
            }
            if (result < int.MinValue)
            {
                result = int.MinValue;
            }

            return Negative?(-1)*((int)result):(int)result;
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode res = null;
            ListNode temp = null;
            while (list1 != null || list2 != null)
            {
                ListNode listNode = new ListNode();
                if (list2 == null)
                {
                    listNode = list1;
                    list1 = list1.next;
                }
                else if (list1 == null)
                {
                    listNode = list2;
                    list2 = list2.next;
                }
                else if (list2.val <= list1.val)
                {
                    listNode = list2;
                    list2 = list2.next;
                }
                else if (list2.val > list1.val)
                {
                    listNode = list1;
                    list1 = list1.next;
                }

                if (res == null)
                {
                    res = temp = listNode;
                }
                else
                {
                    temp.next = listNode;
                    temp = temp.next;
                }

            }
            return res;
        }




    }
}
