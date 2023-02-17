//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int PrintSum(int m, int n)
{
    if(n==m) return n;
    else return n + PrintSum(m, n-1); 
}

void Main()
{
    Console.Write("Введите чсло M: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите чсло N: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine($" N = {n}; M = {m} -> {PrintSum(m, n)}");
}

Main();