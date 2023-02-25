// Массив из 12 случайных элементов из промежутка от минус 9 до 9.
// Найдите сумму отрицательных и положительных элементов массива
Console.WriteLine("Введите разрядность массива: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент массива: ");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент массива: ");
int maxValue = int.Parse(Console.ReadLine());

int[] GetRandomeArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int[] array = GetRandomeArray(size, minValue, maxValue);
Console.WriteLine($"[ {String.Join(" ,", array)} ]");

int[] sumPosNeg(int[] array)
{
    int[] result = new int[2];
    foreach (int el in array)
    {
        result[0] += el > 0 ? el : 0;   //Если элемент больше нуля, то в нулевой элемент массива кладем значение, иначе - 0
        result[1] += el < 0 ? el : 0;   //Если элемент меньше нуля, то в первый элемент массива кладем значение, иначе - 0
    }
    return result;
}
Console.WriteLine($"Positive sum = {sumPosNeg(array)[0]}. Negative sum = {sumPosNeg(array)[1]}");