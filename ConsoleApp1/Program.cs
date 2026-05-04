
                Console.Write("Misolni kiriting (masalan, 1+3-1+5): ");
                string misol = Console.ReadLine();

                // Birinchi sonni olamiz (indeks 0)
                // 'char'ni 'int'ga o'tkazish uchun '0'ning ASCII qiymatidan ayiramiz
                int natija = misol[0] - '0';

                int i = 1; // Tekshirishni 1-indeksdan boshlaymiz (belgilar turgan joy)

                // String funksiyalarisiz, faqat Length va indeks orqali
                while (i < misol.Length)
                {
                    char belgi = misol[i]; // + yoki - belgisi

                    // Belgidan keyin kelgan sonni olamiz
                    int keyingiSon = misol[i + 1] - '0';

                    if (belgi == '+')
                    {
                        natija += keyingiSon;
                    }
                    else if (belgi == '-')
                    {
                        natija -= keyingiSon;
                    }

                    // Har safar 2 qadam oldinga yuramiz (belgi va sondan sakrab o'tamiz)
                    i += 2;
                }

                Console.WriteLine("Natija: " + natija);
