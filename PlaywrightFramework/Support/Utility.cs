using Newtonsoft.Json;

namespace PlaywrightFramework.Support;

internal class Utility
{
    public static dynamic? ReadFromJsonFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"The file '{filePath}' does not exist.");
        }

        string json = File.ReadAllText(filePath);

        dynamic? obj = JsonConvert.DeserializeObject(json);

        if (obj == null)
        {
            return null;
        }

        return obj;
    }

    public static void WriteToJsonFile(string filePath, object obj)
    {
        string updatedJson = JsonConvert.SerializeObject(obj);

        File.WriteAllText(filePath, updatedJson);
    }
}
