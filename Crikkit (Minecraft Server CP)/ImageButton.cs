using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crikkit__Minecraft_Server_CP_
{
    public partial class ImageButton : PictureBox
    {
        private Image imageBase;
        private Image imageHover;
        private Image imagePress;
        public Image ImageBase
        {
            get { return imageBase; }
            set
            {
                BackgroundImage = value;
                imageBase = value;
            }
        }
        public Image ImageHover
        {
            get { return imageHover; }
            set { imageHover = value; }
        }
        public Image ImagePress
        {
            get { return imagePress; }
            set { imagePress = value; }
        }

        public ImageButton()
        {
            InitializeComponent();
            InitializeButton();
        }

        public ImageButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            InitializeButton();
        }

        private void InitializeButton()
        {
            this.MouseEnter += ImageButton_MouseEnter;
            this.MouseLeave += ImageButton_MouseLeave;
            this.MouseDown += ImageButton_MouseDown;
            this.MouseUp += ImageButton_MouseUp;
        }

        private void ImageButton_MouseUp(object sender, MouseEventArgs e)
        {
            BackgroundImage = ImageHover;
        }

        private void ImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            BackgroundImage = ImagePress;
        }

        private void ImageButton_MouseLeave(object sender, EventArgs e)
        {
            BackgroundImage = ImageBase;
        }

        private void ImageButton_MouseEnter(object sender, EventArgs e)
        {
            BackgroundImage = ImageHover;
        }
    }
}
