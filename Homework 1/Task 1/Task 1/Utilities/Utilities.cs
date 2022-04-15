using Task_1.Entities;

namespace Task_1.Utilities
{
    public static class Utilities
    {
        // Checks if the input is an empty string or null
        public static bool CheckInput(this string input)
        {
            return String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input);
        }
        // Checks if username or password are valid
        public static string CheckCredentals(this string inputUsernameOrPassword, string usernameOrPassword)
        {
            while (true)
            {
                Console.WriteLine($"Enter {usernameOrPassword}:");
                inputUsernameOrPassword = Console.ReadLine();
                if (inputUsernameOrPassword.CheckInput())
                {
                    Console.WriteLine("Invalid input! Input must contain atleast one character!");
                    continue;
                }
                else break;
            }
            return inputUsernameOrPassword;
        }
        public static int CheckInput(this Teacher teacher, string username, string password, int count)
        {
            if (teacher.Username == username && teacher.Password != password)
            {
                return 2;
            }
            else if (teacher.Username == username && teacher.Password == password)
            {
                return 1;
            }
            return 3;
        }
    }
}
