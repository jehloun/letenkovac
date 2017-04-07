namespace jehlounCompany
{
    partial class jehlounCompany
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
            this.cbKam = new System.Windows.Forms.ComboBox();
            this.lbKam = new System.Windows.Forms.Label();
            this.dtpDenOdletu = new System.Windows.Forms.DateTimePicker();
            this.lbDenOdletu = new System.Windows.Forms.Label();
            this.cbOdkud = new System.Windows.Forms.ComboBox();
            this.buttDalsi = new System.Windows.Forms.Button();
            this.lbOdkud = new System.Windows.Forms.Label();
            this.dtpDenPriletu = new System.Windows.Forms.DateTimePicker();
            this.lbDenPriletu = new System.Windows.Forms.Label();
            this.rbZpatky = new System.Windows.Forms.RadioButton();
            this.gbtypletu = new System.Windows.Forms.GroupBox();
            this.rbjednosmerny = new System.Windows.Forms.RadioButton();
            this.buttProhoditLet = new System.Windows.Forms.Button();
            this.buttMapa = new System.Windows.Forms.Button();
            this.buttTridaCestujici = new System.Windows.Forms.Button();
            this.lbCestujici = new System.Windows.Forms.Label();
            this.cbTrida = new System.Windows.Forms.ComboBox();
            this.lbTrida = new System.Windows.Forms.Label();
            this.rtbCestujici = new System.Windows.Forms.RichTextBox();
            this.buttVynulovatOsoby = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbtypletu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKam
            // 
            this.cbKam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbKam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKam.FormattingEnabled = true;
            this.cbKam.Location = new System.Drawing.Point(515, 78);
            this.cbKam.Name = "cbKam";
            this.cbKam.Size = new System.Drawing.Size(413, 21);
            this.cbKam.TabIndex = 30;
            this.cbKam.Validating += new System.ComponentModel.CancelEventHandler(this.cbKam_Validating);
            // 
            // lbKam
            // 
            this.lbKam.AutoSize = true;
            this.lbKam.Location = new System.Drawing.Point(512, 60);
            this.lbKam.Name = "lbKam";
            this.lbKam.Size = new System.Drawing.Size(28, 13);
            this.lbKam.TabIndex = 29;
            this.lbKam.Text = "Kam";
            // 
            // dtpDenOdletu
            // 
            this.dtpDenOdletu.Location = new System.Drawing.Point(15, 143);
            this.dtpDenOdletu.MaxDate = new System.DateTime(2017, 6, 8, 0, 0, 0, 0);
            this.dtpDenOdletu.MinDate = new System.DateTime(2017, 3, 5, 0, 0, 0, 0);
            this.dtpDenOdletu.Name = "dtpDenOdletu";
            this.dtpDenOdletu.Size = new System.Drawing.Size(200, 20);
            this.dtpDenOdletu.TabIndex = 26;
            // 
            // lbDenOdletu
            // 
            this.lbDenOdletu.AutoSize = true;
            this.lbDenOdletu.Location = new System.Drawing.Point(12, 127);
            this.lbDenOdletu.Name = "lbDenOdletu";
            this.lbDenOdletu.Size = new System.Drawing.Size(59, 13);
            this.lbDenOdletu.TabIndex = 25;
            this.lbDenOdletu.Text = "Den odletu";
            // 
            // cbOdkud
            // 
            this.cbOdkud.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbOdkud.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOdkud.FormattingEnabled = true;
            this.cbOdkud.Location = new System.Drawing.Point(15, 78);
            this.cbOdkud.Name = "cbOdkud";
            this.cbOdkud.Size = new System.Drawing.Size(413, 21);
            this.cbOdkud.TabIndex = 24;
            this.cbOdkud.Validating += new System.ComponentModel.CancelEventHandler(this.cbOdkud_Validating);
            // 
            // buttDalsi
            // 
            this.buttDalsi.BackColor = System.Drawing.Color.White;
            this.buttDalsi.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttDalsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttDalsi.Location = new System.Drawing.Point(748, 236);
            this.buttDalsi.Name = "buttDalsi";
            this.buttDalsi.Size = new System.Drawing.Size(180, 23);
            this.buttDalsi.TabIndex = 23;
            this.buttDalsi.Text = "Další";
            this.buttDalsi.UseVisualStyleBackColor = false;
            this.buttDalsi.Click += new System.EventHandler(this.buttDalsi_Click);
            // 
            // lbOdkud
            // 
            this.lbOdkud.AutoSize = true;
            this.lbOdkud.Location = new System.Drawing.Point(12, 62);
            this.lbOdkud.Name = "lbOdkud";
            this.lbOdkud.Size = new System.Drawing.Size(39, 13);
            this.lbOdkud.TabIndex = 21;
            this.lbOdkud.Text = "Odkud";
            // 
            // dtpDenPriletu
            // 
            this.dtpDenPriletu.Location = new System.Drawing.Point(228, 143);
            this.dtpDenPriletu.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dtpDenPriletu.MinDate = new System.DateTime(2017, 3, 6, 0, 0, 0, 0);
            this.dtpDenPriletu.Name = "dtpDenPriletu";
            this.dtpDenPriletu.Size = new System.Drawing.Size(200, 20);
            this.dtpDenPriletu.TabIndex = 32;
            this.dtpDenPriletu.Value = new System.DateTime(2017, 3, 6, 0, 0, 0, 0);
            this.dtpDenPriletu.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDenPriletu_Validating);
            // 
            // lbDenPriletu
            // 
            this.lbDenPriletu.AutoSize = true;
            this.lbDenPriletu.Location = new System.Drawing.Point(225, 127);
            this.lbDenPriletu.Name = "lbDenPriletu";
            this.lbDenPriletu.Size = new System.Drawing.Size(61, 13);
            this.lbDenPriletu.TabIndex = 31;
            this.lbDenPriletu.Text = "Den příletu";
            // 
            // rbZpatky
            // 
            this.rbZpatky.AutoSize = true;
            this.rbZpatky.Checked = true;
            this.rbZpatky.Location = new System.Drawing.Point(6, 19);
            this.rbZpatky.Name = "rbZpatky";
            this.rbZpatky.Size = new System.Drawing.Size(79, 17);
            this.rbZpatky.TabIndex = 33;
            this.rbZpatky.TabStop = true;
            this.rbZpatky.Text = "S návratem";
            this.rbZpatky.UseVisualStyleBackColor = true;
            this.rbZpatky.CheckedChanged += new System.EventHandler(this.rbZpatky_CheckedChanged);
            // 
            // gbtypletu
            // 
            this.gbtypletu.Controls.Add(this.rbjednosmerny);
            this.gbtypletu.Controls.Add(this.rbZpatky);
            this.gbtypletu.Location = new System.Drawing.Point(12, 3);
            this.gbtypletu.Name = "gbtypletu";
            this.gbtypletu.Size = new System.Drawing.Size(213, 44);
            this.gbtypletu.TabIndex = 34;
            this.gbtypletu.TabStop = false;
            // 
            // rbjednosmerny
            // 
            this.rbjednosmerny.AutoSize = true;
            this.rbjednosmerny.Location = new System.Drawing.Point(97, 19);
            this.rbjednosmerny.Name = "rbjednosmerny";
            this.rbjednosmerny.Size = new System.Drawing.Size(87, 17);
            this.rbjednosmerny.TabIndex = 35;
            this.rbjednosmerny.Text = "Jednosměrný";
            this.rbjednosmerny.UseVisualStyleBackColor = true;
            this.rbjednosmerny.CheckedChanged += new System.EventHandler(this.rbjednosmerny_CheckedChanged);
            // 
            // buttProhoditLet
            // 
            this.buttProhoditLet.BackColor = System.Drawing.Color.White;
            this.buttProhoditLet.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttProhoditLet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttProhoditLet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttProhoditLet.Location = new System.Drawing.Point(434, 76);
            this.buttProhoditLet.Name = "buttProhoditLet";
            this.buttProhoditLet.Size = new System.Drawing.Size(75, 23);
            this.buttProhoditLet.TabIndex = 35;
            this.buttProhoditLet.Text = "<------>";
            this.buttProhoditLet.UseVisualStyleBackColor = false;
            this.buttProhoditLet.Click += new System.EventHandler(this.buttProhoditLet_Click);
            // 
            // buttMapa
            // 
            this.buttMapa.BackColor = System.Drawing.Color.White;
            this.buttMapa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttMapa.Location = new System.Drawing.Point(15, 236);
            this.buttMapa.Name = "buttMapa";
            this.buttMapa.Size = new System.Drawing.Size(200, 23);
            this.buttMapa.TabIndex = 36;
            this.buttMapa.Text = "Mapa";
            this.buttMapa.UseVisualStyleBackColor = false;
            this.buttMapa.Click += new System.EventHandler(this.buttMapa_Click);
            // 
            // buttTridaCestujici
            // 
            this.buttTridaCestujici.BackColor = System.Drawing.Color.White;
            this.buttTridaCestujici.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttTridaCestujici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttTridaCestujici.Location = new System.Drawing.Point(805, 140);
            this.buttTridaCestujici.Name = "buttTridaCestujici";
            this.buttTridaCestujici.Size = new System.Drawing.Size(123, 23);
            this.buttTridaCestujici.TabIndex = 37;
            this.buttTridaCestujici.Text = "vybrat";
            this.buttTridaCestujici.UseVisualStyleBackColor = false;
            this.buttTridaCestujici.Click += new System.EventHandler(this.buttTridaCestujici_Click);
            // 
            // lbCestujici
            // 
            this.lbCestujici.AutoSize = true;
            this.lbCestujici.Location = new System.Drawing.Point(703, 124);
            this.lbCestujici.Name = "lbCestujici";
            this.lbCestujici.Size = new System.Drawing.Size(50, 13);
            this.lbCestujici.TabIndex = 38;
            this.lbCestujici.Text = "Cestující";
            // 
            // cbTrida
            // 
            this.cbTrida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbTrida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTrida.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbTrida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrida.FormattingEnabled = true;
            this.cbTrida.Items.AddRange(new object[] {
            "Business třída",
            "Economy",
            "Premium economy",
            "První třída"});
            this.cbTrida.Location = new System.Drawing.Point(515, 142);
            this.cbTrida.Name = "cbTrida";
            this.cbTrida.Size = new System.Drawing.Size(133, 21);
            this.cbTrida.TabIndex = 41;
            this.cbTrida.Validating += new System.ComponentModel.CancelEventHandler(this.cbTrida_Validating);
            // 
            // lbTrida
            // 
            this.lbTrida.AutoSize = true;
            this.lbTrida.Location = new System.Drawing.Point(512, 127);
            this.lbTrida.Name = "lbTrida";
            this.lbTrida.Size = new System.Drawing.Size(34, 13);
            this.lbTrida.TabIndex = 42;
            this.lbTrida.Text = "Třída";
            // 
            // rtbCestujici
            // 
            this.rtbCestujici.BackColor = System.Drawing.Color.White;
            this.rtbCestujici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbCestujici.Location = new System.Drawing.Point(706, 140);
            this.rtbCestujici.Name = "rtbCestujici";
            this.rtbCestujici.ReadOnly = true;
            this.rtbCestujici.Size = new System.Drawing.Size(80, 61);
            this.rtbCestujici.TabIndex = 43;
            this.rtbCestujici.Text = "";
            // 
            // buttVynulovatOsoby
            // 
            this.buttVynulovatOsoby.BackColor = System.Drawing.Color.White;
            this.buttVynulovatOsoby.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttVynulovatOsoby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttVynulovatOsoby.Location = new System.Drawing.Point(805, 178);
            this.buttVynulovatOsoby.Name = "buttVynulovatOsoby";
            this.buttVynulovatOsoby.Size = new System.Drawing.Size(123, 23);
            this.buttVynulovatOsoby.TabIndex = 45;
            this.buttVynulovatOsoby.Text = "Vymazat";
            this.buttVynulovatOsoby.UseVisualStyleBackColor = false;
            this.buttVynulovatOsoby.Click += new System.EventHandler(this.buttVynulovatOsoby_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::jehlounCompany.Properties.Resources.jehlounCompanyImage;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-4, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 302);
            this.panel1.TabIndex = 44;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // jehlounCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(944, 638);
            this.Controls.Add(this.buttVynulovatOsoby);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtbCestujici);
            this.Controls.Add(this.lbTrida);
            this.Controls.Add(this.cbTrida);
            this.Controls.Add(this.lbCestujici);
            this.Controls.Add(this.buttTridaCestujici);
            this.Controls.Add(this.buttMapa);
            this.Controls.Add(this.buttProhoditLet);
            this.Controls.Add(this.gbtypletu);
            this.Controls.Add(this.dtpDenPriletu);
            this.Controls.Add(this.lbDenPriletu);
            this.Controls.Add(this.cbKam);
            this.Controls.Add(this.lbKam);
            this.Controls.Add(this.dtpDenOdletu);
            this.Controls.Add(this.lbDenOdletu);
            this.Controls.Add(this.cbOdkud);
            this.Controls.Add(this.buttDalsi);
            this.Controls.Add(this.lbOdkud);
            this.Name = "jehlounCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Jehloun Company a.s.";
            this.Load += new System.EventHandler(this.jehlounCompany_Load);
            this.gbtypletu.ResumeLayout(false);
            this.gbtypletu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKam;
        private System.Windows.Forms.Label lbKam;
        private System.Windows.Forms.DateTimePicker dtpDenOdletu;
        private System.Windows.Forms.Label lbDenOdletu;
        private System.Windows.Forms.ComboBox cbOdkud;
        private System.Windows.Forms.Button buttDalsi;
        private System.Windows.Forms.Label lbOdkud;
        private System.Windows.Forms.DateTimePicker dtpDenPriletu;
        private System.Windows.Forms.Label lbDenPriletu;
        private System.Windows.Forms.RadioButton rbZpatky;
        private System.Windows.Forms.GroupBox gbtypletu;
        private System.Windows.Forms.RadioButton rbjednosmerny;
        private System.Windows.Forms.Button buttProhoditLet;
        private System.Windows.Forms.Button buttMapa;
        private System.Windows.Forms.Button buttTridaCestujici;
        private System.Windows.Forms.Label lbCestujici;
        private System.Windows.Forms.ComboBox cbTrida;
        private System.Windows.Forms.Label lbTrida;
        private System.Windows.Forms.RichTextBox rtbCestujici;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttVynulovatOsoby;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

