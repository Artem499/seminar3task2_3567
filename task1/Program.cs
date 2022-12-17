
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.


// создаю класс MathGeometry

class MathGeometry

// создаю поля класса переменной x , y, z.
// использую модификатор public - доступ не ограничен.
    {
        public double x;
        public double y;
        public double z;
    }
// Создаю класс Programm
class Programm

    {
        static void Main(string[] args)
        {
            MathGeometry point = new MathGeometry();
            Console.Clear();

            Console.WriteLine("Консольная программа принимает на вход координаты двух точек");
            Console.WriteLine("и находит расстояние между ними в 3D пространстве.");

            Console.WriteLine("\nEnter the coordinats X, Y, Z :");
            Console.Write("\n\tX : ");
            point.x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tY : ");
            point.y = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tZ : ");
            point.z = Convert.ToInt32(Console.ReadLine());

            MathGeometry point1 = new MathGeometry();

            Console.WriteLine("\nEnter the coordinats X1, Y1, Z1 :");
            Console.Write("\n\tX1 : ");
            point1.x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tY1 : ");
            point1.y = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tZ1 : ");
            point1.z = Convert.ToInt32(Console.ReadLine());

            double result = Math.Sqrt((Math.Pow((point1.x - point.x), 2)) + (Math.Pow((point1.y - point.y), 2)) + (Math.Pow((point1.z - point.z), 2)));
            
            Console.WriteLine($"\nResult : {result}");
            Console.WriteLine();

       }
    }
