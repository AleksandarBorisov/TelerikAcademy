## Още няколко интересни варианта на задачите
### Fill the Matrix разбито на отделни задачи
#### Matrix A
```C#
int n = int.Parse(Console.ReadLine());
int[,] array = new int[n, n];
int i = 1;
int row = 0;
int col = 0;
while (i <= n * n)
{
    if (row > n - 1)
    {
        row = 0;
        col++;
    }
    array[row++, col] = i;
    i++;
}
for (int k = 0; k < n; k++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[k, j],3}{((j != n - 1) ? " " : "\n")}");
    }
}
```
#### Matrix B
```C#
int n = int.Parse(Console.ReadLine());
int[,] array = new int[n, n];
int i = 1;
int row = 0;
int col = 0;
while (i <= n * n)
{
    if (col % 2 == 0)
    {
        array[row++, col] = i;
        if (row == n)
        {
            col++;
        }
    }
    else
    {
        array[--row, col] = i;
        if (row == 0)
           {
               col++;
           }
    }
    i++;
}
for (int k = 0; k < n; k++)
{
    for (int j = 0; j < n; j++)
    {
         Console.Write($"{array[k, j],3}{((j != n - 1) ? " " : "\n")}");
    }
}
```
#### Matrix C
```C#
int n = int.Parse(Console.ReadLine());
int[,] array = new int[n, n];
int i = 1;
int row = n;
int col = 0;
while (i <= n * n)
{
    if (row > col)
    {
        array[--row, col] = i++;
    }
    else
    {
        row = 0;
        array[row, ++col] = i++;
    }
    int rightIndex = col;
    int leftIndex = row;
    while (rightIndex < n-1 && leftIndex < n-1)
    {
        array[++leftIndex, ++rightIndex] = i++;
    }
}
for (int k = 0; k < n; k++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[k, j],3}{((j != n - 1) ? " " : "\n")}");
    }
}
```
#### Matrix D
```C#
int n = int.Parse(Console.ReadLine());
int[,] array = new int[n, n];
int i = 1;
int row = 0;
int col = 0;
while (i <= n * n)
{
    while (row < n && array[row, col] == 0)
    {
         array[row++, col] = i++;
    }
row--;
col++;
while (col < n && array[row, col] == 0)
{
     array[row, col++] = i++;
}
col--;
row--;
while (row >= 0 && array[row, col] == 0)
{
     array[row--, col] = i++;
}
row++;
col--;
while (col >= 1 && array[row, col] == 0)
{
     array[row, col--] = i++;
}
col++;
row++;
}
for (int k = 0; k < n; k++)
{
     for (int j = 0; j < n; j++)
     {
         Console.Write($"{array[k, j],3}{((j != n - 1) ? " " : "\n")}");
     }
}
```