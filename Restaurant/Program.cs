namespace Restaurant
{
    internal static class Program
    {
        /// <summary>
        ///  By : Sanhatas Jungthirapanich  ID 66102010154
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            if (args.Length > 0 && args[0].ToLower() == "-k")
            {
                Application.Run(new KitchenForm());
            }
            else
            {
                Application.Run(new WaiterForm());
            }
        }
    }
}