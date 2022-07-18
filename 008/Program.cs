// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void Zadacha52()
{
    Random random = new Random ();
    int rows = 3; 
    int columns = 4; 
    int [,] array = new int [rows, columns];
     
     FillArray(array);
     PrintArray(array);

      for (int j = 0; j < columns; j++) 
    {
        int sum =0;
       for (int i = 0; i < rows; i++) 
       {
        sum+= array [i, j];
       }
       Console.WriteLine();
Console.WriteLine(sum/rows + "\t");
    }
    void FillArray (int [,] array)
    { 
    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++) 
       {
        array[i, j] = random.Next (1, 10); 
       }
    }
     }

     void PrintArray (int [,] array)
     {
       for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++) 
       {
        Console.Write(array[i, j] + "\t");
       }
       Console.WriteLine();
     }  
     }
   
 }
Zadacha52();
