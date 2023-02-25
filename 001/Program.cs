// Массив из 12 случайных элементов из промежутка от минус 9 до 9.
// Найдите сумму отрицательных и положительных элементов массива
Console.WriteLine("Введите разрядность массива: ");
int size = int.Parse(Console.ReadLine());
int[] array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

int[] mass = array(size);
Console.WriteLine($" [ {string.Join("; ", mass)} ]");

int [] sum(int [] array)
{
int Neg = 0;
int Pos = 0;
for(int i=0; i<array.Length; i++)
{
if (array[i]>0) {Pos+=array[i];}
else {Neg+=array[i];}
}
int [] sum = {Neg, Pos};
return sum;
}

Console.WriteLine($" [ {string.Join("; ", sum(mass))} ]");