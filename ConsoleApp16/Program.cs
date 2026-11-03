// nodaļu meikers

string Chap = "";
string Lpp = "";
string Dots = "";
int DontMuch = 0;
string Chapt = "";
string ChaptAll = "";


Console.WriteLine("Nodaļu dauduzms: ");
int ChapMuch = int.Parse(Console.ReadLine());

for (int i = 1; i != ChapMuch+1; i++)
{
Console.WriteLine("Nodaļas nosaukums: ");
Chap = Console.ReadLine();
Console.WriteLine("Lapas puses numurs: ");
Lpp = Console.ReadLine();
DontMuch = 40 - (Chap.Length + Lpp.Length);
Dots = new string('.', DontMuch);
Chapt = (Chap + Dots + Lpp);
Console.WriteLine(Chapt);
ChaptAll += (Chapt + "\n");
}
Console.WriteLine("\nTātad nodaļas kopā sakn:\n\n ---Satura rādītājs---\n");
Console.WriteLine(ChaptAll);