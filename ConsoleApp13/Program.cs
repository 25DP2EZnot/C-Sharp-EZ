Console.Write("Saki pozitīvu skaitli un es līdz tam aizskaitīšu: ");
int Numb = int.Parse(Console.ReadLine());

for (int i = 0; i != Numb+1; i++)
{Console.WriteLine(i);}

Console.Write("Skaties es to izdarīšu vēl vienu reizi, bet citā paņēmienā, tev tikai jānospīež enter:");
Console.ReadLine();
Console.Clear();

int a = 0;

while (a != Numb+1)
{{Console.WriteLine(a);}
a++;}

Console.Write("Ok ok tagad es to izdarīšu vienā līnijā! nospied enter, lūdzu:");
Console.ReadLine();
Console.Clear();

Console.Write("Saki pozitīvu skaitli un es līdz tam aizskaitīšu: ");
int Numb2 = int.Parse(Console.ReadLine());

for (int i2 = 0; i2 != Numb2+1; i2++)
{Console.Write(i2 + " ");}

Console.Write("Skaties es to izdarīšu vēl vienu reizi, bet citā paņēmienā, tev tikai jānospīež enter:");
Console.ReadLine();
Console.Clear();

int a2 = 0;

while (a2 != Numb+1)
{{Console.Write(a2 + " ");}
a2++;}