namespace Crikkit__Minecraft_Server_CP_
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ServerListView = new System.Windows.Forms.ListView();
            this.ServerImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageButton_Settings = new Crikkit__Minecraft_Server_CP_.ImageButton(this.components);
            this.imageButton_NewServer = new Crikkit__Minecraft_Server_CP_.ImageButton(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_NewServer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.imageButton_Settings);
            this.panel1.Controls.Add(this.imageButton_NewServer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 51);
            this.panel1.TabIndex = 0;
            // 
            // ServerListView
            // 
            this.ServerListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.ServerListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ServerListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServerListView.ForeColor = System.Drawing.Color.White;
            this.ServerListView.LargeImageList = this.ServerImageList;
            this.ServerListView.Location = new System.Drawing.Point(12, 12);
            this.ServerListView.MultiSelect = false;
            this.ServerListView.Name = "ServerListView";
            this.ServerListView.ShowGroups = false;
            this.ServerListView.Size = new System.Drawing.Size(345, 408);
            this.ServerListView.TabIndex = 1;
            this.ServerListView.TileSize = new System.Drawing.Size(64, 64);
            this.ServerListView.UseCompatibleStateImageBehavior = false;
            // 
            // ServerImageList
            // 
            this.ServerImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ServerImageList.ImageStream")));
            this.ServerImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ServerImageList.Images.SetKeyName(0, "ServerIcon_Grass.png");
            // 
            // imageButton_Settings
            // 
            this.imageButton_Settings.BackgroundImage = global::Crikkit__Minecraft_Server_CP_.Properties.Resources.Button_Settings;
            this.imageButton_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton_Settings.ImageBase = global::Crikkit__Minecraft_Server_CP_.Properties.Resources.Button_Settings;
            this.imageButton_Settings.ImageHover = global::Crikkit__Minecraft_Server_CP_.Properties.Resources.Button_Settings_Hover;
            this.imageButton_Settings.ImagePress = global::Crikkit__Minecraft_Server_CP_.Properties.Resources.Button_Settings_Pressed;
            this.imageButton_Settings.Location = new System.Drawing.Point(54, 3);
            this.imageButton_Settings.Name = "imageButton_Settings";
            this.imageButton_Settings.Size = new System.Drawing.Size(45, 45);
            this.imageButton_Settings.TabIndex = 3;
            this.imageButton_Settings.TabStop = false;
            // 
            // imageButton_NewServer
            // 
            this.imageButton_NewServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageButton_NewServer.BackgroundImage")));
            this.imageButton_NewServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton_NewServer.ImageBase = ((System.Drawing.Image)(resources.GetObject("imageButton_NewServer.ImageBase")));
            this.imageButton_NewServer.ImageHover = ((System.Drawing.Image)(resources.GetObject("imageButton_NewServer.ImageHover")));
            this.imageButton_NewServer.ImagePress = ((System.Drawing.Image)(resources.GetObject("imageButton_NewServer.ImagePress")));
            this.imageButton_NewServer.Location = new System.Drawing.Point(3, 3);
            this.imageButton_NewServer.Name = "imageButton_NewServer";
            this.imageButton_NewServer.Size = new System.Drawing.Size(45, 45);
            this.imageButton_NewServer.TabIndex = 2;
            this.imageButton_NewServer.TabStop = false;
            this.imageButton_NewServer.Click += new System.EventHandler(this.imageButton_NewServer_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(369, 477);
            this.Controls.Add(this.ServerListView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crikkit Launcher";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_NewServer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ImageButton imageButton_NewServer;
        private ImageButton imageButton_Settings;
        private System.Windows.Forms.ListView ServerListView;
        private System.Windows.Forms.ImageList ServerImageList;
    }
}

