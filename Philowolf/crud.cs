using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caelum.Stella.CSharp.Validation;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Philowolf
{
    public partial class crud : Form
    {
        string path = "server=localhost; database = Philowolf; user id = root; Password = ; convert zero datetime = True";

        //Servidor
        MySqlConnection server;

        MySqlCommand command;

        MySqlDataAdapter dataAdapter;

        MySqlDataReader readData;

        string strSQL;

        string fields;

        string values;

        string update;

        public crud()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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
                    command.Parameters.AddWithValue("@ID_TYPE", (cmd_usertype.SelectedIndex + 1).ToString());
                    command.Parameters.AddWithValue("@ID_USER", txt_iduser.Text);
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
                MessageBox.Show("Verifique seus dados.","Dado inválido");
            }
        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {
            
            if (Validation())
            {
                try
                {
                    server = new MySqlConnection(path);
    
                    strSQL = "INSERT INTO USER ( " + fields + " ) VALUES ("+ values +")";

                                    command = new MySqlCommand(strSQL, server);
                    command.Parameters.AddWithValue("@ID_USER", txt_iduser.Text);
                    command.Parameters.AddWithValue("@ID_TYPE", (cmd_usertype.SelectedIndex + 1).ToString());
                    command.Parameters.AddWithValue("@NOME", txt_nome.Text);
                    command.Parameters.AddWithValue("@BIRTH_DATE", txt_birthdate.Text);
                    command.Parameters.AddWithValue("@USERNAME", txt_username.Text);
                    command.Parameters.AddWithValue("@PASS_WORD", txt_password.Text);
                    command.Parameters.AddWithValue("@CPF", txt_cpf.Text);
                    command.Parameters.AddWithValue("@EMAIL", txt_email.Text);
    
                    server.Open();

                    command.ExecuteNonQuery();
;


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
                    values = null;
                    fields = null;
                }
            }
            else
            {
                MessageBox.Show("Verifique seus dados.","Dado inválido");
            }
}

        private void bt_deletar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    server = new MySqlConnection(path);

                    strSQL = "DELETE FROM USER WHERE ID_USER = @ID_USER;";

                    command = new MySqlCommand(strSQL, server);
                    command.Parameters.AddWithValue("@ID_USER", txt_iduser.Text);

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
                }
            
        }

        private void bt_selecionar_Click(object sender, EventArgs e)
        {
            try
            {
                server = new MySqlConnection(path);


                strSQL = "SELECT  USER.ID_USER, TYPE_USER.USER_TYPE, USER.ID_TYPE, USER.NOME, USER.BIRTH_DATE, USER.USERNAME, USER.PASS_WORD, USER.CPF, USER.EMAIL FROM USER, TYPE_USER" +
                " WHERE USER.ID_TYPE = TYPE_USER.ID_TYPE; ";

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

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                server = new MySqlConnection(path);

                strSQL = "SELECT  USER.ID_USER, TYPE_USER.USER_TYPE, USER.ID_TYPE, USER.NOME, USER.BIRTH_DATE, USER.USERNAME, USER.PASS_WORD, USER.CPF, USER.EMAIL FROM USER, TYPE_USER " +
                "WHERE USER.ID_TYPE = TYPE_USER.ID_TYPE"; 

                if (txt_iduser.Text.Length > 0)
                {
                    strSQL += " AND USER.ID_USER LIKE '%" + txt_iduser.Text + "%'";
                }
                if (cmd_usertype.SelectedIndex >= 0 && cmd_usertype.SelectedIndex <= 3)
                {
                    strSQL += " AND TYPE_USER.USER_TYPE LIKE '%" + cmd_usertype.SelectedItem.ToString() + "%'";
                }
                if (txt_nome.Text.Length > 0)
                {
                    strSQL += " AND USER.NOME LIKE '%" + txt_nome.Text + "%'";
                }
                if(txt_birthdate.MaskCompleted)
                {
                    strSQL += " AND USER.BIRTH_DATE LIKE '%" + txt_birthdate.Text + "%'";
                }
                if (txt_username.Text.Length > 0 )
                {
                    strSQL += " AND USER.USERNAME LIKE '%" + txt_username.Text + "%'";
                }
                if (txt_password.Text.Length > 0)
                {
                    strSQL += " AND USER.PASS_WORD LIKE '%" + txt_password.Text + "%'";
                }
                if (txt_cpf.Text.Length > 0)
                {
                    strSQL += " AND USER.CPF LIKE '%" + txt_cpf.Text + "%'";
                }
                if (txt_email.Text.Length > 0)
                {
                    strSQL += " AND USER.EMAIL LIKE '%" + txt_email.Text + "%' ";
                }

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

        private void txt_usertype_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmd_user_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void crud_Load(object sender, EventArgs e)
        {
            try
            {
                server = new MySqlConnection(path);

                strSQL = "SELECT  USER.ID_USER, TYPE_USER.USER_TYPE, USER.ID_TYPE, USER.NOME, USER.BIRTH_DATE, USER.USERNAME, USER.PASS_WORD, USER.CPF, USER.EMAIL FROM USER, TYPE_USER" +
                " WHERE USER.ID_TYPE = TYPE_USER.ID_TYPE; ";

                dataAdapter = new MySqlDataAdapter(strSQL, server); // declarar MySqlDataAdapter dataAdapter;

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

        private void txt_iduser_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }


        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 32)
            {

                e.Handled = true;

            }
        }
     
        public bool Validation()
        {
            //ID_USER, ID_TYPE, NOME, BIRTH_DATE, USERNAME, PASS_WORD, CPF, EMAIL
            //@ID_USER, @ID_TYPE, @NOME, @BIRTH_DATE, @USERNAME, @PASS_WORD, @CPF, @EMAIL
            if (cmd_usertype.SelectedIndex >= 0 && cmd_usertype.SelectedIndex <= 2)
            {
                fields += "ID_TYPE,";
                values += "@ID_TYPE,";
                if (txt_iduser.Text.Length > 0)
                {
                    fields += " ID_USER,";
                    values += " @ID_USER,";
                }
                if (txt_nome.Text.Length > 0)
                {
                    fields += " NOME,";
                    values += " @NOME,";
                }
                if (txt_birthdate.MaskCompleted)
                {
                    fields += " BIRTH_DATE,";
                    values += " @BIRTH_DATE,";
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

                    fields += " USERNAME,";
                    values += " @USERNAME,";
                }
                if (txt_password.Text.Length > 0)
                {

                    fields += " PASS_WORD,";
                    values += " @PASS_WORD,";
                }
                if (txt_cpf.Text.Length > 0)
                {
                    if (new CPFValidator().IsValid(txt_cpf.Text) || (txt_cpf.Text.Length == 0))
                    {
                        fields += " CPF,";
                        values += " @CPF,";
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
                        fields += " EMAIL,";
                        values += " @EMAIL,";
                    }
                    else
                    {
                        return false;
                    }
                }
                fields = fields.Remove(fields.Length - 1);
                values = values.Remove(values.Length - 1);

                return true;

            }
            else
            {
                return false;
            }


        }
        public bool ValidationUpdate()
        {
            if (txt_iduser.Text.Length > 0)
            {
                if (cmd_usertype.SelectedIndex >= 0 && cmd_usertype.SelectedIndex <= 2)
                {
                    update += "ID_TYPE = @ID_TYPE, ";
                }
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
            else
            {
                return false;
            }
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
