// Finanači Kači

Console.WriteLine("--- Fibonači virknes segmentu ģenerators ---");
Console.Write("Fibanači skaitļa kārtas skaitlis:    ");
long FibNumb = Convert.ToInt64(Console.ReadLine());

int iFib = 0;
int nFib = 1;
int stefan = 2;
int nextFib = iFib + nFib;

while (stefan != FibNumb)
{
    nextFib = iFib + nFib;
    iFib = nFib;
    nFib = nextFib;
    stefan++;
}

int oneFib = iFib;
int twoFib = nFib;

nextFib = iFib + nFib;
iFib = nFib;
nFib = nextFib;
nextFib = iFib + nFib;
iFib = nFib;
nFib = nextFib;
nextFib = iFib + nFib;

Console.WriteLine($"{oneFib}; {twoFib}; {iFib}; {nFib}; {nextFib}");