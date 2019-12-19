namespace Projekt_SBB
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab_suab = new System.Windows.Forms.TabControl();
            this.tab_suche = new System.Windows.Forms.TabPage();
            this.listBox_main = new System.Windows.Forms.ListBox();
            this.comboBox_nach = new System.Windows.Forms.ComboBox();
            this.comboBox_von = new System.Windows.Forms.ComboBox();
            this.label_von = new System.Windows.Forms.Label();
            this.label_nach = new System.Windows.Forms.Label();
            this.groupbox_sucherg = new System.Windows.Forms.GroupBox();
            this.groupbox_first = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_zeit = new System.Windows.Forms.Label();
            this.label_datum = new System.Windows.Forms.Label();
            this.button_verbindungsuchen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tab_abfahrtsplan = new System.Windows.Forms.TabPage();
            this.label_abfahrtsort = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox_abf_suche = new System.Windows.Forms.GroupBox();
            this.comboBox_abfahrtsplan = new System.Windows.Forms.ComboBox();
            this.buttonabf_verbsuchen = new System.Windows.Forms.Button();
            this.groupBox_abf_erg = new System.Windows.Forms.GroupBox();
            this.listBox_abfahrtsplan = new System.Windows.Forms.ListBox();
            this.tab_suab.SuspendLayout();
            this.tab_suche.SuspendLayout();
            this.groupbox_first.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab_abfahrtsplan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox_abf_suche.SuspendLayout();
            this.groupBox_abf_erg.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_suab
            // 
            this.tab_suab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_suab.Controls.Add(this.tab_suche);
            this.tab_suab.Controls.Add(this.tab_abfahrtsplan);
            this.tab_suab.Location = new System.Drawing.Point(0, 0);
            this.tab_suab.Name = "tab_suab";
            this.tab_suab.SelectedIndex = 0;
            this.tab_suab.Size = new System.Drawing.Size(1216, 791);
            this.tab_suab.TabIndex = 0;
            // 
            // tab_suche
            // 
            this.tab_suche.BackColor = System.Drawing.Color.White;
            this.tab_suche.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab_suche.BackgroundImage")));
            this.tab_suche.Controls.Add(this.listBox_main);
            this.tab_suche.Controls.Add(this.comboBox_nach);
            this.tab_suche.Controls.Add(this.comboBox_von);
            this.tab_suche.Controls.Add(this.label_von);
            this.tab_suche.Controls.Add(this.label_nach);
            this.tab_suche.Controls.Add(this.groupbox_sucherg);
            this.tab_suche.Controls.Add(this.groupbox_first);
            this.tab_suche.Controls.Add(this.pictureBox1);
            this.tab_suche.Location = new System.Drawing.Point(4, 25);
            this.tab_suche.Name = "tab_suche";
            this.tab_suche.Padding = new System.Windows.Forms.Padding(3);
            this.tab_suche.Size = new System.Drawing.Size(1208, 762);
            this.tab_suche.TabIndex = 0;
            this.tab_suche.Text = "Suche";
            // 
            // listBox_main
            // 
            this.listBox_main.BackColor = System.Drawing.Color.Gainsboro;
            this.listBox_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_main.FormattingEnabled = true;
            this.listBox_main.ItemHeight = 18;
            this.listBox_main.Location = new System.Drawing.Point(43, 399);
            this.listBox_main.Name = "listBox_main";
            this.listBox_main.Size = new System.Drawing.Size(1106, 328);
            this.listBox_main.TabIndex = 11;
            // 
            // comboBox_nach
            // 
            this.comboBox_nach.FormattingEnabled = true;
            this.comboBox_nach.Location = new System.Drawing.Point(141, 283);
            this.comboBox_nach.Name = "comboBox_nach";
            this.comboBox_nach.Size = new System.Drawing.Size(240, 24);
            this.comboBox_nach.TabIndex = 9;
            this.comboBox_nach.DropDown += new System.EventHandler(this.comboBox_nach_DropDown);
            // 
            // comboBox_von
            // 
            this.comboBox_von.ForeColor = System.Drawing.Color.Black;
            this.comboBox_von.FormattingEnabled = true;
            this.comboBox_von.Location = new System.Drawing.Point(141, 218);
            this.comboBox_von.Name = "comboBox_von";
            this.comboBox_von.Size = new System.Drawing.Size(240, 24);
            this.comboBox_von.TabIndex = 8;
            this.comboBox_von.DropDown += new System.EventHandler(this.comboBox_von_DropDown);
            // 
            // label_von
            // 
            this.label_von.AutoSize = true;
            this.label_von.BackColor = System.Drawing.Color.Transparent;
            this.label_von.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_von.ForeColor = System.Drawing.Color.Red;
            this.label_von.Location = new System.Drawing.Point(53, 217);
            this.label_von.Name = "label_von";
            this.label_von.Size = new System.Drawing.Size(58, 25);
            this.label_von.TabIndex = 1;
            this.label_von.Text = "Von:";
            // 
            // label_nach
            // 
            this.label_nach.AutoSize = true;
            this.label_nach.BackColor = System.Drawing.Color.Transparent;
            this.label_nach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nach.ForeColor = System.Drawing.Color.Red;
            this.label_nach.Location = new System.Drawing.Point(53, 282);
            this.label_nach.Name = "label_nach";
            this.label_nach.Size = new System.Drawing.Size(69, 25);
            this.label_nach.TabIndex = 2;
            this.label_nach.Text = "Nach:";
            // 
            // groupbox_sucherg
            // 
            this.groupbox_sucherg.BackColor = System.Drawing.Color.Transparent;
            this.groupbox_sucherg.Location = new System.Drawing.Point(19, 354);
            this.groupbox_sucherg.Name = "groupbox_sucherg";
            this.groupbox_sucherg.Size = new System.Drawing.Size(1159, 399);
            this.groupbox_sucherg.TabIndex = 16;
            this.groupbox_sucherg.TabStop = false;
            this.groupbox_sucherg.Text = "Suchergebnis";
            // 
            // groupbox_first
            // 
            this.groupbox_first.BackColor = System.Drawing.Color.Transparent;
            this.groupbox_first.Controls.Add(this.dateTimePicker1);
            this.groupbox_first.Controls.Add(this.label_zeit);
            this.groupbox_first.Controls.Add(this.label_datum);
            this.groupbox_first.Controls.Add(this.button_verbindungsuchen);
            this.groupbox_first.Location = new System.Drawing.Point(19, 188);
            this.groupbox_first.Name = "groupbox_first";
            this.groupbox_first.Size = new System.Drawing.Size(731, 146);
            this.groupbox_first.TabIndex = 15;
            this.groupbox_first.TabStop = false;
            this.groupbox_first.Text = "Suche";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(398, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label_zeit
            // 
            this.label_zeit.AutoSize = true;
            this.label_zeit.BackColor = System.Drawing.Color.White;
            this.label_zeit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_zeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_zeit.Location = new System.Drawing.Point(590, 10);
            this.label_zeit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_zeit.Name = "label_zeit";
            this.label_zeit.Size = new System.Drawing.Size(38, 19);
            this.label_zeit.TabIndex = 20;
            this.label_zeit.Text = "Zeit";
            // 
            // label_datum
            // 
            this.label_datum.AutoSize = true;
            this.label_datum.BackColor = System.Drawing.Color.White;
            this.label_datum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_datum.Location = new System.Drawing.Point(398, 9);
            this.label_datum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_datum.Name = "label_datum";
            this.label_datum.Size = new System.Drawing.Size(56, 19);
            this.label_datum.TabIndex = 19;
            this.label_datum.Text = "Datum";
            // 
            // button_verbindungsuchen
            // 
            this.button_verbindungsuchen.BackColor = System.Drawing.Color.Red;
            this.button_verbindungsuchen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_verbindungsuchen.ForeColor = System.Drawing.Color.White;
            this.button_verbindungsuchen.Location = new System.Drawing.Point(399, 77);
            this.button_verbindungsuchen.Name = "button_verbindungsuchen";
            this.button_verbindungsuchen.Size = new System.Drawing.Size(229, 58);
            this.button_verbindungsuchen.TabIndex = 7;
            this.button_verbindungsuchen.Text = "Verbindung suchen";
            this.button_verbindungsuchen.UseVisualStyleBackColor = false;
            this.button_verbindungsuchen.Click += new System.EventHandler(this.button_verbindungsuchen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 137);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tab_abfahrtsplan
            // 
            this.tab_abfahrtsplan.BackColor = System.Drawing.Color.White;
            this.tab_abfahrtsplan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab_abfahrtsplan.BackgroundImage")));
            this.tab_abfahrtsplan.Controls.Add(this.label_abfahrtsort);
            this.tab_abfahrtsplan.Controls.Add(this.pictureBox2);
            this.tab_abfahrtsplan.Controls.Add(this.groupBox_abf_suche);
            this.tab_abfahrtsplan.Controls.Add(this.groupBox_abf_erg);
            this.tab_abfahrtsplan.Location = new System.Drawing.Point(4, 25);
            this.tab_abfahrtsplan.Name = "tab_abfahrtsplan";
            this.tab_abfahrtsplan.Padding = new System.Windows.Forms.Padding(3);
            this.tab_abfahrtsplan.Size = new System.Drawing.Size(1208, 762);
            this.tab_abfahrtsplan.TabIndex = 1;
            this.tab_abfahrtsplan.Text = "Abfahrtsplan";
            // 
            // label_abfahrtsort
            // 
            this.label_abfahrtsort.AutoSize = true;
            this.label_abfahrtsort.BackColor = System.Drawing.Color.Transparent;
            this.label_abfahrtsort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_abfahrtsort.ForeColor = System.Drawing.Color.Transparent;
            this.label_abfahrtsort.Location = new System.Drawing.Point(73, 201);
            this.label_abfahrtsort.Name = "label_abfahrtsort";
            this.label_abfahrtsort.Size = new System.Drawing.Size(125, 25);
            this.label_abfahrtsort.TabIndex = 16;
            this.label_abfahrtsort.Text = "Abfahrtsort:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(330, 133);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox_abf_suche
            // 
            this.groupBox_abf_suche.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_abf_suche.Controls.Add(this.comboBox_abfahrtsplan);
            this.groupBox_abf_suche.Controls.Add(this.buttonabf_verbsuchen);
            this.groupBox_abf_suche.Location = new System.Drawing.Point(23, 175);
            this.groupBox_abf_suche.Name = "groupBox_abf_suche";
            this.groupBox_abf_suche.Size = new System.Drawing.Size(821, 156);
            this.groupBox_abf_suche.TabIndex = 18;
            this.groupBox_abf_suche.TabStop = false;
            this.groupBox_abf_suche.Text = "Suche";
            // 
            // comboBox_abfahrtsplan
            // 
            this.comboBox_abfahrtsplan.ForeColor = System.Drawing.Color.Black;
            this.comboBox_abfahrtsplan.FormattingEnabled = true;
            this.comboBox_abfahrtsplan.Location = new System.Drawing.Point(214, 26);
            this.comboBox_abfahrtsplan.Name = "comboBox_abfahrtsplan";
            this.comboBox_abfahrtsplan.Size = new System.Drawing.Size(312, 24);
            this.comboBox_abfahrtsplan.TabIndex = 17;
            this.comboBox_abfahrtsplan.DropDown += new System.EventHandler(this.comboBox_abfahrtsplan_DropDown);
            // 
            // buttonabf_verbsuchen
            // 
            this.buttonabf_verbsuchen.BackColor = System.Drawing.Color.Red;
            this.buttonabf_verbsuchen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonabf_verbsuchen.ForeColor = System.Drawing.Color.White;
            this.buttonabf_verbsuchen.Location = new System.Drawing.Point(214, 70);
            this.buttonabf_verbsuchen.Name = "buttonabf_verbsuchen";
            this.buttonabf_verbsuchen.Size = new System.Drawing.Size(312, 58);
            this.buttonabf_verbsuchen.TabIndex = 8;
            this.buttonabf_verbsuchen.Text = "Verbindung suchen";
            this.buttonabf_verbsuchen.UseVisualStyleBackColor = false;
            this.buttonabf_verbsuchen.Click += new System.EventHandler(this.buttonabf_verbsuchen_Click);
            // 
            // groupBox_abf_erg
            // 
            this.groupBox_abf_erg.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_abf_erg.Controls.Add(this.listBox_abfahrtsplan);
            this.groupBox_abf_erg.Location = new System.Drawing.Point(26, 357);
            this.groupBox_abf_erg.Name = "groupBox_abf_erg";
            this.groupBox_abf_erg.Size = new System.Drawing.Size(1135, 386);
            this.groupBox_abf_erg.TabIndex = 19;
            this.groupBox_abf_erg.TabStop = false;
            this.groupBox_abf_erg.Text = "Suchergebnis";
            // 
            // listBox_abfahrtsplan
            // 
            this.listBox_abfahrtsplan.BackColor = System.Drawing.Color.Gainsboro;
            this.listBox_abfahrtsplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_abfahrtsplan.FormattingEnabled = true;
            this.listBox_abfahrtsplan.ItemHeight = 18;
            this.listBox_abfahrtsplan.Location = new System.Drawing.Point(14, 29);
            this.listBox_abfahrtsplan.Name = "listBox_abfahrtsplan";
            this.listBox_abfahrtsplan.Size = new System.Drawing.Size(1106, 346);
            this.listBox_abfahrtsplan.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 790);
            this.Controls.Add(this.tab_suab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tab_suab.ResumeLayout(false);
            this.tab_suche.ResumeLayout(false);
            this.tab_suche.PerformLayout();
            this.groupbox_first.ResumeLayout(false);
            this.groupbox_first.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab_abfahrtsplan.ResumeLayout(false);
            this.tab_abfahrtsplan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox_abf_suche.ResumeLayout(false);
            this.groupBox_abf_erg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_suab;
        private System.Windows.Forms.TabPage tab_suche;
        private System.Windows.Forms.Label label_von;
        private System.Windows.Forms.Label label_nach;
        private System.Windows.Forms.TabPage tab_abfahrtsplan;
        private System.Windows.Forms.Button button_verbindungsuchen;
        private System.Windows.Forms.ComboBox comboBox_von;
        private System.Windows.Forms.ComboBox comboBox_nach;
        private System.Windows.Forms.ListBox listBox_main;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupbox_first;
        private System.Windows.Forms.GroupBox groupbox_sucherg;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_abfahrtsplan;
        private System.Windows.Forms.Label label_abfahrtsort;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox_abf_suche;
        private System.Windows.Forms.Label label_zeit;
        private System.Windows.Forms.Label label_datum;
        private System.Windows.Forms.Button buttonabf_verbsuchen;
        private System.Windows.Forms.GroupBox groupBox_abf_erg;
        private System.Windows.Forms.ListBox listBox_abfahrtsplan;
    }
}

