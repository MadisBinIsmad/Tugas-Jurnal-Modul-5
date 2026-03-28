using System;

class Penjumlahan
{
    public T JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic x = a;
        dynamic y = b;
        dynamic z = c;
        return x + y + z;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Penjumlahan pj = new Penjumlahan();

        Console.Write("Masukkan angka pertama: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Masukkan angka kedua: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Masukkan angka ketiga: ");
        int c = int.Parse(Console.ReadLine());

        var hasil = pj.JumlahTigaAngka(a, b, c);

        Console.WriteLine($"{a} + {b} + {c} = {hasil}");
    }
}