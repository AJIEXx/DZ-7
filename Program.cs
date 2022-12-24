﻿// Это Main работа. Версии при их наличии будут распределены в репозитории по соответствующим веткам.

int programm, num;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1. Принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
    Console.WriteLine("2. Выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
    Console.WriteLine("3. Принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
    Console.WriteLine("4. Принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
    Console.WriteLine("5. Принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
    Console.WriteLine("6. Принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
            /*
            Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            456 -> 5
            782 -> 8
            918 -> 1
            */

            ReadInt = number int("Введите трехзначное число: ");
            число  =  сумма  int.toString().Длина;

            если (сумма < 3 ||  сумма > 3)
            {
                Консоль.WriteLine("Вы ввели не трехзначное число");
            }
            ещё
            {
                Консоль.Строка записи(в центре (число));
            }



            // ФУНКЦИИ------------------------------------------------------------------------------------------------------

            // Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем. 
            readInt  int(строковое  сообщение)
            {
                Консоль.Написать(сообщение);
                Преобразовать  возврат.ToInt32(консоль.ReadLine());
            }

            // Функция вывода цифры стоящей в середине трехзначногно числа.
            В центре int (int  a)
            {
                
                =  результат  int ((a  / 10) % 10);
                возврат результата ;
            }
            break;

        case 2:
            /*
            Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            645 -> 5
            // 78 -> третьей цифры нет
            // 32679 -> 6
            */

            ReadInt = number int("Введите число: ");
            число =  количество  int.toString().Длина;
            Консоль.Запись(makeArray(число, количество));


            // ФУНКЦИИ------------------------------------------------------------------------------------------------------

            // Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.
            readInt  int(строковое  сообщение)
            {
                Консоль.Написать(сообщение);
                Преобразовать  возврат.ToInt32(консоль.ReadLine());
            }

            // Функция принимает число введенное пользователем, количество символов, и выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0.
            makeArray  int(int  a, int  b)
            {
            0 =  результат  int;
                если (b < 3)
                {
                    Консоль.Write("Третьей цифры нет, держи: ");
                }
                ещё
                {
                    1 = c int;
                    для (int  i = b; i > 3; i--)
                    {
                        10 * c = c;
                    }

                    = результат (a  /  c) % 10;
                }
            возврат результата ;
            }
            break;

        case 3:
            /*
            Задача 15: 
            Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            6 -> да
            7 -> да
            1 -> нет
            */

            ReadInt = dayNumber int("Введите число от 1 до 7: ");
            Консоль.Строка записи (рабочий день (число дней));


            // ФУНКЦИИ------------------------------------------------------------------------------------------------------

            // Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.
            readInt  int(строковое  сообщение)
            {
                Консоль.Написать(сообщение);
                Преобразовать  возврат.ToInt32(консоль.ReadLine());
            }

            // Функция принимает число от 1 до 7 и выводит сообщение - выходной день или нет.
            // *** Костыль, но я тренировал функции. проблема с return была. ***
            Строка  рабочего дня (int  a)
            {
                если (a > 0 && a < 8)
                {
                    если (a == 7 || a == 6)
                    {
                        Консоль.Write("Под цифрой " + a + " - Выходной");
                    }
                    ещё
                    {
                        Консоль.Write("Под цифрой " + a + " - Рабочий");
                    }
                }
                ещё
                {
                    Консоль.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
                }
                "  день."return;
            }
            break;

        case 4:
            /*
            Задача 19
            Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            14212 -> нет
            12821 -> да
            23432 -> да
            */

            Консоль.WriteLine("Введите число: ");
            Консоль = числовая  строка.ReadLine();
            число = len  int.Длина;

            если (len == 5)
            {
                если (число [0] == число [4] && число[1] == число[3])
                {
                    Консоль.WriteLine($"{number} - Палиндром");
                }
                ещё
                {
                    Консоль.WriteLine($"{number} - НЕ палиндром");
                }
            }
            ещё
            {
                Консоль.WriteLine($"ОШИБКА: {number} - не является пятизначным");
            }
            break;

        case 5:
            /*
            Задача 21 (branch task_2)
            Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            A (3,6,8); B (2,1,-7), -> 15,84
            A (7,-5, 0); B (1,-1,9) -> 11,53
            */

            ReadInt = x1 int("Введите координату X первой точки: ");
            ReadInt = y1 int("Введите координату Y первой точки: ");
            ReadInt = z1 int("Введите координату Z первой точки: ");
            ReadInt = x2 int("Введите координату X второй точки: ");
            ReadInt = y2 int("Введите координату Y второй точки: ");
            ReadInt = z2 int("Введите координату Z второй точки: ");

            x1 - x2 = целое  число;
            y1 - y2 = B int;
            z2 - z1 = C int;

            Математика  =  длина  double.Sqrt(A  *  A  +  B  *  B  +  C  *  C);
            Консоль.WriteLine($"Длинна отрезка {length}");


            // Функция ввода сообщения
            readInt  int(строковое  сообщение)
            {
                Консоль.Написать(сообщение);
                Преобразовать  возврат.ToInt32(консоль.ReadLine());
            }
            break;

        case 6:
            /*
            Задача 23
            Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            3 -> 1, 8, 27
            5 -> 1, 8, 27, 64, 125
            */

            ReadInt = number int("Введите число N: ");

            для (int  i = 1; i <= число; i++)
            { 
                Консоль.Написать($"{i*i*i} ");
            }



            // Функция ввода сообщения
            readInt  int(строковое  сообщение)
            {
                Консоль.Написать(сообщение);
                Преобразовать  возврат.ToInt32(консоль.ReadLine());
            }
            break;

        default:
            begin = false;
            break;
    }
}
