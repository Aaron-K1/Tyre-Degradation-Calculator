using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Degradation_Calculator
{
    public static class FileLoader
    {
        public static string LoadText(string fileName)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", fileName);

            if (!FileExists(path))
            {
                MessageBox.Show("File not found: " + fileName);
                return null;
            }

            return File.ReadAllText(path);
        }

        public static XmlDocument LoadXml(string fileName)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", fileName);

            if (!FileExists(path))
            {
                MessageBox.Show("File not found: " + fileName);
                return null;
            }

            var doc = new XmlDocument();
            doc.Load(path);
            return doc;
        }

        private static bool FileExists(string path)
        {
            if (File.Exists(path))
                return true;
               
            return false;
        }
    }

    struct FileExtension
    {
        public const string Xml = ".xml";
        public const string Txt = ".txt";
        public const string Csv = ".csv";
        public const string Json = ".json";
    }
}
