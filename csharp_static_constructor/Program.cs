public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(AppConfig.Setting);
        AppConfig.PrintSetting();
    }
}

public class AppConfig
{
    public static string Setting;

    static AppConfig()
    {
        Console.WriteLine("Static constructor called");
        Setting = "DefaultConfig";
    }

    public static void PrintSetting()
    {
        Console.WriteLine(Setting);
    }
}