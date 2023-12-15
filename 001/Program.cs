//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string[] number = Print("Введите элементы массива через запятую и пробел: ");
string[] result = Filter(number);

Console.WriteLine("Результат:");
for (int i = 0; i < result.Length; i++)
{
    Console.Write($"{result[i]} ");
}


static string[] Print(string text)
{
    Console.Write(text);
    return Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
}

static string[] Filter(string[] number)
{
    int count = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i].Length <= 3)
        {
            count++;
        }
    }

    string[] result = new string[count];
    int ind = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i].Length <= 3)
        {
            result[ind] = number[i];
            ind++;
        }
    }

    return result;
}