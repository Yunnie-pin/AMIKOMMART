using System;
using System.Collections.Generic;

namespace ppob
{
    class Listrik
    {
        private double harga;
        private int jumlahBeli;
        private double uang;
        private double totalHarga;
        private double kembalian;

        public void beliPulsaListrik()
        {
            Console.Clear();
            Console.WriteLine("<------MENU PEMBELIAN TOKEN PULSA LISTRIK------>\n");
            Console.WriteLine("Pilih paket pulsa listrik: ");
            Console.WriteLine("1. Paket pulsa listrik 100.000 (Rp 103.000)");
            Console.WriteLine("2. Paket pulsa listrik 50.000 (Rp 53.000)");
            Console.WriteLine("3. Paket pulsa listrik 20.000 (Rp 23.000)");
            int pilihan1;

            //Logika menentukan harga barang berdasar pilihan
            do { 
            Console.Write("\nMasukkan pilihan Anda [1-3]\t\t\t: ");
            pilihan1 = Convert.ToInt32(Console.ReadLine());
                if (pilihan1 == 1)
                {
                    harga = 103000;
                }
                else if (pilihan1 == 2)
                {
                    harga = 53000;
                }
                else if (pilihan1 == 3)
                {
                    harga = 23000;
                }
            }while (pilihan1 > 3 || pilihan1 <= 0 );

            Console.Write("Masukkan jumlah paket token yang ingin dibeli\t: ");
            //Data jumlah barang yang berupa string dikonversi ke int
            this.jumlahBeli = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan jumlah uang Anda\t\t\t: ");
            //Data uang yang berupa string dikonversi ke double
            this.uang = Convert.ToInt32(Console.ReadLine());

            //Logika menghitung total pembelian dan sisa uang
        

            totalHarga = harga * jumlahBeli;
            kembalian = uang - totalHarga;

            //Jika total harga 0 kemungkinan disebabkan karena user memilih barang diluar dari list
            //atau user menginputkan jumlah barang = 0
            //Jadi jika total harga = 0, maka transaksi dibatalkan
            if (totalHarga > uang)
            {
                Console.WriteLine("\n\nMaaf, uang Anda tidak cukup. Tekan ENTER untuk kembali ke menu utama");
                Console.ReadKey();
            }


            if (uang >= totalHarga)
            {
                //Penawaran kepada user apakah ingin mencetak nota atau tidak
                Console.WriteLine("\n\nCetak nota?");
                Console.WriteLine("1. Ya");
                Console.WriteLine("2. Langsung kembali ke menu");
                int option;
                do
                {
                Console.Write("Masukkan pilihan Anda: ");
                option = Convert.ToInt32(Console.ReadLine());    
                } while (option > 2 || option <= 0);

                //logika untuk mencetak program atau kembali ke menu utama
                if (option == 1)
                {
                    PrintNota tukangprint = PrintNota.Instance;
                    var text1 = new List<string>();
                    text1.Add("\n---------------------------------------");
                    text1.Add("[BARANG]\t\t\t[JUMLAH]");
                    text1.Add("---------------------------------------");
                    text1.Add("TOKEN LISTRIK "+ harga +"an\t\tx"+jumlahBeli);
                    for(int i = 0; i < jumlahBeli; i++){
                        if (pilihan1 == 1){
                            string[] tokenListrik = System.IO.File.ReadAllLines(@"KodeToken/TokenListrik/TokenListrik1.txt");
                            int panjangArray = tokenListrik.Length;
                            string tokenTerbeli = tokenListrik[i];
                            text1.Add("#Token Listrik " + (i+1));
                            text1.Add("- " + tokenTerbeli);  
                            //for(int j = 0 ; j < panjangArray-1 ; j++){
                            //    tokenListrik[j] = tokenListrik[j+1];
                            //}
                        }
                        else if (pilihan1 == 2){
                            string[] tokenListrik = System.IO.File.ReadAllLines(@"KodeToken/TokenListrik/TokenListrik2.txt");
                            int panjangArray = tokenListrik.Length;
                            string tokenTerbeli = tokenListrik[i];
                            text1.Add("#Token Listrik " + (i+1));
                            text1.Add("- " + tokenTerbeli);                         
                        }
                        else if (pilihan1 == 3){
                            string[] tokenListrik = System.IO.File.ReadAllLines(@"KodeToken/TokenListrik/TokenListrik3.txt");
                            int panjangArray = tokenListrik.Length;
                            string tokenTerbeli = tokenListrik[i];
                            text1.Add("#Token Listrik " + (i+1));
                            text1.Add("- " + tokenTerbeli);   
                        }


                    }
                    text1.Add("---------------------------------------");
                    text1.Add("Total Pembelian\t\t: Rp." + totalHarga);
                    text1.Add("Uang dibayarkan\t\t: Rp." + uang);
                    text1.Add("---------------------------------------");
                    text1.Add("Kembalian\t\t: Rp." + kembalian);                    
                    tukangprint.WriteToFile(text1);
                    tukangprint.ReadtoFile(text1);
                    text1.ForEach(i => Console.WriteLine(i));

                    Console.WriteLine("Data berhasil dicetak!!! Tekan ENTER untuk langsung kembali ke menu utama");
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    
                }
                else
                {
                    Console.WriteLine("Menu tidak ditemukan, tekan ENTER untuk langsung kembali ke menu utama");
                    Console.ReadKey();
                }
            }
        }
    }
}
