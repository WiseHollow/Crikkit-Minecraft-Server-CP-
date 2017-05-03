using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Crikkit__Minecraft_Server_CP_
{
    public partial class TextBoxWithWatermark : TextBox
    {
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("Set TextBox's watermark")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        private string watermark;
        public string Watermark
        {
            get
            {
                return watermark;
            }
            set
            {
                Text = value;
                watermark = value;
            }
        }

        public TextBoxWithWatermark()
        {
            InitializeComponent();
            InitializeWatermark();
        }

        public TextBoxWithWatermark(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            InitializeWatermark();
        }

        private void InitializeWatermark()
        {
            EnableWatermark();

            GotFocus += TextBoxWithWatermark_GotFocus;
            LostFocus += TextBoxWithWatermark_LostFocus;
        }

        private void EnableWatermark()
        {
            this.Text = Watermark;
            this.ForeColor = System.Drawing.Color.Gray;
            this.BackColor = System.Drawing.Color.Yellow;
        }

        private void DisableWatermark()
        {
            this.Text = "";
            this.ForeColor = System.Drawing.Color.Black;
            this.BackColor = System.Drawing.Color.White;
        }

        private void TextBoxWithWatermark_LostFocus(object sender, EventArgs e)
        {
            if (this.Text == "")
                EnableWatermark();
        }

        private void TextBoxWithWatermark_GotFocus(object sender, EventArgs e)
        {
            if (this.Text == Watermark)
                DisableWatermark();
        }
    }
}
