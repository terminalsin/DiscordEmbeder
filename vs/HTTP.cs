using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;

namespace DiscordEmbed
{
    public class HTTP
    {
        /*
            Main HTTP request form using Leaf.xNet since I was lazy.
            Action: POST REQUEST
        */
        public string MakeRequest(string url, string jsonContent)
        {
            // Surround with an try statement to prevent errors from logging and crashing the software
            try
            {
                // Initiate the HTTP request
                HttpRequest request = new HttpRequest();
                // Add opera user agent just to be safe
                request.UserAgent = Http.OperaUserAgent();
                // Transform the Json into a payload, specifying it's json
                var payload = new StringContent(jsonContent)
                {
                    ContentType = "application/json"
                };
                // Starting the HTTP POST request
                HttpResponse rep = request.Post(Main.instance.Webhook_url, payload);
                // Response received, message has been posted
                return rep.ToString();
            } catch
            {
                // Response invalid, wrong webhook link
                MessageBox.Show("Error connecting with the Discord API. Is it your webhook link?");
                return string.Empty;
            }
            
        }
    }
}
