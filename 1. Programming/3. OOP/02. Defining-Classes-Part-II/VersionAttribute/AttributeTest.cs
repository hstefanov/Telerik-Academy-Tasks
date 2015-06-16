namespace VersionAttribute
{
    using System;

    class AttributeTest
    {
        static void Main()
        {
            Type type = typeof(AttributeClass);
            // typeof returns the type of the given thing and all its attributes
            object[] allAttributes = type.GetCustomAttributes(false);
            // making an object[] with all the attributes in this class
            foreach (AttributeClass attribute in allAttributes)
            {
                Console.WriteLine("{0}.{1}", attribute.major, attribute.minor);
            }
        }
    }
}
