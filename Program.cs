
using Tortik;

namespace Last
{
    public class Program
    {
        static List<Tortiki> menu = new List<Tortiki>(); //лист для конфигурации торта
        static int price;
        static void Main()
        {
            Vib tort = new Vib();


            DateTime dt = DateTime.Now;
            string d = Convert.ToString(dt);

            Console.Clear();
            Console.WriteLine("Заказ тортов в ШОКОЛАДКА, торты на ваш выбор!");
            Console.WriteLine("Выберите параметр торта");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус торта");
            Console.WriteLine("  Кол-во коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("Цена:" + price);

            Console.WriteLine("Ваш торт:");
            foreach (Tortiki poz in menu)
            {
                Console.Write(poz.Form);
                Console.Write(poz.Razmer);
                Console.Write(poz.Vkyc);
                Console.Write(poz.Korzh);
                Console.Write(poz.Glaz);
                Console.Write(poz.Dekor);
            }
            



            int pozi = 3;
            Console.SetCursorPosition(0, pozi);
            Console.WriteLine("->");
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pozi--;

                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pozi++;


                }
                if (pozi > 9)
                {
                    pozi = 9;
                    Console.SetCursorPosition(0, pozi);
                }
                if (pozi < 4)
                {
                    pozi = 3;
                    Console.SetCursorPosition(0, pozi);
                }
                Console.Clear();
                Console.WriteLine("Заказ тортов в ШОКОЛАДКА, торты на ваш выбор!");
                Console.WriteLine("Выберите параметр торта");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("  Форма торта");
                Console.WriteLine("  Размер торта");
                Console.WriteLine("  Вкус торта");
                Console.WriteLine("  Кол-во коржей");
                Console.WriteLine("  Глазурь");
                Console.WriteLine("  Декор");
                Console.WriteLine("  Конец заказа");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("Цена:" + price);

                Console.WriteLine("Ваш торт:");
                foreach (Tortiki poz in menu)
                {
                    Console.Write(poz.Form);
                    Console.Write(poz.Razmer);
                    Console.Write(poz.Vkyc);
                    Console.Write(poz.Korzh);
                    Console.Write(poz.Glaz);
                    Console.Write(poz.Dekor);
                }
                


                Console.SetCursorPosition(0, pozi);
                Console.WriteLine("->");
                key = Console.ReadKey();


            }

            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт из меню");
            Console.WriteLine("--------------------------------------");

            
            string[] FormaT = new string[] { "  Круг - 500", "  Квадрат - 500", "  Прямоугльник - 500","  Сердечко - 700" };
            string[] Razmero = new string[] { "  Маленький (Деаметр - 16см, 8 порций) - 1000", "  Средний (Деаметр - 18см, 1 порций) - 1200", "  Большой (Деаметр - 28см, 24 порций) - 2000" };
            string[] Vkysovzhina = new string[] { "  Ванильный - 100", "  Шоколадный - 100", "  Карамельный - 150", "  Ягодный - 200", "  Кокосовый - 250" };
            string[] KOl_VO = new string[] { "  1 корж - 200", "  2 коржа - 400", "  3 коржа - 600", "  4 коржа - 800" };
            string[] Galazyr = new string[] { "  Шоколад - 100", "  Крем - 100", "  Бизе - 150", "  Драже - 150", "  Ягоды - 200" };
            string[] Decocor = new string[] { "  Ягодная - 150", "  Шоколадная - 150", "  Кремовая - 150" };

            switch (pozi) 
            {
                case 3:

                    foreach (string ch in FormaT)
                    {
                        Console.WriteLine(ch);
                    }

                    break;
                case 4:

                    foreach (string ch in Razmero)
                    {
                        Console.WriteLine(ch);
                    }

                    break;
                case 5:

                    foreach (string ch in Vkysovzhina)
                    {
                        Console.WriteLine(ch);
                    }

                    break;

                case 6:

                    foreach (string ch in KOl_VO)
                    {
                        Console.WriteLine(ch);
                    }

                    break;

                case 7:

                    foreach (string ch in Galazyr)
                    {
                        Console.WriteLine(ch);
                    }

                    break;
                case 8:

                    foreach (string ch in Decocor)
                    {
                        Console.WriteLine(ch);
                    }

                    break;

                case 9:

                    Console.Clear();
                    Console.WriteLine("Спасибо за заказ! Если хотите сделать еще один, нажмите на клавишу TAB");
                    ConsoleKeyInfo kee = Console.ReadKey();
                    if (kee.Key == ConsoleKey.Tab)
                    {

                        foreach (Tortiki zp in menu)
                        {
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", "Дата: " + d + "\n");
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", "Ваш заказ:" + "\n");
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", zp.Form);
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", zp.Razmer);
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", zp.Vkyc);
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", zp.Korzh);
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", zp.Glaz);
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", zp.Dekor + "\n");
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", "Общая стоимость:" + price + "\n");
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", "\n");

                        }
                        Program.menu.Clear();
                        Vib.Nullik();
                        price = 0;
                        Main();
                    }
                    else
                    {
                        foreach (Tortiki zp in menu)
                        {
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", "Дата: " + d + "\n");
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", "Ваш заказ:" + "\n");
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", zp.Form);
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", zp.Razmer);
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", zp.Vkyc);
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", zp.Korzh);
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", zp.Glaz);
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", zp.Dekor + "\n");
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", "Общая стоимость:" + price + "\n");
                            File.AppendAllText("/Users/oleg/Desktop/заказы/Заказ1.txt", "\n");

                        }
                        Environment.Exit(0);
                    }

                    break;
            }

            int pozi2 = 3;
            Console.SetCursorPosition(0, pozi2);
            Console.WriteLine("->");
            ConsoleKeyInfo keee = Console.ReadKey();
            if (keee.Key == ConsoleKey.Escape)
            {
                Main();

            }
            else
            {
                while (keee.Key != ConsoleKey.Enter)
                {
                    if (keee.Key == ConsoleKey.UpArrow)
                    {
                        pozi2--;
                    }
                    if (keee.Key == ConsoleKey.DownArrow)
                    {
                        pozi2++;

                    }
                    if (pozi2 > 7)
                    {
                        pozi2 = 7;
                        Console.SetCursorPosition(0, pozi2);
                    }
                    if (pozi2 < 3)
                    {
                        pozi2 = 3;
                        Console.SetCursorPosition(0, pozi2);
                    }

                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню");
                    Console.WriteLine("--------------------------------------");

                    switch (pozi) //Дополнительная менюшка
                    {
                        case 3:

                            foreach (string ch in FormaT)
                            {
                                Console.WriteLine(ch);

                            }

                            break;
                        case 4:

                            foreach (string ch in Razmero)
                            {
                                Console.WriteLine(ch);
                            }

                            break;
                        case 5:

                            foreach (string ch in Vkysovzhina)
                            {
                                Console.WriteLine(ch);
                            }

                            break;

                        case 6:

                            foreach (string ch in KOl_VO)
                            {
                                Console.WriteLine(ch);
                            }

                            break;

                        case 7:

                            foreach (string ch in Galazyr)
                            {
                                Console.WriteLine(ch);
                            }

                            break;
                        case 8:

                            foreach (string ch in Decocor)
                            {
                                Console.WriteLine(ch);
                            }

                            break;




                    }
                    Console.SetCursorPosition(0, pozi2);
                    Console.WriteLine("->");
                    keee = Console.ReadKey();
                    if (keee.Key == ConsoleKey.Escape)
                    {
                        Main();
                    }

                }
                Program.menu.Clear();
                                    
                switch (pozi)
                {
                    case 3:

                        if (pozi2 == 3)
                        {
                            Program.menu.Add(Vib.Form(pozi2));
                            price = price + 500;
                        }
                        else if (pozi2 == 4)
                        {
                            Program.menu.Add(Vib.Form(pozi2));
                            price = price + 500;
                        }
                        else if (pozi2 == 5)
                        {
                            Program.menu.Add(Vib.Form(pozi2));
                            price = price + 500;
                        }
                        else if (pozi2 == 6)
                        {
                            Program.menu.Add(Vib.Form(pozi2));
                            price = price + 700;
                        }
                        break;

                    case 4:

                        if (pozi2 == 3)
                        {

                            Program.menu.Add(Vib.Razmer(pozi2));
                            price = price + 1000;
                        }
                        else if (pozi2 == 4)
                        {
                            Program.menu.Add(Vib.Razmer(pozi2));
                            price = price + 1200;
                        }
                        else if (pozi2 == 5)
                        {
                            Program.menu.Add(Vib.Razmer(pozi2));
                            price = price + 2000;
                        }
                        break;

                    case 5:

                        if (pozi2 == 3)
                        {
                            Program.menu.Add(Vib.Vkyc(pozi2));
                            price = price + 100;
                        }
                        else if (pozi2 == 4)
                        {
                            Program.menu.Add(Vib.Vkyc(pozi2));
                            price = price + 100;
                        }
                        else if (pozi2 == 5)
                        {
                            Program.menu.Add(Vib.Vkyc(pozi2));
                            price = price + 150;
                        }
                        else if (pozi2 == 6)
                        {
                            Program.menu.Add(Vib.Vkyc(pozi2));
                            price = price + 200;
                        }
                        else if (pozi2 == 7)
                        {
                            Program.menu.Add(Vib.Vkyc(pozi2));
                            price = price + 250;
                        }
                        break;

                    case 6:

                        if (pozi2 == 3)
                        {
                            Program.menu.Add(Vib.Korzh(pozi2));
                            price = price + 200;
                        }
                        else if (pozi2 == 4)
                        {
                            Program.menu.Add(Vib.Korzh(pozi2));
                            price = price + 400;
                        }
                        else if (pozi2 == 5)
                        {
                            Program.menu.Add(Vib.Korzh(pozi2));
                            price = price + 600;
                        }
                        else if (pozi2 == 6)
                        {
                            Program.menu.Add(Vib.Korzh(pozi2));
                            price = price + 800;
                        }
                        break;

                    case 7:

                        if (pozi2 == 3)
                        {
                            Program.menu.Add(Vib.Glaz(pozi2));
                            price = price + 100;
                        }
                        else if (pozi2 == 4)
                        {
                            Program.menu.Add(Vib.Glaz(pozi2));
                            price = price + 100;
                        }
                        else if (pozi2 == 5)
                        {
                            Program.menu.Add(Vib.Glaz(pozi2));
                            price = price + 150;
                        }
                        else if (pozi2 == 6)
                        {
                            Program.menu.Add(Vib.Glaz(pozi2));
                            price = price + 150;
                        }
                        else if (pozi2 == 7)
                        {
                            Program.menu.Add(Vib.Glaz(pozi2));
                            price = price + 200;
                        }
                        break;

                    case 8:

                        if (pozi2 == 3)
                        {
                            Program.menu.Add(Vib.Dekor(pozi2));
                            price = price + 150;
                        }
                        if (pozi2 == 4)
                        {
                            Program.menu.Add(Vib.Dekor(pozi2));
                            price = price + 150;

                        }
                        if (pozi2 == 5)
                        {
                            Program.menu.Add(Vib.Dekor(pozi2));
                            price = price + 150;
                        }
                        break;

                }
                Main();
            }
        }
    }
}