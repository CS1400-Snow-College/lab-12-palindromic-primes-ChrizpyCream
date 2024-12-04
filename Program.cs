using System.Diagnostics;
Console.Clear();
Console.WriteLine("This will help you find the Nth Palindromic Prime.");
Console.WriteLine("To start, enter any number for the nth prime you would like to see.");
Console.WriteLine("What Nth Palindromic Prime would you like to see\n");
Console.WriteLine(NthPalindromicPrime(ReadNumber()));


long NthPalindromicPrime(long n)
{
 long Nth = 0;
 int i = 1;
 int x = 0;
   do
    {
       i++;
       if(isPrime(i) == true && isPalindromic(i) == true)
       {
           x++;
           if(x > n)
           {
             break;
           }
            Nth = i;
        }
    }while(true);
    return Nth;
}


// checks if the number is prime
bool isPrime (long number)
{
    double square = Math.Sqrt(number);
    for(int i = 2; i <= square; i++)
    {
        if(number % i == 0)
            return false;
    }
    return true;
}


// checks if the number is palindromic
bool isPalindromic(long number)
{
    string NumString = number.ToString();
    if(writeBackwards(NumString) == NumString)
    {
        return true;
    }else
    {
        return false;
    }
    
}


long ReadNumber()
{
    long number = -1;
    do
    {
        try
        {
            Console.Write("Please enter a number ");
            string num = Console.ReadLine();
            number = Convert.ToInt64(num);
            return number;
        }catch(FormatException)
        {
            number = -1;
            
        }
    }while(number == -1);
    return number;
}


string writeBackwards(string Forward)
{
    List<char> Char_acters = new List<char>();
    string newString = "";
    foreach(char a in Forward)
    {
        Char_acters.Add(a);
    }
    Char_acters.Reverse();
    for(int i = 0; i<Char_acters.Count; i++)
    {
        
        newString = newString + Char_acters[i];
    }
    return newString;
}
