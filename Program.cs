
using System;

namespace UC_2FrequencyForParagraph
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Hashing Problem***");
            Console.WriteLine("***USE CASE 3-Remove the word in a paragraph *** ");
            Console.WriteLine("***Paragraph :- Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations");


            MyMapNode<string, int> myMap = new MyMapNode<string, int>(10);
            string[] Paragraph;
            string input = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            Paragraph = input.Split(' ');
            //Given string input

            int counts = 1;
            foreach (string i in Paragraph)
            {
                counts = myMap.CheckHash(i);
                if (counts > 1)
                {
                    myMap.Add(i, counts);
                }
                else
                {
                    myMap.Add(i, 1);
                }
            }
            IEnumerable<string> unique = Paragraph.Distinct<string>();
            Console.WriteLine("\nEnter the word which you want to remove in paragraph");
            string removeWord = Console.ReadLine();
            myMap.Remove(removeWord);
            foreach (var i in unique)
            {
                myMap.Display(i);
            }
            Console.ReadLine();
        }
    }

}



