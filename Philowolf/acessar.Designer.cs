namespace Philowolf
{
    partial class acessar
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
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.lbl_philowolf = new System.Windows.Forms.Label();
            this.gb_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_1
            // 
            this.gb_1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gb_1.Controls.Add(this.lbl_philowolf);
            this.gb_1.Controls.Add(this.bt_sair);
            this.gb_1.Controls.Add(this.dgv_1);
            this.gb_1.Location = new System.Drawing.Point(12, 12);
            this.gb_1.Name = "gb_1";
            this.gb_1.Size = new System.Drawing.Size(1291, 633);
            this.gb_1.TabIndex = 1;
            this.gb_1.TabStop = false;
            // 
            // bt_sair
            // 
            this.bt_sair.BackgroundImage = global::Philowolf.Properties.Resources.IconWolf;
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.Location = new System.Drawing.Point(1139, 524);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 26);
            this.bt_sair.TabIndex = 32;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // dgv_1
            // 
            this.dgv_1.AllowUserToAddRows = false;
            this.dgv_1.AllowUserToDeleteRows = false;
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(23, 31);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.ReadOnly = true;
            this.dgv_1.Size = new System.Drawing.Size(1191, 491);
            this.dgv_1.TabIndex = 0;
            // 
            // lbl_philowolf
            // 
            this.lbl_philowolf.AutoSize = true;
            this.lbl_philowolf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_philowolf.Location = new System.Drawing.Point(503, 522);
            this.lbl_philowolf.Name = "lbl_philowolf";
            this.lbl_philowolf.Size = new System.Drawing.Size(89, 25);
            this.lbl_philowolf.TabIndex = 33;
            this.lbl_philowolf.Text = "Philowolf";
            // 
            // acessar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1323, 657);
            this.Controls.Add(this.gb_1);
            this.Name = "acessar";
            this.Text = "acessar";
            this.Load += new System.EventHandler(this.acessar_Load);
            this.gb_1.ResumeLayout(false);
            this.gb_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_1;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.Label lbl_philowolf;
    }
}