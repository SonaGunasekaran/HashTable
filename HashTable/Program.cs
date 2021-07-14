using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.HashTable\n2.Binary Search Tree");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Hash<string, int> hash = new Hash<string, int>(10);
                    string para = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    string[] words = para.Split(" ");
                    for (int i = 0; i < words.Length; i++)
                    {
                        hash.AddNode(words[i], 1);
                    }
                    hash.Display();
                    Console.WriteLine("The frequency of paranoid is {0}", hash.Frequency("paranoid"));
                    break;

                case 2:

                    BinarySearchTree<int> binarySearch = new BinarySearchTree<int>();
                    binarySearch.AddNode(56);
                    binarySearch.AddNode(30);
                    binarySearch.AddNode(70);
                    binarySearch.AddNode(60);
                    binarySearch.AddNode(3);
                    binarySearch.AddNode(11);
                    binarySearch.AddNode(22);
                    binarySearch.AddNode(40);
                    binarySearch.AddNode(65);
                    binarySearch.AddNode(95);
                    binarySearch.AddNode(63);
                    binarySearch.AddNode(67);
                    binarySearch.AddNode(16);
                    binarySearch.Display(binarySearch.root);
                    Console.WriteLine("the number of node in the tree is :{0}", binarySearch.SizeOf(binarySearch.root));
                    break;
                default:
                    break;

            }
        }
    }
}

