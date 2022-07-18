// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет

void Zadacha50()
{
    Random random = new Random ();
    int rows = 3; 
    int columns = 4; 
    int [,] array = new int [rows, columns];
     
     FillArray(array);
     PrintArray(array);

     Console.WriteLine("Введите номер строки: ");
     int number1 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите номер столбца: ");
     int number2 = Convert.ToInt32(Console.ReadLine());
     
     if (number1 >= 1 && number1 <= rows && number2 >=1 && number2 <= columns)
       {
        Console.WriteLine($"искомый эллемент = {array [number1 - 1, number2 - 1]}");
       }
    else
       {
         Console.WriteLine("Такого числа нет ");
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
Zadacha50();