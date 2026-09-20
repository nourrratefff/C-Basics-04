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




















        }
    }
}
