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
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox_Players = new System.Windows.Forms.ListBox();
            this.imageButton_NewServer = new Crikkit__Minecraft_Server_CP_.ImageButton(this.components);
            this.button_KickPlayer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.imageButton_NewServer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 51);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.button_KickPlayer);
            this.panel2.Controls.Add(this.listBox_Players);
            this.panel2.Location = new System.Drawing.Point(542, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 211);
            this.panel2.TabIndex = 3;
            // 
            // listBox_Players
            // 
            this.listBox_Players.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.listBox_Players.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Players.ForeColor = System.Drawing.Color.White;
            this.listBox_Players.FormattingEnabled = true;
            this.listBox_Players.Location = new System.Drawing.Point(168, 3);
            this.listBox_Players.Name = "listBox_Players";
            this.listBox_Players.ScrollAlwaysVisible = true;
            this.listBox_Players.Size = new System.Drawing.Size(131, 171);
            this.listBox_Players.TabIndex = 0;
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
            // button_KickPlayer
            // 
            this.button_KickPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button_KickPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KickPlayer.ForeColor = System.Drawing.Color.White;
            this.button_KickPlayer.Location = new System.Drawing.Point(168, 182);
            this.button_KickPlayer.Name = "button_KickPlayer";
            this.button_KickPlayer.Size = new System.Drawing.Size(131, 23);
            this.button_KickPlayer.TabIndex = 2;
            this.button_KickPlayer.Text = "Kick";
            this.button_KickPlayer.UseVisualStyleBackColor = false;
            // 
            // ServerCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(841, 262);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox_ConsoleInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxConsoleOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ServerCP";
            this.Text = "Server Control Panel";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerCP_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_KickPlayer;
        public System.Windows.Forms.ListBox listBox_Players;
    }
}