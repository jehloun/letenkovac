namespace jehlounCompany
{
    partial class VyberLetu
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
            this.buttVybratLet = new System.Windows.Forms.Button();
            this.let_grid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odkud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.let_grid_return = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbLetZpet = new System.Windows.Forms.Label();
            this.lbLet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.let_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.let_grid_return)).BeginInit();
            this.SuspendLayout();
            // 
            // buttVybratLet
            // 
            this.buttVybratLet.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttVybratLet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttVybratLet.Location = new System.Drawing.Point(103, 525);
            this.buttVybratLet.Name = "buttVybratLet";
            this.buttVybratLet.Size = new System.Drawing.Size(301, 23);
            this.buttVybratLet.TabIndex = 0;
            this.buttVybratLet.Text = "Vybrat";
            this.buttVybratLet.UseVisualStyleBackColor = true;
            this.buttVybratLet.Click += new System.EventHandler(this.buttVybratLet_Click);
            // 
            // let_grid
            // 
            this.let_grid.AllowUserToAddRows = false;
            this.let_grid.AllowUserToDeleteRows = false;
            this.let_grid.BackgroundColor = System.Drawing.Color.White;
            this.let_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.let_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.let_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.odkud,
            this.kam,
            this.odlet,
            this.cena});
            this.let_grid.Location = new System.Drawing.Point(12, 40);
            this.let_grid.Name = "let_grid";
            this.let_grid.ReadOnly = true;
            this.let_grid.Size = new System.Drawing.Size(517, 214);
            this.let_grid.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // odkud
            // 
            this.odkud.HeaderText = "odkud";
            this.odkud.Name = "odkud";
            this.odkud.ReadOnly = true;
            this.odkud.Width = 130;
            // 
            // kam
            // 
            this.kam.HeaderText = "kam";
            this.kam.Name = "kam";
            this.kam.ReadOnly = true;
            this.kam.Width = 130;
            // 
            // odlet
            // 
            this.odlet.HeaderText = "datum odletu";
            this.odlet.Name = "odlet";
            this.odlet.ReadOnly = true;
            this.odlet.Width = 95;
            // 
            // cena
            // 
            this.cena.HeaderText = "cena";
            this.cena.Name = "cena";
            this.cena.ReadOnly = true;
            this.cena.Width = 50;
            // 
            // let_grid_return
            // 
            this.let_grid_return.AllowUserToAddRows = false;
            this.let_grid_return.AllowUserToDeleteRows = false;
            this.let_grid_return.BackgroundColor = System.Drawing.Color.White;
            this.let_grid_return.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.let_grid_return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.let_grid_return.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.let_grid_return.GridColor = System.Drawing.SystemColors.Control;
            this.let_grid_return.Location = new System.Drawing.Point(12, 289);
            this.let_grid_return.Name = "let_grid_return";
            this.let_grid_return.ReadOnly = true;
            this.let_grid_return.Size = new System.Drawing.Size(517, 214);
            this.let_grid_return.TabIndex = 2;
            this.let_grid_return.Tag = "";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "odkud";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "kam";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "datum odletu";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 95;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "cena";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // lbLetZpet
            // 
            this.lbLetZpet.AutoSize = true;
            this.lbLetZpet.Location = new System.Drawing.Point(12, 273);
            this.lbLetZpet.Name = "lbLetZpet";
            this.lbLetZpet.Size = new System.Drawing.Size(65, 13);
            this.lbLetZpet.TabIndex = 47;
            this.lbLetZpet.Text = "Zpáteční let";
            // 
            // lbLet
            // 
            this.lbLet.AutoSize = true;
            this.lbLet.Location = new System.Drawing.Point(12, 24);
            this.lbLet.Name = "lbLet";
            this.lbLet.Size = new System.Drawing.Size(22, 13);
            this.lbLet.TabIndex = 48;
            this.lbLet.Text = "Let";
            // 
            // VyberLetu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 560);
            this.Controls.Add(this.lbLet);
            this.Controls.Add(this.lbLetZpet);
            this.Controls.Add(this.let_grid_return);
            this.Controls.Add(this.let_grid);
            this.Controls.Add(this.buttVybratLet);
            this.Name = "VyberLetu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vyber si let";
            this.Load += new System.EventHandler(this.VyberLetu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.let_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.let_grid_return)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttVybratLet;
        private System.Windows.Forms.DataGridView let_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn odkud;
        private System.Windows.Forms.DataGridViewTextBoxColumn kam;
        private System.Windows.Forms.DataGridViewTextBoxColumn odlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.DataGridView let_grid_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lbLetZpet;
        private System.Windows.Forms.Label lbLet;
    }
}