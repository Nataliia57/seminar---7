// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.

void Zadacha47()
{
    Random random = new Random ();
    int rows = 3; 
    int columns = 4;

    double [,] array = new double [rows, columns];
     FillArray(array);
     PrintArray(array);


    void FillArray (double [,] array)
    { 
    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++) 
       {
        array[i, j] = Math.Round (random.NextDouble() * 10 -5, 1); 
       }
    }
     }

     void PrintArray (double [,] array)
     {
       for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++) 
       {
        Console.Write((array[i, j])+ "\t");
       }
       Console.WriteLine();
     }  
     }
   
}
Zadacha47();