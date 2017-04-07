namespace jehlounCompany
{
    partial class udajeOsoby
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
            this.components = new System.ComponentModel.Container();
            this.buttDalsi = new System.Windows.Forms.Button();
            this.lbUlice = new System.Windows.Forms.Label();
            this.tbUlice = new System.Windows.Forms.TextBox();
            this.lbMesto = new System.Windows.Forms.Label();
            this.tbMesto = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.lbDatumNarozeni = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lbPohlavi = new System.Windows.Forms.Label();
            this.lbPrijemni = new System.Windows.Forms.Label();
            this.tbPrijmeni = new System.Windows.Forms.TextBox();
            this.cbPohlavi = new System.Windows.Forms.ComboBox();
            this.lbJmeno = new System.Windows.Forms.Label();
            this.tbJmeno = new System.Windows.Forms.TextBox();
            this.lbCisloPrukazu = new System.Windows.Forms.Label();
            this.tbCisloPrukazu = new System.Windows.Forms.TextBox();
            this.lbTyp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpDatumNarozeni = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttDalsi
            // 
            this.buttDalsi.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttDalsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttDalsi.Location = new System.Drawing.Point(15, 374);
            this.buttDalsi.Name = "buttDalsi";
            this.buttDalsi.Size = new System.Drawing.Size(204, 23);
            this.buttDalsi.TabIndex = 65;
            this.buttDalsi.Text = "Další";
            this.buttDalsi.UseVisualStyleBackColor = true;
            this.buttDalsi.Click += new System.EventHandler(this.buttDalsi_Click);
            // 
            // lbUlice
            // 
            this.lbUlice.AutoSize = true;
            this.lbUlice.Location = new System.Drawing.Point(12, 307);
            this.lbUlice.Name = "lbUlice";
            this.lbUlice.Size = new System.Drawing.Size(31, 13);
            this.lbUlice.TabIndex = 60;
            this.lbUlice.Text = "Ulice";
            // 
            // tbUlice
            // 
            this.tbUlice.Location = new System.Drawing.Point(119, 307);
            this.tbUlice.Name = "tbUlice";
            this.tbUlice.Size = new System.Drawing.Size(100, 20);
            this.tbUlice.TabIndex = 59;
            this.tbUlice.Validating += new System.ComponentModel.CancelEventHandler(this.tbUlice_Validating);
            // 
            // lbMesto
            // 
            this.lbMesto.AutoSize = true;
            this.lbMesto.Location = new System.Drawing.Point(12, 281);
            this.lbMesto.Name = "lbMesto";
            this.lbMesto.Size = new System.Drawing.Size(36, 13);
            this.lbMesto.TabIndex = 58;
            this.lbMesto.Text = "Město";
            // 
            // tbMesto
            // 
            this.tbMesto.Location = new System.Drawing.Point(119, 281);
            this.tbMesto.Name = "tbMesto";
            this.tbMesto.Size = new System.Drawing.Size(100, 20);
            this.tbMesto.TabIndex = 57;
            this.tbMesto.Validating += new System.ComponentModel.CancelEventHandler(this.tbMesto_Validating);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(12, 255);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 56;
            this.lbEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(119, 255);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 55;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Location = new System.Drawing.Point(12, 229);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(43, 13);
            this.lbTelefon.TabIndex = 54;
            this.lbTelefon.Text = "Telefon";
            // 
            // lbDatumNarozeni
            // 
            this.lbDatumNarozeni.AutoSize = true;
            this.lbDatumNarozeni.Location = new System.Drawing.Point(12, 203);
            this.lbDatumNarozeni.Name = "lbDatumNarozeni";
            this.lbDatumNarozeni.Size = new System.Drawing.Size(83, 13);
            this.lbDatumNarozeni.TabIndex = 53;
            this.lbDatumNarozeni.Text = "Datum narození";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(119, 229);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(100, 20);
            this.tbTelefon.TabIndex = 52;
            this.tbTelefon.Validated += new System.EventHandler(this.tbTelefon_Validated);
            // 
            // lbPohlavi
            // 
            this.lbPohlavi.AutoSize = true;
            this.lbPohlavi.Location = new System.Drawing.Point(12, 176);
            this.lbPohlavi.Name = "lbPohlavi";
            this.lbPohlavi.Size = new System.Drawing.Size(44, 13);
            this.lbPohlavi.TabIndex = 51;
            this.lbPohlavi.Text = "Pohlaví";
            // 
            // lbPrijemni
            // 
            this.lbPrijemni.AutoSize = true;
            this.lbPrijemni.Location = new System.Drawing.Point(12, 149);
            this.lbPrijemni.Name = "lbPrijemni";
            this.lbPrijemni.Size = new System.Drawing.Size(48, 13);
            this.lbPrijemni.TabIndex = 49;
            this.lbPrijemni.Text = "Příjmení";
            // 
            // tbPrijmeni
            // 
            this.tbPrijmeni.Location = new System.Drawing.Point(119, 149);
            this.tbPrijmeni.Name = "tbPrijmeni";
            this.tbPrijmeni.Size = new System.Drawing.Size(100, 20);
            this.tbPrijmeni.TabIndex = 47;
            this.tbPrijmeni.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrijmeni_Validating);
            // 
            // cbPohlavi
            // 
            this.cbPohlavi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPohlavi.FormattingEnabled = true;
            this.cbPohlavi.Items.AddRange(new object[] {
            "Muž",
            "Žena",
            "Jiné"});
            this.cbPohlavi.Location = new System.Drawing.Point(119, 176);
            this.cbPohlavi.Name = "cbPohlavi";
            this.cbPohlavi.Size = new System.Drawing.Size(100, 21);
            this.cbPohlavi.TabIndex = 48;
            this.cbPohlavi.Validating += new System.ComponentModel.CancelEventHandler(this.cbPohlavi_Validating);
            // 
            // lbJmeno
            // 
            this.lbJmeno.AutoSize = true;
            this.lbJmeno.Location = new System.Drawing.Point(12, 123);
            this.lbJmeno.Name = "lbJmeno";
            this.lbJmeno.Size = new System.Drawing.Size(38, 13);
            this.lbJmeno.TabIndex = 46;
            this.lbJmeno.Text = "Jméno";
            // 
            // tbJmeno
            // 
            this.tbJmeno.Location = new System.Drawing.Point(119, 123);
            this.tbJmeno.Name = "tbJmeno";
            this.tbJmeno.Size = new System.Drawing.Size(100, 20);
            this.tbJmeno.TabIndex = 45;
            this.tbJmeno.Validating += new System.ComponentModel.CancelEventHandler(this.tbJmeno_Validating);
            // 
            // lbCisloPrukazu
            // 
            this.lbCisloPrukazu.AutoSize = true;
            this.lbCisloPrukazu.Location = new System.Drawing.Point(12, 333);
            this.lbCisloPrukazu.Name = "lbCisloPrukazu";
            this.lbCisloPrukazu.Size = new System.Drawing.Size(72, 13);
            this.lbCisloPrukazu.TabIndex = 67;
            this.lbCisloPrukazu.Text = "Číslo průkazu";
            // 
            // tbCisloPrukazu
            // 
            this.tbCisloPrukazu.Location = new System.Drawing.Point(119, 333);
            this.tbCisloPrukazu.Name = "tbCisloPrukazu";
            this.tbCisloPrukazu.Size = new System.Drawing.Size(100, 20);
            this.tbCisloPrukazu.TabIndex = 66;
            this.tbCisloPrukazu.Validating += new System.ComponentModel.CancelEventHandler(this.tbCisloPrukazu_Validating);
            // 
            // lbTyp
            // 
            this.lbTyp.AutoSize = true;
            this.lbTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTyp.Location = new System.Drawing.Point(12, 61);
            this.lbTyp.Name = "lbTyp";
            this.lbTyp.Size = new System.Drawing.Size(109, 39);
            this.lbTyp.TabIndex = 68;
            this.lbTyp.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 39);
            this.label1.TabIndex = 69;
            this.label1.Text = "Letenka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 50;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // dtpDatumNarozeni
            // 
            this.dtpDatumNarozeni.Location = new System.Drawing.Point(119, 203);
            this.dtpDatumNarozeni.MaxDate = new System.DateTime(2017, 3, 3, 0, 0, 0, 0);
            this.dtpDatumNarozeni.MinDate = new System.DateTime(1900, 12, 31, 0, 0, 0, 0);
            this.dtpDatumNarozeni.Name = "dtpDatumNarozeni";
            this.dtpDatumNarozeni.Size = new System.Drawing.Size(100, 20);
            this.dtpDatumNarozeni.TabIndex = 71;
            this.dtpDatumNarozeni.Value = new System.DateTime(2017, 3, 3, 0, 0, 0, 0);
            // 
            // udajeOsoby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 410);
            this.Controls.Add(this.dtpDatumNarozeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTyp);
            this.Controls.Add(this.lbCisloPrukazu);
            this.Controls.Add(this.tbCisloPrukazu);
            this.Controls.Add(this.buttDalsi);
            this.Controls.Add(this.lbUlice);
            this.Controls.Add(this.tbUlice);
            this.Controls.Add(this.lbMesto);
            this.Controls.Add(this.tbMesto);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbTelefon);
            this.Controls.Add(this.lbDatumNarozeni);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.lbPohlavi);
            this.Controls.Add(this.lbPrijemni);
            this.Controls.Add(this.tbPrijmeni);
            this.Controls.Add(this.cbPohlavi);
            this.Controls.Add(this.lbJmeno);
            this.Controls.Add(this.tbJmeno);
            this.Name = "udajeOsoby";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zadejte prosím, vaše údaje";
            this.Load += new System.EventHandler(this.udajeOsoby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttDalsi;
        private System.Windows.Forms.Label lbUlice;
        private System.Windows.Forms.TextBox tbUlice;
        private System.Windows.Forms.Label lbMesto;
        private System.Windows.Forms.TextBox tbMesto;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.Label lbDatumNarozeni;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lbPohlavi;
        private System.Windows.Forms.Label lbPrijemni;
        private System.Windows.Forms.TextBox tbPrijmeni;
        private System.Windows.Forms.ComboBox cbPohlavi;
        private System.Windows.Forms.Label lbJmeno;
        private System.Windows.Forms.TextBox tbJmeno;
        private System.Windows.Forms.Label lbCisloPrukazu;
        private System.Windows.Forms.TextBox tbCisloPrukazu;
        private System.Windows.Forms.Label lbTyp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker dtpDatumNarozeni;
    }
}