using System.ComponentModel;
using System.Windows.Forms;

namespace Crikkit__Minecraft_Server_CP_
{
    public partial class ServerListBox : GroupBox
    {
        public ServerListBox()
        {
            InitializeComponent();
        }

        public ServerListBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Reset()
        {

        }

        public void Add(Server server)
        {

        }
    }
}
