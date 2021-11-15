using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace cSharpHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            int time;
            Console.WriteLine("Добро пожаловать в программу перевода времени! ");
            Console.Write("Введите время в секундах : ");
            time = Convert.ToInt32(Console.ReadLine());
            int Sec = time % 60;
            int Hour = time / 3600;
            int Min = (time/60) % 60;
            Console.Write($"{time} секунд = {Hour} часов, {Min} минут , {Sec} секунд! "); 

            // Task 2
            int L;
            Console.WriteLine("Добро пожаловать в программу расчета радиуса окружности! ");
            Console.Write("Введите длину окружности : ");
            L = Convert.ToInt32(Console.ReadLine());
            double R = L / (2 * Math.PI);
            Console.WriteLine($"Длина окружности {L} , Радиус равен {R} ");

            // Task 3

            
            Console.WriteLine("Введите трехзначное целое число : ");
            int A = Convert.ToInt32(Console.ReadLine());
            int Sotni = A / 100;
            int Dec = (A % 100) / 10;
            int Unit = A % 10;
            Console.Write($"{A} =\n{Sotni} \n{Dec}\n{Unit}\n ");


        }
    }
}
