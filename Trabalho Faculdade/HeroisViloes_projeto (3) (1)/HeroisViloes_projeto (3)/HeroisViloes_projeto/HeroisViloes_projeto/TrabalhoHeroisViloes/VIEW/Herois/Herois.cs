using HeroisViloes.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using viloessViloes.Model;
using System.Security.Policy;
using HeroisViloes.Model.Entities;
using System.Drawing.Text;
using viloessViloes.Model;

namespace TrabalhoHeroisViloes.VIEW.Herois
{
    public partial class Herois : Form
    {

        public Herois()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SuperHeroi herois = new SuperHeroi();
            herois.NomePessoa = TXNP.Text;
            herois.NomeHeroi = textBox2.Text;
            herois.AnoNasc = Convert.ToInt32(textBox10.Text);
            herois.Email = textBox3.Text;
            herois.SuperPoder = textBox6.Text;
            herois.Grupo = textBox7.Text;
            herois.AtividadeProfissional = textBox9.Text;
            herois.PontoFraco = textBox8.Text;
            herois.caminhoImagem = textBox11.Text;
            herois.PlanetaOrigem = textBox4.Text;
            herois.Parceiro = textBox5.Text;
        }

        private void Herois_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
        }
    }
}
