Console.Write("Ierakstat atzīmi punktos: ");
int punkti = int.Parse(Console.ReadLine());

if (punkti < 0)
{
    Console.WriteLine("Neiespējami!");
}
else if (punkti >= 0 && punkti <= 49)
{
    Console.WriteLine("Neizdevās");
}
else if (punkti >= 50 && punkti <= 59)
{
    Console.WriteLine("1");
}
else if (punkti >= 60 && punkti <= 69)
{
    Console.WriteLine("2");
}
else if (punkti >= 70 && punkti <= 79)
{
    Console.WriteLine("3");
}
else if (punkti >= 80 && punkti <= 89)
{
    Console.WriteLine("4");
}
else if (punkti >= 90 && punkti <= 100)
{
    Console.WriteLine("5");
}
else if (punkti > 100)
{
    Console.WriteLine("Neticami!");
}