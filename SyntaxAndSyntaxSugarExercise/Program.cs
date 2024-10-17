using System;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        private static bool response; // I'm Keeping the original variable as directed. 

        static void Main(string[] args)
        {
            var answer = 4; // Inferred typing with var "step 1 in instructions". 

            response = answer < 9; // I'm setting response type to True or False.

            // Using ternary operator "Step 3 in assignment"
            var message = response
                ? $"{answer} is less than nine"
                : $"{answer} is greater than or equal to nine"; // I'm using string interpolation " Step 2 in instructions". 

            Console.WriteLine(message); //  Output the message.
        }
    }
}


// So my task was to Refactor the code to use 3 things "Inferred Typing, String Interpolation, and Tenary Operator, each step is noted in the source. 
// Step 1. Inferred Typing - was to "Replace explicit types with (VAR).
// Step 2. String Interpolation - I was instructed to Refactor the concatenation to use string interpolation.
// Step 3. Ternary Operator -  I needed to replace the "if-else" statement with a ternary operator. 
// Step 4. Did I do this correctly! Y/N :)