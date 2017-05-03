using System;
using System.Windows.Forms;

namespace Crikkit__Minecraft_Server_CP_
{
    public partial class NewServer : Form
    {
        public NewServer()
        {
            InitializeComponent();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            string name = textBoxWithWatermark1.Text;
            uint memory = (uint) numericUpDown1.Value;

            Server.CreateNewServer(name, memory);

            //TODO: Refresh the list of servers in Launcher.

            Close();
        }
    }
}
