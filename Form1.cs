using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Interface
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        MySqlDataReader dr;
        MySqlCommand Comando;
        MySqlDataAdapter da;
        string strSQL;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=client;User Id=root;Password=;");

                strSQL = "INSERT INTO CAD_CLIENTE (NOME, TELEFONE, EMAIL, ENDERECO) VALUES (@NOME, @TELEFONE, @EMAIL, @ENDERECO";

                Comando = new MySqlCommand(strSQL, conexao);
                Comando.Parameters.AddWithValue("@NOME", txtNOME.Text);
                Comando.Parameters.AddWithValue("@TELEFONE", txtTELEFONE.Text);
                Comando.Parameters.AddWithValue("@EMAIL", txtEMAIL.Text);
                Comando.Parameters.AddWithValue("@ENDERECO", txtENDERECO.Text);

                conexao.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                Comando = null;
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

