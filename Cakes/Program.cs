namespace Cakes
{
    internal class Program
    {
        static void Main()
        {
            Zakaz.MAIN();
        }
    }
}


/*List<Parametr> sortedlist = Descriptions.Where(item => item.number == position).ToList<Parametr>();*/


/*while (true)
{

    foreach (string pos in name)
        Console.Write(pos + "; ");
    name.Add(Console.ReadLine());
}*//*

using Cakes;
using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using test1;

namespace Cakes
{
    internal class Program
    {
        private string name;
        private int position1 = 2;
        public int price;
        public static List<string> listok = new();
        public static List<int> listok2 = new();
        public static List<string> listok3 = new();
        public static List<string> listok4 = new();

        static void Main()
        {
            int position = 1;
            int position1 = 2;
            string name;
            int price = 0;
            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (position == 2 || key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                if (position == 9 || key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                List<Parametr> Names = new();
                Parametr name1 = new();
                name1.Name = "   Форма торта";
                Names.Add(name1);

                Parametr name2 = new();
                name2.Name = "   Размер торта";
                Names.Add(name2);

                Parametr name3 = new();
                name3.Name = "   Вкус коржей";
                Names.Add(name3);

                Parametr name4 = new();
                name4.Name = "   Количество коржей";
                Names.Add(name4);

                Parametr name5 = new();
                name5.Name = "   Глазурь";
                Names.Add(name5);

                Parametr name6 = new();
                name6.Name = "   Декор";
                Names.Add(name6);

                Parametr name7 = new();
                name7.Name = "   Конец заказа";
                Names.Add(name7);
                Console.Clear();
                Console.WriteLine("Введите ваш параметр торта");
                Console.WriteLine("--------------------------");
                foreach (Parametr pos in Names)
                {
                    Console.WriteLine(pos.Name);
                }
                Console.WriteLine("\n Цена: " + price);
                Console.Write("Заказ: ");
                foreach (string item in listok)
                {
                    Console.Write(item + " - ");
                }
                foreach (string item in listok4)
                {
                    Console.WriteLine(item + "; ");
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key = Console.ReadKey();

                if (key.Key == ConsoleKey.Enter)
                {
                    Program one = new("Круг", 400);
                    Program two = new("Квадрат", 450);
                    Program three = new("Прямоугольник", 550);
                    Program four = new("Сердечко", 750);

                    Program one2 = new("Маленький ( Диаметр - 16 см, 8 порций)", 900);
                    Program two2 = new("Обычный ( Диаметр - 18 см, 10 порций", 1200);
                    Program three2 = new("Большой ( Диаметр - 28 см, 24 порций)", 1500);
                    Program four2 = new("Громадный ( Диаметр - 42 см, 36 порций)", 3200);

                    Program one3 = new("Ванильный", 150);
                    Program two3 = new("Шоколадный", 125);
                    Program three3 = new("Банановый", 250);
                    Program four3 = new("Карамельный", 200);

                    Program one4 = new("1 корж", 150);
                    Program two4 = new("2 коржа", 300);
                    Program three4 = new("3 коржа", 450);
                    Program four4 = new("4 коржа", 600);

                    Program one5 = new("Шоколад", 100);
                    Program two5 = new("Крем", 100);
                    Program three5 = new("Бизе", 150);
                    Program four5 = new("Ягоды", 250);

                    Program one6 = new("Шоколадная", 100);
                    Program two6 = new("Ягодная", 150);
                    Program three6 = new("Кремовая", 150);
                    Program four6 = new("Фруктовая", 150);
                    while (key.Key != ConsoleKey.Escape)
                    {
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
                        if (position == 2)
                        {
                            one.P1();
                            two.P1();
                            three.P1();
                            four.P1();
                        }
                        if (position == 3)
                        {
                            one2.P1();
                            two2.P1();
                            three2.P1();
                            four2.P1();
                        }
                        if (position == 4)
                        {
                            one3.P1();
                            two3.P1();
                            three3.P1();
                            four3.P1();
                        }
                        if (position == 5)
                        {
                            one4.P1();
                            two4.P1();
                            three4.P1();
                            four4.P1();
                        }
                        if (position == 6)
                        {
                            one5.P1();
                            two5.P1();
                            three5.P1();
                            four5.P1();
                        }
                        if (position == 7)
                        {
                            one6.P1();
                            two6.P1();
                            three6.P1();
                            four6.P1();
                        }

                        Console.SetCursorPosition(0, position1);
                        Console.WriteLine("->");
                        key = Console.ReadKey();
                    }
                }
            }
        }
        string n;
        int p;

        public void P1()
        {
            Console.WriteLine($"  {n} - {p}");
            listok.Add(n);
            listok2.Add(p);
            listok4 = listok2.Select(i => i.ToString()).ToList();
        }

        public void D1()
        {
            listok.Add(n);
            listok2.Add(p);
            listok4 = listok2.Select(i => i.ToString()).ToList();
        }
    }
}



*//*List<Parametr> sortedlist = Descriptions.Where(item => item.number == position).ToList<Parametr>();*/

