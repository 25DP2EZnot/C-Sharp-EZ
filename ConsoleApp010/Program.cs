//uzraksta vārdu tik reizes cik vārdā ir burtu.

//V1
Console.Write("Uzraksti vārdu: ");
string word1 = Console.ReadLine();
Console.WriteLine();
int i1 = 0;
while (i1 != word1.Length)
{Console.WriteLine(word1);
i1++;}

Console.WriteLine("Ja vēlies testēt otru versiju nospied enter: ");
Console.ReadLine();
Console.Clear();

//V2
Console.Write("Uzraksti vārdu: ");
string word2 = Console.ReadLine();
Console.WriteLine();
for (int i2 = 0;i2 != word2.Length;i2++)
{Console.WriteLine(word2);}