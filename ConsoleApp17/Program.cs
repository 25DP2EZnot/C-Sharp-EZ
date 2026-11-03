 ////Gessing game de Elgar
 
 // Set up the game
int Skaitlis = new Random().Next(1, 21);
int iespēja = 5;
int Minējums = 0;
 // Ask the player to guess

Console.WriteLine("Es iedomājos skaitli no 1 līdz 20");
Console.WriteLine("Tev ir 5 iespējas uzminēt,");
Console.WriteLine("citādi es nosūtīšu tava brauzera vēstures kopiju,");
Console.WriteLine("taviem zināmajiem, hehe laimi");

 // Check the guess and give feedback

while (Minējums != Skaitlis)
{
    if (iespēja != 0)
        {
            Console.Write("\nTavs minējums: ");
            Minējums = int.Parse(Console.ReadLine());
            if (Minējums < Skaitlis)
                {Console.WriteLine("\nPar maz, Pīrādzīņ,");
                iespēja--;}
            else if (Minējums > Skaitlis)
                {Console.WriteLine("\nPiebremzē, par daudz,");
                iespēja--;}
            else
                {break;}
        }
    else
        {iespēja = -1;
        break;}
}

 // Announce the result

 if (iespēja != -1)
{Console.WriteLine("\nMalacītis tu uzvarēji! Brauzera vēstures kopija ir \"dzēsta\".");}
else
{Console.WriteLine("\nHaha lašara, tagad tava ģimene zina par nešpetno tavu laika pavadīšanu, haha");
Console.WriteLine($"Jakas skaitlis bija {Skaitlis}, bet tas tev tagad nepalīdzēs");}