using System; 

namespace Program
{
    class Program
    {
       public static void Main(string[] args)
       
        {
            
            Console.WriteLine("Merhaba Lütfen bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayi: " + sayi);
            if (sayi>10)
            {
                Console.WriteLine("Girmiş Olduğunuz sayi 10'dan büyüktür.");
            }
            else if(sayi<10)
            {
                Console.WriteLine("Girmiş Olduğunuz sayi 10'dan küçüktür.");
            
            }
            else if (sayi == 10)
            {
                Console.WriteLine("Girmiş olduğunuz sayi 10'a eşittir.");
            }
            else{
            Console.WriteLine("Geçersiz bir değer girdiniz..");
            }
             if (sayi%2 == 0)    
            {   
                Console.WriteLine("Girmiş olduğunuz sayi çifttir.");
            }
            

        }
       
    }
}