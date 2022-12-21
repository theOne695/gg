namespace regestration
{
    internal class Program
    {
        static public ConsoleKeyInfo cho_to;
        static public int position = 4;
        static public int organ2;
        static public int ogran = 1;
        static public int posit;
        static public int reg;
        static void Main(string[] args)
        {
            Magazin();
        }
        static void Magazin()
        {
            Console.SetCursorPosition(35, 0);
            Console.WriteLine("Добро пожаловать в магазин Glebovskiye!");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  Логин: ");

            Console.WriteLine("  Пароль: ");

            Console.WriteLine("  Авторизироваться");
            organ2 = 4;
            zamena_1();
            zamena_2();
        }
        static void zamena_1()
        {
            position = 2;
            do
            {
                if (cho_to.Key == ConsoleKey.UpArrow)
                {
                    if (position == 2)
                    {
                        position++;
                    }
                    Console.SetCursorPosition(0, position--);
                    Console.Write("->");
                }
                else if (cho_to.Key == ConsoleKey.DownArrow)
                {
                    if (organ2 == 2 && position == 2 || organ2 == 4 && position == 4)
                    {
                        position--;
                    }
                    Console.SetCursorPosition(0, position++);
                    Console.Write("->");
                }
                Console.Write("\r" + new string(' ', 2));
                Console.SetCursorPosition(0, position);
                Console.Write("->");
                cho_to = Console.ReadKey();
                if (cho_to.Key == ConsoleKey.Escape)
                {
                    ogran = 2;
                    organ2 = 4;
                    Magazin();
                    cho_to = Console.ReadKey();
                    return;
                }
            }
            while (cho_to.Key != ConsoleKey.Enter);
        }
        static void zamena_2()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 0);
            Console.WriteLine("Добро пожаловать admin!");
            Console.SetCursorPosition(55, 0);
            Console.WriteLine("Роль: Администратор ");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            ogran = 3;
            organ2 = 6;

            
        }
    }
}