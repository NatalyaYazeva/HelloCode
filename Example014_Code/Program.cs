// В строке точки коррдинат умножить на 2

///

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
            .Replace("(", "")
            .Replace(")", "");

Console.WriteLine(text);

var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Where(e => e.x % 2 == 0)    // добавили условие, что координата х - четная
                .Select(point => (point.x * 2, point.y * 2))   
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    /*for (int k = 0; k < data[i].Length; k++)  //показывает числа построчно
    {
        Console.WriteLine(data [i][k]);
    }*/
    Console.WriteLine();
}

