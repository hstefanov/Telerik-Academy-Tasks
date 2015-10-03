namespace TraverseDir
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;
    class Solution
    {
        static void Main(string[] args)
        {
            using (XmlTextWriter writer = new XmlTextWriter("../../../dir.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = ' ';
                writer.Indentation = 4;

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Telerik-Academy-Tasks";

                writer.WriteStartDocument();
                writer.WriteStartElement("Telerik-Academy-Tasks");
                TraverseDir(desktopPath, writer);
                writer.WriteEndDocument();
            }
        }

        private static void TraverseDir(string dir, XmlWriter writer)
        {
            foreach (var directory in Directory.GetDirectories(dir))
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", directory);
                TraverseDir(directory, writer);
                writer.WriteEndElement();
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", Path.GetFileNameWithoutExtension(file));
                writer.WriteAttributeString("ext", Path.GetExtension(file));
                writer.WriteEndElement();
            }
        }
    }
}
