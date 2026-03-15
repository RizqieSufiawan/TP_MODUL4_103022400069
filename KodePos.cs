namespace TP_MODUL4_103022400069
{
    internal class KodePos
    {
        public string GetKodePos(string kelurahan)
        {
            string[,] tabelKodePos =
            {
                { "Batununggal", "40266" },
                { "Kujangsari",  "40287" },
                { "Mengger",     "40267" },
                { "Wates",       "40256" },
                { "Cijaura",     "40287" },
                { "Jatisari",    "40286" },
                { "Margasari",   "40286" },
                { "Sekejati",    "40286" },
                { "Kebonwaru",   "40272" },
                { "Maleer",      "40274" }
            };

            for (int i = 0; i < tabelKodePos.GetLength(0); i++)
            {
                if (tabelKodePos[i, 0].Equals(kelurahan, StringComparison.OrdinalIgnoreCase))
                {
                    return tabelKodePos[i, 1];
                }
            }

            return "Kelurahan tidak ditemukan";
        }
    }
}