// Задача 36. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int sum1 = 0, sum2 = 0;

FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот массив: ");
PrintArray(numbers);
//int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 == 0)
        sum1 = sum1 + numbers[i];
    else
        sum2 = sum2 + numbers[i];
}
Console.WriteLine("Сумма элементов на нечетных позициях: ={0} ", sum2);

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100, 100);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
