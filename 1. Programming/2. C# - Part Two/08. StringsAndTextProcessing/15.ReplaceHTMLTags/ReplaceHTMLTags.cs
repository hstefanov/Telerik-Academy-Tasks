using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/// <summary>
/// Write a program that replaces in a HTML document given as string
/// all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 
/// </summary>

class ReplaceHTMLTags
{
    private static string text = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course."+
                                  "Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

    static void Main()
    {
        Console.WriteLine(Regex.Replace(text,"<a href=\"(.*?)\">(.*?)</a>","[URL=$1]$2[/URL]"));
    }
}
