using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir cümle girin: ");
        string cumle = Console.ReadLine();

        string[] kelimeler = cumle.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int kelimeSayisi = kelimeler.Length;

        int harfSayisi = 0;
        foreach (string kelime in kelimeler)
        {
            harfSayisi += kelime.Length;
        }

        Console.WriteLine($"Cümledeki kelime sayısı: {kelimeSayisi}");
        Console.WriteLine($"Cümledeki harf sayısı: {harfSayisi}");
    }
}