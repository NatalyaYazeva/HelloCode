// собрать строку с числами от a до b, a<=b

/*string NumbersFor (int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}
Console.WriteLine(NumbersFor(1, 10));

string NumbersRec (int a, int b)
{
    if(a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

Console.WriteLine(NumbersRec(1, 10));*/


// собрать строку с числами от a до b, a>=b

/*string NumbersFor (int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}
Console.WriteLine(NumbersFor(10, 1));

string NumbersRec (int a, int b)
{
    if(a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return String.Empty;
}

Console.WriteLine(NumbersRec(1, 10));*/

// Сумма чисел от 1 до n

/*int SumFor (int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}
Console.WriteLine(SumFor(10));

int SumRec (int n)
{
    if(n == 0) return 0;
    else return n + SumRec (n-1);
}

Console.WriteLine(SumRec(10));*/

//Факториал числа

/*int FactorialFor (int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
Console.WriteLine(FactorialFor(10));

int FactorialRec (int n)
{
    if(n == 1) return 1;
    else return n * FactorialRec (n-1);
}

Console.WriteLine(FactorialRec(10));*/

//Возвести число a в степень n

/*int PowerFor (int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
Console.WriteLine(PowerFor(2, 10));

int PowerRec (int a, int n)
{
    return n == 0 ? 1 : PowerRec (a, n-1) * a;
    //if(n == 0) return 1;
    //else return PowerRec (a, n-1) * a;
}

Console.WriteLine(PowerRec(2,10));

int PowerRecMath (int a, int n)
{
    if(n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath (a*a, n/2);
    else return PowerRecMath (a, n-1) * a;
}

Console.WriteLine(PowerRecMath(2,10));*/

//Перебор слов

/*char[] s = {'а', 'и', 'с', 'в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            for (int l = 0; l < count; l++)
            {
                for (int m = 0; m < count; m++)
                {
                    Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
                }
            }
        }
    }
}*/

/*int n = 1;
void FindWords (string alphabet, char[] word, int lenght = 0)
{
    if (lenght == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[lenght] = alphabet[i];
        FindWords (alphabet, word, lenght + 1);
    }
}
FindWords ("фисв", new char[4]);*/

string path = "/D/GB/Языки программирования/Examples/Example008_IntroMetod";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
