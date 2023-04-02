 string[] arraySimvol = {"BBB", "jjJ", "IIIIII"};//создаем  массив
string[] GetArray (string[] array)
// создаем метод сортирующий символы из массива. 

{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.Write("Введенные символы длинной меньше либо равны 3 : ");
    string[] arrayThreeSimvol = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            arrayThreeSimvol[j] = simvol;
            j++;
        }
    }
    return arrayThreeSimvol;
}

//печать массива
void Print (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
Print(GetArray(arraySimvol));
Console.WriteLine();