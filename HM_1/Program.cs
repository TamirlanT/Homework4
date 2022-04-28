// Напишите (функцию) цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Stepen (int A, int B)
{
    int result = 1;
    int i = 1;
    for (i=1; i<=B; i++)
    {
        result = result * A;
    }
    return result;
}
Console.WriteLine(Stepen(3,5));
Console.WriteLine();
Console.WriteLine(Stepen(2,4));