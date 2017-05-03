using System;
using System.Windows.Forms;

namespace Crikkit__Minecraft_Server_CP_
{
    public partial class Launcher : Form
    {
        public static Launcher Instance;

        public Launcher()
        {
            Instance = this;
            InitializeComponent();
            Populate();
        }

        public void Populate()
        {
            ServerListView.Items.Clear();
            foreach (Server s in Server.Servers)
            {
                ServerListView.Items.Add(s.Name, 0);
            }
        }

        private void imageButton_NewServer_Click(object sender, EventArgs e)
        {
            NewServer ns = new NewServer();
            ns.Show();
        }
    }
}
