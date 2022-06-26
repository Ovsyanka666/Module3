namespace Module3{
    class Final{

        static void Main()
        {
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату Вашего рождения: ");
            var birthdate = Console.ReadLine();
            Console.Write($"Ваше имя {name}\nВаш возраст {age}\nДата Вашего рождения {birthdate}");

        }
    }
}