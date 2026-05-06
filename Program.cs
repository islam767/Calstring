using System;

namespace Calstring
{
    class Program
    {
        static void Main(string[] args)
        { /*
            // Foydalanuvchidan ifodani qabul qilamiz
            Console.Write("Matematik ifodani kiriting (masalan, 1+3-1+5): ");
            string misol = Console.ReadLine();

            int natija = 0;
            int i = 0;
            char amal = '+'; // Dastlabki sonni qo'shib olish uchun default amal

            // 1. WHILE sikli: Stringning har bir belgisini indeks orqali ko'rib chiqamiz
            while (i < misol.Length)
            {
                // 2. FAQAT INDEKS: misol[i] orqali har bir charni olamiz
                char belgi = misol[i];

                // 3. RAQAMNI ANIQLASH: Belgi '0' va '9' oralig'idami?
                if (belgi >= '0' && belgi <= '9')
                {
                    // Char-ni int-ga aylantirish (ASCII mantiqi: '1' - '0' = 1)
                    int son = belgi - '0';

                    // Oldingi amalga qarab hisoblaymiz
                    if (amal == '+')
                    {
                        natija = natija + son;
                    }
                    else if (amal == '-')
                    {
                        natija = natija - son;
                    }
                }
                // 4. AMALNI ANIQLASH: Agar belgi + yoki - bo'lsa
                else if (belgi == '+' || belgi == '-')
                {
                    amal = belgi; // Keyingi raqam uchun amalni eslab qolamiz
                }

                // Indeksni oshiramiz
                i++;
            }

            // FAQAT NATIJANI CHIQARISH
            Console.WriteLine(natija);

            // Dastur yopilib ketmasligi uchun
            Console.ReadKey();
            */

        bool davomEtish = true;
        while (davomEtish)
        {
            Console.WriteLine("\n--- CallString Kalkulyatori ---");
            
            Console.Write("Birinchi sonni kiriting: ");
            double son1 = double.Parse(Console.ReadLine());

            Console.Write("Amalni kiriting (+, -, *, /): ");
            string amal = Console.ReadLine();

            Console.Write("Ikkinchi sonni kiriting: ");
            double son2 = double.Parse(Console.ReadLine());

            double natija = 0;
            bool xatolik = false;

            switch (amal)
            {
                case "+": natija = son1 + son2; break;
                case "-": natija = son1 - son2; break;
                case "*": natija = son1 * son2; break;
                case "/": 
                    if (son2 != 0) natija = son1 / son2; 
                    else { Console.WriteLine("Xato: Nolga bo'lish mumkin emas!"); xatolik = true; }
                    break;
                default:
                    Console.WriteLine("Noto'g'ri amal!");
                    xatolik = true;
                    break;
            }

            if (!xatolik)
            {
                Console.WriteLine($"Natija: {natija}");
            }

            Console.Write("\nYangi amal bajarishni xohlaysizmi? (ha/yo'q): ");
            string javob = Console.ReadLine().ToLower();
            if (javob != "ha") davomEtish = false;
        }
        
        Console.WriteLine("Dastur tugatildi.");
    }
 }
}
