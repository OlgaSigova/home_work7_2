//Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание,
// что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.Write("Введите кол-во столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во строк ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите проверяемое число ");
int result = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");

    }
    Console.WriteLine();
}
bool flag = true;
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (result == matrix[i, j])
            {
                Console.WriteLine("Проверяемое число " +result+  " есть в массиве в  " 
                +i+ " строке " +j+ " столбце");
                flag = false;
            }
            

        }
       

    }
if (flag)
{
     Console.WriteLine("Проверяемого числа в массиве нет  " );
}
    
}
