Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= num)
{
    Console.WriteLine(Square(count));
    count++;
}
string Square(int number)
{
    return ($"{number} -> {number*number*number}");
}