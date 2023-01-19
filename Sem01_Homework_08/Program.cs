﻿/*Задача 8: Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.*/

Console.WriteLine("Введите число N (используйте запятую при введении дробного числа)");
double N = Convert.ToDouble(Console.ReadLine());/*оператор double дает возможность вводить дробные числа*/
Console.ForegroundColor = ConsoleColor.Red;     /*Вывод ответа в консоль красным цветом*/

if(N > 1)
{
for (int i = 2; i <= N; i += 2)                 /* До тех пор, пока i меньше или равно N, 
                                                   выполняется данный цикл.
                                                   i равно 2, потому, что самое ближайшее четное число,
                                                   которое больше 1-это 2.
                                                   Применим шаг +2, так как четные числа идут через два шага*/
                                

Console.Write (i + " " );                       /*Вывод ответа в консоль. Выводится значение (i). 
                                                 (+)-это для склейки строк. 
                                                 ("")-это пробел между цифрами в выводе*/
}

else if(N < 1)/* Если N меньше 1, то...*/
{
for(int i = 0; i >= N; i -= 2)/* До тех пор, пока i больше или равен N, 
                                 выполняется данный цикл. i равно (0), потому, 
                                 что это ближайшее четное число, меньшее 1.
                                 Применим шаг -2, так как четные числа идут через два шага*/

Console.Write (i + " " );     /* Вывод ответа в консоль. Выводится значение (i). 
                                 (+)-это для склейки строк. 
                                 ("")-это пробел между цифрами в выводе*/
}
