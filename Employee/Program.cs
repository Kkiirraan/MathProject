using MathLibrary;

namespace MathProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int add = MathOperations.Add(1, 2);
            Console.WriteLine(add);

            int sub=MathOperations.Sub(1, 2);
            Console.WriteLine(sub);
        }
    }
}
