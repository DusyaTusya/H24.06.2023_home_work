// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Например: [345, 897, 568, 234] -> 2

int[] GenerateArray(int len, int min, int max) // функция генерации массива
{
    int[] answer = new int[len]; 
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max + 1);
    }
    return answer;
}

void PrintArray(int[] array) // функция вывода на экран
{
    foreach (int item in array) // цикл по перебору элементов массива
    {
        System.Console.Write(item + "\t"); 
    }
    System.Console.WriteLine(); 
}

int count(int[] array) // функция по нахождению количества элементов, удовлетворяющих условию
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0) // число должно делиться на 2 без остатка
        {
            sum ++;
        } 
    }return sum;
}

int[] newArray = GenerateArray(10, 100, 1000); // задаем параметры массива (длина, минимальное значение, максимальное значение)
PrintArray(newArray); // вывод массива на экран
System.Console.WriteLine($"В данном массиве положительных чисел - {count(newArray)}.");