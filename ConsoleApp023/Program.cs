//Atlaižu piemērošana precēm

int[] preces = {  25, 40, 15, 60, 30 };
int[] discountedprices = new int[preces.Length];
int Nr = 0;
Console.Write("\n");

foreach (int cena in preces)
{
    if (cena > 30)
    {
        discountedprices[Nr] = cena - cena/10;
    }
    else
    {
        discountedprices[Nr] = cena;
    }

    Console.WriteLine($"Orģinālā cena: {cena}");
    Console.WriteLine($"Cena pēc apstrādes: {discountedprices[Nr]}\n");
    Nr++;
}

int sum1 = 0;
int sum2 = 0;

Console.WriteLine($"Orģinālās cenas: ");

foreach (int i in preces)
{
    sum1 += i;
    Console.Write($"{i} ");
}
Console.Write("\n");

Console.WriteLine($"Apstrādātās cenas:");

foreach (int i in discountedprices)
{
    sum2 += i;
    Console.Write($"{i} ");
}
Console.Write("\n\n");

Console.WriteLine($"Kopējā cenu summa: {sum1}");
Console.WriteLine($"Kopējā cenu ar atlaidēm summa: {sum2}");
Console.WriteLine($"Kopējā atlaide: {sum1 - sum2}");

Console.Write("\n");