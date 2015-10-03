namespace TraverseDirXDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;
    class XDocumentSolution
    {
        static void Main(string[] args)
        {
            var destination = Traverse(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Telerik-Academy-Tasks");
            destination.Save("../../../dirXDocument.xml");
            Console.WriteLine("File saved as dirXDocument.xml");
        }

        private static XElement Traverse(string dir)
        {
            var element = new XElement("dir", new XAttribute("path", dir));

            foreach (var directory in Directory.GetDirectories(dir))
            {
                element.Add(Traverse(directory));
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                element.Add(new XElement("file",
                    new XAttribute("name", Path.GetFileNameWithoutExtension(file)),
                    new XAttribute("ext", Path.GetExtension(file))
                    ));
            }

            return element;
        }
    }
}
