// Напишите программу, которая задаёт массив из некоторого количества элементов
// и выводит их на экран с помощью функций. 
//(можно спрашивать количество вводимых элементов и вводить все значения с клавиатуры)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write(" Введите количество элементов массива: ");
int elemetnsCount = Convert.ToInt32(Console.ReadLine());
int [] myArray = new int [elemetnsCount];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($" Введите элемент массива под индексом {i} :");
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Вывод Массива");
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}
