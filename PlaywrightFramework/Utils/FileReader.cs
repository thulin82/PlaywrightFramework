namespace PlaywrightFramework.Utils
{
    public static class FileReader
    {
        public static string Read(string filePath)
        {
            using (var stream = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)))
            {
                return stream.ReadToEnd();
            }
        }
    }
}
