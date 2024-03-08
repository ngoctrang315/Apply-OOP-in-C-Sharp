namespace ThucHanhTuan1
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FHocSinh());
        }
    }
}