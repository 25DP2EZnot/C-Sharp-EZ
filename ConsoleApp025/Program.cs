class Program
{
    static void Main()
    {
        PrintStars(5,"*");
        Console.Write("\n");
        PrintStars(3,"#");
        Console.Write("\n");
        PrintStars(9,"%");
        Console.Write("\n");

        PrintSquare(4,"*");
        PrintSquare(5,"*");
        PrintSquare(1,"^");
        PrintSquare(0,"^");

        PrintTriangle(3,"#");
        PrintTriangle(5,"^");
        PrintTriangle(8,"*");

        PrintPyramid(2,"^");
        PrintPyramid(5,"#");
        PrintPyramid(6,"*");
    }
    static void PrintStars(int count, string simb)
    {
        for (int i = 0; i != count; i++)
        {
            Console.Write(simb);
        }
        Console.Write("\n");

    }
    static void PrintSquare(int size, string simb)
    {
        for (int i = 0; i != size; i++)
        {
            PrintStars(size, simb);
        }
        Console.Write("\n");

    }

    static void PrintTriangle(int trip, string simb)
    {
        for (int i = 0; i != trip; i++)
        {
            PrintStars(i+1, simb);
        }
        Console.Write("\n");

    }

    static void PrintPyramid(int height, string simb)
    {
        for (int i = 0; i != height; i++)
        {            
            for (int a = 1; a != height-i; a++)
            {
            Console.Write(" ");
            }
            PrintStars(1+i*2, simb);
        }
        Console.Write("\n");
    }
}