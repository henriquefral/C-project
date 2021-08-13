using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Philowolf
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        public string ID_USER { get; set; }
        string ID;
        public string TYPE_USER { get ; set;}
        string TYPE;
        private void menu_Load(object sender, EventArgs e)
        {
            if (!this.ID_USER.Equals(""))
            {
                ID = this.ID_USER;
            }
            if (!this.TYPE_USER.Equals(""))
            {
                TYPE = this.TYPE_USER;
            }
            MessageBox.Show(ID, "TESTE");
            MessageBox.Show(TYPE_USER, "TESTE");
            if (TYPE == "Cliente")
            {
                registrosToolStripMenuItem.Visible = false; 
            }
            else if (TYPE == "Licenciado")
            {
                cRUDToolStripMenuItem.Visible = false;
            }
        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento...", "Espere...");
        }

        private void verAContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conta conta = new conta();
            conta.ID_USER = ID;
            conta.TYPE_USER = TYPE;
            conta.ShowDialog();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crud crud = new Philowolf.crud();
            crud.ShowDialog();
        }

        private void acessarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acessar acessar = new Philowolf.acessar();
            acessar.ShowDialog();
        }
    }
}
