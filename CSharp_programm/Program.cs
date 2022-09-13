// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void CheckElementLength(string[] array)  // метод поиска элементов массива длиной <= 3 и вывод таких элементов на экран
{
    string[] result = new string[array.Length];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            result[index] = array[i];
            Console.Write($"{result[index]} ");
            index++;
        }
    }
} 

void PrintArray(string[] array)  // метод вывода массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

string[] input = new string[] {"Hello", "2", "world", ":-)"}; //["Hello", "2", "world", ":-)"] или ["1234", "1567", "-2", "computer science"] или ["Russia", "Denmark", "Kazan"]
Console.Write("Исходный массив: ");
PrintArray(input); // печать заданного массива
Console.WriteLine();
Console.Write("Результат: ");
CheckElementLength(input); // вывод результата