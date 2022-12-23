// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// int Stepen(int A, int B)
// {
//     int S = A;
//     for(int i = 1; i<B; i++)
//         S *= A;
//     return S;
// }
// Console.Write("Enter number A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// int res = Stepen(A, B);
// Console.Write($"Результат равен {res}");


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// int Summ(int N)
// {
//     int S = 0;
//     while (N>0)
//     {
//         S = S + N % 10;
//         N = N /10 ;
//     }
//     return S;


// }
// Console.Write("Enter your number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int res = Summ(N);
// Console.WriteLine($"Сумма цифр в числе {N} равна {res}");


//  Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] Array(int N)
{
    int [] arr = new int [N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next();
    }
    return arr;
}
void ShowArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.Write("Write your length: ");
int lengthMass = Convert.ToInt32(Console.ReadLine());
ShowArray(Array(lengthMass));
