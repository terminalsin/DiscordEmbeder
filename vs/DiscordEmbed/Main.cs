using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordEmbed
{
    public partial class Main : Form
    {
        // Instance and pointer for dragging
        public static Main instance;
        public Point mouseLoc;

        // Coming soon because cbb
        public List<string> consoleText = new List<string>();

        // All the values. These are changed on the embed button press to optimize
        public string Webhook_url, author, authorIcon, title, titleUrl, message, imageURL, thumbnailURL, footerText, footerIcon; // REQUIRED
        public int color; // OPTIONAL - [PARSED INT]

        public Main()
        {
            InitializeComponent();
        }

        /*
          Main load of the instance
          Action: LOAD
        */
        private void Main_Load(object sender, EventArgs e)
        {
            instance = this;
            label5.BackColor = System.Drawing.Color.Transparent;
        }

        /*
          Application quit button because we aren't SAO
          Action: QUIT
        */
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
          Mouse logger for the draggable feature
          Action: LOG
        */
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoc = new Point(-e.X, -e.Y);
        }

        /*
          Simple solution to make the form draggable
          Action: DRAG
        */
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLoc.X, mouseLoc.Y);
                Location = mousePos;
            }
        }

        /*
           Application quit button because we aren't SAO
           Action: QUIT
        */
        private void exits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*
           Simple solution to make button hover
           Action: HOVER
        */
        private void exit_MouseHover(object sender, EventArgs e)
        {
            exit.BackColor = Color.FromArgb(112, 145, 255);
        }

        /*
           In progress to make a live console. Still need to figure out a thing or two
           Action: WRITE
        */
        private void webhookURL_TextChanged(object sender, EventArgs e)
        {
            
            //console.Text = consoleText.ToArray();
            htmlPanel1.Text = "<p>Initialized webhook <br> Done!</p>";
        }

        /*
           Main button to execute the embed
           Action: EXECUTE
        */
        private void Embedbutton_Click(object sender, EventArgs e)
        {

            // Check if the webhook is valid
            if (webhookURL.Text != "" || !webhookURL.Text.Contains(" ") || webhookURL.Text.Contains("https://https://discordapp.com/api/webhooks/"))
            {
                // Webhook is valid, edit the local variable
                Webhook_url = webhookURL.Text;
            } else
            {
                // Webhook is invalid, show error and quit void statement
                MessageBox.Show("Please enter a valid webhook URL!");
                return;
            }
            
            // Assign all variables to the local ones
            author = authorInput.Text;
            authorIcon = iconInput.Text;
            title = titleInput.Text;
            titleUrl = urlInput.Text;
            message = messageInput.Text;
            color = int.Parse(colorInput.Text);
            imageURL = imageUrlInput.Text;
            thumbnailURL = thumbnailInput.Text;
            footerText = footerTextInput.Text;
            footerIcon = footerIconUrl.Text;

            // Call the embed builder to build the embed
            EmbedBuilder.buildEmbed();
        }

        // --> Config

        /*
           Button to save the configuration file
           Action: SAVE
        */
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get all the data using the Embed builder
            string json = EmbedBuilder.saveEmbed();
            // Write a new file called 'config.txt'
            StreamWriter writer = new StreamWriter("config.txt");
            // Write the json into the file
            writer.Write(json);
            // Dispose the writter and save the file
            writer.Dispose();
        }

        /*
           Button to open and load the configuration file
           Action: LOAD
        */
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }

        // --> Links

        /*
           Button to link my MC-Market
           Action: EXECUTE
        */
        private void mCMarketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mc-market.org/members/54909/");
        }

        /*
           Button to link my Twitter
           Action: EXECUTE
        */
        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/@ghastpics");
        }

        /*
           Button to link my SpigotMC
           Action: EXECUTE
        */
        private void spigotMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.spigotmc.org/members/ghastb.203111/");
        }

        /*
           Button to link my Github
           Action: EXECUTE
        */
        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/GhastD");
        }





        //-------------------------------------------------------//
        //
        // USELESS BUT CBB TO REMOVE THE EVENTS IN THE FORM
        //
        //-------------------------------------------------------//
        private void console_Click(object sender, EventArgs e)
        {

        }
        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void menu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void htmlPanel1_Click(object sender, EventArgs e)
        {

        }
        private void colorInput_Click(object sender, EventArgs e)
        {

        }

        
        private void metroUserControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void authorInput_Click(object sender, EventArgs e)
        {

        }

        private void iconInput_Click(object sender, EventArgs e)
        {

        }

        private void titleInput_Click(object sender, EventArgs e)
        {

        }

        private void urlInput_Click(object sender, EventArgs e)
        {

        }

        private void messageInput_Click(object sender, EventArgs e)
        {

        }

        private void imageUrlInput_Click(object sender, EventArgs e)
        {

        }

        private void thumbnailInput_Click(object sender, EventArgs e)
        {

        }

        private void footerTextInput_Click(object sender, EventArgs e)
        {

        }

        private void footerIconUrl_Click(object sender, EventArgs e)
        {

        }

        private void webhookURL_Click(object sender, EventArgs e)
        {

        }

        
    }
}
