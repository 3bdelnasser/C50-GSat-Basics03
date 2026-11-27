using System.Text;

namespace C50_GSat_Basics03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            /*Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print 
            both title and upperTitle to show that title did not change. */

            //string title = "clean code";

            //string upperTitle = title.ToUpper();

            //Console.WriteLine($"title: {title}");
            //Console.WriteLine($"upperTitle: {upperTitle}");
            #endregion

            #region Question 2
            /*Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() 
            to check if they point to the same object in memory. */

            //string s1 = "Clean Code";
            //string s2 = "Clean Code";

            //Console.WriteLine(ReferenceEquals(s1, s2));
            #endregion

            #region Question 3
            /*Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same 
            object. Print the final result.*/

            StringBuilder text = new StringBuilder("Book List");

            Console.WriteLine($"text before: {text}");

            text.Append(" - Updated");

            Console.WriteLine($"text after: {text}");
            #endregion
        }
    }
}
