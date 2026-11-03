// 0 Player RPG

int hp = 3;
int dziras = 3;
Random rand = new Random();
bool speleTurpinas = true;

Console.WriteLine("--- Spēle sākas! ---");

while (speleTurpinas)
{
    Console.WriteLine($"Pašreizējais HP: {hp} | Dzīvības dziras: {dziras}");

    hp--;

    if (rand.Next(0, 100) < 30) 
    {
        dziras++;
        Console.WriteLine("-> Tu ieguvi 'Dzīvības dziru'!");
    }

    if (hp == 0)
    {
        Console.WriteLine("HP ir 0!");

        if (dziras == 0)
        {
            Console.WriteLine("Tev nav dziru. Tev nav atdzīvināšanas iespēja.");
            speleTurpinas = false;
            Console.WriteLine("[ZAUDRĒTS] Spēle beigusies!");
        }
        else
        {
            dziras--;
            int atdzimsanasProcents = rand.Next(1, 11);
            atdzimsanasProcents *= 10;
            Console.WriteLine($"Izmantota dzira! Tava atdzimšanas iespēja ir {atdzimsanasProcents}%.");

            if (rand.Next(0, 100) < atdzimsanasProcents)
            {
                hp = 3;
                Console.WriteLine("[VEIKSMĪGI] Dzira Tevi glāba! HP atjaunots uz 3.");
            }
            else
            {
                speleTurpinas = false;
                Console.WriteLine("[ZAUDRĒTS] Dzira nepalīdzēja. Spēle beigusies!");
            }
        }
        Console.WriteLine("-----------------------------------");
    }
}