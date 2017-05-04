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
            Server.LoadAllServers();
            Populate();
        }

        public void Populate()
        {
            ServerListView.Items.Clear();
            foreach (Server s in Server.Servers)
            {
                ListViewItem item = ServerListView.Items.Add(s.Name, 0);
                item.SubItems.Add("" + s.ID);
            }
        }

        private void imageButton_NewServer_Click(object sender, EventArgs e)
        {
            NewServer ns = new NewServer();
            ns.ShowDialog();
        }

        private void ServerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServerListView.SelectedItems.Count > 0)
            {
                ListViewItem item = ServerListView.SelectedItems[0];
                if (item != null)
                {
                    int id;
                    int.TryParse(item.SubItems[1].Text, out id);
                    Console.WriteLine("Clicked on server with id: " + id);

                    Server server = Server.GetServer(id);
                    if (server == null || server.ControlPanel != null)
                        return;

                    ServerCP cp = new ServerCP(server);
                    cp.Show();
                }
            }

            ServerListView.SelectedItems.Clear();
        }
    }
}
