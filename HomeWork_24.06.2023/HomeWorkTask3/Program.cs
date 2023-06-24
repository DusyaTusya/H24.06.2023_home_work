// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GenerateArray(int len, double min, double max) // функция генерации массива
{
    double[] answer = new double[len]; 
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.NextDouble() * 100; // умножаем на 100 для получения чисел больше 1
    }
    return answer;
}

void PrintArray(double[] array) // функция вывода на экран
{
    foreach (double item in array) // цикл по перебору элементов массива
    {
        System.Console.WriteLine(item);
    }
    System.Console.WriteLine(); 
}
double maxDigit(double[] array) // функция нахождения  максимального числа
{
    double max = array[0];
    foreach (double item in array)
    {
        if (item > max)
        {
            max = item;
        }        
    }
    return max;
} 
double minDigit(double[] array) // функция нахождения  минимального числа
{
    double min = array[0];
    //double min = array[0];
    //double div = 0;
    foreach (double item in array)
    {
        if (item < min)
        {
            min = item;
        }
    }
    return min;
} 

double[] array = GenerateArray(5,0,100);
PrintArray(array);

double maxNumber = maxDigit(array);
double minNumber = minDigit(array);

System.Console.WriteLine($"Из максимальго числа <{maxNumber}> вычитаем минимальное <{minNumber}>, получаем <{maxNumber-minNumber}>.");


