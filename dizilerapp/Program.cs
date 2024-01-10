using System;

namespace dizilerapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 10;
            //int[] numbers= new int[3];
            //numbers[0] = 10;
            //numbers[1] = 20; 
            //numbers[2] = 30;
            //numbers[3] = 40; //IndexOutOfRangeException

            //int[] numbers = {30,20,10};
            ////Console.WriteLine(numbers[0]);
            ////Console.WriteLine(numbers[1]);
            ////Console.WriteLine(numbers[2]);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            
            
            //Array.Sort(numbers); // sıralayarak yazar
            //for (int i = 0;i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            
            //}

            //how many names do you want to sort? 3
            //enter 1. name ali
            //enter 2. name veli
            //enter 3. name deli
            //sorted names:
            //1- ali 2 - deli 3 - veli


            //Console.WriteLine("how many names do you want so sort");
            //byte count=byte.Parse(Console.ReadLine());
            //string[] names = new string[count];
            //for     (int i = 0;i<count ; i++)
            //{
            //    Console.WriteLine($"enter {i+1}. Name");
            //    names[i] = Console.ReadLine();
            //}  

            //Array.Sort (names);
            //for (int i = 0;i<names.Length ; i++)
            //{
            //    Console.WriteLine($"{i + i}-{names[i]}");   
            //}


            //how many names do you want to sort? 
            //enter starting number : 10
            //enter end number : 20

            Console.WriteLine("how many names do you want so sort");
            byte count=byte.Parse(Console.ReadLine());
            Console.WriteLine("enter starting number");
            byte start = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter ending number");
            byte end = byte.Parse(Console.ReadLine());
            Random rnd = new Random(); //random fonk girer ve random sayı atmak için değişken tanımladık sadece rnd değişebilir
            int[] numbers = new int[count]; //köşeli parantes diziyi ikincisi de kaç adet indeks istersem onu belirtmek için

            for (int i = 0; i < count;) 
            {
                int number = rnd.Next(start, end);  

                bool control = true; //true false ihtimali olan bool 
                for (int j = 0; j < i; j++) //burada dizideki değerleri eşitliği kontrol edilir ve döngü çalışır ona göre 
                {
                    if (numbers[j] == number)  
                    {
                        control = false; 
                        break;
                    }
                }

                if (control == true)  //dizideki elemanlar tek tek ekrana yazdırılır
                {
                    numbers[i++] = number; //Bu, döngü bloğunun içindeki işlemlerin ardından i'nin bir arttırılacağı anlamına gelir.
                }                          //random atanan sayıyı number[i] ye atar ardından i yi 1 artırır ve başa döner. 
            }


            Array.Sort(numbers); //sıralı yazmak için

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            //generated random numbers must be unique (aynı sayıdan bir tane daha gelmicek githuba at)







        }
    }
}

//numbers: referans heap bölgesindeki değerlerin adresini tutan yapıdır
//index: dizi elemanlarına ulaşmak için kulanılan sayılar. Indexler 0dan başlar