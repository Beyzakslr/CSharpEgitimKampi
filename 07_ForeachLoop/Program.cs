using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //Foreache(1;2;3;4)

            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste, Koleksiyon,Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "ist", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}


            //int[] numbers = { 45, 78, 985, 635, 78, 74, 11, 22, 33, 41, 5246 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            // int[] numbers = { 45, 78, 985, 635, 78, 74, 11, 22, 33, 41, 5246 };
            //foreach (int number in numbers)
            // {
            //     if (number %2 == 0)
            //     {
            //         Console.WriteLine( number);
            //     }
            // }



            //int[] numbers = { 45, 78, 985, 635, 78, 74, 11, 22, 33, 41, 5246 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine( total);



            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine( c);
            //}






            #endregion


            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("****** C# Eğitim Sınav Sistemi Uygulaması****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine( "----------------------");
            Console.WriteLine("Sınıfınıda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");


            //Öğrencinin iimlerini ve not ortalamalarını saklayacak dizi
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;


                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());

                    totalExamResult += value; //notları topluyoruz

                }
                studentExamAvg[i] = totalExamResult / 3;

               
            }

            //sınav ortalamaları

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("--------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >=50)
                {
                    Console.WriteLine($"{ studentNames[i]} adlı öğreci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğreci dersten kaldı");
                }

                Console.WriteLine("--------------------");


            }




            #endregion

            Console.Read();


        }
    }
}
