// Ask for number
Console.WriteLine("Enter nubmer from 1 - 100: ");
int Numb = Convert.ToByte(Console.ReadLine());

// is Numb devisabeliy of 3 Fizz

// is Numb devisabeliy of 5 Buzz

// is Numb devisabeliy of 3 and 5  FizzBuzz

if (Numb > 100 || Numb < 0)
{
    Console.WriteLine("Not in the trucking rainge you filfy animal!");
}
else if (Numb % 3 == 0 && Numb % 5 == 0)
{
    Console.WriteLine("FizzBuzz");
}
else if (Numb % 3 == 0)
{
    Console.WriteLine("Fizz");
}
else if (Numb % 5 == 0)
{
    Console.WriteLine("Buzz");
}
else
{
    Console.WriteLine(Numb);
}