using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoHeroisViloes.VIEW.Herois;


namespace TrabalhoHeroisViloes.VIEW.Herois
{

    public partial class Menu : Form
    {
        public Form Form;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aMIGOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form?.Close();

            Form = new Parceiros
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            ControlePainel.Controls.Add(Form);
            Form.Show();

        }

        private void cADASTRARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form?.Close();

            Form = new Herois
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            ControlePainel.Controls.Add(Form);
            Form.Show();
        }

        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form?.Close();

            Form = new Viloes
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            ControlePainel.Controls.Add(Form);
            Form.Show();
        }

        private void cONSULTARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form?.Close();

            Form = new consultaHerois
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            ControlePainel.Controls.Add(Form);
            Form.Show();
        }
    }
}
