namespace _8032_Observer
{
    public class Program
    {
        static void Main(string[] args)
        {
            HRApplikation applikation = new();
            Gui gui = new Gui();
            applikation.Attach(gui);
            applikation.Run();
        }
    }
}
