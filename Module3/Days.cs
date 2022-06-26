namespace Module3{
    class Days{

        //static void Main(string[] args)
        //{
        //    //DaysOfWeek MyFavouriteDay = DaysOfWeek.Saturday;

        //    //Console.WriteLine(MyFavouriteDay);
        //    //Console.WriteLine("\tПривет,\nмир!");
        //    //Console.WriteLine("Меня зовут {0}", MyFavouriteDay);
        //    //byte age = 22;
        //    //Console.WriteLine($"Мой возраст {age}");

        //    ////Напишите код для вывода на экран трёх переменных: name, age, favcolor через перенос строки с помощью индексов {0}, {1}, {2}.
        //    //string name = "Лера";
        //    //string favcolor = "жёлтый";

        //    //Console.WriteLine("{0}\n {1}\n {2}", name, age, favcolor);

        //    //string str = Console.ReadLine();
        //    //Console.WriteLine(str);

        //    //int test = -5 / 2;
        //    //Console.WriteLine(test);

        //    ////double result = 5f / 2f;
        //    ////Console.WriteLine("5 / 2 = {0}", result);

        //    //int counter = 10;
        //    //Console.WriteLine("Value: {0} Increment: {1}", counter, ++counter);

        //    ////Запишите 5 делить на 2 умножить на 3 в переменную result типа double.

        //    //double result = 5 / 2 * 3;

        //    //int k = -5;
        //    //int b = 7;
        //    //b -= k;
        //    //Console.WriteLine(b);

        //    Console.Write("Enter your name: ");
        //    string name = Console.ReadLine();
        //    Console.Write("Enter your age: ");
        //    byte age = (byte)int.Parse(Console.ReadLine());
        //    Console.WriteLine("Your name is {0} and age is {1} ", name, age);
        //    Console.ReadKey();

        //    Console.Write("What is your favourite day of week? ");
        //    DaysOfWeek MyFavouriteDay = (DaysOfWeek)byte.Parse(Console.ReadLine());
        //    Console.Write("My favourite day is " + MyFavouriteDay);

        //    var age1 = checked(Convert.ToByte(Console.ReadLine()));
        //}

    }

    enum DaysOfWeek : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thirthsday,
        Friday,
        Saturday,
        Sunday
    }

    enum Semaphore : short {
        Green = 100, Yellow = 200, Red = 300
    }
}