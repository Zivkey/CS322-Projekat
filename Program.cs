using CS322_Projekat.Data;

namespace CS322_Projekat
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            try
            {
                using (var context = new AppDbContext())
                {
                    context.Database.EnsureCreated(); // kreira bazu i tabele ako ne postoje
                    Console.WriteLine("Konekcija uspešna!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Greška pri konekciji: " + ex.Message);
            }


            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}