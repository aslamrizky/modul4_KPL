// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class KodeProduk
{
    private static readonly Dictionary<string, string> KodeProdukMap = new Dictionary<string, string>()
    {
        {"Laptop","E100"},
        {"Smartphone","E101"},
        {"Tablet","E102"},
        {"Headset","E103"},
        {"Keyboard","E104"},
        {"Mouse","E105"},
        {"Printer","E106"},
        {"Monitor","E107"},
        {"Smartwatch","E108"},
        {"Kamera","E109"}
    };

    public static string GetKodeProduk (string produk)
    {
        if (KodeProdukMap.ContainsKey(produk))
        {
            return KodeProdukMap[produk];
        } else
        {
            return "Kode Pos Tak Ditemukan.";
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Masukkan Nama Produk: ");
        string produk = Console.ReadLine();

        string kodeproduk = KodeProduk.GetKodeProduk(produk);
        Console.WriteLine("Kode Produk untuk " + produk + " adalah " + kodeproduk);
    }
}

