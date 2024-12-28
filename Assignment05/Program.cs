using System;
using System.ComponentModel.Design;
using System.Security;

namespace Assignment05
{
    #region Q1
    enum WeekDays
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesdat,
        Thursday,
        Friday

    }

    #endregion
    #region Q2
    enum Seasons
    {
        Spring,
        Winter,
        Summer,
        Autumn

    }
    #endregion
    #region Q3
    [Flags]
    enum Permessions
    {
        Read = 8,
        Write = 4,
        Execute = 2,
        Delete = 1 
    }
    #endregion
    #region Q4
    enum Colors
    {
        Red,
        Green,
        Blue
    }
    #endregion
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Q1

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion
            #region Q2
            //Console.WriteLine("Enter a season");
            //string Season = Console.ReadLine();
            //if(Enum.TryParse(Season, true, out Seasons season)){
            //    switch (season)
            //    {
            //        case Seasons.Spring:
            //            Console.WriteLine("Spring March to May");
            //            break;
            //        case Seasons.Winter:
            //            Console.WriteLine("Winter Dec To Feb");
            //            break;
            //        case Seasons.Summer:
            //            Console.WriteLine("Summer Jun to Aug");
            //            break;
            //        case Seasons.Autumn:
            //            Console.WriteLine("Autumn Sept to Nov");
            //            break;

            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Please enter valid Season");
            //}
            #endregion
            #region Q3
            Permessions Perm01 = Permessions.Execute;
            Perm01 ^= Permessions.Delete;
            if ((Perm01 & Permessions.Delete) == Permessions.Delete)
            {
                Console.WriteLine("Exsist");
            }
            else
            {
                Console.WriteLine("not exist");

            }
            #endregion
            #region Q4
            Console.WriteLine("Enter a color");
            string Col = Console.ReadLine();
            if (Enum.TryParse(Col, true, out Colors color))
            {
                if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
                {
                    Console.WriteLine($"{color} is a primary color.");
                }
                else
                {
                    Console.WriteLine($"{color} is not a primary color.");
                }
            }
 
            #endregion

        }
    }
}
