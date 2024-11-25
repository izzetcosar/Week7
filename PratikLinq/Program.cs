public class program
{

    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { -5, -2, 0, 5, 10, 16, 19, 8, 21, 25 };

        var evenNumbers = numbers.Where(numbers => numbers % 2 == 0); //çift sayılar
        foreach (int number in evenNumbers)
        { Console.WriteLine(number); }

        Console.WriteLine("------------------------");
        var oddNumbers = numbers.Where(numbers => numbers % 2 != 0); //tek sayılar

        foreach (int number in oddNumbers)
        { Console.WriteLine(number); }

        Console.WriteLine("------------------------");


        var positiveNumbers = numbers.Where(numbers => numbers > 0); //pozitif sayılar

        foreach (int number in positiveNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("------------------------");
        var negativeNumbers = numbers.Where(numbers => numbers < 0); //negatif sayılar

        foreach (int number in negativeNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("------------------------");

        var squaredNumbers = numbers.Select(numbers => numbers * numbers); // sayıların karesi

        foreach (int number in squaredNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("------------------------");

        var xnumbers = numbers.Where(number => number > 17 && number < 22); //17 ile 22 arasındaki sayılar

        foreach (var num in xnumbers)
        {
            Console.WriteLine(num);
        }





    }
}