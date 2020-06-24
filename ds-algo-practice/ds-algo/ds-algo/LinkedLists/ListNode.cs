using System;
using System.Collections.Generic;
using System.Text;

namespace ds_algo.LinkedLists
{
    public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int value)
        {
            Value = value;
        }
    }
}
