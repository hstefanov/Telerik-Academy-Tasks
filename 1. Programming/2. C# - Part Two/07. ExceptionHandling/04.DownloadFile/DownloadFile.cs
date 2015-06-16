using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
/// Find in Google how to download files in C#.
/// Be sure to catch all exceptions and to free any used resources in the finally block.
/// </summary>

class DownloadFile
{
    static void Main()
    {
        using (WebClient webClient = new WebClient())
        {
            try
            {
                webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "../../logo.jpg");
            }
            catch (WebException)
            {
                Console.WriteLine("The address is invalid.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called sumultaneously");
            }
        }
    }
}
