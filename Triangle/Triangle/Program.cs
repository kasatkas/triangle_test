Random rand = new Random();
int rows = 5;
int[][] triangle = new int[rows][];

for (int i = 0; i < rows; i++)
{
    triangle[i] = new int[i + 1];
    for (int j = 0; j < i + 1; j++)
    {
        triangle[i][j] = rand.Next(0, 10);
    }
}

int GetMax(int first, int second)
{
    return first > second ? first : second;
}
int CountWay(int[][] tmp)
{
    for (int i = rows - 2; i > -1; i--)
        for (int j = 0; j < i + 1; j++)
        {
            tmp[i][j] += GetMax(tmp[i + 1][j], tmp[i + 1][j + 1]);
        }
    return tmp[0][0];
}

void ShowTriangle(int[][] triangle)
{
    for (int i = 0; i < rows; i++)
    {
        Console.SetCursorPosition(rows-i, i+1);   
        for (int j = 0; j < i + 1; j++)
        {
            Console.Write(triangle[i][j] + " ");
        }
    }
}

ShowTriangle(triangle);
Console.WriteLine("\n\nMax weight: " + CountWay(triangle));