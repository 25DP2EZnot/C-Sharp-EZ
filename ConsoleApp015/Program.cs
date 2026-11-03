// tikai skaitļu pieskaite bez nulles
int Numb = 1;
int i = 0;

while (Numb != 0)
{
    Console.WriteLine("Ierakstiet pieskaitāmo: ");
    Numb = int.Parse(Console.ReadLine());
    if (Numb != 0)
    {i += Numb;}
    else
    {Console.Write($"Skaitļa summa: {i}");}
}