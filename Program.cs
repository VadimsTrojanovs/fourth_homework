int a;
int b;
Console.WriteLine("Введите число которое нужно возвести в степень");
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Введите степень в которую нужно возвести число");
int.TryParse(Console.ReadLine(), out b);

int res= a;
for (int i=1; i<b; i++)
{
res= res * a;
}
Console.WriteLine("A в степени B равно " + res);
