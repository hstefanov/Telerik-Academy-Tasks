namespace XslTransform
{
    using System;
    using System.Xml.Xsl;
    using System.IO;
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XslCompiledTransform xslt = new XslCompiledTransform();
                xslt.Load("../../../style.xslt");
                xslt.Transform("../../../catalogue.xml", "../../../catalogue.html");
                Console.WriteLine("result saved as catalogue.html");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
