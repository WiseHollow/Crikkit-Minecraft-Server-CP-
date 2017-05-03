using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Crikkit__Minecraft_Server_CP_
{
    public partial class ServerIcon : Panel
    {
        public PictureBox Icon
        {
            get;set;
        }
        public Label Title
        {
            get;set;
        }

        public ServerIcon()
        {
            InitializeComponent();
            Setup();
        }

        public ServerIcon(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            Width = 75;
            Height = 100;

            Icon = new PictureBox();
            Icon.Width = 75;
            Icon.Height = 75;
            Icon.BackgroundImageLayout = ImageLayout.Stretch;
            Icon.BackgroundImage = (Image)Properties.Resources.ServerIcon_Grass;

            Title = new Label();
            Title.Text = "Server Name";

            Controls.Add(Icon);
            Controls.Add(Title);

            Icon.Location = new Point(0, 0);
            Title.Location = new Point(0, 80);

            MouseDown += ServerIcon_MouseDown;
            Icon.MouseDown += ServerIcon_MouseDown;
            Title.MouseDown += ServerIcon_MouseDown;
        }

        private void ServerIcon_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("To do: Open CP for this server.");
        }
    }
}
