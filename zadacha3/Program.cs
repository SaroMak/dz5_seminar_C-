// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)

{
    Random rand = new Random();

    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange) + rand.NextDouble();

        arr[i] = Math.Round(arr[i], 3);
    }
    return arr;
}

Random rnd = new Random();

int size = rnd.Next(1, 9);

double[] array = new double[size];

array = FillArrayWithRandomNumbers(size, -9, 9);

Console.WriteLine('[' + string.Join("| ", array) + ']');

double maxMeaning = array[0];

double minMeaning = array[0];

for (int i = 1; i < size; i++)
{
    if (array[i] > maxMeaning)
    {
        maxMeaning = array[i];
    }

    if (array[i] < minMeaning)
    {
        minMeaning = array[i];
    }
}

double diff = maxMeaning - minMeaning;

Console.WriteLine($"максимальное значение инднкса = {maxMeaning}");

Console.WriteLine($"минимальное значение инднкса = {minMeaning}");

Console.WriteLine($"разница между максимальным и минимальным  значением = {diff}");


//  Random rand = new Random();
//  double r = Math.Round(rand.NextDouble()*20 - 10, 5);
//double r2 = Math.Round(rand.NextDouble()*20 - 10, 5);
//  Console.WriteLine(r);
//ПРиветствую изначально хотел вот этим способ передать методу  leftRange,  rightRange! но программа очень ругалась! в нужных 
//местах инт менял на дабл, но в строчке 13  все пересекались инт и дабл  и программ ругалась что одно не преоброховать в другое!
//и таки  не сооброзил что не то