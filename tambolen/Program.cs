using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen pozitif bir sayı (n) girin: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir sayı girin.");
            Console.Write("Lütfen pozitif bir sayı (n) girin: ");
        }

        Console.Write("Lütfen pozitif bir sayı (m) girin: ");
        int m;
        while (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
        {
            Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir sayı girin.");
            Console.Write("Lütfen pozitif bir sayı (m) girin: ");
        }

        List<int> sayilar = new List<int>();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Lütfen {i + 1}. pozitif sayıyı girin: ");
            int sayi;
            while (!int.TryParse(Console.ReadLine(), out sayi) || sayi <= 0)
            {
                Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir sayı girin.");
                Console.Write($"Lütfen {i + 1}. pozitif sayıyı girin: ");
            }
            sayilar.Add(sayi);
        }

        Console.WriteLine($"Girilen sayılardan {m}'e eşit veya tam bölünenler:");
        foreach (int sayi in sayilar)
        {
            if (sayi == m || sayi % m == 0)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}