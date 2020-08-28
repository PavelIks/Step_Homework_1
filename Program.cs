using System;

namespace Step_Homework_2
{
    class Program
    {
        /*Домашнее задание №2*/
        static void Main(string[] args)
        {
            /*Встреча №3*/
            /*Задание 1: Заданы три сопротивлении R1, R2, R3 . Вычислить значение сопротивления R0 по
            формуле: 1 / R0 = 1 / R1 + 1 / R2 + 1 / R3.
            Контрольный пример: R1 = 2, R2 = 4, R3 = 8 R0 = 1.142857*/

            /*double R1 = 2;
            double R2 = 4;
            double R3 = 8;
            double R0 = 1 / R1 + 1 / R2 + 1 / R3;
            Console.WriteLine(1 / R0);
            Console.ReadKey();*/


            /*Задание 2: По заданной длине окружности найти площадь круга по формуле S = pi*R2, радиус
            вычислить из формулы длины окружности: L=2*pi *R
            Примечание pi = 3.14*/

            /*double pi = 3.14;
            Console.Write("Enter R: ");
            double Radius_kruga = Convert.ToDouble(Console.ReadLine());
            double S = pi * Radius_kruga * 2;
            Console.WriteLine(S);
            double L = 2 * pi * Radius_kruga;
            Console.WriteLine(L);
            Console.ReadKey();*/


            /*Задание 3: Вычислить пройденное расстояние при прямолинейном равноускоренном
            движении по формуле S = v*t + (a*t2) / 2, где v – скорость, t – время, а – ускорение.*/

            /*Console.Write("Enter V: ");
            double V = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter T: ");
            double T = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            double S = V * T + (A * T * 2) / 2;
            Console.WriteLine(S);
            Console.ReadKey();*/



            /*Встреча №4*/
            /*Задание 1. Пользователь вводит с клавиатуры время в секундах. Необходимо написать программу,
            которая переведет введенные пользователем секунды в часы, минуты, секунды и выводит их на экран.*/

            /*Console.Write("Enter s.: ");
            double S = Convert.ToDouble(Console.ReadLine());
            double H = S * 0.000277778;
            Console.WriteLine("h.: " + (int)H);
            double M = S * 0.0166667;
            Console.WriteLine("m.: " + (int)M);
            Console.ReadKey();*/


            /*Задание 2. Написать программу, которая преобразует введенное с клавиатуры
            дробное число в денежный формат. Например, число 12,5 должно быть преобразовано к виду 12грн 50 коп.*/

            /*Console.Write("Enter number: ");
            double Number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((int)Number + " гривен, " + Number % 1 * 100 + " копеек.");
            Console.ReadKey();*/


            /*Задание 3. Написать программу, вычисляющую, с какой скоростью бегун пробежал дистанцию.
            Рекомендуемый вид экрана во время выполнения программы приведен ниже:
            Вычисление скорости бега
            Введите длину дистанции (метров) = 1000
            Введите время (мин.сек) = 3.25
            Дистанция: 1000 м
            Время: 3 мин 25 сек = 205 сек
            Вы бежали со скоростью 17.56 км/ч*/

            /*Console.Write("Введите длину дистанции (метров): ");
            double S = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите время (мин. сек.): ");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Дистанция: " + S);
            double a1 = (int)t * 60;
            double a2 = t % 1 * 100;
            double a3 = (int)(a1 + a2);
            Console.WriteLine((int)t + " минуты, " + t % 1 * 100 + " секунд = " + a3 + " секунд");
            double V = (S / 1000) / (a3 / 3600);
            Console.WriteLine(Math.Round(V, 2) + " км/час");
            Console.ReadKey();*/


            /*Задание 4. Пользователь указывает цену одой минуты исходящего звонка с
            одного мобильного оператора другому, а также продолжительность разговора
            в минутах и секундах. Необходимо вычислить денежную сумму на которую был произведен звонок.*/


            /*Console.Write("Введите стоимость звонка: ");
            double Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите продолжительность разговора в минутах и секундах: ");
            double Time = Convert.ToDouble(Console.ReadLine());
            double Seconds = ((int)Time * 60) + ((Time * 100) - (int)Time * 100); // Переводим в секунды
            double Cost = Price / 60; // Определяем стоимость 1-ой минуты разговора
            double Total_cost = Seconds * Cost; // Определяем стоимость разговора
            Console.WriteLine("Стоимость звонка составила: " + Math.Round(Total_cost, 2) + " гривны");
            Console.ReadKey();*/


            /*Задание 5. Написать программу, которая преобразует введенное пользователем
            количество дней в количество полных недель и оставшихся дней. Например,
            пользователь ввел 17 дней, программа должна вывести на экран 2 недели и 3 дня.*/

            /*Console.Write("Введите количество дней: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int Week = a / 7;
            int Day = a % 7;
            Console.WriteLine("Недель: " + Week + ", дней: " + Day + ".");
            Console.ReadKey();*/
        }
    }
}