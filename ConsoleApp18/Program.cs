//Autostāvvieta
//No Elgara
//Esmu gandarīt, jo tagad viss strādā!
//līnijas no 16 lidz 26 ir opcionālas, tās ir lai apskatītu fīčas labāk

string[] pakingSpace = new string[10];

List<string> parkingHistory = new List<string>();

List<string> vipCars = new List<string>();

bool isOn = true;
string izNurZim = "";
int a = 0;

pakingSpace[1] = "VIPAB1234";
pakingSpace[3] = "RK7846";
pakingSpace[6] = "TL9027";
pakingSpace[7] = "MZ4516";
pakingSpace[9] = "JN6399";

parkingHistory.Add(pakingSpace[1]);
parkingHistory.Add(pakingSpace[3]);
parkingHistory.Add(pakingSpace[6]);
parkingHistory.Add(pakingSpace[7]);
parkingHistory.Add(pakingSpace[9]);


while (isOn)
{
    Console.WriteLine("\nIzvēlaties komandu, rakstiet tikai ciparu\n");
    Console.WriteLine("1 - Novietot automašīnu");
    Console.WriteLine("2 - Izņemt automašīnu");
    Console.WriteLine("3 - Parādīt visas stāvvietas");
    Console.WriteLine("4 - Meklēt automašīnu, un līdzīgi varianti");
    Console.WriteLine("5 - Parādīt vēsturi");
    Console.WriteLine("6 - Aizņemtības statistika");
    Console.WriteLine("0 - Iziet\n");

    int answer = int.Parse(Console.ReadLine() ?? "");



    if (answer == 1)
    {
        Console.WriteLine("Ievadiet ievietojamās māšīnas numura zīmi: ");
        izNurZim = Console.ReadLine() ?? "";

        if (!(izNurZim.Length >= 5))
        {
            Console.WriteLine("Nederīga numura zīme.");
            break;
        }

        int unoMT = Array.IndexOf(pakingSpace, null);
        if (unoMT != -1)
        {
            if (izNurZim.Substring(0, 3) == "VIP")
            {
                Console.WriteLine("VIP automašīna ieradusies!");
                vipCars.Add($"{izNurZim} VIP automašīna ieradusies!");
            }
            pakingSpace[unoMT] = izNurZim;
            parkingHistory.Add(izNurZim);
            Console.WriteLine($"Auto novietots vietā Nr.{unoMT+1}");
        }
        else
        {
            Console.WriteLine("Nav brīvu stāvvietu.");
        }
    }



    else if (answer == 2)
    {
        Console.WriteLine("Ievadiet izņemamo mašīnas numura zīmi: ");
        izNurZim = Console.ReadLine() ?? "";

        int nowMT = Array.IndexOf(pakingSpace, izNurZim);

        if (nowMT != -1)
        {
            pakingSpace[nowMT] = "";
            Console.WriteLine($"Auto izbrauca no vietas Nr. {nowMT+1}");
        }
        else
        {
            Console.WriteLine("Auto nav atrasts.");
        }
    }



    else if (answer == 3)
    {
        for (int i = 0; i < 10; i++)
        {
            if (pakingSpace[i] == "" || pakingSpace[i] == null)
            {
                Console.WriteLine($"{i+1}. vieta - [Brīva]");
            }
            else
            {
                Console.WriteLine($"{i+1}. vieta - {pakingSpace[i]}");
            }
        }    
    }



    else if (answer == 4)
    {
        Console.WriteLine("Ievadiet numura zīmi, vai tās daļu: ");
        izNurZim = Console.ReadLine() ?? "";

        if (izNurZim.Length <= 5)
        {
            Console.WriteLine("Visas mašīnas ar šādu zīmes numura daļu");
            for (int i = 0; i < pakingSpace.Length; i++)
            {
                if (pakingSpace[i] != null && pakingSpace[i].Contains(izNurZim))
                {
                    Console.WriteLine(pakingSpace[i]);
                }
            }
        }
        else
        {
            int itsHere = Array.IndexOf(pakingSpace, izNurZim);

            if (itsHere != -1)
            {
                Console.WriteLine($"Auto atrodas vietā Nr.{itsHere+1}");
            }
            else
            {
                Console.WriteLine("Auto nav atrasts.");
            }
        }
    }



    else if (answer == 5)
    {
        parkingHistory.ForEach(Console.WriteLine);
    }



    else if (answer == 6)
    {
        for (int i = 0; pakingSpace[i] == null; i++)
        {
            a++;
            Console.WriteLine($"Brīvas vietas: {a}");
            Console.WriteLine($"Aizņemtās vietas: {10-a}");
            Console.WriteLine($"Noslodze: {(10-a)*10}%");
        }    
    }



    else if (answer == 0)
    {
        isOn = false;
        break;
    }
}