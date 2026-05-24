using SQLitePCL;

namespace LocalDBExample
{
    internal static class Program
    {

        [STAThread]

        static void Main()
        {
            Batteries.Init();
            ApplicationConfiguration.Initialize();
            Database.Initialize();
            Application.Run(new UserForm());
        }
    }
}