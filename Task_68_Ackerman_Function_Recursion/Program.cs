int M()
{
    System.Console.WriteLine("Введите M: ");
    int M = int.Parse(Console.ReadLine()!);
    return M;
}

int N()
{
    System.Console.WriteLine("Введите N: ");
    int N = int.Parse(Console.ReadLine()!);
    return N;
}


int AckermanFunction(int M, int N)
{
   if(M == 0) 
    {
        return N + 1;
    }
    else if(M > 0 && N == 0) 
    {
        return AckermanFunction(M - 1, 1);
    }
    else if(M > 0 && N > 0) 
    {
        return AckermanFunction(M - 1, AckermanFunction(M, N - 1));
    }
    else return -1;
}

int ackermanFunction = AckermanFunction(M(), N());
System.Console.WriteLine(ackermanFunction);