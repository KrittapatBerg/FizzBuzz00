namespace FizzBuzz00;

public static class Program
{
    public static void Main(string[] args)
    {
        string fizz = "Fizz";
        string buzz = "Buzz";
        string fb = "FizzBuzz";

        int number = 100;

        for (int i = 0; i < number; i++)
        {
            if (i % 3 == 0 )
            {
                Console.WriteLine(fizz);
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine(buzz);
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine(fb);
            }
            else  Console.WriteLine(i);
        }
        
        
    }
}
