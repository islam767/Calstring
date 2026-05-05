# Calstring
# 🧮 Calstring - String Parser Calculator

Bu loyiha foydalanuvchi tomonidan kiritilgan matematik ifodani (string) tahlil qiluvchi va natijani hisoblovchi konsol dasturidir. Loyiha davomida algoritmlash va stringlar bilan ishlash ko'nikmalari qo'llanilgan.

## 📋 Loyiha Shartlari
Dastur quyidagi qat'iy texnik cheklovlar asosida ishlab chiqilgan:
*   **While sikli:** Barcha hisob-kitoblar faqatgina `while` sikli yordamida amalga oshiriladi.
*   **Indeks orqali kirish:** Stringning har bir belgisi (char) faqatgina indeks orqali olinadi, masalan: `misol[i]`.
*   **Metodlarsiz yondashuv:** Stringning `Split()`, `Substring()`, `Parse()` kabi tayyor metodlaridan foydalanilmagan.
*   **Faqat natija:** Dastur ortiqcha matnlarsiz faqatgina hisoblash natijasini ekranga chiqaradi.

## 🚀 Ishlash prinsipi
Foydalanuvchi quyidagi formatda ifoda kiritadi:
`1+3-1+5`

Dastur stringni boshidan oxirigacha o'qib chiqadi, raqamlarni va amallarni (`+`, `-`) aniqlaydi hamda natijani terminalda ko'rsatadi.

## 🛠 Texnologiyalar
*   **Til:** C# (C-Sharp)
*   **Platforma:** .NET Console Application
*   **Muhit:** Visual Studio
*   **Apparatura:** HP Victus Gaming Laptop

## 💻 Kod tuzilishi haqida
Loyiha mantiqi `Program.cs` faylida, `Main` metodi ichida joylashgan. Kod tarkibida ASCII mantiqi yordamida char-ni int-ga o'girish va amallarni (`+` yoki `-`) navbati bilan bajarish algoritmi qo'llanilgan.