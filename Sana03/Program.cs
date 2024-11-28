double[] array;
double negativeSum = 0;

Console.Write("Введіть к-ть елементів масиву: ");
if(int.TryParse(Console.ReadLine(), out int n));
array = new double[n];

Console.WriteLine("Введіть значення елементів масиву: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"[{i}] ", array[i]);
    array[i] = double.Parse(Console.ReadLine());
    if (array[i] < 0)
    {
        negativeSum += array[i];
    }
}

Console.WriteLine($"Сума відʼємних елементів: {negativeSum}");