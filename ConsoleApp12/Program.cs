// Bolts, nuts and washers!

Console.Write("Cik vajag skrūves?: ");
int bolt = int.Parse(Console.ReadLine());
Console.Write("Cik vajag uzgriežņu?: ");
int nut = int.Parse(Console.ReadLine());
Console.Write("Cik vajag paplāksnes?: ");
int washer = int.Parse(Console.ReadLine());

int i = 0;

if (!(nut >= bolt))
{Console.WriteLine("Pārbaudi pasūtījumu, par maz uzgriežņu!");
i++;}

if (!(2*washer >= bolt))
{Console.WriteLine("Pārbaudi pasūtījumu, par maz uzgriežņu!");
i++;}

if (i == 0)
{Console.WriteLine("Pasūtījums pareizs.");}

Console.WriteLine($"\nPasūtījuma summa ir {bolt*5+nut*3+washer} centi.");
Console.Write($"Jeb {(bolt*5+nut*3+washer)/100.00} eiro.");