double[] array;
double negativeSum = 0;

Console.Write("Введіть к-ть елементів масиву: ");
if(int.TryParse(Console.ReadLine(), out int n));

array = new double[n];
double min = array[0], max = array[0];
int maxIndex = 0;
double maxAbs = 0, sumPositiveIndex = 0, qtyOfInt = 0;
bool isInt;

Console.WriteLine("Введіть значення елементів масиву: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"[{i}] ", array[i]);
    array[i] = double.Parse(Console.ReadLine());
    if (array[i] < 0)
    {
        negativeSum += array[i];
    }
    else
    {
        sumPositiveIndex += i;
    }
    if (array[i] == Math.Floor(array[i]))
    {
        qtyOfInt++;
    }
}

for (int i = 1; i < array.Length; i++)
{
    if(array[i]>max) {
        max = array[i];
        maxIndex = i;
    } 
    if(array[i]<min) {
        min = array[i];
    }
}

if (max + min >= 0)
{
    maxAbs = Math.Abs(max);
}
else
{
    maxAbs = Math.Abs(min);
}

Console.WriteLine($"Сума відʼємних елементів: {negativeSum}");
Console.WriteLine($"Мінімальний елемент масиву: {min}");
Console.WriteLine($"Індекс максимального елементу масиву: {maxIndex}");
Console.WriteLine($"Mаксимальний за модулем елемент масиву: {maxAbs}");
Console.WriteLine($"Cума індексів додатних елементів: {sumPositiveIndex}");
Console.WriteLine($"Кількість цілих чисел у масиві: {qtyOfInt}");