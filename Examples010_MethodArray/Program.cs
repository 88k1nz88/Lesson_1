int [] array = {1 ,2 ,3 ,92 ,51 ,62 ,75 ,83 ,92};

int n = array.Length;
int find =92;

int index = 0;

while (index < n)
{
    if (array [index] == find)
    {
        Console.WriteLine (index);
        break;
    }
    index ++;

}