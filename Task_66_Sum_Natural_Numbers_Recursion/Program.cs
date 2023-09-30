int MinNum()
{
    System.Console.WriteLine("Введите минимальное значение: ");
    int min = int.Parse(Console.ReadLine()!);
    return min;
}

int MaxNum()
{
    System.Console.WriteLine("Введите максимальное значение: ");
    int max = int.Parse(Console.ReadLine()!);
    return max;
}


int Sum(int M, int N)
{
    
     if (M == N) return N;
    else return Sum(M + 1, N) + M;
}


System.Console.WriteLine($"{Sum(MinNum(), MaxNum())}");