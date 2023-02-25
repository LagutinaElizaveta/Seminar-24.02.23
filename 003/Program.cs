// Задайте массив. Напишите программу, которая определяет, есть ли заданное число в массиве

Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
Console.WriteLine("Введите искомое число: ");
int a = int.Parse(Console.ReadLine());
// Метод преобразования строку в массив
int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ");
    int[] res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
// Метод сравнения числа
int[] array = GetArrayFromString(elements);
Console.WriteLine($"[ {String.Join(" ,", array)} ]");
bool search(int[] array, int a)
{
    foreach (int el in array)
        if (el == a)
        {
            return true;
        }
    return false;
}
// Вывод по совпадению или несовпадению чисел
if (search(array, a))
{
    Console.WriteLine("Введенное число есть в массиве.");
}
else
{
    Console.WriteLine("Введенного числа нет в массиве.");
}