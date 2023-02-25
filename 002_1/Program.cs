// Напишите программу замены элементов массива: положительные элементы на отрицательные, отрицательные на положительные
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

int[] invArray(int[] array)
{
    int[] result = new int[array.Length];
    int j = 0;
    foreach (int i in array)
    {
        result[j] = i * -1;
        j++;
    }
    return result;
}
int[] res = invArray(array);
Console.WriteLine($"[ {String.Join(" ,", res)} ]");