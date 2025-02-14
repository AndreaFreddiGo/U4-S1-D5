using U4_S1_D5.Models;

namespace U4_S1_D5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcolatoreImposte();

        }
        static void CalcolatoreImposte() {
        Console.WriteLine("==================================================\r\n               CALCOLATORE IMPOSTE\r\n==================================================");
            Console.Write("\r\nInserisci il nome del contribuente: ");
            string Nome = Console.ReadLine();
            Console.Write("\r\nInserisci il cognome del contribuente: ");
            string Cognome = Console.ReadLine();
            Console.Write("\r\nInserisci la data di nascita del contribuente (gg/mm/aa): ");
            string inputData = Console.ReadLine();
            DateTime DataNascita;
            if (!DateTime.TryParseExact(inputData, "dd/MM/yy", null, System.Globalization.DateTimeStyles.None, out DataNascita))
            {
                Console.WriteLine("Formato data non valido!");
                return;
            }
            Console.Write("\r\nInserisci il codice fiscale del contribuente: ");
            string CodiceFiscale = Console.ReadLine().ToUpper();
            Console.Write("\r\nInserisci il sesso del contribuente (M o F): ");
            string Sesso = Console.ReadLine();
            if (Sesso != "M" && Sesso != "F")
            {
                Console.WriteLine("\r\nSesso non valido!");

                return;
            }
            Console.Write("\r\nInserisci il comune di residenza del contribuente: ");
            string ComuneResidenza = Console.ReadLine();
            Console.Write("\r\nInserisci il reddito annuale del contribuente: ");
            int RedditoAnnuale = int.Parse(Console.ReadLine());

            Contribuente contribuente = new Contribuente(Nome, Cognome, DataNascita, CodiceFiscale, Sesso, ComuneResidenza, RedditoAnnuale);

            Console.WriteLine($"\r\n==================================================\r\n         CALCOLO DELL'IMPOSTA DA VERSARE:\r\n\r\nContribuente: {Nome} {Cognome},\r\n\r\nnato il {DataNascita.ToString("dd/MM/yyyy")} ({Sesso}),\r\n\r\nresidente in {ComuneResidenza},\r\n\r\ncodice fiscale: {CodiceFiscale}\r\n\r\nReddito dichiarato: {RedditoAnnuale},00\r\n\r\nIMPOSTA DA VERSARE: € {contribuente.CalcoloImposta(RedditoAnnuale)}");

        }
        
    }
}
