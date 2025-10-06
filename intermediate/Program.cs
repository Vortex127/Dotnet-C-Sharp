
namespace Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Max(5, 7));
            Console.WriteLine(Math.Min(5, 7));
            Console.WriteLine(Math.Sqrt(16));
            Console.WriteLine(Math.Abs(16));
            Console.WriteLine(Math.Round(6.3));

            string txt = "kjdgjhvjhsvhnhbkjg78ty72gjh csbvkjbdbvciuycgshgvjhauyvb";
            Console.WriteLine("The length is: " + txt.Length);
            Console.WriteLine("The text is: " + txt.ToUpper());
            Console.WriteLine("The text is: " + txt.ToLower());

            
        }
    }
}