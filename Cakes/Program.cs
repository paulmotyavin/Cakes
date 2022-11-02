namespace Cakes
{
    internal class Program
    {
        static public string zakaz;
        static public int price;
        static public int position = 2;
        static public int position1 = 2;
        public static DateTime day = new();
        static void Main()
        {
            while (true)
            {
                List<Parametr> Names = new();
                List<Parametr> Descriptions = new();
                Parametr name1 = new();
                Parametr value1 = new();
                name1.Name = "   Форма торта";
                value1.Name1 = "   Круг";
                value1.price1 = 400;
                value1.Name2 = "   Квадрат";
                value1.price2 = 450;
                value1.Name3 = "   Прямоугольник";
                value1.price3 = 550;
                value1.Name4 = "   Сердечко";
                value1.price4 = 750;
                Names.Add(name1);
                Descriptions.Add(value1);

                Parametr name2 = new();
                Parametr value2 = new();
                name2.Name = "   Размер торта";
                value2.Name1 = "   Маленький ( Диаметр - 16 см, 8 порций)";
                value2.price1 = 900;
                value2.Name2 = "   Обычный ( Диаметр - 18 см, 10 порций)";
                value2.price2 = 1200;
                value2.Name3 = "   Большой ( Диаметр - 28 см, 24 порций)";
                value2.price3 = 1500;
                value2.Name4 = "   Громадный ( Диаметр - 42 см, 36 порций)";
                value2.price4 = 3200;
                Names.Add(name2);
                Descriptions.Add(value2);

                Parametr name3 = new();
                Parametr value3 = new();
                name3.Name = "   Вкус коржей";
                value3.Name1 = "   Ванильный";
                value3.price1 = 150;
                value3.Name2 = "   Шоколадный";
                value3.price2 = 125;
                value3.Name3 = "   Банановый";
                value3.price3 = 250;
                value3.Name4 = "   Карамельный";
                value3.price4 = 200;
                Names.Add(name3);
                Descriptions.Add(value3);

                Parametr name4 = new();
                Parametr value4 = new();
                name4.Name = "   Количество коржей";
                value4.Name1 = "   1 корж";
                value4.price1 = 150;
                value4.Name2 = "   2 коржа";
                value4.price2 = 300;
                value4.Name3 = "   3 коржа";
                value4.price3 = 450;
                value4.Name3 = "   4 коржа";
                value4.price3 = 600;
                value4.Name4 = "   6 коржей";
                value4.price4 = 850;
                Names.Add(name4);
                Descriptions.Add(value4);

                Parametr name5 = new();
                Parametr value5 = new();
                name5.Name = "   Глазурь";
                value5.Name1 = "   Шоколад";
                value5.price1 = 100;
                value5.Name2 = "   Крем";
                value5.price2 = 100;
                value5.Name3 = "   Бизе";
                value5.price3 = 150;
                value5.Name4 = "   Ягоды";
                value5.price4 = 250;
                Names.Add(name5);
                Descriptions.Add(value5);

                Parametr name6 = new();
                Parametr value6 = new();
                name6.Name = "   Декор";
                value6.Name1 = "   Шоколадная";
                value6.price1 = 100;
                value6.Name2 = "   Ягодная";
                value6.price2 = 150;
                value6.Name3 = "   Кремовая";
                value6.price3 = 150;
                value6.Name4 = "   Фруктовая";
                value6.price4 = 150;
                Names.Add(name6);
                Descriptions.Add(value6);

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
                Console.WriteLine("\n\nВаш заказ: " + zakaz);
                Console.WriteLine("\nЦена: " + price);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                ConsoleKeyInfo key = Console.ReadKey();
                if (position == 2 || key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                if (position == 9 || key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 2)
                    {
                        Descriptions.Clear();
                        Descriptions.Add(value1);
                    }
                    if (position == 3)
                    {
                        Descriptions.Clear();
                        Descriptions.Add(value2);
                    }
                    if (position == 4)
                    {
                        Descriptions.Clear();
                        Descriptions.Add(value3);
                    }
                    if (position == 5)
                    {
                        Descriptions.Clear();
                        Descriptions.Add(value4);
                    }
                    if (position == 6)
                    {
                        Descriptions.Clear();
                        Descriptions.Add(value5);
                    }
                    if (position == 7)
                    {
                        Descriptions.Clear();
                        Descriptions.Add(value6);
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
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
                            foreach (Parametr item in Descriptions)
                            {
                                Console.WriteLine(item.Name1 + " - " + item.price1);
                                Console.WriteLine(item.Name2 + " - " + item.price2);
                                Console.WriteLine(item.Name3 + " - " + item.price3);
                                Console.WriteLine(item.Name4 + " - " + item.price4);
                            }
                            Console.SetCursorPosition(0, position1);
                            Console.WriteLine("->");
                            if (position == 8)
                            {
                                Console.Clear();
                                Console.WriteLine("Спасибо за заказ!");
                                 day = DateTime.Now;
                                File.AppendAllText("C:/Users/paulscriptum/Desktop/заказ.txt", "Заказ от " + day + "\n\t" + "Заказ: " + zakaz + "\n\t" + "Цена: " + price + "\n");
                            }
                            key = Console.ReadKey();
                            if (key.Key == ConsoleKey.Enter)
                            {
                                foreach (Parametr item in Descriptions)
                                {
                                    if (position1 == 3)
                                    {
                                        price += item.price1;
                                        zakaz = zakaz + item.Name1 + " - " + item.price1 + "; ";
                                    }
                                    if (position1 == 4)
                                    {
                                        price += item.price2;
                                        zakaz = zakaz + item.Name2 + " - " + item.price2 + "; ";
                                    }
                                    if (position1 == 5)
                                    {
                                        price += item.price3;
                                        zakaz = zakaz + item.Name3 + " - " + item.price3 + "; ";
                                    }
                                    if (position1 == 6)
                                    {
                                        price += item.price4;
                                        zakaz = zakaz + item.Name4 + " - " + item.price4 + "; ";
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }
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
        public Program(string description, int price) { n = description; p = price; }

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

