using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion

            byte a = 5;
            sbyte b = 20;
            short c = 30;

            int d = a + b + c ;
            Console.WriteLine("d " + d);

            long h = d;
            Console.WriteLine("h " + h);

            float g = h;
            Console.WriteLine("h " + g);

            string isim = "Fatih";
            char f = 'b';
            Object result =  isim + f + g;
            Console.WriteLine(result);
            //Explicit Conversion


            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);


            // **** To String **** //

            int yy = 6;
            string xx = yy.ToString();
            Console.WriteLine(xx);

            float tt = 12.5f ;
            string jj = tt.ToString();
            Console.WriteLine(jj);



            string s = "10"  , s2 = "20";
            int sayi1 , sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1 + sayi2; 
            Console.WriteLine("Toplam" + Toplam);

            //Parse
            parseMethod();

        }

        public static void parseMethod()
        {
            string say = "10";
            string say1 = "10.25";

            int oo ;
            double ll ;

            oo = Int32.Parse(say);
            Console.WriteLine("oo" + oo);
            ll = Double.Parse(say1);
            Console.WriteLine("ll" + ll);
        }
    }
}