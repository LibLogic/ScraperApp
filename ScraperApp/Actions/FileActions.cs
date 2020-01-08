using System;
using System.IO;
using System.Collections.Generic;

namespace ScraperApp
{ 
    class FileActions
    {
        public static string WriteCSVFile(List<string> tableText)
        {
            string CSV = string.Join(",", tableText);
            string path = @"C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperConsole\lastScrape.csv";
            File.WriteAllText(path, CSV);
            return path;
        }
    }
}
