namespace Philowolf
{
    partial class crud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.bt_sair = new System.Windows.Forms.Button();
            this.txt_birthdate = new System.Windows.Forms.MaskedTextBox();
            this.cmd_usertype = new System.Windows.Forms.ComboBox();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.lbl_pesquisar = new System.Windows.Forms.Label();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.lbl_modificar = new System.Windows.Forms.Label();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.lbl_inserir = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_usertype = new System.Windows.Forms.Label();
            this.txt_iduser = new System.Windows.Forms.TextBox();
            this.lbl_iduser = new System.Windows.Forms.Label();
            this.bt_deletar = new System.Windows.Forms.Button();
            this.lbl_deletar = new System.Windows.Forms.Label();
            this.bt_selecionar = new System.Windows.Forms.Button();
            this.lbl_selecionar = new System.Windows.Forms.Label();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.lbl_philowolf = new System.Windows.Forms.Label();
            this.gb_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_1
            // 
            this.gb_1.Controls.Add(this.bt_sair);
            this.gb_1.Controls.Add(this.txt_birthdate);
            this.gb_1.Controls.Add(this.cmd_usertype);
            this.gb_1.Controls.Add(this.bt_pesquisar);
            this.gb_1.Controls.Add(this.lbl_pesquisar);
            this.gb_1.Controls.Add(this.bt_modificar);
            this.gb_1.Controls.Add(this.lbl_modificar);
            this.gb_1.Controls.Add(this.bt_inserir);
            this.gb_1.Controls.Add(this.lbl_inserir);
            this.gb_1.Controls.Add(this.txt_email);
            this.gb_1.Controls.Add(this.lbl_email);
            this.gb_1.Controls.Add(this.txt_cpf);
            this.gb_1.Controls.Add(this.lbl_cpf);
            this.gb_1.Controls.Add(this.txt_password);
            this.gb_1.Controls.Add(this.lbl_password);
            this.gb_1.Controls.Add(this.txt_username);
            this.gb_1.Controls.Add(this.lbl_username);
            this.gb_1.Controls.Add(this.lbl_birthdate);
            this.gb_1.Controls.Add(this.txt_nome);
            this.gb_1.Controls.Add(this.lbl_nome);
            this.gb_1.Controls.Add(this.lbl_usertype);
            this.gb_1.Controls.Add(this.txt_iduser);
            this.gb_1.Controls.Add(this.lbl_iduser);
            this.gb_1.Controls.Add(this.bt_deletar);
            this.gb_1.Controls.Add(this.lbl_deletar);
            this.gb_1.Controls.Add(this.bt_selecionar);
            this.gb_1.Controls.Add(this.lbl_selecionar);
            this.gb_1.Controls.Add(this.dgv_1);
            this.gb_1.Location = new System.Drawing.Point(22, 12);
            this.gb_1.Name = "gb_1";
            this.gb_1.Size = new System.Drawing.Size(1204, 552);
            this.gb_1.TabIndex = 0;
            this.gb_1.TabStop = false;
            this.gb_1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_sair
            // 
            this.bt_sair.BackgroundImage = global::Philowolf.Properties.Resources.IconWolf;
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.Location = new System.Drawing.Point(1094, 471);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 26);
            this.bt_sair.TabIndex = 32;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // txt_birthdate
            // 
            this.txt_birthdate.Location = new System.Drawing.Point(1082, 133);
            this.txt_birthdate.Mask = "0000/00/00";
            this.txt_birthdate.Name = "txt_birthdate";
            this.txt_birthdate.Size = new System.Drawing.Size(100, 20);
            this.txt_birthdate.TabIndex = 29;
            // 
            // cmd_usertype
            // 
            this.cmd_usertype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmd_usertype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmd_usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmd_usertype.FormattingEnabled = true;
            this.cmd_usertype.Items.AddRange(new object[] {
            "Administrador",
            "Licenciado",
            "Cliente"});
            this.cmd_usertype.Location = new System.Drawing.Point(1078, 53);
            this.cmd_usertype.Name = "cmd_usertype";
            this.cmd_usertype.Size = new System.Drawing.Size(104, 21);
            this.cmd_usertype.TabIndex = 28;
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisar.Location = new System.Drawing.Point(954, 447);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(87, 25);
            this.bt_pesquisar.TabIndex = 27;
            this.bt_pesquisar.Text = "Pesquise";
            this.bt_pesquisar.UseVisualStyleBackColor = true;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // lbl_pesquisar
            // 
            this.lbl_pesquisar.AutoSize = true;
            this.lbl_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisar.Location = new System.Drawing.Point(951, 427);
            this.lbl_pesquisar.Name = "lbl_pesquisar";
            this.lbl_pesquisar.Size = new System.Drawing.Size(71, 17);
            this.lbl_pesquisar.TabIndex = 26;
            this.lbl_pesquisar.Text = "Pesquisar";
            // 
            // bt_modificar
            // 
            this.bt_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modificar.Location = new System.Drawing.Point(1082, 379);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(87, 25);
            this.bt_modificar.TabIndex = 25;
            this.bt_modificar.Text = "Modifique";
            this.bt_modificar.UseVisualStyleBackColor = true;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // lbl_modificar
            // 
            this.lbl_modificar.AutoSize = true;
            this.lbl_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modificar.Location = new System.Drawing.Point(1079, 359);
            this.lbl_modificar.Name = "lbl_modificar";
            this.lbl_modificar.Size = new System.Drawing.Size(65, 17);
            this.lbl_modificar.TabIndex = 24;
            this.lbl_modificar.Text = "Modificar";
            // 
            // bt_inserir
            // 
            this.bt_inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inserir.Location = new System.Drawing.Point(955, 379);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(83, 25);
            this.bt_inserir.TabIndex = 23;
            this.bt_inserir.Text = "Insira";
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // lbl_inserir
            // 
            this.lbl_inserir.AutoSize = true;
            this.lbl_inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inserir.Location = new System.Drawing.Point(953, 359);
            this.lbl_inserir.Name = "lbl_inserir";
            this.lbl_inserir.Size = new System.Drawing.Size(47, 17);
            this.lbl_inserir.TabIndex = 22;
            this.lbl_inserir.Text = "Inserir";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(1082, 274);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 23);
            this.txt_email.TabIndex = 21;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(1079, 254);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(48, 17);
            this.lbl_email.TabIndex = 20;
            this.lbl_email.Text = "EMAIL";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpf.Location = new System.Drawing.Point(954, 274);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(100, 23);
            this.txt_cpf.TabIndex = 19;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(988, 254);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(34, 17);
            this.lbl_cpf.TabIndex = 18;
            this.lbl_cpf.Text = "CPF";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(1082, 207);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 23);
            this.txt_password.TabIndex = 17;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(1079, 187);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(96, 17);
            this.lbl_password.TabIndex = 16;
            this.lbl_password.Text = "PASS_WORD";
            this.lbl_password.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(954, 207);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 23);
            this.txt_username.TabIndex = 15;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(951, 187);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(85, 17);
            this.lbl_username.TabIndex = 14;
            this.lbl_username.Text = "USERNAME";
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthdate.Location = new System.Drawing.Point(1078, 111);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_birthdate.Size = new System.Drawing.Size(94, 17);
            this.lbl_birthdate.TabIndex = 12;
            this.lbl_birthdate.Text = "BIRTH_DATE";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(954, 131);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 23);
            this.txt_nome.TabIndex = 11;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(951, 111);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(49, 17);
            this.lbl_nome.TabIndex = 10;
            this.lbl_nome.Text = "NOME";
            // 
            // lbl_usertype
            // 
            this.lbl_usertype.AutoSize = true;
            this.lbl_usertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usertype.Location = new System.Drawing.Point(1079, 31);
            this.lbl_usertype.Name = "lbl_usertype";
            this.lbl_usertype.Size = new System.Drawing.Size(90, 17);
            this.lbl_usertype.TabIndex = 8;
            this.lbl_usertype.Text = "USER_TYPE";
            // 
            // txt_iduser
            // 
            this.txt_iduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iduser.Location = new System.Drawing.Point(954, 51);
            this.txt_iduser.Name = "txt_iduser";
            this.txt_iduser.Size = new System.Drawing.Size(100, 23);
            this.txt_iduser.TabIndex = 7;
            this.txt_iduser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_iduser_KeyPress);
            // 
            // lbl_iduser
            // 
            this.lbl_iduser.AutoSize = true;
            this.lbl_iduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iduser.Location = new System.Drawing.Point(951, 31);
            this.lbl_iduser.Name = "lbl_iduser";
            this.lbl_iduser.Size = new System.Drawing.Size(71, 17);
            this.lbl_iduser.TabIndex = 6;
            this.lbl_iduser.Text = "ID_USER ";
            // 
            // bt_deletar
            // 
            this.bt_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_deletar.Location = new System.Drawing.Point(152, 520);
            this.bt_deletar.Name = "bt_deletar";
            this.bt_deletar.Size = new System.Drawing.Size(75, 25);
            this.bt_deletar.TabIndex = 4;
            this.bt_deletar.Text = "Delete";
            this.bt_deletar.UseVisualStyleBackColor = true;
            this.bt_deletar.Click += new System.EventHandler(this.bt_deletar_Click);
            // 
            // lbl_deletar
            // 
            this.lbl_deletar.AutoSize = true;
            this.lbl_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deletar.Location = new System.Drawing.Point(162, 500);
            this.lbl_deletar.Name = "lbl_deletar";
            this.lbl_deletar.Size = new System.Drawing.Size(54, 17);
            this.lbl_deletar.TabIndex = 3;
            this.lbl_deletar.Text = "Deletar";
            // 
            // bt_selecionar
            // 
            this.bt_selecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_selecionar.Location = new System.Drawing.Point(25, 520);
            this.bt_selecionar.Name = "bt_selecionar";
            this.bt_selecionar.Size = new System.Drawing.Size(83, 25);
            this.bt_selecionar.TabIndex = 2;
            this.bt_selecionar.Text = "Selecione";
            this.bt_selecionar.UseVisualStyleBackColor = true;
            this.bt_selecionar.Click += new System.EventHandler(this.bt_selecionar_Click);
            // 
            // lbl_selecionar
            // 
            this.lbl_selecionar.AutoSize = true;
            this.lbl_selecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selecionar.Location = new System.Drawing.Point(29, 500);
            this.lbl_selecionar.Name = "lbl_selecionar";
            this.lbl_selecionar.Size = new System.Drawing.Size(75, 17);
            this.lbl_selecionar.TabIndex = 1;
            this.lbl_selecionar.Text = "Selecionar";
            // 
            // dgv_1
            // 
            this.dgv_1.AllowUserToAddRows = false;
            this.dgv_1.AllowUserToDeleteRows = false;
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(23, 31);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.ReadOnly = true;
            this.dgv_1.Size = new System.Drawing.Size(917, 466);
            this.dgv_1.TabIndex = 0;
            this.dgv_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_1_CellContentClick);
            // 
            // lbl_philowolf
            // 
            this.lbl_philowolf.AutoSize = true;
            this.lbl_philowolf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_philowolf.Location = new System.Drawing.Point(651, 9);
            this.lbl_philowolf.Name = "lbl_philowolf";
            this.lbl_philowolf.Size = new System.Drawing.Size(89, 25);
            this.lbl_philowolf.TabIndex = 12;
            this.lbl_philowolf.Text = "Philowolf";
            // 
            // crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1252, 576);
            this.Controls.Add(this.lbl_philowolf);
            this.Controls.Add(this.gb_1);
            this.Name = "crud";
            this.Text = "crud";
            this.Load += new System.EventHandler(this.crud_Load);
            this.gb_1.ResumeLayout(false);
            this.gb_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_1;
        private System.Windows.Forms.Label lbl_philowolf;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.Button bt_deletar;
        private System.Windows.Forms.Label lbl_deletar;
        private System.Windows.Forms.Button bt_selecionar;
        private System.Windows.Forms.Label lbl_selecionar;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_usertype;
        private System.Windows.Forms.TextBox txt_iduser;
        private System.Windows.Forms.Label lbl_iduser;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.Label lbl_modificar;
        private System.Windows.Forms.Button bt_inserir;
        private System.Windows.Forms.Label lbl_inserir;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.Label lbl_pesquisar;
        private System.Windows.Forms.ComboBox cmd_usertype;
        private System.Windows.Forms.MaskedTextBox txt_birthdate;
        private System.Windows.Forms.Button bt_sair;
    }
}