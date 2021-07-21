using System;
using System.Collections.Generic;
using System.Threading;

namespace ppob
{
    class Data{

        private int pilihan;
        private int paket;
        private double price;
        private double kembalian;
        private string noTlp;
        private double cash;

       public Data(int paket,int price,int kembalian,string noTlp,double cash){
            this.paket = paket;
            this.price = price;
            this.kembalian = kembalian;
            this.noTlp = noTlp;
            this.cash = cash;
       }

       public void buydata(){
           Console.Clear();
           setDefault();
           Console.WriteLine("----MENU PAKET DATA----\n");
           Console.WriteLine("Pilih paket data : ");
           Console.WriteLine("1. Paket data 5Gb, Rp 45.000");
           Console.WriteLine("2. Paket data 8Gb, Rp 72.000");
           Console.WriteLine("3. Paket data 10Gb, Rp 98.000");
           Console.WriteLine("4. Paket data 12Gb, Rp 112.000");

           do{
           Console.Write("Masukkan pilihan [1-3] : ");
           pilihan = Convert.ToInt32(Console.ReadLine());
           }while(pilihan >3 || pilihan < 1);


           switch (pilihan){
               case 1:
                    price = 45000;
                    paket = 5;
                    break;

               case 2:
                    price = 72000;
                    paket = 8;
                    break;

               case 3:
                    price = 98000;
                    paket = 10;
                    break;

               case 4:
                    price = 112000;
                    paket = 12;
                    break;

                default :
                    Console.WriteLine("Menu yang Anda pilih tidak ada");
                    Console.WriteLine("Silahkan coba lagi");
                    break;     
   
           }

           // memanggil method bayar untuk melakukan transaksi
           NoTlp();
           bayar();
           if (cash >= price){
               // logika untuk menghitung kembalian
               kembalian = cash - price;

               // menampilkan pesan transaksi berhasil
               ngirimDataProcess();
               Console.WriteLine("Selamat Transaksi Anda telah berhasil");
               Console.WriteLine($"Paket data sebesar {paket}GB telah BERHASIL diaktifkan");
               
               CetakStruk();

           } else {
               // menampilkan pesan transaksi gagal karena uang yg diinputkan user tidak mencukupi
               Console.WriteLine("Maaf, transaksi telah gagal karena uang Anda tidak mencukupi");
               Console.WriteLine("Anda akan dialihkan pada halaman utama");
               Console.ReadKey();
           }
       }

       // method untuk menginputkan nomor user
       private void NoTlp(){
           Console.WriteLine("Silahkan masukkan Nomor Telephone Anda di sini");
           Console.Write("No. Telephone : ");
           noTlp = Console.ReadLine();
       }

       //method untuk membayar
       private void bayar(){
           Console.Write("Masukkan uang Anda : ");
           cash = Convert.ToDouble(Console.ReadLine());
       }

        private void ngirimDataProcess(){
            Console.WriteLine("Sedang Mengirim Data sebesar " + paket + "Gb ke " + noTlp);
                for (int counter = 10; counter >= 0; counter--)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Tunggu ..." + counter +" detik.");
                }
            Console.WriteLine("Transaksi berhasil!");
        }

        private void CetakStruk(){
                    PrintNota tukangprint = PrintNota.Instance;
                    var text3 = new List<string>();
                    text3.Add("\n       STRUK  PEMBELIAN       ");
                    text3.Add("     : PEMBAYARAN PULSA :     ");
                    text3.Add("==============================");
                    text3.Add("NO HANDPHONE   : "+ noTlp);
                    text3.Add("NOMINAL        : Rp"+ price);
                    text3.Add("Data Sebesar "+ paket +"Gb");
                    text3.Add("\n       - DETAIL BAYAR -       \n");
                    text3.Add("TUNAI          : "+ cash);    
                    text3.Add("KEMBALIAN      : "+ kembalian);    
                    text3.Add("==============================");                            
                    tukangprint.WriteToFile(text3);
                    tukangprint.ReadtoFile(text3);
                    text3.ForEach(i => Console.WriteLine(i));

                    Console.WriteLine("Data berhasil dicetak!!! Tekan ENTER untuk langsung kembali ke menu utama");
                    Console.ReadKey();
        }

        private void setDefault(){
            this.paket = 0;
            this.price = 0;
            this.kembalian = 0;
            this.noTlp = "";
            this.cash = 0;
        }

    }
}