namespace Philowolf
{
    partial class menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_aula = new System.Windows.Forms.Label();
            this.btn_aula = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_philowolf = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.registrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAContaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // verAContaToolStripMenuItem
            // 
            this.verAContaToolStripMenuItem.Name = "verAContaToolStripMenuItem";
            this.verAContaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.verAContaToolStripMenuItem.Text = "Ver a conta";
            this.verAContaToolStripMenuItem.Click += new System.EventHandler(this.verAContaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::Philowolf.Properties.Resources.IconWolf;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessarToolStripMenuItem,
            this.cRUDToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            this.registrosToolStripMenuItem.Click += new System.EventHandler(this.registrosToolStripMenuItem_Click);
            // 
            // acessarToolStripMenuItem
            // 
            this.acessarToolStripMenuItem.Name = "acessarToolStripMenuItem";
            this.acessarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acessarToolStripMenuItem.Text = "Acessar";
            this.acessarToolStripMenuItem.Click += new System.EventHandler(this.acessarToolStripMenuItem_Click);
            // 
            // cRUDToolStripMenuItem
            // 
            this.cRUDToolStripMenuItem.Name = "cRUDToolStripMenuItem";
            this.cRUDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cRUDToolStripMenuItem.Text = "CRUD";
            this.cRUDToolStripMenuItem.Click += new System.EventHandler(this.cRUDToolStripMenuItem_Click);
            // 
            // lbl_aula
            // 
            this.lbl_aula.AutoSize = true;
            this.lbl_aula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aula.Location = new System.Drawing.Point(43, 85);
            this.lbl_aula.Name = "lbl_aula";
            this.lbl_aula.Size = new System.Drawing.Size(52, 25);
            this.lbl_aula.TabIndex = 2;
            this.lbl_aula.Text = "Aula";
            // 
            // btn_aula
            // 
            this.btn_aula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aula.Location = new System.Drawing.Point(12, 124);
            this.btn_aula.Name = "btn_aula";
            this.btn_aula.Size = new System.Drawing.Size(112, 29);
            this.btn_aula.TabIndex = 3;
            this.btn_aula.Text = "Acessar a aula";
            this.btn_aula.UseVisualStyleBackColor = true;
            this.btn_aula.Click += new System.EventHandler(this.btn_aula_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Philowolf.Properties.Resources.wolf_30695;
            this.pictureBox2.Location = new System.Drawing.Point(167, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 282);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_philowolf
            // 
            this.lbl_philowolf.AutoSize = true;
            this.lbl_philowolf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_philowolf.Location = new System.Drawing.Point(162, 40);
            this.lbl_philowolf.Name = "lbl_philowolf";
            this.lbl_philowolf.Size = new System.Drawing.Size(89, 25);
            this.lbl_philowolf.TabIndex = 11;
            this.lbl_philowolf.Text = "Philowolf";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(481, 416);
            this.Controls.Add(this.lbl_philowolf);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_aula);
            this.Controls.Add(this.lbl_aula);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessarToolStripMenuItem;
        private System.Windows.Forms.Label lbl_aula;
        private System.Windows.Forms.Button btn_aula;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem cRUDToolStripMenuItem;
        private System.Windows.Forms.Label lbl_philowolf;
    }
}