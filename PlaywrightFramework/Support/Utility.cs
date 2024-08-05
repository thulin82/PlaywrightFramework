using Newtonsoft.Json;

namespace PlaywrightFramework.Support;
internal class Utility
{
    public static dynamic ReadFromJsonFile(string filePath)
    {
        // Check if the file exists
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"The file '{filePath}' does not exist.");
        }

        // Read the contents of the file
        string json = File.ReadAllText(filePath);

        // Deserialize the JSON into an object
        dynamic obj = JsonConvert.DeserializeObject(json);
        return obj;
    }

    public static void WriteToJsonFile(string filePath, object obj)
    {
        string updatedJson = JsonConvert.SerializeObject(obj);

        File.WriteAllText(filePath, updatedJson);
    }
}
