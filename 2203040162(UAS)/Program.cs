using System;


namespace _2203040162_UAS_
{
    class Program
    {
        static void Main(string[] args)
        {
            string ulang = "y";
            do
            {
                Console.WriteLine("=====Aplikasi Penghitung Luas & Keliling Persegi Panjang =====");
                Console.WriteLine("Menu pilihan");
                Console.WriteLine("1. Menghitung Luas");
                Console.WriteLine("2. Menghitung Keliling");
                Console.Write("Masukkan pilihan : ");
                string pilihan = Convert.ToString(Console.ReadLine());

                if (pilihan == "1")
                {
                    try
                    {
                        Console.WriteLine("Menghitung Luas Persegi Panjang");
                        Console.Write("Masukkan panjang: ");
                        int p = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Masukkan lebar: ");
                        int l = Convert.ToInt16(Console.ReadLine());
                        int hasil = perkalian(p, l);

                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine(fe.Message);
                        Console.WriteLine("Maaf input yang anda masukkan salah");
                    }
                    finally
                    {
                        Console.WriteLine("Terimakasih!");
                    }
                    Console.WriteLine("Apakah anda ingin mengulang? (y/t)");
                    ulang = Convert.ToString(Console.ReadLine());
                }
                else if (pilihan == "2")
                {
                    try
                    {
                        Console.WriteLine("Menghitung Keliling Persegi Panjang");
                        Console.Write("Masukkan panjang: ");
                        int p = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Masukkan lebar: ");
                        int l = Convert.ToInt16(Console.ReadLine());
                        int hasil = keliling(p, l);

                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine(fe.Message);
                        Console.WriteLine("Maaf input yang anda masukkan salah");
                    }
                    finally
                    {
                        Console.WriteLine("Terimakasih!");
                    }
                    Console.WriteLine("Apakah anda ingin mengulang? (y/t)");
                    ulang = Convert.ToString(Console.ReadLine());
                }

            } while (ulang == "y");
            Console.WriteLine(" Baiklah Semoga Hari Anda Baik");
        }

        public static int perkalian(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Jadi hasil penghitungan luasnya adalah " + c);
            return c;
        }
        public static int keliling(int a, int b)
        {
            int c = 2*a + 2*b ;
            Console.WriteLine("Jadi hasil penghitungan luasnya adalah " + c);
            return c;
        }
    }
            
 }
