
void PrintArray(string[] array)
{
    int size = array.Length;
    int i = 0;
    while (i < size)
    {
        Console.Write(array[i]);
        Console.Write(" ");
        i++;
    }
}


string[] FindString(string[] array, int size)     // size - размер массива под найденные строки
{
    string[] resultArray = new string[size];
    int length = arr.Length;
    int i = 0;
    int j = 0;
    while (i < length)
    {
        if (array[i].Length < 4)
        {
            resultArray[j] = arr[i];
            j++;
        }
        i++;
    }
    return resultArray;
}






