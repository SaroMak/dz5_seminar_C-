// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)

{
    Random rand = new Random();

    int[] arr = new int[size];

    for (int i = 0; i < size; i++)

    {
        arr[i] = rand.Next(leftRange, rightRange + 1); // [-9; 10)
    }
    
    return arr;
}

Random rnd = new Random();

int size = rnd.Next(1, 99);

int[] array = new int[size];

array = FillArrayWithRandomNumbers(size, 100, 999);

Console.WriteLine('[' + string.Join("| ", array) + ']');

int count = 0;

for (int i = 0; i < size; i++)

{
    if (array[i] % 2 == 0)

    {
        count++;
    }
}

Console.WriteLine($"количество четных чисел в рандомном масcиве = {count}" );





// Random rand = new Random();
// double r = Math.Round(rand.NextDouble()*20 - 10, 3);
