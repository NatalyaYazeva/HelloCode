int[] array = {1,2,3,9,5,8,7,9};

int n = array.Length;
int find =9;

int index = 0;

while (index < n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}
