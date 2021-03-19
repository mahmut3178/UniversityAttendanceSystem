using Business.BaseFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.UI.UI.Controls
{
    public partial class MessageYesNo : Form
    {
        public MessageYesNo()
        {
            InitializeComponent();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            FunctionBase.ReleaseCapture();
            FunctionBase.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            FunctionBase.ReleaseCapture();
            FunctionBase.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Image MessageIcon
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }

        public string Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }

        public string Caption
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
