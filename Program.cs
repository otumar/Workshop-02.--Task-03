// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 

Console.Write("Введите число => ");
string paramString = Console.ReadLine();
int Paramint = int.Parse(paramString);

if (Paramint < 100) Console.Write("Третьей цифры нет");
else
{
    while (Paramint > 999)
    {
        Paramint = Paramint / 10;
    }
    Paramint = Paramint % 100 % 10;
    Console.Write($"{Paramint} - третья цифра вашего числа");
}