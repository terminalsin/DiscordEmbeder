using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordEmbed
{
    public class EmbedBuilder
    {
        /*
            Builds the JSON according to the local values
            Action: COMPILE/EXECUTE
        */
        public static void buildEmbed()
        {
            Json json = new Json()
            {
                embeds = new List<Embed>()
                {
                    new Embed
                    {
                        author = new Author
                        {
                            name = Main.instance.author,
                            iconurl = Main.instance.authorIcon,
                        },
                        title = Main.instance.title,
                        url = Main.instance.titleUrl,
                        color = Main.instance.color,
                        description = Main.instance.message,
                        thumbnail = new Thumbnail
                        {
                            url = Main.instance.thumbnailURL,
                        },
                        image = new Image
                        {
                            url = Main.instance.imageURL
                        },
                        footer = new Footer
                        {
                            text = Main.instance.footerText,
                            iconurl = Main.instance.footerIcon,
                        }
                    }
                }

            };
            // Call the HTTP client and execute request
            HTTP.MakeRequest(Main.instance.Webhook_url, Newtonsoft.Json.JsonConvert.SerializeObject(json));
            
        }

        /*
            Compiles the local values into the format provided in Json.cs. Must have run the webhook once (soon will be dynamic)
            Action: COMPILE/SAVE
        */
        public static string saveEmbed()
        {
            // Make a new config
            Config json = new Config()
            {
                webhook = Main.instance.Webhook_url,
                json = new Json
                {
                    embeds = new List<Embed>()
                    {
                        new Embed
                        {
                            author = new Author
                            {
                                name = Main.instance.author,
                                iconurl = Main.instance.authorIcon,
                            },
                            title = Main.instance.title,
                            url = Main.instance.titleUrl,
                            color = Main.instance.color,
                            description = Main.instance.message,
                            thumbnail = new Thumbnail
                            {
                                url = Main.instance.thumbnailURL,
                            },
                            image = new Image
                            {
                                url = Main.instance.imageURL
                            },
                            footer = new Footer
                            {
                                text = Main.instance.footerText,
                                iconurl = Main.instance.footerIcon,
                            }
                        }
                    }
                }
            };
            // Return a serialized value
            return JsonConvert.SerializeObject(json);

        }
    }
}
