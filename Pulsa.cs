using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ppob
{
    class Pulsa
    {
        private int pilih;
        private int pulsa = 0;
        private int admin = 2000;
        private int total;
        private int tunai;
        private int kembalian;
        private string noTelp;
        private bool kunci = false;

        // method untuk menu pulsa
        public void MenuPulsa()
        {
            Console.WriteLine("=============");
            Console.WriteLine("=== PULSA ===");
            Console.WriteLine("=============");
            Console.WriteLine();
            Console.WriteLine("Selamat datang di menu isi pulsa");
            Console.WriteLine();
            NoTelp();

            // akan terjadi perulangan apabila menu yang dipilih tidak termasuk dalam daftar menu
            do
            {
                kunci = false;
                IsiPulsa();
            } while (kunci == true);

            // memanggil method Bayar() untuk memasukkan pulsa uang
            Bayar();
            if (tunai >= pulsa + admin)
            {
                kembalian = tunai - (pulsa + admin); // perhitungan kembalian
                TransaksiBerhasil();
                CetakStruk();
            }
            else
            {
                TransaksiGagal();
            }
        }

        // method untuk menampilkan waktu
        private String Waktu()
        {
            DateTime waktu;

            // tanggal dan waktu saat ini
            waktu = DateTime.Now;
            return waktu.ToString();
        }

        // method untuk mencetak struk ke file txt
        public void CetakStruk()
        {
            try
            {
                StreamWriter cetak = new StreamWriter("C:\\StrukPembayaran.txt");
                /////////////////123456789012345678901234567890
                cetak.WriteLine("       STRUK  PEMBELIAN       ");
                cetak.WriteLine("     ", Waktu(), "     ");
                cetak.WriteLine("     : PEMBAYARAN PULSA :     ");
                cetak.WriteLine("==============================");
                cetak.WriteLine("NO HANDPHONE   : ", noTelp);
                cetak.Write("NOMINAL        : ");
                switch (pilih)
                {
                    case 1:
                        cetak.WriteLine("Rp", pulsa);
                        break;
                    case 2:
                        cetak.WriteLine("Rp", pulsa);
                        break;
                    case 3:
                        cetak.WriteLine("Rp", pulsa);
                        break;
                    case 4:
                        cetak.WriteLine("Rp", pulsa);
                        break;
                    case 5:
                        cetak.WriteLine("Rp", pulsa);
                        break;
                }
                cetak.WriteLine("BIAYA ADMIN    : ", admin);
                cetak.WriteLine("TOTAL          : ", (total = pulsa + admin));
                cetak.WriteLine();
                cetak.WriteLine("       - DETAIL BAYAR -       ");
                cetak.WriteLine();
                cetak.WriteLine("TUNAI          : ", tunai);
                cetak.WriteLine("KEMBALIAN      : ", kembalian);
                cetak.WriteLine("==============================");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.WriteLine("Transaksi Sukses!");
            }
        }

        // method untuk membayar
        public void Bayar()
        {
            Console.Write("Masukkan uang : ");
            tunai = Console.Read();
        }

        // method untuk input nomor telepon/handphone
        private void NoTelp()
        {
            Console.WriteLine("Masukkan nomor telepon Anda");
            Console.Write("Nomor Telepon : ");
            noTelp = Console.ReadLine(); // meminta user untuk menginputkan nomor telepon/handphone
        }

        // method untuk mengisi pulsa
        public void IsiPulsa()
        {
            Console.WriteLine("Mau isi pulsa berapa?");
            Console.WriteLine("No| Pulsa    | Harga");
            Console.WriteLine("1 | Rp5000   | Rp7000");
            Console.WriteLine("2 | Rp10000  | Rp12000");
            Console.WriteLine("3 | Rp25000  | Rp27000");
            Console.WriteLine("4 | Rp50000  | Rp52000");
            Console.WriteLine("5 | Rp100000 | Rp102000");
            Console.WriteLine("*Sudah termasuk biaya admin");
            Console.Write("Pilih : ");
            pilih = Console.Read();

            switch (pilih)
            {
                case 1:
                    // memberi nilai ke variabel pulsa
                    pulsa = 5000;
                    break;

                case 2:
                    // memberi nilai ke variabel pulsa
                    pulsa = 10000;
                    break;

                case 3:
                    // memberi nilai ke variabel pulsa
                    pulsa = 25000;
                    break;

                case 4:
                    // memberi nilai ke variabel pulsa
                    pulsa = 50000;
                    break;

                case 5:
                    // memberi nilai ke variabel pulsa
                    pulsa = 100000;
                    break;

                default:
                    Console.WriteLine("Menu yang Anda pilih tidak ditemukan");
                    Console.WriteLine("Silahkan coba lagi");
                    kunci = true; // memberikan nilai true ke variabel kunci sebagai syarat untuk melakukan perulangan do_while
                    break;
            }
        }

        // method untuk menampilkan pesan transaksi berhasil
        private void TransaksiBerhasil()
        {
            Console.WriteLine("Transaksi berhasil");
            Console.WriteLine($"Pulsa telah ditambahkan sebesar Rp{pulsa} ke nomor {noTelp}");
            Console.WriteLine("=========================================================");
            Console.WriteLine();
        }

        // method untuk menampilkan pesan transaksi gagal
        private void TransaksiGagal()
        {
            Console.WriteLine("Transaksi gagal karena uang tidak mencukupi");
        }
    }
}
