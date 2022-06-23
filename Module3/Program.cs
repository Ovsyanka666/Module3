namespace Module3{
    class Program{

        static void Main()
        {
            //const string MyName = "Lera";
            //Console.WriteLine(MyName);
            //Console.WriteLine("\t Привет, мир");
            //Console.WriteLine("\t Мне 22 года");
            //Console.WriteLine("\t My name is\nLera");

            //Console.WriteLine('\u0040'); 
            //Console.WriteLine('\u0023');

            string name = "Lera";
            byte age = 22;
            bool HavePet = true;
            double ShoeSize = 37.5;

            Console.WriteLine("My name is {0}\nI'm {1} years old\nDo I have a pet? {2}\nMy shoe size {3}", name, age, HavePet, ShoeSize);


        }
    }
}