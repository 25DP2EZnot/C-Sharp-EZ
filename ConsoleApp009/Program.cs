// Finanači Kači

Console.WriteLine("--- Fibonači virknes segmentu ģenerators ---");
Console.Write("Kad stop(līdz 92)?    ");
long FibNumb = Convert.ToInt64(Console.ReadLine());

if (FibNumb > 92)
{
    Console.WriteLine("Tātad, tu mums nemāki lasīt, kas ir iekavās?");
}
else
{
    long iFib = 0;
    long nFib = 1;
    long nextFib = 0;
    long stefan = 0;

    Console.WriteLine($"{nextFib}");
    nextFib = iFib + nFib;

    while (stefan != FibNumb)
    {
        Console.WriteLine($"{nextFib}");
        nextFib = iFib + nFib;
        iFib = nFib;
        nFib = nextFib;
        stefan++;
    }
}