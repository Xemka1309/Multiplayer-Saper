using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper
{
    public partial class FormChangeIP : Form
    {
        public String iPAddress;
        public int port;
        public FormChangeIP()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(textBoxip.Text);
                port = Convert.ToInt32(textBoxport.Text);
                iPAddress = textBoxip.Text;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid data");
            }
        }
    }
}
