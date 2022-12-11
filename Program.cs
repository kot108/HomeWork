Console.WriteLine("Введите число 1");
string A = Console.ReadLine()!;

Console.WriteLine("Введите число 2");
string B = Console.ReadLine()!;

Console.WriteLine("Введите число 3");
string C = Console.ReadLine()!;

int ParseA = int.Parse(A);

int ParseB = int.Parse(B);

int ParseC = int.Parse(C);

int max = ParseA;


if (ParseB > ParseA)
{
    max = ParseB;
    
}
if (ParseC > ParseA)
{
    max = ParseC;

}
Console.WriteLine("Максимальное число =");

Console.WriteLine(max);


