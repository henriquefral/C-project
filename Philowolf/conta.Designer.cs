namespace Philowolf
{
    partial class conta
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
            this.lbl_philowolf = new System.Windows.Forms.Label();
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.bt_sair = new System.Windows.Forms.Button();
            this.txt_identification = new System.Windows.Forms.TextBox();
            this.txt_birthdate = new System.Windows.Forms.MaskedTextBox();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.lbl_modificar = new System.Windows.Forms.Label();
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
            this.bt_selecionar = new System.Windows.Forms.Button();
            this.lbl_selecionar = new System.Windows.Forms.Label();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.gb_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_philowolf
            // 
            this.lbl_philowolf.AutoSize = true;
            this.lbl_philowolf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_philowolf.Location = new System.Drawing.Point(25, 0);
            this.lbl_philowolf.Name = "lbl_philowolf";
            this.lbl_philowolf.Size = new System.Drawing.Size(89, 25);
            this.lbl_philowolf.TabIndex = 14;
            this.lbl_philowolf.Text = "Philowolf";
            // 
            // gb_1
            // 
            this.gb_1.Controls.Add(this.bt_sair);
            this.gb_1.Controls.Add(this.txt_identification);
            this.gb_1.Controls.Add(this.lbl_philowolf);
            this.gb_1.Controls.Add(this.txt_birthdate);
            this.gb_1.Controls.Add(this.bt_modificar);
            this.gb_1.Controls.Add(this.lbl_modificar);
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
            this.gb_1.Controls.Add(this.bt_selecionar);
            this.gb_1.Controls.Add(this.lbl_selecionar);
            this.gb_1.Controls.Add(this.dgv_1);
            this.gb_1.Location = new System.Drawing.Point(12, 3);
            this.gb_1.Name = "gb_1";
            this.gb_1.Size = new System.Drawing.Size(1283, 567);
            this.gb_1.TabIndex = 13;
            this.gb_1.TabStop = false;
            // 
            // bt_sair
            // 
            this.bt_sair.BackgroundImage = global::Philowolf.Properties.Resources.IconWolf;
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.Location = new System.Drawing.Point(998, 471);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 26);
            this.bt_sair.TabIndex = 31;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // txt_identification
            // 
            this.txt_identification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_identification.Location = new System.Drawing.Point(988, 31);
            this.txt_identification.Name = "txt_identification";
            this.txt_identification.ReadOnly = true;
            this.txt_identification.Size = new System.Drawing.Size(273, 23);
            this.txt_identification.TabIndex = 30;
            // 
            // txt_birthdate
            // 
            this.txt_birthdate.Location = new System.Drawing.Point(1174, 162);
            this.txt_birthdate.Mask = "0000/00/00";
            this.txt_birthdate.Name = "txt_birthdate";
            this.txt_birthdate.Size = new System.Drawing.Size(100, 20);
            this.txt_birthdate.TabIndex = 29;
            // 
            // bt_modificar
            // 
            this.bt_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modificar.Location = new System.Drawing.Point(1174, 386);
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
            this.lbl_modificar.Location = new System.Drawing.Point(1171, 366);
            this.lbl_modificar.Name = "lbl_modificar";
            this.lbl_modificar.Size = new System.Drawing.Size(65, 17);
            this.lbl_modificar.TabIndex = 24;
            this.lbl_modificar.Text = "Modificar";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(1174, 288);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 23);
            this.txt_email.TabIndex = 21;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(1171, 268);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(48, 17);
            this.lbl_email.TabIndex = 20;
            this.lbl_email.Text = "EMAIL";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpf.Location = new System.Drawing.Point(988, 288);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(100, 23);
            this.txt_cpf.TabIndex = 19;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(985, 268);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(34, 17);
            this.lbl_cpf.TabIndex = 18;
            this.lbl_cpf.Text = "CPF";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(1174, 221);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 23);
            this.txt_password.TabIndex = 17;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(1171, 201);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(96, 17);
            this.lbl_password.TabIndex = 16;
            this.lbl_password.Text = "PASS_WORD";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(988, 221);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 23);
            this.txt_username.TabIndex = 15;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(985, 201);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(85, 17);
            this.lbl_username.TabIndex = 14;
            this.lbl_username.Text = "USERNAME";
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthdate.Location = new System.Drawing.Point(1170, 140);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_birthdate.Size = new System.Drawing.Size(94, 17);
            this.lbl_birthdate.TabIndex = 12;
            this.lbl_birthdate.Text = "BIRTH_DATE";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(988, 160);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 23);
            this.txt_nome.TabIndex = 11;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(985, 140);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(49, 17);
            this.lbl_nome.TabIndex = 10;
            this.lbl_nome.Text = "NOME";
            // 
            // bt_selecionar
            // 
            this.bt_selecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_selecionar.Location = new System.Drawing.Point(991, 386);
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
            this.lbl_selecionar.Location = new System.Drawing.Point(995, 366);
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
            this.dgv_1.Size = new System.Drawing.Size(942, 466);
            this.dgv_1.TabIndex = 0;
            // 
            // conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1612, 582);
            this.Controls.Add(this.gb_1);
            this.Name = "conta";
            this.Text = "conta";
            this.Load += new System.EventHandler(this.conta_Load);
            this.gb_1.ResumeLayout(false);
            this.gb_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_philowolf;
        private System.Windows.Forms.GroupBox gb_1;
        private System.Windows.Forms.MaskedTextBox txt_birthdate;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.Label lbl_modificar;
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
        private System.Windows.Forms.Button bt_selecionar;
        private System.Windows.Forms.Label lbl_selecionar;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.TextBox txt_identification;
        private System.Windows.Forms.Button bt_sair;
    }
}