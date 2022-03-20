/*
 * File: TestProject\Program.cs
 * Espresso Version 1.1
 * Author: Sira Pornsiriprasert
 * MIT License https://psira.mit-license.org/
 */

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            // String input = "(51+(73*2)-5)+10+(-50.1)*7+(10/((5*10)-1.9))";
            String input = "(3E2)";
            Espresso.Expression expression = new (input);
            double result = expression.Eval();
            Console.WriteLine(result);
        }
    }
}