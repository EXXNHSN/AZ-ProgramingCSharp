using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Console.Write("Hello");
            //Console.WriteLine("Hello");
            //Console.WriteLine("Benim Adim Elxan");
            //Console.WriteLine("Bu ilin Axirina Kimi Bu Kursu Bitir Kishiliyin Olsun");
            #endregion
            #region DEYISHKENLER
            //string capital,country;
            //capital = Console.ReadLine();  -  klavyeden deyer girme
            //country = Console.ReadLine();   
            //Console.WriteLine(capital);
            //Console.WriteLine(country);
            //Console.Write("Hello");
            //addition = number1 + number2;
            //extraction = number1 - number2;
            //multiplcation = number1 * number2;
            //division = number1 / number2;

            //int sayi;
            //Console.WriteLine("Sayiyi girin");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(sayi);

            //double s1, s2, s3;
            //double cvb;

            //Console.WriteLine("uc eded reqem giriniz");
            //s1  = Convert.ToDouble(Console.ReadLine());
            //s2 = Convert.ToDouble(Console.ReadLine());
            //s3 = Convert.ToDouble(Console.ReadLine());
            //cvb = (s1 + s2 + s3) / 3;
            //Console.WriteLine("ortalama  " + cvb);

            //char charfs = 'a';   // tek deyishken 
            //Console.WriteLine(charfs);
            #endregion
            #region KARAR YAPILARI



            #endregion
            Console.WriteLine("Enter first number");
            int var1;

            while (true)
            {
                Console.WriteLine("Dovur aperatoru whileye daxil oldu");

                try
                {
                    var1 = int.Parse(Console.ReadLine());
                    //var1 = int.Parse(Console.ReadLine());
                    
                    break;     
                    // Console.ReadLine();

                }
                catch (Exception ex)
                {

                    Console.WriteLine("siz ancaq reqem daxil edin---you can only enter int number");
                    //var1 = 0;
                }

                

            }

            Console.WriteLine("enter second number");
            
            int var2 = int.Parse(Console.ReadLine());
            int sum = Sum(var1, var2);
            Console.WriteLine("sum is:" + sum);
            Console.ReadLine();
            //var1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter second number");
            //int var2 = int.Parse(Console.ReadLine());
            //int sum = Sum(var1,var2);

            //Console.WriteLine(var1+ " Yazdigin birinci reqem");
            //int var3 = int.Parse(Console.ReadLine());
            //Console.WriteLine(var1 + " Yazdigin ikinci reqem");
            // Console.WriteLine(var1 + var2 + "sum is:"  );


        }

        //method
        public static int Sum(int reqem1, int reqem2)
        {
            return reqem1 + reqem2;
        }
    }
}
