using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Philowolf
{
    public partial class acessar : Form
    {
        string path = "server=localhost; database = Philowolf; user id = root; Password = ; convert zero datetime = True";

        MySqlConnection server;

        MySqlCommand command;

        MySqlDataAdapter dataAdapter;

        MySqlDataReader readData;

        string strSQL;

        public acessar()
        {
            InitializeComponent();
        }

        private void acessar_Load(object sender, EventArgs e)
        {
            try
            {
                server = new MySqlConnection(path);

                strSQL = "SELECT  USER.ID_USER, TYPE_USER.USER_TYPE, USER.NOME, USER.BIRTH_DATE, USER.USERNAME, USER.EMAIL FROM USER, TYPE_USER" +
                " WHERE USER.ID_TYPE = TYPE_USER.ID_TYPE AND USER_TYPE = 'Cliente' ; ";

                dataAdapter = new MySqlDataAdapter(strSQL, server);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                dgv_1.DataSource = dataTable;
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
            finally
            {
                server.Close();
                server = null;
                command = null;
            }
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
