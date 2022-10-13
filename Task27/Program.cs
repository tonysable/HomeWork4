int Sum(int a)
{
    int result = default;
    while(a > 0){
        result += a % 10;
        a /= 10; 
    }   
    return result;
}

string str;
int chislo;
Console.WriteLine("Введите число: ");
str = Console.ReadLine();
chislo = Convert.ToInt32(str);

int res1 = Sum(chislo);
Console.WriteLine(res1);