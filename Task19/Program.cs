// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число. Проверим, является ли оно палиндромом");
int num = int.Parse(Console.ReadLine());
int invertedNum = 0;
int outputNum = num;

if (num > 9999 && num < 100000) 
{
    int multiply = 10000;
    while (multiply != 0)
    {
        int digit = num % 10;
        invertedNum = digit * multiply + invertedNum;

        num /= 10;
        multiply /= 10;
    }
    if (outputNum == invertedNum) System.Console.WriteLine($"Число {outputNum} является палиндромом");
    else System.Console.WriteLine($"Число {outputNum} не палиндром");
}
else System.Console.WriteLine("Необходимо ввести пятизначное число");