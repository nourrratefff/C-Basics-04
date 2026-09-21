using System.Globalization;

namespace C_Basics_04.Answers
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            String title = "Refactoring";

            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice !");
                    break;

                case "Refractoring":
                    Console.WriteLine("Nice pick!");
                    break;

                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }



            #endregion


            #region Question 2

            int pages = 464;


            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";


            #endregion


            #region Question 3

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            int i;

            for (i = 0; i < books.Length; i++)
            {

                Console.WriteLine($"{i+1}. {books[i]}");

            }

            #endregion


            #region Question 4
            int l = 0;
            while (l < books.Length)
            {
                Console.WriteLine(books[l]);
                l++;
            }


            #endregion


            #region Question 5
            int j = 0;
            do
            {
                Console.WriteLine("Checking book...");

                j++;

            } while (j < 3);


            #endregion

            #region Question 6

            foreach(string book in books)
            {
                Console.WriteLine(book);
            }





            #endregion


            #region Question 7

            for(i = 0; i < books.Length; ++i)
            {
                if (books[i] == "Refactoring")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(books[i]);
                }
            }


            #endregion


            #region Question 8

            for(i = 0; i < books.Length; ++i)
            {
                if(books[i] == "The Pragramtic Programmer")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(books[i]);
                }
            }
            #endregion


            PrintFirstBook(books);

            #region Question 1
            string title2 = "clean code";

            title2.ToUpper();

            string upperTitle = title2;

            Console.WriteLine(title2);
            Console.WriteLine(upperTitle);

            #endregion

            #region Question 2

            string string1 = "Clean Code";
            string string2 = "Clean Code";

            bool sameMemory = Object.ReferenceEquals(string1, string2);
            Console.WriteLine(sameMemory);

            #endregion

        }


        #region Question 9

        static void PrintFirstBook(string[] Array)
        {
            if(Array.Length == 0)
            {
                return;
            }

            else
            {
                Console.WriteLine(Array[0]);
            }
           
            


        }

        #endregion


    }
}





