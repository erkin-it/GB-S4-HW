// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

string InputTxt (string TxtSrting) // Модуль приглашения для ввода данных в виде текста с клавиатуры
{
    Console.Write (TxtSrting);
    return Console.ReadLine();
}

int SumNumbers (int InputNumber)
{
    int IN = Math.Abs(InputNumber);
    int R = 0;
    int T = 0;
    do 
        {
            T=IN%10;
            R=R+T;
            IN=IN/10;
        }
    while (IN > 0);
    return R;
}

//------------------------------------------------------------------------------------------------

int Number = int.Parse(InputTxt("Введите число: "));

int Result = SumNumbers (Number);

Console.WriteLine($"Сумма цифр в числе равна {Result}");