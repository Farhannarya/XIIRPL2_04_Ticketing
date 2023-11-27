using XIIRPL2_04_Ticketing.MasterForm;

namespace XIIRPL2_04_Ticketing
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
            ApplicationConfiguration.Initialize();
            //FormLogin login = new FormLogin();
            //login.Show();
            FormMasterBandara bandara = new FormMasterBandara();   
            bandara.Show();

            //FormMastermaskapai maskapai = new FormMastermaskapai();
            //maskapai.Show();

            //FormMasterKodePromo kodepromo = new FormMasterKodePromo();
            //kodepromo.Show();

            //FormMasterjadwalpenerbangan jadwalpenerbangan = new FormMasterjadwalpenerbangan();
            //jadwalpenerbangan.Show();

            Application.Run();

        }
    }
}