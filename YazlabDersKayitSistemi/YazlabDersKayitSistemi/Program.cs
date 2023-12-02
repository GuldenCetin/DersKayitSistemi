namespace YazlabDersKayitSistemi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // ApplicationConfiguration.Initialize();
            // Application.Run(new Form1());
            using (var engine = new TesseractEngine(@"C: \Users\cetle\OneDrive\Masaüstü\YazlabDersKayitSistemi\YazlabDersKayitSistemi\bin\Debug", "eng", EngineMode.Default))
            {
                using (var image = Pix.LoadFromFile(@"C:\Users\cetle\Downloads\TRASKRİPT.pdf"))
                {
                    using (var page = engine.Process(image))
                    {
                        string text = page.GetText();
                        Console.WriteLine(text);
                    }
                }
            }
        }
    }
}