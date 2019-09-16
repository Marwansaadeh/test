using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DatetimeLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab1();
            //Lab2();
            //Lab3();
            //Lab4();
            //Lab5();
            //Lab6();
            //Lab7();
            //Lab8();
            Lab9();
            Console.ReadLine();
        }


        public static void Lab1()
        {
            DateTime dateTimenow = DateTime.Now;

            Console.WriteLine(dateTimenow);

            Console.WriteLine(String.Format("{0:yyyy}/{1:MM}/{2:dd}",
            dateTimenow, dateTimenow, dateTimenow).ToString());

        }

        public static void Lab2()
        {
            DateTime dateTimenow = DateTime.Now;


            Console.WriteLine(String.Format("{0:yyyy}/{1:MM}/{2:dd}/{3:ss}/{4:ff}",
            dateTimenow, dateTimenow, dateTimenow, dateTimenow, dateTimenow).ToString());

        }

        public static void Lab3()
        {
            DateTime date = new DateTime(2019, 09, 13);
            string sepecificdate = String.Format("{0:d}", date).ToString();
            Console.WriteLine("the dat of the week for {0} is {1}", sepecificdate, date.DayOfWeek);


        }

        public static void Lab4()
        {

            DateTime date = DateTime.Now;
            Console.WriteLine("today is {0}", date);
            date = date.AddDays(3);

            Console.WriteLine("day is {0}", date.DayOfWeek);

        }

        public static void Lab5()
        {
            DateTime date = DateTime.Now;

            for (int i = 0; i < 10; i++)
            {
                string format = String.Format("{0:d}", date).ToString();
                Console.WriteLine(format);

                date = date.AddDays(40);

            }

        }

        public static void Lab6()
        {
            
           DateTime date= Convert.ToDateTime(Console.ReadLine());
            Thread.CurrentThread.CurrentCulture = new CultureInfo("sv-SE");

            Console.WriteLine(String.Format("{0:d}", date) + " " + DateTime.Now.Hour +":" +DateTime.Now.Minute);

        }

        static Random rnd = new Random();

        static void Lab7()

        {

            DateTime date = Convert.ToDateTime(Console.ReadLine());
            
            Console.WriteLine(DateTime.DaysInMonth(date.Year,date.Month));


        }


        public static void Lab8()
        {
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            DateTime date1 = Convert.ToDateTime(Console.ReadLine());
            TimeSpan interval = date - date1;
            Console.WriteLine(interval.TotalDays);
        }
        public static void Lab9()
        {
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            if(date.Year.Equals(DateTime.Now.Year)&& date.Month.Equals(DateTime.Now.Month)&&
                date.Day.Equals(DateTime.Now.Day)
                )
            {
                Console.WriteLine("equal");
            }
            else Console.WriteLine("NOT equal");

        }


    }
}
