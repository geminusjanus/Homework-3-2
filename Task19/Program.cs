Console.WriteLine("Введите пятизначное число и я скажу палиндром оно или нет");
int num = Convert.ToInt32(Console.ReadLine());

int firstDigit = 0;
int lastDigit = 0;
int secondDigit = 0;
int forthDigit = 0;
if (num >= 10000 && num <= 99999)
{
    firstDigit = num / 10000;
    lastDigit = num % 10;
    secondDigit = num % 10000 / 1000;
    forthDigit = num % 100 / 10;
    if (firstDigit == lastDigit && secondDigit == forthDigit)
    {
        Console.WriteLine("Да");
    }
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Число не пятизначное");
// Console.WriteLine($"{firstDigit}, {secondDigit}, {forthDigit}, {lastDigit}");