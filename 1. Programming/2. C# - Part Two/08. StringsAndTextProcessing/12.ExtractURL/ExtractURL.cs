using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


/// <summary>
/// Write a program that parses an URL address given in the format: and extracts from it the 
/// [protocol], [server] and [resource] elements. 
/// For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
///	[protocol] = "http"
///	[server] = "www.devbg.org"
///	[resource] = "/forum/index.php"
/// </summary>

class ExtractURL
{
    private static string url = "http://www.devbg.net/forum/index.php ";
    private static string protocol = null;
    private static string server = null;
    private static string resource = null;

    static void Main()
    {
        Match match = Regex.Match(url, @"(?<protocol>(ht|f)tp(s?))?://(?<server>www.[\w]+.[\w]+)?(?<resource>/.*)?");

        if (match.Success)
        {
            protocol = match.Groups["protocol"].Value;
            Console.WriteLine("[protocol] : {0}",protocol);
            server = match.Groups["server"].Value;
            Console.WriteLine("[server] : {0}",server);
            resource = match.Groups["resource"].Value;
            Console.WriteLine("[resource] : {0}",resource);
            
        }
    }
}
