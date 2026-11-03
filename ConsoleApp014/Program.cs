// tikai pozitīvi kvadrāti
int Numb = 1;

while (Numb != 0)
{
    Console.WriteLine("Ievadi skaitli: ");
    Numb = int.Parse(Console.ReadLine());
    if (Numb <= 0)
    {
        Console.Write("Nepiemērots skaitlis");
    }
    else
    {
        Console.Write(Numb*Numb + " ");
    }
}