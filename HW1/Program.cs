/* Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Сколько числел вы хотели бы проверить?");
Console.Write("Введите количество: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[length];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Введите {i}-е число: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write($"Вы ввели числа: "); 
WriteArray(numbers);

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > 0)
    {
        sum++;
    }
}

Console.WriteLine($"Числе больше нуля - {sum}");

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

