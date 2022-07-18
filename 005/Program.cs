// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            void Zadacha41()
        {
                Console.WriteLine("Введите необходимое кол-во чисел: ");
                int number = Convert.ToInt32(Console.ReadLine());

                int count = 0;

                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(" ");
                    Console.Write($"Введите {i} число: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    if (number2 > 0) count++;
                }
                Console.WriteLine("Количество чисел больше нуля " + count);
            }
            Zadacha41();
        
