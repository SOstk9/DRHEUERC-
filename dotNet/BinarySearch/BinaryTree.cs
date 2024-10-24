using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Markup;
using System.Xml.Linq;

namespace BinarySearch
{
    public class BinaryTree<T> : IBinaryTree<T> where T : IComparable<T>
    {
    
        BinaryTreeNode<T> bdata;

        public BinaryTree()
            {
             
            }

        public void Clear()
        {

        }

        public void Insert(T value)
        {
            if (bdata == null)
            {
                bdata.Data = value;
            }
            else
            {
                Insert(value, bdata);
            }
        }

        private void Insert(T value, BinaryTreeNode<T> node)
        {
            // if 100 < 50 
            if(value.CompareTo(node.Data) == -1)
            {
                if (node.Left == null)
                {
                    BinaryTreeNode<T> neu = new BinaryTreeNode<T>(value);

                    bdata.Left = neu;
                }
                else
                {
                    Insert(value, node.Left);
                }
            }
            else if (value.CompareTo(node.Data) == 1)
            {
                if (node.Right == null)
                {

                    BinaryTreeNode<T> neu = new BinaryTreeNode<T>(value);

                    bdata.Right = neu;
                }
                else
                {
                    Insert(value, node.Right);
                }

            }

        }

        public void Delete(T value)
        {

        }

        public bool Contains(T value)
        {
            return true;
        }

        public BinaryTreeNode<T> Search(T value)
        {
            return bdata;
        }

        public void PrintInorder()
        {
           
        }
    }
}