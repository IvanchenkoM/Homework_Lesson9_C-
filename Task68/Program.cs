// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа N и M.

int start = ReadInt("Enter M: ");
int end = ReadInt("Enter N: ");

if (start<0 && end<0)
    Console.WriteLine("Please enter numbers greater than 0.");

Console.Write($"A({start},{end}) = ");
Console.Write(Akkerman(start,end));

int Akkerman(int n, int m)
{
    if (n == 0)        
        return m+1;
    if (n>0 && m == 0)
        return Akkerman(n-1,1);
    else
        return Akkerman(n-1, Akkerman(n,m-1));
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
