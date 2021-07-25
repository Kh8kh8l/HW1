using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Первое задание!
            
            Console.WriteLine("Введите имя!");
            string data;

            data = Console.ReadLine();
            Console.WriteLine("Привет " + data);

            //Второе задание!

            Console.WriteLine("Решение квадратного уравнения");
            Console.Write(" a = ");
            var a = double.Parse(Console.ReadLine());

            Console.Write(" b = ");
            var b = double.Parse(Console.ReadLine());

            Console.Write(" c = ");
            var c = double.Parse(Console.ReadLine());

            double x1, x2;

            var discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("В уровнении нет корней");
            }
            else
            {
                if (discriminant == 0)
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }
                Console.WriteLine($"x1 = {x1}; x2 = {x2}");
            }//3 задание!

            double x, y, z;
            Console.Write(" a = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write(" b = ");
            y = Convert.ToDouble(Console.ReadLine());
            z = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine("Гипотенуза = " + z);

            double X1 = Math.Acos(((Math.Pow(x, 2) + Math.Pow(z, 2) - Math.Pow(y, 2)) / (2 * x * z))) * 180 / Math.PI;
            double Y1 = Math.Acos(((Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(z, 2)) / (2 * x * y))) * 180 / Math.PI;
            double Z1 = Math.Acos(((Math.Pow(y, 2) + Math.Pow(z, 2) - Math.Pow(x, 2)) / (2 * z * y))) * 180 / Math.PI;

            Console.WriteLine("Уголы равны {0} {1} {2}", X1, Y1, Z1);
            

            Console.WriteLine("Для выхода нажмите любую клавишу...");
            Console.ReadKey(true);
        }
    }
}
