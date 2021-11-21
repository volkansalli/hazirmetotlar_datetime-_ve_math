using System;

namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            string z=DateTime.Now.ToString();
            //string[][] y=DateTime.Now;  BU ŞEKİLDEDE ÇALIŞMIYOR DATETIME düz bir string yada dizi değil                      
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(z=DateTime.Now.ToString());
            //Console.WriteLine(a=Convert.ToInt32(DateTime.Now)); bu şekilde çalışmıyor
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            

            Console.WriteLine("*****************");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.AddDays(10));
            Console.WriteLine(DateTime.Now.AddHours(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(10));
            Console.WriteLine(DateTime.Now.AddMinutes(10));
            Console.WriteLine(DateTime.Now.AddSeconds(10));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMonths(10));
            Console.WriteLine(DateTime.Now.AddTicks(10));

            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));//21
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Paz
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Pazar
            Console.WriteLine(DateTime.Now.ToString("MM"));//11
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Kas
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//Kasım
            Console.WriteLine(DateTime.Now.ToString("yy"));//21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021

            //Math kütüphanesi
            Console.WriteLine(Math.Abs(-23));
            Console.WriteLine(Math.Sin(30));
            Console.WriteLine(Math.Cos(60));
            Console.WriteLine(Math.Tan(45));

            Console.WriteLine(Math.Floor(-22.7));
            Console.WriteLine(Math.Round(-23.2));
            Console.WriteLine(Math.Round(-23.7));
            Console.WriteLine(Math.Ceiling(-22.7));
            
            Console.WriteLine(Math.Min(4.1,6.1));
            if(4.1<6.1)
            Console.WriteLine("volki");
            Console.WriteLine(Math.Max(4.1,6.1));
            Console.WriteLine(Math.Pow(2,3));
            Console.WriteLine(Math.Sqrt(4));
            Console.WriteLine(Math.Log(2,5));
            Console.WriteLine(Math.Log10(100));
            Console.WriteLine(Math.Exp(10));
            



            



        }
    }
}
