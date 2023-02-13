using Newtonsoft.Json;

namespace PlaywrightFramework.Utils
{
    public static class JsonReader
    {
        public static T Read<T>(string filePath)
        {
            return JsonConvert.DeserializeObject<T>(FileReader.Read(filePath));
        }
    }
}
