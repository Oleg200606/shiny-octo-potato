

namespace Tortik
{
    public class Tortiki
    {
        public string Form;
        public string Razmer;
        public string Vkyc;
        public string Korzh;
        public string Glaz;
        public string Dekor;

    }
    public class Vib
    {

        static Tortiki tort = new Tortiki();


        public static Tortiki Form(int chis)
        {
            switch (chis)
            {
                case 3:

                    tort.Form = "Круг - 500, ";
                    return tort;

                case 4:

                    tort.Form = "Квадрат - 500, ";
                    return tort;
                case 5:

                    tort.Form = "Прямоугольник - 500, ";
                    return tort;
                case 6:

                    tort.Form = "Сердце - 700, ";
                    return tort;
            }
            return tort;

        }
        public static Tortiki Razmer(int chis)
        {
            switch (chis)
            {
                case 3:
                    tort.Razmer = "Маленький (Деаметр - 16см, 8 порций) - 1000, ";
                    return tort;
                case 4:
                    tort.Razmer = "Средний (Деаметр - 18см, 1 порций) - 1200, ";
                    return tort;
                case 5:
                    tort.Razmer = "Большой (Деаметр - 28см, 24 порций) - 2000, ";
                    return tort;

            }
            return tort;
        }
        public static Tortiki Vkyc(int chis)
        {
            switch (chis)
            {
                case 3:
                    tort.Vkyc = "Ванильный - 100, ";
                    return tort;
                case 4:
                    tort.Vkyc = "Шоколадный - 100, ";
                    return tort;
                case 5:
                    tort.Vkyc = "Карамельный - 150, ";
                    return tort;
                case 6:
                    tort.Vkyc = "Ягодный - 200, ";
                    return tort;
                case 7:
                    tort.Vkyc = "Кокосовый - 250, ";
                    return tort;

            }
            return tort;
        }
        public static Tortiki Korzh(int chis)
        {
            switch (chis)
            {
                case 3:
                    tort.Korzh = "1 корж - 200, ";
                    return tort;
                case 4:
                    tort.Korzh = "2 коржа - 400, ";
                    return tort;
                case 5:
                    tort.Korzh = "3 коржа - 600, ";
                    return tort;
                case 6:
                    tort.Korzh = "4 коржа - 800, ";
                    return tort;
            }
            return tort;
        }
        public static Tortiki Glaz(int chis)
        {
            switch (chis)
            {
                case 3:
                    tort.Glaz = "Шоколад - 100, ";
                    return tort;
                case 4:
                    tort.Glaz = "Крем - 100, ";
                    return tort;
                case 5:
                    tort.Glaz = "Бизе - 150, ";
                    return tort;
                case 6:
                    tort.Glaz = "Драже - 150, ";
                    return tort;
                case 7:
                    tort.Glaz = "Ягоды - 200, ";
                    return tort;

            }
            return tort;
        }
        public static Tortiki Dekor(int chis)
        {
            switch (chis)
            {
                case 3:
                    tort.Dekor = "Ягодная - 150, ";
                    return tort;
                case 4:
                    tort.Dekor = "Шоколадная - 150, ";
                    return tort;
                case 5:
                    tort.Dekor = "Кремовая - 150, ";
                    return tort;

            }
            return tort;

        }
        public static Tortiki Nullik()
        {
            tort.Form = null;
            tort.Razmer = null;
            tort.Vkyc = null;
            tort.Korzh = null;
            tort.Glaz = null;
            tort.Dekor = null;


            return tort;
        }
    }
}



    
