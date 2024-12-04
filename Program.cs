using System.Diagnostics;
Console.Clear();
Console.WriteLine("This will help you find the Nth Palindromic Prime.");
Console.WriteLine("To start, enter any number for the nth prime you would like to see.");
Console.WriteLine("What Nth Palindromic Prime would you like to see?\n");
long n = ReadNumber();
Console.WriteLine($"The {n}th Palindromic Prime is: {NthPalindromicPrime(n)}");

long NthPalindromicPrime(long n)
{
    long Nth = 0;
    int i = 1;
    int x = 0;
    do
    {
        i++;
        if (isPrime(i) && isPalindromic(i))
        {
            x++;
            if (x >= n) //  x >= n to stop once we reach the nth prime
            {
                Nth = i;
                break;
            }
        }
    } while (true);
    return Nth;
}

// Checks if the number is prime
bool isPrime(long number)
{   if (number < 2) return false; // handle cases for numbers less than 2
    if (number == 2) return true;  // 2 is a prime number
    if (number % 2 == 0) return false; // takes away even numbers greater than 2
    double square = Math.Sqrt(number);
    for (int i = 3; i <= square; i += 2) // only check odd numbers after 2
    {
        if (number % i == 0) return false;
    }
    return true;
}

// Checks if the number is palindromic
bool isPalindromic(long number)
{
    string numString = number.ToString();
    return numString == writeBackwards(numString); // Direct comparison
}

long ReadNumber()
{
    long number = -1;
    do
    {
        try
        {
            Console.Write("Please enter a number: ");
            string num = Console.ReadLine();
            number = Convert.ToInt64(num);
            return number;
        }
        catch (FormatException)
        {
            number = -1;
        }
    } while (number == -1);
    return number;
}

// reverses a string without using a List
string writeBackwards(string forward)
{
    char[] charArray = forward.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}
