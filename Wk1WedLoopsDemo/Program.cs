using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

namespace Wk1WedLoopsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortedList mySL1 = new SortedList();
            //mySL1.Add("First", "Adam");

            List<string> myList = new List<string>();
            string inputName;

            //For
            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine(i);
                Console.Write("Enter a name: ");
                inputName = Console.ReadLine();
                myList.Add(inputName);
            }

            //While
            string userInput = "INITIALIZE_THIS_STRING_IN_SUCH_A_WAY_THAT_IT_IS_NOT_EMPTY=>SoThereIsSomethingBetweenTheQuotes";
            while (userInput != "")
            {
                Console.Write("Enter a name: ");
                userInput = Console.ReadLine();
                if ( userInput != "")
                {
                    myList.Add(userInput);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Break Between While And Do-While");
            Console.WriteLine();
            //DO-While
            userInput = "";
            do
            {
                Console.Write("Enter a name: ");
                userInput = Console.ReadLine();
                if (userInput != "")
                {
                    myList.Add(userInput);
                }
            } while (userInput != ""); // need a semicolon, unlike while - otherwise is the same


            //ForEach
            foreach (var s in myList)
            {
                Console.WriteLine("Hello " + s);
            }

            Console.WriteLine();
            Console.WriteLine("Break Between Foreach And For");
            Console.WriteLine();
            
            // For Each implemented as a for loop - this does the same thing as the foreach loop above
            //for (int i = 0; i < 3; i++)
            for (int i = 0; i < myList.Count(); i++ )
            {
                var s2 = myList[i];
                Console.WriteLine("Hello " + s2);
                //Console.WriteLine("Hello " + myList[i]);
            }


            int index = -1;
            //DoWhile with Index variable - same as for loop, except that executes statements at least once
            index = 1;
            do
            {
                Console.WriteLine("The index value is " + index + ".");
                index++;
            }while(index <= 100);

            //While with Index variable -> Same as for loop
            index = 1;
            while (index <= 100)
            {
                Console.WriteLine("The index value is " + index);
                index++;
            }













                Console.ReadLine();
        }
    }
}
