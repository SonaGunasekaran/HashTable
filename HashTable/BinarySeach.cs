using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
        public class TreeNode<T>
        {
            public T value;
            public TreeNode<T> Left;
            public TreeNode<T> Right;
            public TreeNode(T value)
            {
                this.value = value;
                this.Left = null;
                this.Right = null;
            }
        }
        
        class BinarySearchTree<T> where T : IComparable
        {
            public TreeNode<T> root;
            int count = 0;
            
            public void AddNode(T value)
            {
                TreeNode<T> newNode = new TreeNode<T>(value);
                
                if (root == null)
                {
                    root = newNode;
                }
              
                else
                {
                    TreeNode<T> parent = root;
                    TreeNode<T> current = root;
                    //repeat the loop until the condition becomes true
                    while (true)
                    {
                        parent = current;
                        //if the current node value is greater than new node 
                        if (current.value.CompareTo(value) >= 0)
                        {
                            current = current.Left;
                            if (current == null)
                            {
                                parent.Left = newNode;
                                break;
                            }
                        }
                       
                        else
                        {
                            current = current.Right;
                            if (current == null)
                            {
                                parent.Right = newNode;
                                break;
                            }
                        }
                    }
                }
            }

            public void Display(TreeNode<T> parent)
            {
                if (parent != null)
                {
                    Display(parent.Left);
                    Console.WriteLine("The node :{0}", parent.value);
                    Display(parent.Right);
                }
            }

            public int SizeOf(TreeNode<T> parent)
            {
                //check if the root is null
                if (parent == null)
                {
                    return 0;
                }
                //else find size of left sub tree and size of right sub tree 
                else
                {
                    return (SizeOf(parent.Left) + 1 + SizeOf(parent.Right));
                }
            }

            public int SearchTree(T value)
            {
                if (root == null)
                {
                    return 0;
                }
                else
                {
                    TreeNode<T> current = root;
                    while (true)
                    {
                        if (current == null)
                        {
                            return 0;
                        }
                        if (current.value.CompareTo(value) == 0)
                        {
                            return 1;
                        }
                        else if (current.value.CompareTo(value) > 0)
                        {
                            current = current.Left;
                        }
                        else
                        {
                            current = current.Right;
                        }
                    }
                }
            }
        }
}

