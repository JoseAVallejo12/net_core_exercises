using System;
namespace console_test_code.Utilities
{
    public class Utility
    {
        public Utility()
        {
        }

        public static int GetUserInput(string message)
        {
            int userValue;
            string? userinput="";
            try
            {
                Console.WriteLine(message);
                userinput = Console.ReadLine();
                userValue = Convert.ToInt16(userinput);
            }
            catch
            {
                throw new FormatException($"Value typing '{userinput}' don't allowed"); 
            }

            return userValue;
        }
    }
}

