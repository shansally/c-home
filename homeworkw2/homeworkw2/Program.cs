using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace homeworkw2
{
    internal class Program
    {
        public static void hw2_1()
        {   //寫一程式，輸入x和y，如果x>y，則列印x，否則列印y
            double x, y;
            Console.WriteLine("請輸入x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入y:");
            y = Convert.ToDouble(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine(x);
            }
            else { Console.WriteLine(y); }
        }

        public static void hw2_2()
        {   //寫一程式，輸入x和y，如果x和y都是正數，令z=1，如兩者均為負數，令z=-1，否則令z=0
            double x, y, z;
            Console.WriteLine("請輸入x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入y:");
            y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                z = 1;

            }
            else if (x < 0 && y < 0)
            {
                z = -1;

            }
            else { z = 0; }
            Console.WriteLine(z);
        }

        public static void hw2_3()
        {    // 寫一程式，輸入x、y、u、v，如果(x+y)>(u+v)，則令z=x-y，否則令z=u-v
            double x, y, u, v, z;
            Console.WriteLine("請輸入x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入u:");
            u = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入v:");
            v = Convert.ToDouble(Console.ReadLine());


            if ((x + y) > (u + v))
            { z = x - y; }
            else
            { z = u - v; }
            Console.WriteLine(z);

        }

        public static void hw2_4()
        {   //寫一程式，輸入x、y、u、v，如果((x+y)/(u-v))>=2，令z=x-y，否則令z=u-v
            double x, y, u, v, z;
            Console.WriteLine("請輸入x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入u:");
            u = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入v:");
            v = Convert.ToDouble(Console.ReadLine());

            if (((x + y) / (u - v)) >= 2)
            { z = x - y; }
            else
            { z = u - v; }
            Console.WriteLine(z);
        }

        public static void hw2_5()
        {   //寫一程式，輸入x和y，如果x >= y，令z = x2，否則令z = y2
            double x, y ,z;
            Console.WriteLine("請輸入x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入y:");
            y = Convert.ToDouble(Console.ReadLine());

            if (x >= y)
            { z = Math.Pow(x,2); }
            else
            { z = Math.Pow(y,2); }
            Console.WriteLine(z);
        }

        public static void hw2_6()
        {
            double income, rate, difference,tax;
            Console.WriteLine("請輸入income:");
            income = Convert.ToDouble(Console.ReadLine());


            if (income > 4090000)
            {
                rate = 0.4;
                difference = 721100;
            }
            else if (income > 2180000)
            {
                rate = 0.3;
                difference = 312100;
            }
            else if (income > 1090000)
            {
                rate = 0.21;
                difference = 115900;
            }
            else if (income > 410000)
            {
                rate = 0.13;
                difference = 28700;
            }
            else
            {   rate = 0.06;
                difference = 0;
            }
            tax = (income * rate) - difference;
            Console.WriteLine(tax);



        }
        public static void hw2_7()
        {
            double x, y;
            Console.WriteLine("請輸入x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入y:");
            y = Convert.ToDouble(Console.ReadLine());

            if(x>0)
            {
                if (y > 0) { Console.WriteLine("1st quadrant\n"); }
                else if (y == 0) { Console.WriteLine("X-axis\n"); }
                else {Console.WriteLine("4th quadrant\n"); }
            }
            else if(x == 0)
            {   if (y == 0) { Console.WriteLine("Origin\n"); }
                else { Console.WriteLine("Y-axis\n"); }
             }
            else
            {
                if(y>0) { Console.WriteLine("2nd quadrant\n");}
                else if(y== 0) { Console.WriteLine("X-axis\n");}
                else
                {Console.WriteLine("3th quadrant\n");}
            }
            Console.WriteLine();
        }

        public static void addhw1()
        {
            int x,z;
            Console.WriteLine("請輸入x:");
            x = Convert.ToInt32(Console.ReadLine());

            if(x<=10)
            {
                z = x * 6;
            }
            else if(x>10 && x<=20)
            {
                z =(x - 10) * 2 + 60;
            }
            else if(x>20 && x<=40)
            {
                z = (x - 20) * 1 + 80;
            }
            else
            { z = 100; }
            Console.WriteLine(z);
        }

        public static void add2_1()
        {
            double h, w, bmi;
            Console.WriteLine("請輸入身高(m):");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入體重:(kg)");
            w = Convert.ToDouble(Console.ReadLine());
            bmi = w/Math.Pow(h,2);

            if(bmi<18.5) 
            { Console.WriteLine("體重過輕"); }
            else if(bmi > 18.5 && bmi <24)
            { Console.WriteLine("健康體重"); }
            else
            { Console.WriteLine("體重過重");}
        }

        public static void add2_2()
        {   // 隨意輸入三個數，請由大到小 依序印出
            double x, y, z;
            Console.WriteLine("請輸入x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入z:");
            z = Convert.ToDouble(Console.ReadLine());

            if (x > y)
            {
                if (y > z) { Console.WriteLine($"x,y,z   {x},{y},{z}"); }
                else if (x > z) { Console.WriteLine($"x,z,y   {x},{z},{y}"); }
                else { Console.WriteLine($"z,y,x   {z},{y},{x}"); }
            }
            else
            {
                if (x > z) { Console.WriteLine($"y,x,z   {y},{x},{z}"); }
                else if (y > z) { Console.WriteLine($"y,z,x   {y},{z},{x}"); }
                else
                {
                    Console.WriteLine($"z,y,x   {z},{y},{x}");
                }
            }
        }


        public static void add2_3()
        {
            //企業發放的獎金根據利潤提成。利潤低於或等於10萬元時，獎金可提10 %；
            //利潤高于10萬元，低於20萬元時，低於10萬元的部分按10 % 提成，高於10萬元的部分，可提成7.5 %；
            //20萬到40萬之間時，高於20萬元的部分，可提成5 %；
            //40萬到60萬之間時高於40萬元的部分，可提成3 %；
            //60萬到100萬之間時，高於60萬元的部分，可提成1.5 %，
            //高於100萬元時，超過100萬元的部分按1 % 提成，從鍵盤輸入當月利潤I，求應發放獎金總數？

            double x, y;
            Console.WriteLine("請輸入利潤:");
            x = Convert.ToDouble(Console.ReadLine());   

            if(x<=100000) 
            { y = x* 0.1; }
            else if(x >= 200000 && x < 400000)
            { y = (x - 200000) * 0.75 + x * 0.1; }
            else if(x>=400000&&x<600000)
            { y=(x-400000)*0.03+  200000 * 0.75 + x * 0.1; }
            else if(x >= 600000 && x < 1000000)
            { y=(x-600000)*0.015+  400000* 0.03 +  200000* 0.75 + x * 0.1; }
            else { y= (x-1000000)*0.01+ 600000*0.015 + 400000 * 0.03 + 200000 * 0.75 + x * 0.1; }
            Console.WriteLine(y);
        }


        static void Main(string[] args)
        {
             hw2_1();
             hw2_2();
             hw2_3();
             hw2_4();
             hw2_5();
             hw2_6();
             hw2_7();  
            addhw1();
            add2_1();
            add2_2();
            add2_3();


        }
    }
}
