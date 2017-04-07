namespace jehlounCompany
{
    partial class Souhrn
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
            this.lbCenaPopisek = new System.Windows.Forms.Label();
            this.buttObjednat = new System.Windows.Forms.Button();
            this.lbCenaVypoctena = new System.Windows.Forms.Label();
            this.rtbCestujici = new System.Windows.Forms.RichTextBox();
            this.lbCestujici = new System.Windows.Forms.Label();
            this.gbTypPlatby = new System.Windows.Forms.GroupBox();
            this.rbHotove = new System.Windows.Forms.RadioButton();
            this.rbPrevodem = new System.Windows.Forms.RadioButton();
            this.lbKam = new System.Windows.Forms.Label();
            this.tbKam = new System.Windows.Forms.TextBox();
            this.lbOdkud = new System.Windows.Forms.Label();
            this.tbOdkud = new System.Windows.Forms.TextBox();
            this.lbKdy = new System.Windows.Forms.Label();
            this.tbDen = new System.Windows.Forms.TextBox();
            this.buttStorno = new System.Windows.Forms.Button();
            this.gbLetTam = new System.Windows.Forms.GroupBox();
            this.gbZpatecniLet = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOdkudZL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKamZL = new System.Windows.Forms.TextBox();
            this.tbDenZL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbTypPlatby.SuspendLayout();
            this.gbLetTam.SuspendLayout();
            this.gbZpatecniLet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCenaPopisek
            // 
            this.lbCenaPopisek.AutoSize = true;
            this.lbCenaPopisek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCenaPopisek.Location = new System.Drawing.Point(8, 178);
            this.lbCenaPopisek.Name = "lbCenaPopisek";
            this.lbCenaPopisek.Size = new System.Drawing.Size(51, 20);
            this.lbCenaPopisek.TabIndex = 0;
            this.lbCenaPopisek.Text = "Cena:";
            // 
            // buttObjednat
            // 
            this.buttObjednat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttObjednat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttObjednat.Location = new System.Drawing.Point(12, 223);
            this.buttObjednat.Name = "buttObjednat";
            this.buttObjednat.Size = new System.Drawing.Size(216, 23);
            this.buttObjednat.TabIndex = 1;
            this.buttObjednat.Text = "Objednat";
            this.buttObjednat.UseVisualStyleBackColor = true;
            this.buttObjednat.Click += new System.EventHandler(this.buttObjednat_Click);
            // 
            // lbCenaVypoctena
            // 
            this.lbCenaVypoctena.AutoSize = true;
            this.lbCenaVypoctena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCenaVypoctena.Location = new System.Drawing.Point(62, 178);
            this.lbCenaVypoctena.Name = "lbCenaVypoctena";
            this.lbCenaVypoctena.Size = new System.Drawing.Size(51, 20);
            this.lbCenaVypoctena.TabIndex = 2;
            this.lbCenaVypoctena.Text = "label2";
            // 
            // rtbCestujici
            // 
            this.rtbCestujici.BackColor = System.Drawing.Color.White;
            this.rtbCestujici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbCestujici.Location = new System.Drawing.Point(12, 25);
            this.rtbCestujici.Name = "rtbCestujici";
            this.rtbCestujici.ReadOnly = true;
            this.rtbCestujici.Size = new System.Drawing.Size(216, 61);
            this.rtbCestujici.TabIndex = 45;
            this.rtbCestujici.Text = "";
            // 
            // lbCestujici
            // 
            this.lbCestujici.AutoSize = true;
            this.lbCestujici.Location = new System.Drawing.Point(9, 9);
            this.lbCestujici.Name = "lbCestujici";
            this.lbCestujici.Size = new System.Drawing.Size(50, 13);
            this.lbCestujici.TabIndex = 44;
            this.lbCestujici.Text = "Cestující";
            // 
            // gbTypPlatby
            // 
            this.gbTypPlatby.Controls.Add(this.rbHotove);
            this.gbTypPlatby.Controls.Add(this.rbPrevodem);
            this.gbTypPlatby.Location = new System.Drawing.Point(12, 98);
            this.gbTypPlatby.Name = "gbTypPlatby";
            this.gbTypPlatby.Size = new System.Drawing.Size(216, 44);
            this.gbTypPlatby.TabIndex = 46;
            this.gbTypPlatby.TabStop = false;
            this.gbTypPlatby.Text = "Vyberte způsob platby";
            // 
            // rbHotove
            // 
            this.rbHotove.AutoSize = true;
            this.rbHotove.Location = new System.Drawing.Point(97, 19);
            this.rbHotove.Name = "rbHotove";
            this.rbHotove.Size = new System.Drawing.Size(60, 17);
            this.rbHotove.TabIndex = 35;
            this.rbHotove.Text = "Hotově";
            this.rbHotove.UseVisualStyleBackColor = true;
            // 
            // rbPrevodem
            // 
            this.rbPrevodem.AutoSize = true;
            this.rbPrevodem.Checked = true;
            this.rbPrevodem.Location = new System.Drawing.Point(6, 19);
            this.rbPrevodem.Name = "rbPrevodem";
            this.rbPrevodem.Size = new System.Drawing.Size(74, 17);
            this.rbPrevodem.TabIndex = 33;
            this.rbPrevodem.TabStop = true;
            this.rbPrevodem.Text = "Převodem";
            this.rbPrevodem.UseVisualStyleBackColor = true;
            // 
            // lbKam
            // 
            this.lbKam.AutoSize = true;
            this.lbKam.Location = new System.Drawing.Point(7, 40);
            this.lbKam.Name = "lbKam";
            this.lbKam.Size = new System.Drawing.Size(31, 13);
            this.lbKam.TabIndex = 53;
            this.lbKam.Text = "Kam:";
            // 
            // tbKam
            // 
            this.tbKam.Location = new System.Drawing.Point(63, 39);
            this.tbKam.Name = "tbKam";
            this.tbKam.ReadOnly = true;
            this.tbKam.Size = new System.Drawing.Size(150, 20);
            this.tbKam.TabIndex = 52;
            // 
            // lbOdkud
            // 
            this.lbOdkud.AutoSize = true;
            this.lbOdkud.Location = new System.Drawing.Point(7, 14);
            this.lbOdkud.Name = "lbOdkud";
            this.lbOdkud.Size = new System.Drawing.Size(42, 13);
            this.lbOdkud.TabIndex = 51;
            this.lbOdkud.Text = "Odkud:";
            // 
            // tbOdkud
            // 
            this.tbOdkud.Location = new System.Drawing.Point(63, 13);
            this.tbOdkud.Name = "tbOdkud";
            this.tbOdkud.ReadOnly = true;
            this.tbOdkud.Size = new System.Drawing.Size(150, 20);
            this.tbOdkud.TabIndex = 50;
            // 
            // lbKdy
            // 
            this.lbKdy.AutoSize = true;
            this.lbKdy.Location = new System.Drawing.Point(7, 66);
            this.lbKdy.Name = "lbKdy";
            this.lbKdy.Size = new System.Drawing.Size(30, 13);
            this.lbKdy.TabIndex = 55;
            this.lbKdy.Text = "Den:";
            // 
            // tbDen
            // 
            this.tbDen.Location = new System.Drawing.Point(63, 65);
            this.tbDen.Name = "tbDen";
            this.tbDen.ReadOnly = true;
            this.tbDen.Size = new System.Drawing.Size(150, 20);
            this.tbDen.TabIndex = 54;
            // 
            // buttStorno
            // 
            this.buttStorno.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttStorno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttStorno.Location = new System.Drawing.Point(281, 223);
            this.buttStorno.Name = "buttStorno";
            this.buttStorno.Size = new System.Drawing.Size(233, 23);
            this.buttStorno.TabIndex = 56;
            this.buttStorno.Text = "Storno";
            this.buttStorno.UseVisualStyleBackColor = true;
            this.buttStorno.Click += new System.EventHandler(this.buttStorno_Click);
            // 
            // gbLetTam
            // 
            this.gbLetTam.Controls.Add(this.lbOdkud);
            this.gbLetTam.Controls.Add(this.tbOdkud);
            this.gbLetTam.Controls.Add(this.lbKdy);
            this.gbLetTam.Controls.Add(this.tbKam);
            this.gbLetTam.Controls.Add(this.tbDen);
            this.gbLetTam.Controls.Add(this.lbKam);
            this.gbLetTam.Location = new System.Drawing.Point(281, 12);
            this.gbLetTam.Margin = new System.Windows.Forms.Padding(0);
            this.gbLetTam.Name = "gbLetTam";
            this.gbLetTam.Padding = new System.Windows.Forms.Padding(4);
            this.gbLetTam.Size = new System.Drawing.Size(233, 93);
            this.gbLetTam.TabIndex = 47;
            this.gbLetTam.TabStop = false;
            this.gbLetTam.Text = "Váš let";
            // 
            // gbZpatecniLet
            // 
            this.gbZpatecniLet.Controls.Add(this.label1);
            this.gbZpatecniLet.Controls.Add(this.tbOdkudZL);
            this.gbZpatecniLet.Controls.Add(this.label2);
            this.gbZpatecniLet.Controls.Add(this.tbKamZL);
            this.gbZpatecniLet.Controls.Add(this.tbDenZL);
            this.gbZpatecniLet.Controls.Add(this.label3);
            this.gbZpatecniLet.Location = new System.Drawing.Point(281, 105);
            this.gbZpatecniLet.Margin = new System.Windows.Forms.Padding(0);
            this.gbZpatecniLet.Name = "gbZpatecniLet";
            this.gbZpatecniLet.Padding = new System.Windows.Forms.Padding(4);
            this.gbZpatecniLet.Size = new System.Drawing.Size(233, 93);
            this.gbZpatecniLet.TabIndex = 56;
            this.gbZpatecniLet.TabStop = false;
            this.gbZpatecniLet.Text = "Zpáteční let";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Odkud:";
            // 
            // tbOdkudZL
            // 
            this.tbOdkudZL.Location = new System.Drawing.Point(63, 13);
            this.tbOdkudZL.Name = "tbOdkudZL";
            this.tbOdkudZL.ReadOnly = true;
            this.tbOdkudZL.Size = new System.Drawing.Size(150, 20);
            this.tbOdkudZL.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Den:";
            // 
            // tbKamZL
            // 
            this.tbKamZL.Location = new System.Drawing.Point(63, 39);
            this.tbKamZL.Name = "tbKamZL";
            this.tbKamZL.ReadOnly = true;
            this.tbKamZL.Size = new System.Drawing.Size(150, 20);
            this.tbKamZL.TabIndex = 52;
            // 
            // tbDenZL
            // 
            this.tbDenZL.Location = new System.Drawing.Point(63, 65);
            this.tbDenZL.Name = "tbDenZL";
            this.tbDenZL.ReadOnly = true;
            this.tbDenZL.Size = new System.Drawing.Size(150, 20);
            this.tbDenZL.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Kam:";
            // 
            // Souhrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 258);
            this.Controls.Add(this.gbZpatecniLet);
            this.Controls.Add(this.gbLetTam);
            this.Controls.Add(this.buttStorno);
            this.Controls.Add(this.gbTypPlatby);
            this.Controls.Add(this.rtbCestujici);
            this.Controls.Add(this.lbCestujici);
            this.Controls.Add(this.lbCenaVypoctena);
            this.Controls.Add(this.buttObjednat);
            this.Controls.Add(this.lbCenaPopisek);
            this.Name = "Souhrn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Souhrn";
            this.Load += new System.EventHandler(this.Souhrn_Load);
            this.gbTypPlatby.ResumeLayout(false);
            this.gbTypPlatby.PerformLayout();
            this.gbLetTam.ResumeLayout(false);
            this.gbLetTam.PerformLayout();
            this.gbZpatecniLet.ResumeLayout(false);
            this.gbZpatecniLet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCenaPopisek;
        private System.Windows.Forms.Button buttObjednat;
        private System.Windows.Forms.Label lbCenaVypoctena;
        private System.Windows.Forms.RichTextBox rtbCestujici;
        private System.Windows.Forms.Label lbCestujici;
        private System.Windows.Forms.GroupBox gbTypPlatby;
        private System.Windows.Forms.RadioButton rbHotove;
        private System.Windows.Forms.RadioButton rbPrevodem;
        private System.Windows.Forms.Label lbKam;
        private System.Windows.Forms.TextBox tbKam;
        private System.Windows.Forms.Label lbOdkud;
        private System.Windows.Forms.TextBox tbOdkud;
        private System.Windows.Forms.Label lbKdy;
        private System.Windows.Forms.TextBox tbDen;
        private System.Windows.Forms.Button buttStorno;
        private System.Windows.Forms.GroupBox gbLetTam;
        private System.Windows.Forms.GroupBox gbZpatecniLet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOdkudZL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKamZL;
        private System.Windows.Forms.TextBox tbDenZL;
        private System.Windows.Forms.Label label3;
    }
}