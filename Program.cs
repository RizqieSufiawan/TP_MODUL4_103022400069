namespace TP_MODUL4_103022400069
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodePos kodePos = new KodePos();

            Console.WriteLine("Batununggal : " + kodePos.GetKodePos("Batununggal"));
            Console.WriteLine("Kujangsari  : " + kodePos.GetKodePos("Kujangsari"));
            Console.WriteLine("Mengger     : " + kodePos.GetKodePos("Mengger"));
            Console.WriteLine("Wates       : " + kodePos.GetKodePos("Wates"));
            Console.WriteLine("Cijaura     : " + kodePos.GetKodePos("Cijaura"));
            Console.WriteLine("Jatisari    : " + kodePos.GetKodePos("Jatisari"));
            Console.WriteLine("Margasari   : " + kodePos.GetKodePos("Margasari"));
            Console.WriteLine("Sekejati    : " + kodePos.GetKodePos("Sekejati"));
            Console.WriteLine("Kebonwaru   : " + kodePos.GetKodePos("Kebonwaru"));
            Console.WriteLine("Maleer      : " + kodePos.GetKodePos("Maleer"));
        }
    }
}