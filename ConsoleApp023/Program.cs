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