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


















        }
    }
}





