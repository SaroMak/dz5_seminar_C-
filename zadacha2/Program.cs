// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)

{
    Random rand = new Random();

    int[] arr = new int[size];

    for (int i = 0; i < size; i++)

    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }

    return arr;
}

Random rnd = new Random();

int size = rnd.Next(1, 20);

int[] array = new int[size];

array = FillArrayWithRandomNumbers(size, 1, 99);

Console.WriteLine('[' + string.Join("| ", array) + ']');

int sum = 0;

for (int i = 1; i < size; i = i + 2)

{
    sum = sum + array[i];
}

Console.WriteLine($"сумма элементов, стоящих на нечётных позицияхsum = {sum}");