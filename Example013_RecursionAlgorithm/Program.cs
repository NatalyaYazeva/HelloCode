/*string[,] table = new string [2, 5];
// String.Empty - инициализация для строк
table[1, 2] = "слово";
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine($"--{table[i, j]}--");
    }
}*/
/*void PrintArray (int[,] matr){

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
            matr [i,j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int [3,4];
PrintArray (matrix);
Console.WriteLine();
FillArray (matrix);
PrintArray (matrix);*/

// Вывод на экран картинки

/*int[,] pic = new int[,]
{
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0 },
{0,	0, 0, 0, 1,	0, 0, 0, 1,	0, 0, 0, 0 },
{0,	0, 0, 1, 0,	0, 0, 0, 0,	1, 0, 0, 0 },
{0,	0, 1, 0, 0,	0, 0, 0, 0,	0, 1, 0, 0 },
{0,	1, 0, 0, 0,	0, 0, 0, 0,	0, 0, 1, 0 },
{1,	0, 0, 0, 0,	0, 0, 0, 0,	0, 0, 0, 1 },
{0,	1, 0, 0, 0,	0, 0, 0, 0,	0, 0, 1, 0 },
{0,	0, 1, 0, 0,	0, 0, 0, 0,	0, 1, 0, 0 },
{0,	0, 0, 1, 0,	0, 0, 0, 0,	1, 0, 0, 0 },
{0,	0, 0, 0, 1,	0, 0, 0, 1,	0, 0, 0, 0 },
{0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

PrintImage (pic);
FillImage (8,5); //координаты точки внутри
PrintImage (pic);


void PrintImage (int[,] image) {

    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i, j]} ");
            if (image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}


void FillImage (int row, int col)
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage (row-1, col);
        FillImage (row, col-1);
        FillImage (row+1, col);
        FillImage (row, col+1);
    }
}*/

//Факторил

/*double Factorial (int n)
{
    //1! = 1
    //0! = 1
    if (n == 1) return 1;
    else return n * Factorial (n-1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
Console.WriteLine(Factorial(5));*/

//Фибоначчи
// f(0) = 0
// f(1) = 1
// f(2) = 1
// f (n) = f(n-1)+f(n-2)

double Fibonacci (int n)
{
    if(n == 1 || n ==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}


