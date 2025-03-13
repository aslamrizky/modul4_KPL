// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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
        //    Console.Write("Masukkan Nama Produk: ");
        //    string produk = Console.ReadLine();

        //    string kodeproduk = KodeProduk.GetKodeProduk(produk);
        //    Console.WriteLine("Kode Produk untuk " + produk + " adalah " + kodeproduk);

        FanLaptop fanlaptop = new FanLaptop();
        Console.WriteLine("Fan saat ini mode Quiet");
        fanlaptop.increaseFanMode();
        fanlaptop.increaseFanMode();
        fanlaptop.increaseFanMode();
        fanlaptop.decreaseFanMode();
        fanlaptop.decreaseFanMode();
        fanlaptop.decreaseFanMode();
        fanlaptop.quiet_turbo();
        fanlaptop.turbo_quiet();
    }
}

public class FanLaptop
{
    public enum state { Quiet, Turbo, Balance, Performed}
    private state currentstate;

    public FanLaptop()
    {
        currentstate = state.Quiet;
    }

    public void quiet_turbo()
    {
        if (currentstate == state.Quiet)
        {
            currentstate = state.Quiet;
            Console.WriteLine("Fan Quiet Tak Berubah Menjadi Turbo");
        } else
        {
            Console.WriteLine("Fan Quiet Berubah Menjadi Turbo");
        }
    }
    public void turbo_quiet()
    {
        if (currentstate == state.Turbo)
        {
            currentstate = state.Turbo;
            Console.WriteLine("Fan Turbo Tak Berubah Menjadi Quiet");
        }else
        {
            Console.WriteLine("Fan Turbo Berubah Menjadi Quiet");
        }
    }

    public void increaseFanMode()
    {
        if (currentstate == state.Quiet)
        {
            currentstate = state.Balance;
            Console.WriteLine("Fan Quiet Berubah Menjadi Balanced");
        } else if (currentstate == state.Balance)
        {
            currentstate = state.Performed;
            Console.WriteLine("Fan Balance Berubah Menjadi Performed");
        } else if (currentstate == state.Performed)
        {
            currentstate = state.Turbo;
            Console.WriteLine("Fan Performed Berubah Menjadi Turbo");
        } else if (currentstate == state.Turbo)
        {
            Console.WriteLine("Fan State Sudah Turbo");
        }
    }

    public void decreaseFanMode()
    {
        if (currentstate == state.Performed)
        {
            currentstate = state.Balance;
            Console.WriteLine("Fan Performed Berubah Menjadi Balance");
        } else if (currentstate == state.Balance)
        {
            currentstate = state.Quiet;
            Console.WriteLine("Fan Balance Berubah Menjadi Quiet");
        } else if (currentstate == state.Turbo)
        {
            currentstate = state.Performed;
            Console.WriteLine("Fan Turbo Berubah Menjadi Performed");
        } else if (currentstate == state.Quiet)
        {
            Console.WriteLine("Fan State Sudah Quiet");
        }
    }
}
