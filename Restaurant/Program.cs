namespace Restaurant;

internal static class Program
{
    /// <summary>
    ///  By: Natthanon Limlek 137
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
        ApplicationConfiguration.Initialize();
        if (args.Length > 0 && args[0].ToLower() == "-k")
            Application.Run(new KitchenForm());
        else
            Application.Run(new WaiterForm());
    }
}