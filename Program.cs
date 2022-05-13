
namespace BST_UC1_Insertion
{

    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("UC1_Creating Binary Search Tree"); 
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56); //56 is root
            binarySearch.Insert(30); //inserting 30 to left
            binarySearch.Insert(70);//inserting 70 to right
            binarySearch.Display();
            Console.ReadKey();
        }
    }
}
