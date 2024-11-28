int[] array;
int negativeSum = 0;

Console.Write("Введіть к-ть елементів масиву: ");
if(int.TryParse(Console.ReadLine(), out int n));

array = new int[n];
int min = array[0];
int max = array[0];
int maxIndex = 0;
int maxAbs = array[0];

Console.WriteLine("Введіть значення елементів масиву: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"[{i}] ", array[i]);
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] < 0)
    {
        negativeSum += array[i];
    }
}

for (int i = 1; i < array.Length; i++)
{
    if(array[i]>max) {
        max = array[i];
        maxAbs = Math.Abs(max);
        maxIndex = i;
    } 
    if(array[i]<min) {
        min = array[i];
    }
}

Console.WriteLine($"Сума відʼємних елементів: {negativeSum}");
Console.WriteLine($"Мінімальний елемент масиву: {min}");
Console.WriteLine($"Індекс максимального елементу масиву: {maxIndex}");