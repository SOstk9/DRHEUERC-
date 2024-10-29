using System;

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
            bdata = null;

        }

        public void Insert(T value)
        {
            if (bdata == null)
            {
                BinaryTreeNode<T> neu = new BinaryTreeNode<T>(value);
                bdata = neu;
            }
            else
            {
                Insert(value, bdata);
            }
        }

        private void Insert(T value, BinaryTreeNode<T> node)
        {
            // if 100 < 50 
            if (value.CompareTo(node.Data) == -1)
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
            if(value.CompareTo(bdata.Data)==0)
            {
                if(bdata.Right == null && bdata.Left == null)
                {
                    bdata = null;                    
                }
                else
                {

                }

            }
            


        }

        public bool Contains(T value)
        {
        
            if(Search(value) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
            

         

        }

        public BinaryTreeNode<T> Search(T value)
        {
               return Search(value, bdata);            
        }

        private BinaryTreeNode<T> Search(T value,  BinaryTreeNode<T> node)
        {
            if (value.CompareTo(node.Data) == 0)
            {
                return node;
            }
            else if (value.CompareTo(node.Data) == -1)
            {
                Search(value, node.Left);
            }
            else if (value.CompareTo(node.Data) == 1)
            {
                Search(value, node.Right);
            }
            else if (node.Right == null && node.Left == null)
            {
                return null;
            }
            return node;
        }

        public void PrintInorder()
        {
            PrintInorder(bdata);
        }
        public void PrintInorder(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                PrintInorder(node.Left);
                Console.WriteLine(node.Data);
                PrintInorder(node.Right);
            }

        }
    }
}