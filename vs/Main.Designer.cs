namespace DiscordEmbed
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new MetroFramework.Controls.MetroButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mCMarketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spigotMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorInput = new MetroFramework.Controls.MetroTextBox();
            this.footerIconUrl = new MetroFramework.Controls.MetroTextBox();
            this.footerTextInput = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageUrlInput = new MetroFramework.Controls.MetroTextBox();
            this.thumbnailInput = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.messageInput = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.urlInput = new MetroFramework.Controls.MetroTextBox();
            this.titleInput = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconInput = new MetroFramework.Controls.MetroTextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorInput = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.webhookURL = new MetroFramework.Controls.MetroTextBox();
            this.Embedbutton = new MetroFramework.Controls.MetroButton();
            this.console = new MetroFramework.Controls.MetroTextBox();
            this.htmlPanel1 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menu1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 24);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DiscordEmbed.Properties.Resources.Discord_Logo_Wordmark_Color;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.exit.Location = new System.Drawing.Point(765, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 24);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.UseCustomBackColor = true;
            this.exit.UseSelectable = true;
            this.exit.UseStyleColors = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseHover += new System.EventHandler(this.exit_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem1,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(115, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configToolStripMenuItem1
            // 
            this.configToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.configToolStripMenuItem1.Name = "configToolStripMenuItem1";
            this.configToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem1.Text = "Config";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCMarketToolStripMenuItem,
            this.twitterToolStripMenuItem,
            this.spigotMCToolStripMenuItem,
            this.githubToolStripMenuItem});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // mCMarketToolStripMenuItem
            // 
            this.mCMarketToolStripMenuItem.Name = "mCMarketToolStripMenuItem";
            this.mCMarketToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mCMarketToolStripMenuItem.Text = "MC-Market";
            this.mCMarketToolStripMenuItem.Click += new System.EventHandler(this.mCMarketToolStripMenuItem_Click);
            // 
            // twitterToolStripMenuItem
            // 
            this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
            this.twitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.twitterToolStripMenuItem.Text = "Twitter";
            this.twitterToolStripMenuItem.Click += new System.EventHandler(this.twitterToolStripMenuItem_Click);
            // 
            // spigotMCToolStripMenuItem
            // 
            this.spigotMCToolStripMenuItem.Name = "spigotMCToolStripMenuItem";
            this.spigotMCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spigotMCToolStripMenuItem.Text = "SpigotMC";
            this.spigotMCToolStripMenuItem.Click += new System.EventHandler(this.spigotMCToolStripMenuItem_Click);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.SystemColors.Control;
            this.menu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu1.DropShadowEnabled = false;
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(111, 54);
            this.menu1.Text = "Menu";
            this.menu1.Opening += new System.ComponentModel.CancelEventHandler(this.menu1_Opening);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveConfigToolStripMenuItem,
            this.loadConfigToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // saveConfigToolStripMenuItem
            // 
            this.saveConfigToolStripMenuItem.Name = "saveConfigToolStripMenuItem";
            this.saveConfigToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveConfigToolStripMenuItem.Text = "Save Config";
            // 
            // loadConfigToolStripMenuItem
            // 
            this.loadConfigToolStripMenuItem.Name = "loadConfigToolStripMenuItem";
            this.loadConfigToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.loadConfigToolStripMenuItem.Text = "Load Config";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(107, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.colorInput);
            this.panel2.Controls.Add(this.footerIconUrl);
            this.panel2.Controls.Add(this.footerTextInput);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.imageUrlInput);
            this.panel2.Controls.Add(this.thumbnailInput);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.messageInput);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.urlInput);
            this.panel2.Controls.Add(this.titleInput);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.iconInput);
            this.panel2.Controls.Add(this.authorLabel);
            this.panel2.Controls.Add(this.authorInput);
            this.panel2.Location = new System.Drawing.Point(13, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 372);
            this.panel2.TabIndex = 4;
            // 
            // colorInput
            // 
            // 
            // 
            // 
            this.colorInput.CustomButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorInput.CustomButton.FlatAppearance.BorderSize = 10;
            this.colorInput.CustomButton.Image = null;
            this.colorInput.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.colorInput.CustomButton.Name = "";
            this.colorInput.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.colorInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.colorInput.CustomButton.TabIndex = 1;
            this.colorInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.colorInput.CustomButton.UseSelectable = true;
            this.colorInput.CustomButton.Visible = false;
            this.colorInput.Lines = new string[0];
            this.colorInput.Location = new System.Drawing.Point(285, 202);
            this.colorInput.MaxLength = 32767;
            this.colorInput.Name = "colorInput";
            this.colorInput.PasswordChar = '\0';
            this.colorInput.PromptText = "Color ID";
            this.colorInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.colorInput.SelectedText = "";
            this.colorInput.SelectionLength = 0;
            this.colorInput.SelectionStart = 0;
            this.colorInput.ShortcutsEnabled = true;
            this.colorInput.ShowClearButton = true;
            this.colorInput.Size = new System.Drawing.Size(106, 25);
            this.colorInput.TabIndex = 15;
            this.colorInput.UseSelectable = true;
            this.colorInput.WaterMark = "Color ID";
            this.colorInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.colorInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.colorInput.Click += new System.EventHandler(this.colorInput_Click);
            // 
            // footerIconUrl
            // 
            // 
            // 
            // 
            this.footerIconUrl.CustomButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.footerIconUrl.CustomButton.FlatAppearance.BorderSize = 10;
            this.footerIconUrl.CustomButton.Image = null;
            this.footerIconUrl.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.footerIconUrl.CustomButton.Name = "";
            this.footerIconUrl.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.footerIconUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.footerIconUrl.CustomButton.TabIndex = 1;
            this.footerIconUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.footerIconUrl.CustomButton.UseSelectable = true;
            this.footerIconUrl.CustomButton.Visible = false;
            this.footerIconUrl.Lines = new string[0];
            this.footerIconUrl.Location = new System.Drawing.Point(200, 319);
            this.footerIconUrl.MaxLength = 32767;
            this.footerIconUrl.Name = "footerIconUrl";
            this.footerIconUrl.PasswordChar = '\0';
            this.footerIconUrl.PromptText = "Icon URL:";
            this.footerIconUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.footerIconUrl.SelectedText = "";
            this.footerIconUrl.SelectionLength = 0;
            this.footerIconUrl.SelectionStart = 0;
            this.footerIconUrl.ShortcutsEnabled = true;
            this.footerIconUrl.ShowClearButton = true;
            this.footerIconUrl.Size = new System.Drawing.Size(191, 25);
            this.footerIconUrl.TabIndex = 14;
            this.footerIconUrl.UseSelectable = true;
            this.footerIconUrl.WaterMark = "Icon URL:";
            this.footerIconUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.footerIconUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.footerIconUrl.Click += new System.EventHandler(this.footerIconUrl_Click);
            // 
            // footerTextInput
            // 
            // 
            // 
            // 
            this.footerTextInput.CustomButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.footerTextInput.CustomButton.FlatAppearance.BorderSize = 10;
            this.footerTextInput.CustomButton.Image = null;
            this.footerTextInput.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.footerTextInput.CustomButton.Name = "";
            this.footerTextInput.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.footerTextInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.footerTextInput.CustomButton.TabIndex = 1;
            this.footerTextInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.footerTextInput.CustomButton.UseSelectable = true;
            this.footerTextInput.CustomButton.Visible = false;
            this.footerTextInput.Lines = new string[0];
            this.footerTextInput.Location = new System.Drawing.Point(6, 319);
            this.footerTextInput.MaxLength = 32767;
            this.footerTextInput.Name = "footerTextInput";
            this.footerTextInput.PasswordChar = '\0';
            this.footerTextInput.PromptText = "Footer Text:";
            this.footerTextInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.footerTextInput.SelectedText = "";
            this.footerTextInput.SelectionLength = 0;
            this.footerTextInput.SelectionStart = 0;
            this.footerTextInput.ShortcutsEnabled = true;
            this.footerTextInput.ShowClearButton = true;
            this.footerTextInput.Size = new System.Drawing.Size(188, 25);
            this.footerTextInput.TabIndex = 13;
            this.footerTextInput.UseSelectable = true;
            this.footerTextInput.WaterMark = "Footer Text:";
            this.footerTextInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.footerTextInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.footerTextInput.Click += new System.EventHandler(this.footerTextInput_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Footer";
            // 
            // imageUrlInput
            // 
            // 
            // 
            // 
            this.imageUrlInput.CustomButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imageUrlInput.CustomButton.FlatAppearance.BorderSize = 10;
            this.imageUrlInput.CustomButton.Image = null;
            this.imageUrlInput.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.imageUrlInput.CustomButton.Name = "";
            this.imageUrlInput.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.imageUrlInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.imageUrlInput.CustomButton.TabIndex = 1;
            this.imageUrlInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.imageUrlInput.CustomButton.UseSelectable = true;
            this.imageUrlInput.CustomButton.Visible = false;
            this.imageUrlInput.Lines = new string[0];
            this.imageUrlInput.Location = new System.Drawing.Point(6, 260);
            this.imageUrlInput.MaxLength = 32767;
            this.imageUrlInput.Name = "imageUrlInput";
            this.imageUrlInput.PasswordChar = '\0';
            this.imageUrlInput.PromptText = "Image URL:";
            this.imageUrlInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.imageUrlInput.SelectedText = "";
            this.imageUrlInput.SelectionLength = 0;
            this.imageUrlInput.SelectionStart = 0;
            this.imageUrlInput.ShortcutsEnabled = true;
            this.imageUrlInput.ShowClearButton = true;
            this.imageUrlInput.Size = new System.Drawing.Size(188, 25);
            this.imageUrlInput.TabIndex = 11;
            this.imageUrlInput.UseSelectable = true;
            this.imageUrlInput.WaterMark = "Image URL:";
            this.imageUrlInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.imageUrlInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.imageUrlInput.Click += new System.EventHandler(this.imageUrlInput_Click);
            // 
            // thumbnailInput
            // 
            // 
            // 
            // 
            this.thumbnailInput.CustomButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.thumbnailInput.CustomButton.FlatAppearance.BorderSize = 10;
            this.thumbnailInput.CustomButton.Image = null;
            this.thumbnailInput.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.thumbnailInput.CustomButton.Name = "";
            this.thumbnailInput.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.thumbnailInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.thumbnailInput.CustomButton.TabIndex = 1;
            this.thumbnailInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.thumbnailInput.CustomButton.UseSelectable = true;
            this.thumbnailInput.CustomButton.Visible = false;
            this.thumbnailInput.Lines = new string[0];
            this.thumbnailInput.Location = new System.Drawing.Point(200, 260);
            this.thumbnailInput.MaxLength = 32767;
            this.thumbnailInput.Name = "thumbnailInput";
            this.thumbnailInput.PasswordChar = '\0';
            this.thumbnailInput.PromptText = "Thumbnail URL:";
            this.thumbnailInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.thumbnailInput.SelectedText = "";
            this.thumbnailInput.SelectionLength = 0;
            this.thumbnailInput.SelectionStart = 0;
            this.thumbnailInput.ShortcutsEnabled = true;
            this.thumbnailInput.ShowClearButton = true;
            this.thumbnailInput.Size = new System.Drawing.Size(191, 25);
            this.thumbnailInput.TabIndex = 10;
            this.thumbnailInput.UseSelectable = true;
            this.thumbnailInput.WaterMark = "Thumbnail URL:";
            this.thumbnailInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.thumbnailInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.thumbnailInput.Click += new System.EventHandler(this.thumbnailInput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Images";
            // 
            // messageInput
            // 
            // 
            // 
            // 
            this.messageInput.CustomButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.messageInput.CustomButton.FlatAppearance.BorderSize = 10;
            this.messageInput.CustomButton.Image = null;
            this.messageInput.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.messageInput.CustomButton.Name = "";
            this.messageInput.CustomButton.Size = new System.Drawing.Size(73, 73);
            this.messageInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.messageInput.CustomButton.TabIndex = 1;
            this.messageInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.messageInput.CustomButton.UseSelectable = true;
            this.messageInput.CustomButton.Visible = false;
            this.messageInput.Lines = new string[0];
            this.messageInput.Location = new System.Drawing.Point(6, 152);
            this.messageInput.MaxLength = 32767;
            this.messageInput.Name = "messageInput";
            this.messageInput.PasswordChar = '\0';
            this.messageInput.PromptText = "Type the message here";
            this.messageInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.messageInput.SelectedText = "";
            this.messageInput.SelectionLength = 0;
            this.messageInput.SelectionStart = 0;
            this.messageInput.ShortcutsEnabled = true;
            this.messageInput.ShowClearButton = true;
            this.messageInput.Size = new System.Drawing.Size(273, 75);
            this.messageInput.TabIndex = 8;
            this.messageInput.UseSelectable = true;
            this.messageInput.WaterMark = "Type the message here";
            this.messageInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.messageInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.messageInput.Click += new System.EventHandler(this.messageInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Message";
            // 
            // urlInput
            // 
            // 
            // 
            // 
            this.urlInput.CustomButton.Image = null;
            this.urlInput.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.urlInput.CustomButton.Name = "";
            this.urlInput.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.urlInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.urlInput.CustomButton.TabIndex = 1;
            this.urlInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.urlInput.CustomButton.UseSelectable = true;
            this.urlInput.CustomButton.Visible = false;
            this.urlInput.Lines = new string[0];
            this.urlInput.Location = new System.Drawing.Point(200, 90);
            this.urlInput.MaxLength = 32767;
            this.urlInput.Name = "urlInput";
            this.urlInput.PasswordChar = '\0';
            this.urlInput.PromptText = "URL:";
            this.urlInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.urlInput.SelectedText = "";
            this.urlInput.SelectionLength = 0;
            this.urlInput.SelectionStart = 0;
            this.urlInput.ShortcutsEnabled = true;
            this.urlInput.ShowClearButton = true;
            this.urlInput.Size = new System.Drawing.Size(191, 25);
            this.urlInput.TabIndex = 6;
            this.urlInput.UseSelectable = true;
            this.urlInput.WaterMark = "URL:";
            this.urlInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.urlInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.urlInput.Click += new System.EventHandler(this.urlInput_Click);
            // 
            // titleInput
            // 
            // 
            // 
            // 
            this.titleInput.CustomButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleInput.CustomButton.FlatAppearance.BorderSize = 10;
            this.titleInput.CustomButton.Image = null;
            this.titleInput.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.titleInput.CustomButton.Name = "";
            this.titleInput.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.titleInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.titleInput.CustomButton.TabIndex = 1;
            this.titleInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.titleInput.CustomButton.UseSelectable = true;
            this.titleInput.CustomButton.Visible = false;
            this.titleInput.Lines = new string[0];
            this.titleInput.Location = new System.Drawing.Point(6, 90);
            this.titleInput.MaxLength = 32767;
            this.titleInput.Name = "titleInput";
            this.titleInput.PasswordChar = '\0';
            this.titleInput.PromptText = "Title:";
            this.titleInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.titleInput.SelectedText = "";
            this.titleInput.SelectionLength = 0;
            this.titleInput.SelectionStart = 0;
            this.titleInput.ShortcutsEnabled = true;
            this.titleInput.ShowClearButton = true;
            this.titleInput.Size = new System.Drawing.Size(188, 25);
            this.titleInput.TabIndex = 5;
            this.titleInput.UseSelectable = true;
            this.titleInput.WaterMark = "Title:";
            this.titleInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.titleInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.titleInput.Click += new System.EventHandler(this.titleInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // iconInput
            // 
            // 
            // 
            // 
            this.iconInput.CustomButton.Image = null;
            this.iconInput.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.iconInput.CustomButton.Name = "";
            this.iconInput.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.iconInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.iconInput.CustomButton.TabIndex = 1;
            this.iconInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.iconInput.CustomButton.UseSelectable = true;
            this.iconInput.CustomButton.Visible = false;
            this.iconInput.Lines = new string[0];
            this.iconInput.Location = new System.Drawing.Point(200, 26);
            this.iconInput.MaxLength = 32767;
            this.iconInput.Name = "iconInput";
            this.iconInput.PasswordChar = '\0';
            this.iconInput.PromptText = "Icon URL:";
            this.iconInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.iconInput.SelectedText = "";
            this.iconInput.SelectionLength = 0;
            this.iconInput.SelectionStart = 0;
            this.iconInput.ShortcutsEnabled = true;
            this.iconInput.ShowClearButton = true;
            this.iconInput.Size = new System.Drawing.Size(191, 25);
            this.iconInput.TabIndex = 3;
            this.iconInput.UseSelectable = true;
            this.iconInput.WaterMark = "Icon URL:";
            this.iconInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.iconInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.iconInput.Click += new System.EventHandler(this.iconInput_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.ForeColor = System.Drawing.Color.Black;
            this.authorLabel.Location = new System.Drawing.Point(3, 5);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(62, 18);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Author";
            // 
            // authorInput
            // 
            // 
            // 
            // 
            this.authorInput.CustomButton.Image = null;
            this.authorInput.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.authorInput.CustomButton.Name = "";
            this.authorInput.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.authorInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.authorInput.CustomButton.TabIndex = 1;
            this.authorInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.authorInput.CustomButton.UseSelectable = true;
            this.authorInput.CustomButton.Visible = false;
            this.authorInput.Lines = new string[0];
            this.authorInput.Location = new System.Drawing.Point(3, 26);
            this.authorInput.MaxLength = 32767;
            this.authorInput.Name = "authorInput";
            this.authorInput.PasswordChar = '\0';
            this.authorInput.PromptText = "Author:";
            this.authorInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.authorInput.SelectedText = "";
            this.authorInput.SelectionLength = 0;
            this.authorInput.SelectionStart = 0;
            this.authorInput.ShortcutsEnabled = true;
            this.authorInput.ShowClearButton = true;
            this.authorInput.Size = new System.Drawing.Size(191, 25);
            this.authorInput.TabIndex = 0;
            this.authorInput.UseSelectable = true;
            this.authorInput.WaterMark = "Author:";
            this.authorInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.authorInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.authorInput.Click += new System.EventHandler(this.authorInput_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(450, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Discord Webhook";
            // 
            // webhookURL
            // 
            // 
            // 
            // 
            this.webhookURL.CustomButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.webhookURL.CustomButton.FlatAppearance.BorderSize = 10;
            this.webhookURL.CustomButton.Image = null;
            this.webhookURL.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.webhookURL.CustomButton.Name = "";
            this.webhookURL.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.webhookURL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.webhookURL.CustomButton.TabIndex = 1;
            this.webhookURL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.webhookURL.CustomButton.UseSelectable = true;
            this.webhookURL.CustomButton.Visible = false;
            this.webhookURL.Lines = new string[0];
            this.webhookURL.Location = new System.Drawing.Point(453, 81);
            this.webhookURL.MaxLength = 32767;
            this.webhookURL.Name = "webhookURL";
            this.webhookURL.PasswordChar = '\0';
            this.webhookURL.PromptText = "Webhook URL";
            this.webhookURL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.webhookURL.SelectedText = "";
            this.webhookURL.SelectionLength = 0;
            this.webhookURL.SelectionStart = 0;
            this.webhookURL.ShortcutsEnabled = true;
            this.webhookURL.ShowClearButton = true;
            this.webhookURL.Size = new System.Drawing.Size(331, 25);
            this.webhookURL.TabIndex = 15;
            this.webhookURL.UseSelectable = true;
            this.webhookURL.WaterMark = "Webhook URL";
            this.webhookURL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.webhookURL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.webhookURL.TextChanged += new System.EventHandler(this.webhookURL_TextChanged);
            this.webhookURL.Click += new System.EventHandler(this.webhookURL_Click);
            // 
            // Embedbutton
            // 
            this.Embedbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.Embedbutton.BackgroundImage = global::DiscordEmbed.Properties.Resources.ui_button_1;
            this.Embedbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Embedbutton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Embedbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.Embedbutton.Location = new System.Drawing.Point(453, 113);
            this.Embedbutton.Name = "Embedbutton";
            this.Embedbutton.Size = new System.Drawing.Size(331, 29);
            this.Embedbutton.TabIndex = 16;
            this.Embedbutton.Text = "Send Embed";
            this.Embedbutton.UseCustomBackColor = true;
            this.Embedbutton.UseCustomForeColor = true;
            this.Embedbutton.UseMnemonic = false;
            this.Embedbutton.UseSelectable = true;
            this.Embedbutton.Click += new System.EventHandler(this.Embedbutton_Click);
            // 
            // console
            // 
            // 
            // 
            // 
            this.console.CustomButton.Image = null;
            this.console.CustomButton.Location = new System.Drawing.Point(183, 2);
            this.console.CustomButton.Name = "";
            this.console.CustomButton.Size = new System.Drawing.Size(145, 145);
            this.console.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.console.CustomButton.TabIndex = 1;
            this.console.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.console.CustomButton.UseSelectable = true;
            this.console.CustomButton.Visible = false;
            this.console.Lines = new string[] {
        "f\\n",
        "test 2"};
            this.console.Location = new System.Drawing.Point(453, 161);
            this.console.MaxLength = 32767;
            this.console.Name = "console";
            this.console.PasswordChar = '\0';
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.console.SelectedText = "";
            this.console.SelectionLength = 0;
            this.console.SelectionStart = 0;
            this.console.ShortcutsEnabled = true;
            this.console.Size = new System.Drawing.Size(331, 150);
            this.console.TabIndex = 17;
            this.console.Text = "f\\n\r\ntest 2";
            this.console.UseSelectable = true;
            this.console.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.console.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.console.Click += new System.EventHandler(this.console_Click);
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.AutoScroll = true;
            this.htmlPanel1.AutoScrollMinSize = new System.Drawing.Size(331, 0);
            this.htmlPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel1.Location = new System.Drawing.Point(453, 161);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.htmlPanel1.Size = new System.Drawing.Size(331, 150);
            this.htmlPanel1.TabIndex = 18;
            this.htmlPanel1.Click += new System.EventHandler(this.htmlPanel1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(538, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Made with  <3 by Ghast (https://ghast.cc)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::DiscordEmbed.Properties.Resources.fxlb9eda42a31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(796, 439);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.htmlPanel1);
            this.Controls.Add(this.console);
            this.Controls.Add(this.Embedbutton);
            this.Controls.Add(this.webhookURL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Discord Embed [Made with <3 by Ghast]";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menu1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private MetroFramework.Controls.MetroContextMenu menu1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mCMarketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spigotMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox authorInput;
        private MetroFramework.Controls.MetroTextBox urlInput;
        private MetroFramework.Controls.MetroTextBox titleInput;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox iconInput;
        private System.Windows.Forms.Label authorLabel;
        private MetroFramework.Controls.MetroTextBox footerIconUrl;
        private MetroFramework.Controls.MetroTextBox footerTextInput;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox imageUrlInput;
        private MetroFramework.Controls.MetroTextBox thumbnailInput;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox messageInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox webhookURL;
        private MetroFramework.Controls.MetroButton Embedbutton;
        private MetroFramework.Controls.MetroTextBox console;
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel1;
        private MetroFramework.Controls.MetroTextBox colorInput;
        private System.Windows.Forms.Label label6;
    }
}

