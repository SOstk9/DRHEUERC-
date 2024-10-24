using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearch
{
    public class BinaryTreeNode<T> where T : IComparable<T>
    {
        public BinaryTreeNode(T value)
        {
            Data = value;
        }
        public T Data { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }
    }
}