using System.Collections.Generic;
using System.IO;

namespace ScraperApp
{
    class FileActions
    {
        public static string WriteCSVFile(List<string> tableText)
        {
            string CSV = string.Join(",", tableText);
            string path = @"C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\lastScrape.csv";
            File.WriteAllText(path, CSV);
            return path;
        }
    }
}
