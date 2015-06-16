namespace VersionAttribute
{
    /// <summary>
    /// Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations 
    /// and methods and holds a version in the format major.minor (e.g. 2.11). 
    /// Apply the version attribute to a sample class and display its version at runtime.
    /// </summary>
    
    public class AttributeClass : System.Attribute
    {
        public int major { get; private set; }
        public int minor { get; private set; }
        // making two varibles for magor and minor

        public AttributeClass(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }
    }
}
