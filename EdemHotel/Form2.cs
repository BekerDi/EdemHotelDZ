using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdemHotel
{
    public partial class Form2 : Form

    {
        private string guestName;

        public string GuestName
        {
            get { return guestName; }
            set
            {
                guestName = value;
                labelName.Text = guestName;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }
        private EdemContext db = new EdemContext();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chckBoxHasPet_CheckedChanged(object sender, EventArgs e)
        {
            Gosti gostiInstance = new Gosti();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCloseForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
