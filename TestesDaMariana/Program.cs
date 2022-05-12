using Newtonsoft.Json;
using System.Windows.Forms;
using System;
namespace TestesDaMariana
{
    internal static class Program
    {
        static JsonSerializer serializador = new JsonSerializer();
        static DataContext context = new DataContext(serializador);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaMain());

            context.Save();
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            context.GravarDados();
        }
    }
}
