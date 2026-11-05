//Darbinieku piemaksu aprēķins

string statuss = "";
int les = 0;
int evn = 0;
int mor = 0;
int[] hours = { 28, 35, 42, 18, 40, 26, 50 };

for (int i = 0; hours.Length != i; i++)
{
    if (hours[i] <= 30)
    {
        les++;
        statuss = "Nepilna slodze";
    }
    else if (30 <= hours[i] && hours[i] <= 40)
    {
        evn++;
        statuss = "Normāla slodze";
    }
    else
    {
        mor++;
        statuss = "Virsstundas";
    }

    Console.WriteLine($"{hours[i]} stundas -> {statuss}");
}

Console.WriteLine($"Darbineiki ar nepilnu slodzi: {les}");
Console.WriteLine($"Darbineiki ar normālu slodzi: {evn}");
Console.WriteLine($"Darbineiki ar virsstundām: {mor}");