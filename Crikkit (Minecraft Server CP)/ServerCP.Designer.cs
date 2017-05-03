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
            this.imageButton_NewServer = new Crikkit__Minecraft_Server_CP_.ImageButton(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_NewServer)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxConsoleOutput
            // 
            this.TextBoxConsoleOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.TextBoxConsoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxConsoleOutput.ForeColor = System.Drawing.Color.White;
            this.TextBoxConsoleOutput.Location = new System.Drawing.Point(0, 107);
            this.TextBoxConsoleOutput.Multiline = true;
            this.TextBoxConsoleOutput.Name = "TextBoxConsoleOutput";
            this.TextBoxConsoleOutput.ReadOnly = true;
            this.TextBoxConsoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxConsoleOutput.Size = new System.Drawing.Size(541, 101);
            this.TextBoxConsoleOutput.TabIndex = 2;
            this.TextBoxConsoleOutput.Text = "Console Output Window";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.imageButton_NewServer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 51);
            this.panel1.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(541, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxConsoleOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ServerCP";
            this.Text = "ServerCP";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_NewServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private ImageButton imageButton_NewServer;
        public System.Windows.Forms.TextBox TextBoxConsoleOutput;
    }
}