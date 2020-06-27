using System.IO;

namespace AirMonitor.Util
{
    public static class FileHelper
    {
        public static string InPersonalDir(string fileName)
            => Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), fileName);
    }
}
