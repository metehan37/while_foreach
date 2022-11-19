﻿namespace while_foreach;
class Program
{
    static void Main(string[] args)
    {
        //While (1 den girilen sayıya kadar ortalama hesaplama)
        
        Console.Write("Bir sayı giriniz: ");
        int sayi= int.Parse(Console.ReadLine());
        int sayac=1;
        int toplam=0;
        while (sayac<=sayi)
        {
            toplam+=sayac;
            sayac++;
        }
        Console.WriteLine(toplam/sayi);

        //a'dan z'ye kadar olan harflerin yazılması
        char character='a';
        while (character<'z')
        {
            Console.Write(character);
            character++;
        }
        Console.WriteLine("******FOREACH*******");
        string[] arabalar={"Toyota","Honda","BMW","Mercedes"};
        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
}
