// Напишите функцию, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumAllN (int N)
{
int result = 0;
while ( N > 0)
{
    int sum = N % 10;
    result = result + sum;
    N = N/10;
}
return result;
}
Console.WriteLine(SumAllN(452));
Console.WriteLine();
Console.WriteLine(SumAllN(82));
Console.WriteLine();
Console.WriteLine(SumAllN(9012));