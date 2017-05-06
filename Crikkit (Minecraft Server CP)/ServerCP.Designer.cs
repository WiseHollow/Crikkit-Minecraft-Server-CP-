namespace Crikkit__Minecraft_Server_CP_
{
    partial class ServerCP
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
            this.TextBoxConsoleOutput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ServerBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.textBox_ConsoleInput = new System.Windows.Forms.TextBox();
            this.listBox_Players = new System.Windows.Forms.ListBox();
            this.imageButton_Kick = new Crikkit__Minecraft_Server_CP_.ImageButton(this.components);
            this.imageButton1 = new Crikkit__Minecraft_Server_CP_.ImageButton(this.components);
            this.imageButton_NewServer = new Crikkit__Minecraft_Server_CP_.ImageButton(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_Kick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_NewServer)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxConsoleOutput
            // 
            this.TextBoxConsoleOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.TextBoxConsoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxConsoleOutput.ForeColor = System.Drawing.Color.White;
            this.TextBoxConsoleOutput.Location = new System.Drawing.Point(0, -1);
            this.TextBoxConsoleOutput.Multiline = true;
            this.TextBoxConsoleOutput.Name = "TextBoxConsoleOutput";
            this.TextBoxConsoleOutput.ReadOnly = true;
            this.TextBoxConsoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxConsoleOutput.Size = new System.Drawing.Size(541, 193);
            this.TextBoxConsoleOutput.TabIndex = 2;
            this.TextBoxConsoleOutput.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.imageButton_Kick);
            this.panel1.Controls.Add(this.imageButton1);
            this.panel1.Controls.Add(this.imageButton_NewServer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 51);
            this.panel1.TabIndex = 0;
            // 
            // textBox_ConsoleInput
            // 
            this.textBox_ConsoleInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox_ConsoleInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ConsoleInput.ForeColor = System.Drawing.Color.White;
            this.textBox_ConsoleInput.Location = new System.Drawing.Point(0, 191);
            this.textBox_ConsoleInput.Name = "textBox_ConsoleInput";
            this.textBox_ConsoleInput.Size = new System.Drawing.Size(541, 20);
            this.textBox_ConsoleInput.TabIndex = 0;
            this.textBox_ConsoleInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ConsoleInput_KeyDown);
            // 
            // listBox_Players
            // 
            this.listBox_Players.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.listBox_Players.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Players.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox_Players.ForeColor = System.Drawing.Color.White;
            this.listBox_Players.FormattingEnabled = true;
            this.listBox_Players.Location = new System.Drawing.Point(540, 0);
            this.listBox_Players.Name = "listBox_Players";
            this.listBox_Players.ScrollAlwaysVisible = true;
            this.listBox_Players.Size = new System.Drawing.Size(131, 211);
            this.listBox_Players.TabIndex = 0;
            // 
            // imageButton_Kick
            // 
            this.imageButton_Kick.BackgroundImage = global::Crikkit__Minecraft_Server_CP_.Properties.Resources.Button_Kick;
            this.imageButton_Kick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton_Kick.ImageBase = global::Crikkit__Minecraft_Server_CP_.Properties.Resources.Button_Kick;
            this.imageButton_Kick.ImageHover = global::Crikkit__Minecraft_Server_CP_.Properties.Resources.Button_Kick_Hover;
            this.imageButton_Kick.ImagePress = global::Crikkit__Minecraft_Server_CP_.Properties.Resources.Button_Kick_Pressed;
            this.imageButton_Kick.Location = new System.Drawing.Point(105, 3);
            this.imageButton_Kick.Name = "imageButton_Kick";
            this.imageButton_Kick.Size = new System.Drawing.Size(45, 45);
            this.imageButton_Kick.TabIndex = 5;
            this.imageButton_Kick.TabStop = false;
            this.imageButton_Kick.Click += new System.EventHandler(this.button_KickPlayer_Click);
            // 
            // imageButton1
            // 
            this.imageButton1.BackgroundImage = global::Crikkit__Minecraft_Server_CP_.Properties.Resources.Button_Ban;
            this.imageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton1.ImageBase = global::Crikkit__Minecraft_Server_CP_.Properties.Resources.Button_Ban;
            this.imageButton1.ImageHover = global::Crikkit__Minecraft_Server_CP_.Properties.Resources.Button_Ban_Hover;
            this.imageButton1.ImagePress = global::Crikkit__Minecraft_Server_CP_.Properties.Resources.Button_Ban_Pressed;
            this.imageButton1.Location = new System.Drawing.Point(54, 3);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(45, 45);
            this.imageButton1.TabIndex = 4;
            this.imageButton1.TabStop = false;
            this.imageButton1.Click += new System.EventHandler(this.button_BanPlayer_Click);
            // 
            // imageButton_NewServer
            // 
            this.imageButton_NewServer.BackgroundImage = global::Crikkit__Minecraft_Server_CP_.Properties.Resources.Button_Power;
            this.imageButton_NewServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton_NewServer.ImageBase = global::Crikkit__Minecraft_Server_CP_.Properties.Resources.Button_Power;
            this.imageButton_NewServer.ImageHover = global::Crikkit__Minecraft_Server_CP_.Properties.Resources.Button_Power_Hover;
            this.imageButton_NewServer.ImagePress = global::Crikkit__Minecraft_Server_CP_.Properties.Resources.Button_Power_Pressed;
            this.imageButton_NewServer.Location = new System.Drawing.Point(3, 3);
            this.imageButton_NewServer.Name = "imageButton_NewServer";
            this.imageButton_NewServer.Size = new System.Drawing.Size(45, 45);
            this.imageButton_NewServer.TabIndex = 3;
            this.imageButton_NewServer.TabStop = false;
            this.imageButton_NewServer.Click += new System.EventHandler(this.imageButton_NewServer_Click);
            // 
            // ServerCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(671, 262);
            this.Controls.Add(this.listBox_Players);
            this.Controls.Add(this.textBox_ConsoleInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxConsoleOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ServerCP";
            this.Text = "Server Control Panel";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerCP_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_Kick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_NewServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private ImageButton imageButton_NewServer;
        public System.Windows.Forms.TextBox TextBoxConsoleOutput;
        private System.ComponentModel.BackgroundWorker ServerBackgroundWorker;
        private System.Windows.Forms.TextBox textBox_ConsoleInput;
        public System.Windows.Forms.ListBox listBox_Players;
        private ImageButton imageButton1;
        private ImageButton imageButton_Kick;
    }
}