//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


int[] StringWork(string start)
{
    int count = 1;
    for (int i = 0; i < start.Length; i++)
    {
        if (start[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < start.Length; i++)
    {
        string step = "";

        while (start [i] != ',')
        {
        if(i != start.Length - 1)
        {
            step += start [i].ToString();
            i++;
        }
        else
        {
            step += start [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(step);
        index++;
    }
    return numbers;
}



Console.Write("Вводите М чисел через запятую: ");
int[] numbers = StringWork(Console.ReadLine());
Print(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество положительных чисел = {sum}");


