int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

/*
int A = ReadInt("Введите число A: ");

int GetSum (int x)
{
    int sum = 0;
    for(int i = 1; i <= A; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.WriteLine("Сумма чисел от 1 до " + A + " = " + GetSum(A));
*/
/*
int N = ReadInt("Введите число N: ");

int i = 0;

int CheckLen(int x)
{
    if (N == 0)
    {
        i++;
    }
    else
    {
        while (N != 0)
        {
            N = N / 10;
            i++;
        }
    }

    return i;
}

Console.WriteLine("В числе " + CheckLen(N) + " цифр");
*/
/*
int N = ReadInt("Введите число N: ");


int Proizv(int x)
{
    int rez = 1;
    for(int i = 1; i <= N; i++)
    {
        rez = rez * i;
    }
    return rez;
}

Console.WriteLine("Произведения числе от 1 до " + N + " равно: " + Proizv(N) + ".");
*/

int len = 8;
int[] homework = new int[8];
for (int i = 0; i < len; i++)
{
    homework[i] = new Random().Next(0, 9);
    Console.Write(homework[i] + " ");
}
