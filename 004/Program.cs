// Задайте одномерный массив из 123 случайных чисел [0; 150].
//Найдите количество элементов массива, значения которых лежат в отрезке[10;99].

// Функция генерации массива
int[] GetRandomeArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

// Создание массива с заданными в условии параметрами
int[] array = GetRandomeArray(123, 0, 150);

// Следующая строка была бы нужна, если бы нужно было его вывести. Так как такая задача не стоит, я ее "закомментила"
// Console.WriteLine($"[ {String.Join(" ,", array)} ]");

// Функция вычисления количества элементов в заданном отрезке
int GetCountElements(int[] array, int leftRange, int rigthRange)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el >= leftRange && el <= rigthRange) count++;
    }
    return count;
}

// Вывод итога работы программы
Console.WriteLine($"Количество элементов в отрезке [10; 99] равно {GetCountElements(array, 10, 99)}");