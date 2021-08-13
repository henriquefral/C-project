namespace Philowolf
{
    partial class login
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
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.rbt_user = new System.Windows.Forms.RadioButton();
            this.rbt_id = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_sair = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_chance = new System.Windows.Forms.TextBox();
            this.lbl_chance = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.cmd_user_type = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(77, 91);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(61, 17);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "Usuário:";
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(148, 88);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(100, 23);
            this.txt_user.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(148, 131);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(100, 23);
            this.txt_password.TabIndex = 3;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(77, 134);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(53, 17);
            this.lbl_senha.TabIndex = 2;
            this.lbl_senha.Text = "Senha:";
            // 
            // bt_login
            // 
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(80, 240);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(75, 26);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // rbt_user
            // 
            this.rbt_user.AutoSize = true;
            this.rbt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_user.Location = new System.Drawing.Point(80, 31);
            this.rbt_user.Name = "rbt_user";
            this.rbt_user.Size = new System.Drawing.Size(75, 21);
            this.rbt_user.TabIndex = 5;
            this.rbt_user.TabStop = true;
            this.rbt_user.Text = "Usuário";
            this.rbt_user.UseVisualStyleBackColor = true;
            this.rbt_user.CheckedChanged += new System.EventHandler(this.rbt_user_CheckedChanged);
            // 
            // rbt_id
            // 
            this.rbt_id.AutoSize = true;
            this.rbt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_id.Location = new System.Drawing.Point(171, 31);
            this.rbt_id.Name = "rbt_id";
            this.rbt_id.Size = new System.Drawing.Size(39, 21);
            this.rbt_id.TabIndex = 6;
            this.rbt_id.TabStop = true;
            this.rbt_id.Text = "ID";
            this.rbt_id.UseVisualStyleBackColor = true;
            this.rbt_id.CheckedChanged += new System.EventHandler(this.rbt_id_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Philowolf.Properties.Resources.IconWolf;
            this.pictureBox1.Location = new System.Drawing.Point(193, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bt_sair
            // 
            this.bt_sair.BackgroundImage = global::Philowolf.Properties.Resources.IconWolf;
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.Location = new System.Drawing.Point(291, 240);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 26);
            this.bt_sair.TabIndex = 8;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Philowolf.Properties.Resources.wolf_30695;
            this.pictureBox2.Location = new System.Drawing.Point(291, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // txt_chance
            // 
            this.txt_chance.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_chance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chance.Location = new System.Drawing.Point(327, 28);
            this.txt_chance.Name = "txt_chance";
            this.txt_chance.Size = new System.Drawing.Size(24, 23);
            this.txt_chance.TabIndex = 11;
            this.txt_chance.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_chance
            // 
            this.lbl_chance.AutoSize = true;
            this.lbl_chance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chance.Location = new System.Drawing.Point(256, 31);
            this.lbl_chance.Name = "lbl_chance";
            this.lbl_chance.Size = new System.Drawing.Size(67, 17);
            this.lbl_chance.TabIndex = 10;
            this.lbl_chance.Text = "Chances:";
            this.lbl_chance.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(148, 88);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 23);
            this.txt_id.TabIndex = 13;
            this.txt_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(77, 91);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(25, 17);
            this.lbl_id.TabIndex = 12;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(77, 175);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(40, 17);
            this.lbl_tipo.TabIndex = 14;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // cmd_user_type
            // 
            this.cmd_user_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmd_user_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmd_user_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmd_user_type.FormattingEnabled = true;
            this.cmd_user_type.Items.AddRange(new object[] {
            "Administrador",
            "Licenciado",
            "Cliente"});
            this.cmd_user_type.Location = new System.Drawing.Point(123, 175);
            this.cmd_user_type.Name = "cmd_user_type";
            this.cmd_user_type.Size = new System.Drawing.Size(125, 21);
            this.cmd_user_type.TabIndex = 15;
            this.cmd_user_type.SelectedIndexChanged += new System.EventHandler(this.cmd_user_type_SelectedIndexChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(521, 330);
            this.Controls.Add(this.cmd_user_type);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_chance);
            this.Controls.Add(this.lbl_chance);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbt_id);
            this.Controls.Add(this.rbt_user);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_user);
            this.Name = "login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.RadioButton rbt_user;
        private System.Windows.Forms.RadioButton rbt_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_chance;
        private System.Windows.Forms.Label lbl_chance;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.ComboBox cmd_user_type;
    }
}

