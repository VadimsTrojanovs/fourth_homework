int i;
Console.WriteLine("введите число");
int.TryParse(Console.ReadLine(), out i);
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("сумма всех цифр данного числа равна: " + sum);