// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

string InputTxt (string TxtSrting) // Модуль приглашения для ввода данных в виде текста с клавиатуры
{
    Console.Write (TxtSrting);
    return Console.ReadLine();
}

int A = int.Parse(InputTxt("Введите число которое необходимо возвести в степень: "));
int B = int.Parse(InputTxt("Введите степень числа: "));
int result = 1;

if (B > 0)
{
    for (int i = 0; i < B;i++ )
    {
        result *= A;
    }
    Console.WriteLine ($"Число {A} в степени {B} равен {result}");
}
else
{
    Console.WriteLine ("Степень должна быть больше нуля");
}