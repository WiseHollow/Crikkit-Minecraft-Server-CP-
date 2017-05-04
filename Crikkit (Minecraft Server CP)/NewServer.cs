using System;
using System.Windows.Forms;

namespace Crikkit__Minecraft_Server_CP_
{
    public partial class NewServer : Form
    {
        public NewServer()
        {
            InitializeComponent();

            for(int i = 0; i < Enum.GetValues(typeof(ServerType)).Length; i++)
            {
                ServerType type = (ServerType)i;
                comboBox_ServerJarType.Items.Add(type.ToString());
            }
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            string name = textBoxWithWatermark1.Text;
            uint memory = (uint) numericUpDown1.Value;

            Server.CreateNewServer(name, memory);
            
            Launcher.Instance.Populate();

            Close();
        }
    }
}
