using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using viloessViloes.Model;
using HeroisViloes.Model.DAO;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Net.Mime.MediaTypeNames;
using HeroisViloes.Model.Entities;
using System.Data.SqlClient;

namespace TrabalhoHeroisViloes.VIEW.Herois
{
    public partial class consultaHerois : Form
    {
        private SqlConnection _sqlConnection;
        public consultaHerois()
        {
            InitializeComponent();
            preencheDgvComHerois();
        }

        public void preencheDgvComHerois()
        {
            var herois = new heroisDAO();
            var todos_herois = herois.consultarTodos();
            this.dataGridView1.DataSource = todos_herois;
        }

        private void consultaHerois_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
