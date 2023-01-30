// Вид 1
/*void Method ()
{
    Console.WriteLine("Автор ...");
}
Method();*/

//Вид 2
/*void Method2(string msg)
{
    Console.WriteLine (msg);
}
Method2("Текст сообщения");*/
/*void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст", 4);
Method21(count: 4, msg: "Новый текст");*/

//Вид 3

/*int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);*/

// Вид4

/*string Method4(int count, String Text)
{
    int i=0;
    String result = String.Empty;
    while (i<count)
    {
        result = result + Text;
        i++;
    }
    return result;
}
string res = Method4 (10, "а ");
Console.WriteLine(res);*/

/*string Method4(int count, String Text)
{
    String result = String.Empty;
    for (int i=0; i<count; i++)
    {
        result = result + Text;
    }
    return result;
}
string res = Method4 (10, "а ");
Console.WriteLine(res);*/

/*for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} х {j} = {i*j}");
    }
    Console.WriteLine();
}*/

//====Работа с текстом. 
/* Дан текст. В нем нужно заменить пробелы чероточками, маленькие буквы к на большие К, а большие С на маленькие с*/

/*string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace (string text, char oldvalue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
    if(text[i] == oldvalue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
    }
    return result;
    
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();*/

// Сортировка массива методом выбора (мин, макс)

int[] arr = {1,5,4,3,2,6,7,1,1,2};
void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort (int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array [minPosition])  minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);