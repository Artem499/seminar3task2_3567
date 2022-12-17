//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


class Cube

    {
        public int N;
        public int D;
    }

class calculation
    {
        static void Main(string[] args)
    
        {
            Cube number = new Cube();
            Cube degreeOfNumber = new Cube();

            Console.Clear();

            Console.WriteLine("Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N");

            Console.Write("Enter the number : ");
            number.N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the degree of the number : ");
            degreeOfNumber.D = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nAnswer: {Math.Pow(number.N, degreeOfNumber.D)}");
            
            for (int i = 1; i <= number.N; i++)
            {
                Console.WriteLine($"\ntable : {i}");

                if (i <= number.N)
                {
                    Console.Write($"otput : {Math.Pow(i, degreeOfNumber.D)}");
                }
            Console.WriteLine();
            }         
        }
    }

