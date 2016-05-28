using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilgiKontrolLib;
//Mehmet Can
//14253016
//Algoritmalar
namespace AlgorithmsHW2
{
    class Program
    {
       static int lab = 0; //değişkenler tanımlanıyor 
       static int test = 9999998;
        static string password = "";
        static string password1 = "";
        static string password2 = "";
       
       static int pc = 0;

        static Random r = new Random();
        static int rnum = r.Next(0, 9);
        
       


        static void Main(string[] args)
        {
            

          
             BilgiKontrol.baslat("14253016");

            
            Console.WriteLine("sifreler bulunuyor");
           
            lab = 0;
            deneme();//fonksyonumuz çalışmaya başlıyor

          
           BilgiKontrol.bitir();
        }

      public static  void deneme() // lab 0 için 9999999 dan geriye eksilerek teker teker deniyor
        {
            while (test > 999999 && BilgiKontrol.sifreKontrol(lab, pc, password) == false)
            {
                password = Convert.ToString(test);
                BilgiKontrol.sifreKontrol(lab, pc, password);
                test--;



            }
            pc++;
            test = 9999999; 

            if (BilgiKontrol.kalanSifreSayisi(lab) ==10 )
            {
                if (lab<2)
                {
                    pc = 1; lab++; Console.WriteLine("lab "+lab+" oldu"); deneme();                }
                else
                {
                    BilgiKontrol.bitir();
                }
            }
            else
            { deneme(); }
        }
      public static  int i = 1;
        public static void deneme1()
        {
            List<string> strings = new List<string>();
            while (BilgiKontrol.sifreKontrol(1, pc, password1) == false)
            {
                GetRandomNumbers(7);
                for (int i = 1; i < 20; i++)
                {
                    BilgiKontrol.sifreKontrol(1, 1, password1);
                }
             //   Console.WriteLine(password1);
                password1 = "";
            }


            if (BilgiKontrol.kalanSifreSayisi(1) == 19)
            {
                Console.WriteLine("seaseaseas");
            }


        } // lab 1 sifresine uygun olarak  rastgele 7 haneli sifreler üretip deniyor

        public static void deneme3() {

            while (test > 999999 && BilgiKontrol.sifreKontrol(2, pc, password2) == false)
            {
                password2 = Convert.ToString(test);

                for (int i = 0; i <5; i++)
                { int a = Convert.ToInt16(password2[i]);
                    int b = Convert.ToInt16(password2[i+1]);

                    if (password2[i]==password2[i+1] || a+1==b )
                    {
                        test--; deneme3(); break;
                    }
                }

                BilgiKontrol.sifreKontrol(2, pc, password2);


            }
            pc++;
            test = 9999999;
            BilgiKontrol.bitir();
            if (BilgiKontrol.kalanSifreSayisi(2) == 14)
            {

            }
            else
            { deneme3(); }

        } //lab 2 için 9999999 dan geriye eksilerek 'uygunlugu kontrol ederek' deniyor
      
        public static void deneme0()
        {                      
            while (test > 999999)// && BilgiKontrol.sifreKontrol(1, pc, password1) == false)
            {
             //  Console.WriteLine(password1);

                password1 = Convert.ToString(test);
                if (kontrol(password1)=="333")
                {
                    //  Console.WriteLine("dogru"); break; 
                   // test--;
                }
                else
                {
                    BilgiKontrol.sifreKontrol(1, pc, password1);
                   
                    // Console.WriteLine("tested");
                   // test--;
                }
                //
                test--;



            }
            Console.WriteLine("buldum");
            pc++;
            test = 9999999;


            if (BilgiKontrol.kalanSifreSayisi(lab) == 4)
            {
                BilgiKontrol.bitir();
            }
            else
            { deneme0(); }


        } //lab 1 için 9999999 dan geriye "kontrol ederek" deniyor, sifre lab 1 formatına uygun değilse denemiyor

        public static List<int> GetRandomNumbers(int count)
        {
            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                int number;

                do number = r.Next(0,9);
                while (randomNumbers.Contains(number));

                string aziz = number.ToString();
                
                password1 = password1 + aziz;
                randomNumbers.Add(number);
            }
            randomNumbers.Clear();
            return randomNumbers;
           
        } //lab 1 sifre formatına uygun rastgele sayı ureten fonksyon 

        public static string kontrol(string dier)
        {
            List<string> str = new List<string>();
            
            for (int i = 0; i < 7; i++)
            {
                if (str.Contains(dier[i].ToString()))
                {
                    dier = "333"; break;
                }
                else
                { str.Add(dier[i].ToString()); }

            }


            str.Clear();
            return dier;
        }//lab 1 için üretilen herhangi bir şifrenin lab 1 formatına uygun olup olmadığını kontrol eden fonksyon

        

       
    }
}
