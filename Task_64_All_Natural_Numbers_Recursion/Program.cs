int EnteredNumber()
{
    System.Console.WriteLine("Enter a number for recursion: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int Rec(int N)
{
    if(N == 0) return 0;
    else 
    {
        System.Console.Write($"{N} ");
        return Rec(N - 1);
    }
}

Rec(EnteredNumber());