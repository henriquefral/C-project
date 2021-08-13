using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Caelum.Stella.CSharp.Validation;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Philowolf
{
    public partial class conta : Form
    {
        string path = "server=localhost; database = Philowolf; user id = root; Password = ; convert zero datetime = True";

        //Servidor
        MySqlConnection server;

        MySqlCommand command;

        MySqlDataAdapter dataAdapter;

        MySqlDataReader readData;

        public string ID_USER { get; set; }
        public string TYPE_USER { get; set; }

        string strSQL;

        string update;

        public conta()
        {
            InitializeComponent();
        }

        private void conta_Load(object sender, EventArgs e)
        {
            try
            {
                server = new MySqlConnection(path);

                strSQL = "SELECT  TYPE_USER.USER_TYPE, USER.NOME, USER.BIRTH_DATE, USER.USERNAME, USER.PASS_WORD, USER.CPF, USER.EMAIL FROM USER, TYPE_USER" +
                " WHERE USER.ID_TYPE = TYPE_USER.ID_TYPE AND USER.ID_USER = @ID_USER;";

                dataAdapter = new MySqlDataAdapter(strSQL, server);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@ID_USER", ID_USER);

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
            try
            {
                server = new MySqlConnection(path);

                strSQL = "SELECT  TYPE_USER.USER_TYPE, USER.NOME FROM USER, TYPE_USER" +
                " WHERE USER.ID_TYPE = TYPE_USER.ID_TYPE AND USER.ID_USER = @ID_USER ;";

                command = new MySqlCommand(strSQL, server);
                command.Parameters.AddWithValue("@ID_USER", ID_USER);

                server.Open();

                readData = command.ExecuteReader();

                while (readData.Read())
                {
                    txt_identification.Text = "Bem vindo: " + readData["NOME"]+ ". Nível de conta: " + readData["USER_TYPE"];
                }
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

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            if (ValidationUpdate())
            {

                try
                {
                    server = new MySqlConnection(path);

                    strSQL = "UPDATE USER SET " + update + " WHERE ID_USER = @ID_USER;";

                    command = new MySqlCommand(strSQL, server);
                    command.Parameters.AddWithValue("@ID_USER", ID_USER);
                    command.Parameters.AddWithValue("@NOME", txt_nome.Text);
                    command.Parameters.AddWithValue("@BIRTH_DATE", txt_birthdate.Text);
                    command.Parameters.AddWithValue("@USERNAME", txt_username.Text);
                    command.Parameters.AddWithValue("@PASS_WORD", txt_password.Text);
                    command.Parameters.AddWithValue("@CPF", txt_cpf.Text);
                    command.Parameters.AddWithValue("@EMAIL", txt_email.Text);
                    server.Open();

                    command.ExecuteNonQuery();
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
                    update = null;
                }
            }
            else
            {
                MessageBox.Show("Verifique seus dados.", "Dado inválido");
            }
        }
        public bool ValidationUpdate()
        {
                if (txt_nome.Text.Length > 0)
                {
                    update += " NOME = @NOME,";
                }
                if (txt_birthdate.MaskCompleted)
                {
                    update += " BIRTH_DATE = @BIRTH_DATE,";
                }
                if (txt_username.Text.Length > 0)
                {
                    try
                    {
                        server = new MySqlConnection(path);

                        strSQL = "SELECT USERNAME FROM USER;";

                        command = new MySqlCommand(strSQL, server);

                        server.Open();

                        readData = command.ExecuteReader();

                        while (readData.Read())
                        {
                            if (readData["USERNAME"].ToString() == txt_username.ToString())
                            {
                                return false;
                            }
                        }
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

                    update += " USERNAME = @USERNAME,";
                }
                if (txt_password.Text.Length > 0)
                {
                    update += " PASS_WORD = @PASS_WORD,";
                }
                if (txt_cpf.Text.Length > 0)
                {
                    if (new CPFValidator().IsValid(txt_cpf.Text) || (txt_cpf.Text.Length == 0))
                    {
                        update += " CPF = @CPF,";
                    }
                    else
                    {
                        return false;
                    }
                }
                if (txt_email.Text.Length > 0)
                {
                    Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
                    if (rg.IsMatch(txt_email.Text) || (txt_email.Text.Length == 0))
                    {
                        update += " EMAIL = @EMAIL,";
                    }
                    else
                    {
                        return false;
                    }
                }
                update = update.Remove(update.Length - 1);
                return true;
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_selecionar_Click(object sender, EventArgs e)
        {
            try
            {
                server = new MySqlConnection(path);

                strSQL = "SELECT  TYPE_USER.USER_TYPE, USER.NOME, USER.BIRTH_DATE, USER.USERNAME, USER.PASS_WORD, USER.CPF, USER.EMAIL FROM USER, TYPE_USER" +
                " WHERE USER.ID_TYPE = TYPE_USER.ID_TYPE AND USER.ID_USER = @ID_USER;";

                dataAdapter = new MySqlDataAdapter(strSQL, server);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@ID_USER", ID_USER);

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
            try
            {
                server = new MySqlConnection(path);

                strSQL = "SELECT  TYPE_USER.USER_TYPE, USER.NOME FROM USER, TYPE_USER" +
                " WHERE USER.ID_TYPE = TYPE_USER.ID_TYPE AND USER.ID_USER = @ID_USER ;";

                command = new MySqlCommand(strSQL, server);
                command.Parameters.AddWithValue("@ID_USER", ID_USER);

                server.Open();

                readData = command.ExecuteReader();

                while (readData.Read())
                {
                    txt_identification.Text = "Bem vindo: " + readData["NOME"] + ". Nível de conta: " + readData["USER_TYPE"];
                }
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
        private void txt_iduser_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 32)
            {

                e.Handled = true;

            }
        }
    }
}
