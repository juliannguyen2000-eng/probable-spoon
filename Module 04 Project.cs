using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("First Input:");
        string input1 = Console.ReadLine();
        if (string.IsNullOrEmpty(input1) || input1 == "null")
            throw new ArgumentNullException(nameof(input1), "First input cannot be null or empty!"); // argumentnullexception

        Console.WriteLine("Second Input:");
        string input2 = Console.ReadLine();
        if (string.IsNullOrEmpty(input2) || input2 == "null")
            throw new ArgumentNullException(nameof(input2), "Second input cannot be null or empty!");

        try
        {
            int number1 = Convert.ToInt32(input1); // takes the first input and converts it into a number
            int number2 = Convert.ToInt32(input2); // takes the second input and converts it into a number

            int result = number1 / number2; // this divides the first integer by the second integer

            Console.WriteLine($"Result: {result}"); // writes the result, if not the catches should be able to assist in determing what error occured
        }
        catch (FormatException ex) //formatexception in the assignment
        {
            Console.WriteLine("Inputs 1 and/or 2 are not numeric values."); // displays if the inputs are not numeric values, i believe writelines should be in layman's terms.
            Console.WriteLine($"   Details: {ex.Message}"); // a more detailed explanation as to what happened
            Console.WriteLine($"   Stack Trace: {ex.StackTrace}"); // helps a debugger find out where exactly the code went wrong.
        }
        catch (DivideByZeroException ex) // dividebyzeroexception in the assignment
        {
            Console.WriteLine("Second input cannot be 0.");
            Console.WriteLine($"   Details: {ex.Message}");
            Console.WriteLine($"   Stack Trace: {ex.StackTrace}");
        }
        catch (OverflowException ex) // overflowexception, not listed in assignment but for step 2
        {
            Console.WriteLine("The number is either too large or too small! Please keep values between -2147483648 and 2147483647.");
            Console.WriteLine($"   Details: {ex.Message}");
        }
        catch (Exception ex) // exception catches should always come last, as it is the most general one. c# goes down the list of exceptions from top to bottom and outputs the first one that corresponds to the error.
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            Console.WriteLine($"   Details: {ex.Message}");
            Console.WriteLine($"   Stack Trace: {ex.StackTrace}");
        }
        finally
        {
            Console.WriteLine("Operation complete.");
        }
    }
}
