class Program
{
    public static void Main()
    {
        PrintIsLeapYear(2004);
    }
    public static bool IsDivisibleBy(int firstInt, int secondInt) => firstInt % secondInt == 0;
    public static bool IsLeapYear(int Year)
    {
        if ((IsDivisibleBy(Year, 4) == true && IsDivisibleBy(Year, 100) == false) || IsDivisibleBy(Year, 400) == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static void PrintIsLeapYear(int Year)
    {
        if (IsLeapYear(Year) == true)
        {
            Console.WriteLine($"{Year} is a leap year");
        }
        else
        {
            Console.WriteLine($"{Year} is not a leap year");
        }
    }
}
