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

















        }
    }
}
