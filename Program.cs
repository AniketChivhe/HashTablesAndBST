
using System;

namespace UC_2FrequencyForParagraph
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Hashing Problem***");
            Console.WriteLine("***USE CASE 2-To find frequency of words *** ");
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
            Console.WriteLine("\n---------Frequency of words in paragraph---------\n");
            IEnumerable<string> distinct = Paragraph.Distinct<string>();
            foreach (var i in distinct)
            {
                myMap.Display(i);
            }
            Console.ReadLine();
        }
    }

}


