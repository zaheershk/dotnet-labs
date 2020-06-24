using System;
using ds_algo.BinarySearchTree;
using ds_algo.LinkedLists;

namespace ds_algo
{
    class Program
    {
        static void Main(string[] args)
        {
            // sort
            //Sort.BubbleSort(5, new int[5] { 2, 4, 8, 7, 1 });
            //Sort.SelectionSort(5, new int[5] { 2, 4, 8, 7, 1 });
            //Sort.InsertionSort(5, new int[5] { 2, 4, 8, 7, 1 });  
            //Sort.MergeSort(5, new int[5] { 2, 4, 8, 7, 1 });

            // search
            //Search.BinarySearch(new int[5] { 1, 2, 3, 4, 5 }, 5, 1);

            // linked-list
            //LinkedListActions.Initialize().Reverse();
            //LinkedListActions.Initialize().Find(4);

            // binary-search-tree
            //BstActions.Initialize().Root.PrintPretty("", NodePosition.center, true, false);
            //BstActions.Initialize().Root.Preorder();
            //Console.WriteLine("===");
            //BstActions.Initialize().Root.Inorder();
            //Console.WriteLine("===");
            //BstActions.Initialize().Root.Postorder();
            //Console.WriteLine("===");
            //BstActions.Initialize().Root.BreadthFirstTraversal();
            //Console.WriteLine("===");
            //BstActions.Initialize().Root.DepthFirstTraversal();
            SocialNetworkActions.Initialize().BreadthFirstTraversal();
            Console.WriteLine("===");
            SocialNetworkActions.Initialize().BreadthFirstSearch("Eva");
            SocialNetworkActions.Initialize().BreadthFirstSearch("Brian");
            SocialNetworkActions.Initialize().BreadthFirstSearch("Soni");
            Console.WriteLine("===");
            SocialNetworkActions.Initialize().DepthFirstTraversal();
            Console.WriteLine("===");
            SocialNetworkActions.Initialize().DepthFirstSearch("Eva");
            SocialNetworkActions.Initialize().DepthFirstSearch("Brian");
            SocialNetworkActions.Initialize().DepthFirstSearch("Soni");
        }
    }
}
