using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crikkit__Minecraft_Server_CP_
{
    public partial class ServerCP : Form
    {
        private Server Server;

        public ServerCP(Server server)
        {
            InitializeComponent();
            Server = server;
        }

        private void imageButton_NewServer_Click(object sender, EventArgs e)
        {
            Server.Run();
        }
    }
}
