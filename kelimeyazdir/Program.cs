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

        List<string> kelimeler = new List<string>();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Lütfen {i + 1}. kelimeyi girin: ");
            string kelime = Console.ReadLine();
            kelimeler.Add(kelime);
        }

        Console.WriteLine("Girilen kelimeler sondan başa doğru:");
        for (int i = kelimeler.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(kelimeler[i]);
        }
    }
}