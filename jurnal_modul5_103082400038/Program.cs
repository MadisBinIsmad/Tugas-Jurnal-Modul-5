using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
>>>>>>> implementasi-generic-class

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

<<<<<<< HEAD
=======
class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, disimpan pada waktu: {inputDates[i]}");
        }
    }
}

>>>>>>> implementasi-generic-class
class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        Penjumlahan pj = new Penjumlahan();

=======

        Penjumlahan pj = new Penjumlahan();
        Console.WriteLine("=== Penjumlahan ===");
>>>>>>> implementasi-generic-class
        Console.Write("Masukkan angka pertama: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Masukkan angka kedua: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Masukkan angka ketiga: ");
        int c = int.Parse(Console.ReadLine());

        var hasil = pj.JumlahTigaAngka(a, b, c);

        Console.WriteLine($"{a} + {b} + {c} = {hasil}");
<<<<<<< HEAD
=======

        Console.WriteLine("");

        SimpleDataBase<int> db = new SimpleDataBase<int>();
        Console.WriteLine("=== SimpleDataBase ===");
        Console.Write("Masukkan data pertama: ");
        int e = int.Parse(Console.ReadLine());

        Console.Write("Masukkan data kedua: ");
        int f = int.Parse(Console.ReadLine());

        Console.Write("Masukkan data ketiga: ");
        int g = int.Parse(Console.ReadLine());

        db.AddNewData(e);
        db.AddNewData(f);
        db.AddNewData(g);

        Console.WriteLine("\nData yang tersimpan:");
        db.PrintAllData();
>>>>>>> implementasi-generic-class
    }
}