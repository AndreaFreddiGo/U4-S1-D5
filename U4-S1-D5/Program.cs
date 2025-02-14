using U4_S1_D5.Models;

namespace U4_S1_D5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CalcolatoreImposte();
        }

        static void CalcolatoreImposte()
        {
            Console.WriteLine("==================================================" +
                "\r\n\r\n              CALCOLATORE IMPOSTE" +
                "\r\n\r\n==================================================");
            Console.Write("\r\nInserisci il nome del contribuente: ");
            string Nome = Console.ReadLine()?.ToUpper() ?? string.Empty;
            Console.Write("\r\nInserisci il cognome del contribuente: ");
            string Cognome = Console.ReadLine()?.ToUpper() ?? string.Empty;
            Console.Write("\r\nInserisci la data di nascita del contribuente (gg/mm/aa): ");
            string inputData = Console.ReadLine()?.ToUpper() ?? string.Empty;
            DateTime DataNascita;
            while (!DateTime.TryParseExact(inputData, "dd/MM/yy", null, System.Globalization.DateTimeStyles.None, out DataNascita))
            {
                Console.WriteLine("\r\nFormato data non valido! Riprova.");
                Console.Write("\r\nInserisci la data di nascita del contribuente (gg/mm/aa): ");
                inputData = Console.ReadLine()?.ToUpper() ?? string.Empty;
            }
            Console.Write("\r\nInserisci il codice fiscale del contribuente: ");
            string CodiceFiscale = Console.ReadLine()?.ToUpper() ?? string.Empty;

            Console.Write("\r\nInserisci il sesso del contribuente (M o F): ");
            string Sesso = Console.ReadLine()?.ToUpper() ?? string.Empty;
            while (Sesso != "M" && Sesso != "F")
            {
                Console.WriteLine("\r\nSesso non valido! Riprova.");
                Console.Write("\r\nInserisci il sesso del contribuente (M o F): ");
                Sesso = Console.ReadLine()?.ToUpper() ?? string.Empty;
            }

            Console.Write("\r\nInserisci il comune di residenza del contribuente: ");
            string ComuneResidenza = Console.ReadLine()?.ToUpper() ?? string.Empty;
            Console.Write("\r\nInserisci il reddito annuale del contribuente: ");
            int RedditoAnnuale;
            while (!int.TryParse(Console.ReadLine(), out RedditoAnnuale))
            {
                Console.WriteLine("\r\nFormato non valido! Riprova.");
                Console.Write("\r\nInserisci il reddito annuale del contribuente: ");
            }

            Contribuente contribuente = new Contribuente(Nome, Cognome, DataNascita, CodiceFiscale, Sesso, ComuneResidenza, RedditoAnnuale);

            Console.WriteLine($"\r\n==================================================" +
                $"\r\n\r\n         CALCOLO DELL'IMPOSTA DA VERSARE:" +
                $"\r\n\r\n==================================================" +
                $"\r\n\r\nContribuente: {Nome} {Cognome}," +
                $"\r\n\r\nNato il {DataNascita.ToString("dd/MM/yyyy")} ({Sesso})," +
                $"\r\n\r\nResidente in {ComuneResidenza},\r\n\r\ncodice fiscale: {CodiceFiscale}" +
                $"\r\n\r\nReddito dichiarato: €{RedditoAnnuale},00" +
                $"\r\n\r\nImposta da versare: €{contribuente.CalcoloImposta(RedditoAnnuale)}" +
                $"\r\n\r\n==================================================" +
                $"\r\n\r\n==================================================");
        }
    }
}
