int Stepen(int chislo, int pokaz)
{
    int result = 0;
    result = Convert.ToInt32(Math.Pow(chislo, pokaz));
    return result;
}

string str;
int a;
Console.WriteLine("Введите число:");
str = Console.ReadLine();
a = Convert.ToInt32(str);
string str1;
int b;
Console.WriteLine("Введите степень: ");
str1 = Console.ReadLine();
b = Convert.ToInt32(str1);

int res1 = Stepen(a, b);
Console.WriteLine(res1);