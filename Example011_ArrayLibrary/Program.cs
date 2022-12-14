// Используем генератор случайнах чисел и используем метод
// Тренируем как можно создать метод туда включить массив и заполнить его
// нужным колличеством элементов.

void FillArray(int[] collection) // метод заполнения массива с помощью случайных чисел
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col) // метод вывода массива в терминал в стобик
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // метод поиска заданного значения find в массиве и возврат индекса найдена элемента
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если элемент не найден в массиве, то выводится -1
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; //выходим после нахождения первого значения 4
        }
        index++;
    }
    return position;
}

int[] array = new int [10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);

