Console.Write("Ievadiet varoņa vārdu: ");
string name = Console.ReadLine();
Console.Write("");

Console.Write("Ievadiet varoņa imperālos pieredzes punktus: ");
int XP = int.Parse(Console.ReadLine());
Console.Write("");

if (XP < 0)
{
    Console.Write($"Varonis {name} ir neiespējams");
}
else if (0 <= XP && XP <= 99)
{
    Console.Write($"Zemnieks {name}");
}
else if (100 <= XP && XP <= 249)
{
    Console.Write($"Peidzīvojumu meklētājs {name}");
}
else if (250 <= XP && XP <= 499)
{
    Console.Write($"Karotājs {name}");
}
else if (500 <= XP && XP <= 749)
{
    Console.Write($"Bruņinieks {name}");
}
else if (750 <= XP && XP <= 999)
{
    Console.Write($"Fjords {name}");
}
else if (1000 <= XP && XP <= 1500)
{
    Console.Write($"Leģendārais varonis {name}");
}
else if (1501 <= XP && XP <= 5000)
{
    Console.Write($"Dievu izrdzētais {name}");
}
else
{
    Console.Write($"Tas nav, \"{name}\", bet gan Elgars!");
}