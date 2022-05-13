using System;

namespace HashTablesAndBST
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Hashing Problem***");
            Console.WriteLine("***USE CASE 2-To find frequency of words *** ");
            Console.WriteLine("***Words :- to be or not to be");


            MyMapNode<string, int> myMapNode = new MyMapNode<string, int>(6);
            
                    string[] words = { "to", "be", "or", "not", "to", "be" };
                    int count = 1;
            
                foreach (string i in words)
                {
                    count = myMapNode.CheckHash(i);
                    if (count > 1)
                    {
                        myMapNode.Add(i, count);
                    }
                    else
                    {
                        myMapNode.Add(i, 1);
                    }
                }

                IEnumerable<string> uniqueItems = words.Distinct<string>();
                foreach (var i in uniqueItems)
                {
                    myMapNode.Display(i);
                }
            

            Console.ReadLine();

        }
    }

}


