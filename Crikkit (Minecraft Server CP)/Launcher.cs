using System;
using System.Windows.Forms;

namespace Crikkit__Minecraft_Server_CP_
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();

            PictureBox test = new PictureBox();
            test.BackColor = System.Drawing.Color.White;
            test.Width = 20;
            test.Height = 20;
            groupBox_Servers.Controls.Add(test);
            groupBox_Servers.Controls.Add(test);
            groupBox_Servers.Controls.Add(test);
        }

        private void imageButton_NewServer_Click(object sender, EventArgs e)
        {
            NewServer ns = new NewServer();
            ns.Show();
        }
    }
}
