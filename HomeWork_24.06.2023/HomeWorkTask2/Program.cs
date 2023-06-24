// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int sumNumber(int[] array) // функция по вычислению суммы чисел, стоящих на нечетных позициях
{
    int sum = 0;
    for (int i = 1; i <= array.Length; i = i+2)
    {
        sum  += array[i];
    } 
    return sum;
}

int[] newArray = GenerateArray(4, -10, 10); // задаем параметры массива (длина, минимальное значение, максимальное значение)
PrintArray(newArray); // вывод массива на экран
System.Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях равна {sumNumber(newArray)}.");