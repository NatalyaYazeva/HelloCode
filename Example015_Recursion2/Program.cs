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

/*string path = "D:/GB/Языки программирования/Examples/Example015_Recursion2";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}*/

//Игра в пирамидки

/*void Towers (string with = "1", string on = "3", string some = "2", int count =3)
{
    if (count > 1) Towers (with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();*/

//Обход разных структур

/*string emp = String.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};

void InOrderTraversal (int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();*/

// Время расчета Фибоначчи

/*decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion (int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n-1) + FibonacciRecursion(n-2);
}

decimal FibonacciIteration (int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}



Console.ReadLine();
DateTime dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();
Console.ReadLine();
dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.WriteLine();
Console.ReadLine();*/

// закрашивание картинки
int[,] pic = new int[10,10];
for (int i = 0; i < 10; i++)
{
    pic[0,i] = 1;
    pic[i,0] = 1;
    pic[i,9] = 1;
    pic[9,i] = 1;
}
PrintImage(pic);
FillImage(1,1);
Console.WriteLine();
PrintImage(pic);

void PrintImage(int[,]image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i,j]} ");
            if (image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage (int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}
