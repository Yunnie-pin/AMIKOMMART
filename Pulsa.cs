using System;
using System.Collections.Generic;
using System.Threading;


namespace ppob
{
    class Pulsa
    {
        private int pilih;
        private int pulsa;
        private int admin = 2000;
        private int total;
        private int tunai;
        private int kembalian;
        private string noTelp;
        private string verif;

        public Pulsa(int pulsa, int total, int kembalian,int tunai, string noTelp){
            this.pulsa = pulsa;
            this.total = total;
            this.kembalian = kembalian;
            this.tunai = tunai;
            this.noTelp = noTelp;
        }

        // method untuk menu pulsa
        public void MenuPulsa()
        {
            Console.Clear();
            setDefault();
            Console.WriteLine("=============");
            Console.WriteLine("=== PULSA ===");
            Console.WriteLine("=============");
            Console.WriteLine();
            Console.WriteLine("Selamat datang di menu isi pulsa");
            Console.WriteLine();
            NoTelp();

            IsiPulsa();

            // memanggil method Bayar() untuk memasukkan pulsa uang
            Bayar();
            if (tunai >= pulsa + admin)
            {
                kembalian = tunai - (pulsa + admin); // perhitungan kembalian
                TransaksiBerhasil();
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



        // method untuk membayar
        public void Bayar()
        {
            Console.Write("Masukkan uang : ");
            tunai = Convert.ToInt32(Console.ReadLine());
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

            // akan terjadi perulangan apabila menu yang dipilih tidak termasuk dalam daftar menu
            do
            {
                Console.Write("Pilih : ");
                pilih = Convert.ToInt32(Console.ReadLine());

            } while (pilih > 5 || pilih <= 0);

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
            }
        }

        // method untuk menampilkan pesan transaksi berhasil
        private void TransaksiBerhasil()
        {
            ngirimPulsaProcess();
            Console.WriteLine($"Pulsa telah ditambahkan sebesar Rp{pulsa} ke nomor {noTelp}");
            Console.WriteLine("=========================================================\n");
            Console.Write("ketik ok untuk mencetak nota\n : ");
            verif = Console.ReadLine();
            if (verif == "ok" || verif == "OK" || verif == "oK" || verif == "Ok"){
                CetakStruk();
            } else {
                Console.WriteLine("\nTidak jadi mencetak, Halaman akan dialihkan pada halaman utama");
                Console.ReadKey();
            }
            
        }

        // method untuk menampilkan pesan transaksi gagal
        private void TransaksiGagal()
        {
            Console.WriteLine("Transaksi gagal karena uang tidak mencukupi");
            if (!(tunai >= pulsa + admin)){
                Console.WriteLine("karena uang tidak mencukupi");
            }
        }
        


        private void ngirimPulsaProcess(){
            Console.WriteLine("Sedang Mengirim ke " + noTelp);
                for (int counter = 10; counter >= 0; counter--)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Tunggu ..." + counter +" detik.");
                }
            Console.WriteLine("Transaksi berhasil!");
        }

        private void CetakStruk(){
                    PrintNota tukangprint = PrintNota.Instance;
                    var text2 = new List<string>();
                    text2.Add("\n       STRUK  PEMBELIAN       ");
                    text2.Add("     : PEMBAYARAN PULSA :     ");
                    text2.Add("==============================");
                    text2.Add("NO HANDPHONE   : "+ noTelp);
                    text2.Add("NOMINAL        : Rp"+ pulsa);
                    text2.Add("BIAYA ADMIN    : Rp"+ admin);
                    text2.Add("TOTAL          : Rp"+ (total = pulsa + admin));
                    text2.Add("\n       - DETAIL BAYAR -       \n");
                    text2.Add("TUNAI          : Rp"+ tunai);    
                    text2.Add("KEMBALIAN      : Rp"+ kembalian);    
                    text2.Add("==============================");                            
                    tukangprint.WriteToFile(text2);
                    tukangprint.ReadtoFile(text2);
                    text2.ForEach(i => Console.WriteLine(i));

                    Console.WriteLine("Data berhasil dicetak!!! Tekan ENTER untuk langsung kembali ke menu utama");
                    Console.ReadKey();
        }

        private void setDefault(){
            this.pulsa = 0;
            this.total = 0;
            this.kembalian = 0;
            this.tunai = 0;
            this.noTelp = "";
        }

    }
}
