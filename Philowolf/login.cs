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
    public partial class login : Form
    {
        string path = "server=localhost; database = Philowolf; user id = root; Password = ";

        //Servidor
        MySqlConnection server;

        MySqlCommand command;

        MySqlDataReader readData;

        int tries = 5;

        string typeUser;

        string ID;

        Boolean log = false;

        public login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_chance.Text = tries.ToString();
            rbt_user.Checked = true;
            try
            {
                server = new MySqlConnection(path);
                server.Open();

            } catch
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (cmd_user_type.SelectedItem != "Administrador" && cmd_user_type.SelectedItem != "Cliente" && cmd_user_type.SelectedItem != "Licenciado")
            {
                MessageBox.Show("Se atente ao tipo de usuário.");
            } else 
            {
                tries -= 1;
                txt_chance.Text = tries.ToString();
                string SqlSelect = "SELECT TYPE_USER.USER_TYPE, USER.ID_TYPE, USER.ID_USER, USER.USERNAME, USER.PASS_WORD FROM USER, TYPE_USER WHERE USER.ID_TYPE = TYPE_USER.ID_TYPE;";
                command = new MySqlCommand(SqlSelect, server);
                readData = command.ExecuteReader();
                while (readData.Read())
                {

                    if (txt_password.Text == readData["PASS_WORD"].ToString() &&
                        txt_user.Text == readData["USERNAME"].ToString() ||
                        txt_id.Text == readData["ID_USER"].ToString())
                    {
                        if ((cmd_user_type.SelectedIndex + 1).ToString() == readData["ID_TYPE"].ToString())
                        {
                            log = true;
                            ID = readData["ID_USER"].ToString();
                            typeUser = readData["USER_TYPE"].ToString();
                        }
                        else
                        {
                            log = false;
                        }
                    }
                }

                readData.Close();
                if (tries <= 0)
                {
                    MessageBox.Show("As chances chegaram ao fim. Usuário bloqueado", "Banido.");
                    this.Close();
                } else if (log)
                {
                        MessageBox.Show("Seja bem vindo ao sistema", "Acesso permitido");
                        menu menu = new menu();
                        menu.ID_USER = ID;
                        menu.TYPE_USER = typeUser;
                        menu.ShowDialog();
                 } 
                else
                {
                    
                    MessageBox.Show("Digite novamente, usuário ou ID e a senha não existem no sistema", "Restam " + tries + " tentativas.");
                }
            }
        }
        private void bt_sair_Click(object sender, EventArgs e)
        {
            server.Close();
            this.Close();
        }

        private void rbt_user_CheckedChanged(object sender, EventArgs e)
        {
            txt_id.Visible = false;
            lbl_id.Visible = false;
            txt_user.Visible = true;
            lbl_user.Visible = true;
        }

        private void rbt_id_CheckedChanged(object sender, EventArgs e)
        {
            txt_user.Visible = false;
            lbl_user.Visible = false;
            txt_id.Visible = true;
            lbl_id.Visible = true;
        }

        private void cmd_user_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
