
namespace Compare
{
    class Program
    {
        static string? GetNum()
        {
            return Console.ReadLine();
        }
        static bool IsNumThere(string? num)
        {
            if (num == null || num == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool IsNumeric(string? num)
        {
            int i = 0;
            int numLength = num.Length - 1;
            do
            {
                if (Char.IsNumber(num, i))
                {
                    return true;
                }
                i++;
            }
            while (numLength >= i);
            return false;
        }
        static bool IsNumLetter(string? num)
        {
            int i = 0;
            int numLength = num.Length - 1;
            do
            {
                if (Char.IsLetter(num, i))
                {
                    return true;
                }
                i++;
            }
            while (numLength >= i);
            return false;
        }
        static string? ValidateNum()
        {
            bool numIsThere = false;
            bool numIsNum = false;
            bool numIsLetter = true;
            string? num;

            do
            {
                num = GetNum();
                numIsThere = IsNumThere(num);

                if (!numIsThere)
                {
                    Console.Write("Nothing was entered.\nPlease pick a number: ");
                    continue;
                }

                numIsNum = IsNumeric(num);
                numIsLetter = IsNumLetter(num);

                if (!numIsNum || numIsLetter)
                {
                    Console.Write("Something other than a number was entered.\nPlease pick a number: ");
                    continue;
                }
            }
            while (!numIsThere || !numIsNum || numIsLetter);

            return num;
        }
        static void Main(string[] args)
        {
            Console.Write("This tool will compare two numbers for you.\nPlease choose a first number: ");

            string? num1 = ValidateNum();

            Console.Write("Please choose a second number: ");

            string? num2 = ValidateNum();

            Console.WriteLine($"You\'ve chosen {num1} as your first number, and {num2} as your second number. ");

            if (Convert.ToDouble(num1) > Convert.ToDouble(num2))
            {
                Console.WriteLine($"The number {num1} is greater than the number {num2}. ");
            }
            else if (Convert.ToDouble(num1) < Convert.ToDouble(num2))
            {
                Console.WriteLine($"The number {num2} is greater than the number {num1}. ");
            }
            else
            {
                Console.WriteLine($"The number {num1} is equal to the number {num2}. ");
            }

            Console.WriteLine("Thank you for using this tool.");
        }
    }
}
