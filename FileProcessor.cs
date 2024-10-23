namespace Zapper
{
    public class FileProcessor
    {
        public List<string[]> ReadFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            List<string[]> array = new();

            for (int i = 0; i < lines.Length; i++)
            {
                if (!String.IsNullOrEmpty(lines[i]))
                {
                    string[] parts = lines[i].Split(' ');
                    array.Add(new string[] { parts[0], parts[1] });
                }
            }
            return array;
        }
        
        public void WriteToFile(List<string> lines, string filePath)
        {
            File.WriteAllLines(filePath, lines);
        }


    }
}
