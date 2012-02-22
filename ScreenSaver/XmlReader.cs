using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml;
using System.Windows.Forms;
using System.Text;

namespace ScreenSaver
{
    /// <summary>
    /// Representation of an RSS element in a RSS 2.0 XML document
    /// </summary>
    public class RssFeed : Form
    {
        private RssFeed()
        {
            // used to build entire input
            StringBuilder sb = new StringBuilder();

            // used on each read operation
            byte[] buf = new byte[8192];

            // prepare the web page we will be asking for
            HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create("https://linuxsandbox.coleman.edu/~pm34860/1-16-2012H8M16S31.xml");

            // execute the request
            HttpWebResponse response = (HttpWebResponse)
                request.GetResponse();

            // we will read data via the response stream
            Stream resStream = response.GetResponseStream();

            string Response = null;
            int count = 0;

            while (count > 0)
            {
                // fill the buffer with data
                count = resStream.Read(buf, 0, buf.Length);

                // read data until there is none left to read
                if (count != 0)
                {
                    // translate from bytes to UTF8 text
                    Response = Encoding.UTF8.GetString(buf, 0, count);

                    // continue building the string
                    sb.Append(Response);
                }
            }
            // build and printvthe toString
            Console.WriteLine(sb.ToString());
            count++;
        }
    }
}