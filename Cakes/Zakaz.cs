namespace Cakes
{
    internal class Zakaz
    {
        static public string zakaz = "";
        static public int price = 0;
        static public int position = 2;
        static public int position1 = 2;
        public static DateTime day = new();
        public static ConsoleKeyInfo key = Console.ReadKey();
        public static List<Podpunkt> list = new();
        static public void MAIN()
        {
            while (true)
            {
                FirstMenu();
                if (key.Key == ConsoleKey.Enter)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        while (key.Key != ConsoleKey.Escape)
                        {
                            SecondMenu();
                            Order();
                            key = Console.ReadKey();
                            if (key.Key == ConsoleKey.Enter)
                            {
                                Result();
                                break;
                            }
                        }
                    }
                }
            }
        }
        private static void FirstMenu()
        {
            Console.Clear();
            Console.WriteLine("Введите ваш параметр торта");
            Console.WriteLine("--------------------------");
            Console.WriteLine("   Форма торта");
            Console.WriteLine("   Размер торта");
            Console.WriteLine("   Вкус коржей");
            Console.WriteLine("   Количество коржей");
            Console.WriteLine("   Глазурь");
            Console.WriteLine("   Декор");
            Console.WriteLine("   Конец заказа");
            Console.WriteLine("\n\nВаш заказ: " + zakaz);
            Console.WriteLine("\nЦена: " + price);
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            key = Console.ReadKey();
            if (position == 1 || key.Key == ConsoleKey.DownArrow)
            {
                position++;
            }
            if (position == 9 || key.Key == ConsoleKey.UpArrow)
            {
                position--;
            }
        }
        private static void SecondMenu()
        {
            Podpunkt value1 = new("   Круг", 400, "   Квадрат", 450, "   Прямоугольник", 550, "   Сердечко", 750);
            Podpunkt value2 = new("   Маленький ( Диаметр - 16 см, 8 порций)", 900, "   Обычный ( Диаметр - 18 см, 10 порций)", 1200, "   Большой ( Диаметр - 28 см, 24 порций)", 1500, "   Громадный ( Диаметр - 42 см, 36 порций)", 3200);
            Podpunkt value3 = new("   Ванильный", 150, "   Шоколадный", 125, "   Банановый", 250, "   Карамельный", 200);
            Podpunkt value4 = new("   1 корж", 150, "   2 коржа", 300, "   3 коржа", 450, "   4 коржа", 600);
            Podpunkt value5 = new("   Шоколад", 100, "   Крем", 100, "   Бизе", 150, "   Ягоды", 250);
            Podpunkt value6 = new("   Шоколадная", 100, "   Ягодная", 150, "   Кремовая", 150, "   Фруктовая", 150);
            if (position == 2)
            {
                list.Clear();
                list.Add(value1);
            }
            if (position == 3)
            {
                list.Clear();
                list.Add(value2);
            }
            if (position == 4)
            {
                list.Clear();
                list.Add(value3);
            }
            if (position == 5)
            {
                list.Clear();
                list.Add(value4);
            }
            if (position == 6)
            {
                list.Clear();
                list.Add(value5);
            }
            if (position == 7)
            {
                list.Clear();
                list.Add(value6);
            }
            if (position1 == 6 || key.Key == ConsoleKey.UpArrow)
            {
                position1--;
            }
            if (position1 == 2 || key.Key == ConsoleKey.DownArrow)
            {
                position1++;
            }
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт из меню: ");
            Console.WriteLine("--------------------------");
            foreach (Podpunkt item in list)
            {
                Console.WriteLine(item.Name1 + " - " + item.price1);
                Console.WriteLine(item.Name2 + " - " + item.price2);
                Console.WriteLine(item.Name3 + " - " + item.price3);
                Console.WriteLine(item.Name4 + " - " + item.price4);
            }
            Console.SetCursorPosition(0, position1);
            Console.WriteLine("->");
        }
        private static void Result()
        {
            foreach (Podpunkt i in list)
            {
                if (position1 == 3)
                {
                    price += i.price1;
                    zakaz = zakaz + i.Name1 + " - " + i.price1 + "; ";
                }
                if (position1 == 4)
                {
                    price += i.price2;
                    zakaz = zakaz + i.Name2 + " - " + i.price2 + "; ";
                }
                if (position1 == 5)
                {
                    price += i.price3;
                    zakaz = zakaz + i.Name3 + " - " + i.price3 + "; ";
                }
                if (position1 == 6)
                {
                    price += i.price4;
                    zakaz = zakaz + i.Name4 + " - " + i.price4 + "; ";
                }
            }
        }
        private static void Order()
        {
            if (position == 8)
            {
                Console.Clear();
                Console.WriteLine("Спасибо за заказ! Для повторного заказа нажмите Escape");
                day = DateTime.Now;
                File.AppendAllText("C:/Users/paulscriptum/Desktop/заказ.txt", "Заказ от " + day + "\n\t" + "Заказ: " + zakaz + "\n\t" + "Цена: " + price + "\n");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    price = 0;
                    zakaz = "";
                    MAIN();
                }
            }
        }
    }
}