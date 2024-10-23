using Zapper;

public class Program
{
    public static void Main(string[] args)
    {
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string projectRoot = Directory.GetParent(baseDirectory).Parent.Parent.Parent.FullName; 

        string inputFilePath = Path.Combine(projectRoot, "Files", "input.txt");
        string outputFilePath = Path.Combine(projectRoot, "Files", "output.txt");

        FileProcessor processor = new FileProcessor();
        SettingsChecker settingsChecker = new SettingsChecker();

        List<string[]> input = processor.ReadFile(inputFilePath);

        List<string> output = new List<string>();

        foreach (var setting in input)
        {
            output.Add(settingsChecker.IsSettingEnabled(setting[0], Int32.Parse(setting[1])).ToString());
        }

        processor.WriteToFile(output, outputFilePath);

    }
}
