namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        private static bool response; // Declaring a private static bool variable

        static void Main(string[] args)
        {
            // Step 1: Delcare and initialize my variable
            int answer = 4;

            // Step 2: Determine if the answer is less than 9
            response = answer < 9; // This sets the resonse to True or False

            // Step 3: Use if-else to create the output message to user
            string message; // Declare the message variable

            if (response)
            {
                message = $"{answer} is less than nine"; // If response is only true
            }
            else
            {
                message = $"{answer} is greater than or equal to nine"; // If the response is false 
            }

            // Step 4: Output the message to the console
            Console.WriteLine(message); // Display the message 
        }
    }
}
