using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 1){
            Console.WriteLine("Weird");
            }else if(sayi % 2 == 0 && 2 <= sayi  && sayi >= 5 ) {
             Console.WriteLine("Not Weird");
            }else if(sayi % 2 == 0 && 6 <= sayi  && sayi >= 20 ){
            Console.WriteLine("Weird");
             }else if(sayi % 2 == 0 &&  sayi > 20) {
            Console.WriteLine("Not Weird");
             }

            int time = DateTime.Now.Hour;
            string sonuc = time <= 18 ? "Tunaydin" : "Iyi aksamlar";
            Console.WriteLine(sonuc);
           
        }

      
    }
}