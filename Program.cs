using System;

namespace ppob
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine( "|=========================================================================================================================|" );
                Console.WriteLine( " " );
                //Menampilkan home page yang berisi list menu yang terdapat pada program cinekom 
                Console.WriteLine( "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM" );
                Console.WriteLine( "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM" );
                Console.WriteLine( "MMMMMMMMMMMMMMMMMMMMMMMMWWXd:;dKWMMMMMMMMMMMMMMMMM" +"\t\t    <========== AMIKOMART==========> " );
                Console.WriteLine( "MMMMMMMMMMMMMWX0XWMMMMN0xoc,,,;cd0NWMMMMMMMMMMMMMM" );
                Console.WriteLine( "MMMMMMMMMMMN0xc;cOWWKkl;,,,,,,,,,;lxKWMMMMMMMMMMMM" +"\t <================== MENU AMIKOMART ==================> " );
                Console.WriteLine( "MMMMMMMMWKkl;,:lxxxo:,,,,,,,,;:lol:,:okXWMMMMMMMMM" );
                Console.WriteLine( "MMMMMWNOo:,;cdxdl;,,,,,,,,,:ldxkkkxoc;;:dOXWMMMMMM" );
                Console.WriteLine( "MMMN0xc;;:oxxo:,',,,,,,;cldOXKOxxdoloooc;;cxNMMMMM" );
                Console.WriteLine( "WKkl;,,:dkkkxc,'',,,;:oOXNNWMMWXkc,',;codlcxNMMMMM" );
                Console.WriteLine( "Xl,,,,,:xOxxkOOl,,;lkKNWMMMMMMW0c,',,,,,:okXMMMMMM" );
                Console.WriteLine( "Nx,,,,,,lkOKNWMXkx0XWWWWWWWMMMW0o:,,,,,,,,;lkXWMMM" );
                Console.WriteLine( "MXl,,,,,;oKWMMMMMWWNXK00000KXNWWNKko:,,,,,,,,:dONW" );
                Console.WriteLine( "MWO:,,,,,:xXMMMMWNKOkkkxxxxkkOKNWWWN0xl;,,,,,,,,cx" + "\t 1. Beli Pulsa "  );
                Console.WriteLine( "MMNx,,,,,,l0NMMWX0kxxxxxxxxxxxk0XWMMWWXOdc;,,,,,,;" );
                Console.WriteLine( "KO0Oc,,,,,;dKWMWKOkxxxdddddxxxxOKNMMMMMWKkdl:,,,;x" + "\t 2. Beli Paket Data  " );
                Console.WriteLine( "c;ckd;,,,,,:kNWNKOkxxxdooodxxxxO0NMMMMMNOdkOkc,,lK" );
                Console.WriteLine( "d;;okl,',,',c0WWX0kxxxxxxxxxxxkOXWWKO0KOxdxOxc,:OW" + "\t 3. Beli Token Listrik  " );
                Console.WriteLine( "Kl,:dx:,,;ldOXWMWX0Okkxxxxxxkk0XNW0l,,;;:cxkl,;xNM" );
                Console.WriteLine( "WO:,cxxood0WMMMMMWNXK0OOOOO0KXNWWXd;,,''':xd:,lKMM" + "\t 4. Keluar ");
                Console.WriteLine( "MNx;,lkOkxkXWWWWWWWWNNXXNNNWWMMMNk:,,,,',oxc,:OWMM" );
                Console.WriteLine( "MMKl,;lddoodddddddddddod0NWMMMMW0l,,,,,,lko;;dNMMM" + "\t ");
                Console.WriteLine( "MMWOc,,,,,,,,,,,,,,,,,',dXNMMMWKd;,,,,,cO0xldKMMMM" );
                Console.WriteLine( "MMMNx;,,,,,,,,,,,,,,,,',lkO0000x:,,,,,:OWMWWWMMMMM" );
                Console.WriteLine( "MMMMXo;;;;;;;;;;;;;;;;;;cddxxkkl,,,,,,dNMMMMMMMMMM" );
                Console.WriteLine( "MMMMWNKKKKKKKKKKkdxxdxxxxkkkkko;,,,,,lKMMMMMMMMMMM" );
                Console.WriteLine( "MMMMMMMMMMMMMMMNx:::::::::::::;,,,,,:OWMMMMMMMMMMM" );
                Console.WriteLine( "MMMMMMMMMMMMMMMM:;;;;;;;;;;;;;,,,,,MMMMMMMMMMMMMMM" );
                Console.WriteLine( "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM" );
                Console.WriteLine( "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM" );
                Console.WriteLine("\n\n"); 
                Console.WriteLine("Pilih menu untuk melanjutkan pembelian"); 
                Console.Write("Ketik (1-5) = ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    //Menu Pulsa
                    case 1:
                        Pulsa pulsa = new Pulsa();
                        pulsa.MenuPulsa();
                        break;
                    //Menu Paket Data
                    case 2:
                        
                        break;

                    //Menu Listrik
                    case 3:

                        Listrik listrik = new Listrik();
                        listrik.beliPulsaListrik();
                        break;
                    case 4:

                        break;

                                        
                }
            }
        
        }
    }