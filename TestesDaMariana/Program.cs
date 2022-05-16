using Newtonsoft.Json;
using System.Windows.Forms;
using System;
using TestesMariana.Infra.Arquivos.Compartilhado;

namespace TestesMariana
{
    internal static class Program
    {
        static ISerializador serializador = new SerializadorDadosEmJsonDotnet();
        static DataContext context = new DataContext(serializador);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaMain(context));

            context.GravarDados();
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            context.GravarDados();
        }
    }
}
