// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина который меньше или равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Массив из скольки элементов Вы хотите создать?");
int size = Convert.ToInt32(Console.ReadLine());

string[] yourArray = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write("Введите элемент Вашего массива: ");
    yourArray[i] = Console.ReadLine();
}
