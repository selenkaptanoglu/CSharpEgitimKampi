using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //DeğişkenTürü [] DiziAdı= new DeğişkenTürü[ElemanSayısı]
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.Write(cities[4]);  

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 458;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);


            #endregion

            #region Dizideki Tüm Elemanları Listeleme 

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for(int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 520, 4567, 7554 };

            //for(int i = 0;i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3== 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbol = { 'a', 'b', 'c', '*', '/', '-' };
            //for(int i = 0; i < symbol.Length; i++)
            //{
            //    Console.WriteLine(symbol[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];

            //for(int i = 0; i <myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] person = { "cem", "ali", "ahmet", "ayşe", "buse", "deniz" };
            //Console.WriteLine(person.Length);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}7

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotları

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 86, 35, 29, 94, 55, 22, 75, 60 };
            //Console.WriteLine("Dizinin En Büyük ELemanı: "+numbers.Max()+" Dizinin En Küçük Elemanı: "+numbers.Min());


            #endregion


            #region Kullanıcıdan Değer Alma

            // string[] cities = new string[5];
            //for(int i = 0; i < cities.Length; i++) 
            //{
            //     Console.Write($"Lütfen {i + 1}.Şehri Giriniz: ");
            //     cities[i] = Console.ReadLine();

            //}
            // Console.WriteLine();
            // Console.WriteLine("---------------------");
            // for(int i = 0;i < cities.Length; i++)
            // {
            //     Console.WriteLine(cities[i]);
            // }

            //int[] numbers = {10, 20, 30,40,50};
            //int sum = 0;

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum+= numbers[i];
            //}
            //Console.WriteLine(sum);

           // int[] numbers = { 21, 42, 33, 54,55, 66, 897, 748, 39, 220 };
           // Console.WriteLine("Çift Sayılar");
           // Console.WriteLine();

           //for (int i = 0; i < numbers.Length; i++)
           //{
           //     if (numbers[i] % 2 == 0)
           //     {
           //         Console.WriteLine(numbers[i]);
           //     }
           //}
           // Console.WriteLine("-----------");
           // Console.WriteLine("Tek Sayılar");
           // for (int i = 0; i < numbers.Length; i++)
           // {
           //     if (numbers[i] % 2 == 1)
           //     {
           //         Console.WriteLine(numbers[i]);
           //     }
           // }
            #endregion
            Console.Read();
        }
    }
}
