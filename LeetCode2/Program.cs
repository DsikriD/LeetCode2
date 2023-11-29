using LeetCode2.StaticFunc;
using System.ComponentModel.Design;
using System.Timers;
using static LeetCode2.StaticFunc.Solution;

namespace LeetCode2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode listNode = new ListNode(1);
            ListNode listNode1 = new ListNode(2,listNode);
            ListNode listNode2 = new ListNode(3,listNode1);

            Solution.MergeTwoLists(listNode, null);


        }
    }
}