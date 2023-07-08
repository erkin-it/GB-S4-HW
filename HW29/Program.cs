// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

string InputTxt (string TxtSrting) // Модуль приглашения для ввода данных в виде текста с клавиатуры
{
    Console.Write (TxtSrting);
    return Console.ReadLine();
}

void PrintArray (int LenArray, int MinNumber, int MaxNumber)
{
    int[] arr = new int[LenArray];
    Random rnd = new Random ( );
    Console.Write ("[");
    for (int i = 0; i < LenArray; i++)
    {
        arr[i] = rnd.Next(MinNumber, MaxNumber+1);
        if (i<LenArray-1)
        {
            Console.Write ($"{arr[i]}, ");
        }
        else
        {
            Console.Write ($"{arr[i]}]");
        }
    }
}

//----------------------------------------------------------------------------------------------------

int Len = int.Parse(InputTxt("Введите величину массива: "));
int MinValue = int.Parse(InputTxt("Введите минимальное значение массива: "));
int MaxValue = int.Parse(InputTxt("Введите максимальное значение массива: "));

PrintArray (Len, MinValue, MaxValue);