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
            this.tab_suab = new System.Windows.Forms.TabControl();
            this.tab_suche = new System.Windows.Forms.TabPage();
            this.comboBox_nach = new System.Windows.Forms.ComboBox();
            this.comboBox_von = new System.Windows.Forms.ComboBox();
            this.button_verbindungsuchen = new System.Windows.Forms.Button();
            this.dateTimePicker_nach = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_von = new System.Windows.Forms.DateTimePicker();
            this.label_von = new System.Windows.Forms.Label();
            this.label_nach = new System.Windows.Forms.Label();
            this.label_sbbtitle = new System.Windows.Forms.Label();
            this.tab_abfahrtsplan = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tab_suab.SuspendLayout();
            this.tab_suche.SuspendLayout();
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
            this.tab_suab.Size = new System.Drawing.Size(1106, 791);
            this.tab_suab.TabIndex = 0;
            // 
            // tab_suche
            // 
            this.tab_suche.BackColor = System.Drawing.Color.White;
            this.tab_suche.Controls.Add(this.treeView1);
            this.tab_suche.Controls.Add(this.comboBox_nach);
            this.tab_suche.Controls.Add(this.comboBox_von);
            this.tab_suche.Controls.Add(this.button_verbindungsuchen);
            this.tab_suche.Controls.Add(this.dateTimePicker_nach);
            this.tab_suche.Controls.Add(this.dateTimePicker_von);
            this.tab_suche.Controls.Add(this.label_von);
            this.tab_suche.Controls.Add(this.label_nach);
            this.tab_suche.Controls.Add(this.label_sbbtitle);
            this.tab_suche.Location = new System.Drawing.Point(4, 25);
            this.tab_suche.Name = "tab_suche";
            this.tab_suche.Padding = new System.Windows.Forms.Padding(3);
            this.tab_suche.Size = new System.Drawing.Size(1098, 762);
            this.tab_suche.TabIndex = 0;
            this.tab_suche.Text = "Suche";
            // 
            // comboBox_nach
            // 
            this.comboBox_nach.FormattingEnabled = true;
            this.comboBox_nach.Location = new System.Drawing.Point(141, 196);
            this.comboBox_nach.Name = "comboBox_nach";
            this.comboBox_nach.Size = new System.Drawing.Size(218, 24);
            this.comboBox_nach.TabIndex = 9;
            this.comboBox_nach.DropDown += new System.EventHandler(this.comboBox_nach_DropDown);
            // 
            // comboBox_von
            // 
            this.comboBox_von.FormattingEnabled = true;
            this.comboBox_von.Location = new System.Drawing.Point(141, 110);
            this.comboBox_von.Name = "comboBox_von";
            this.comboBox_von.Size = new System.Drawing.Size(218, 24);
            this.comboBox_von.TabIndex = 8;
            this.comboBox_von.DropDown += new System.EventHandler(this.comboBox_von_DropDown);
            // 
            // button_verbindungsuchen
            // 
            this.button_verbindungsuchen.Location = new System.Drawing.Point(516, 265);
            this.button_verbindungsuchen.Name = "button_verbindungsuchen";
            this.button_verbindungsuchen.Size = new System.Drawing.Size(156, 58);
            this.button_verbindungsuchen.TabIndex = 7;
            this.button_verbindungsuchen.Text = "Verbindung suchen";
            this.button_verbindungsuchen.UseVisualStyleBackColor = true;
            this.button_verbindungsuchen.Click += new System.EventHandler(this.button_verbindungsuchen_Click);
            // 
            // dateTimePicker_nach
            // 
            this.dateTimePicker_nach.Location = new System.Drawing.Point(428, 196);
            this.dateTimePicker_nach.Name = "dateTimePicker_nach";
            this.dateTimePicker_nach.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker_nach.TabIndex = 6;
            // 
            // dateTimePicker_von
            // 
            this.dateTimePicker_von.Location = new System.Drawing.Point(428, 113);
            this.dateTimePicker_von.Name = "dateTimePicker_von";
            this.dateTimePicker_von.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker_von.TabIndex = 5;
            // 
            // label_von
            // 
            this.label_von.AutoSize = true;
            this.label_von.Location = new System.Drawing.Point(55, 113);
            this.label_von.Name = "label_von";
            this.label_von.Size = new System.Drawing.Size(37, 17);
            this.label_von.TabIndex = 1;
            this.label_von.Text = "Von:";
            // 
            // label_nach
            // 
            this.label_nach.AutoSize = true;
            this.label_nach.Location = new System.Drawing.Point(55, 196);
            this.label_nach.Name = "label_nach";
            this.label_nach.Size = new System.Drawing.Size(45, 17);
            this.label_nach.TabIndex = 2;
            this.label_nach.Text = "Nach:";
            // 
            // label_sbbtitle
            // 
            this.label_sbbtitle.AutoSize = true;
            this.label_sbbtitle.ForeColor = System.Drawing.Color.DarkRed;
            this.label_sbbtitle.Location = new System.Drawing.Point(47, 35);
            this.label_sbbtitle.Name = "label_sbbtitle";
            this.label_sbbtitle.Size = new System.Drawing.Size(35, 17);
            this.label_sbbtitle.TabIndex = 0;
            this.label_sbbtitle.Text = "SBB";
            // 
            // tab_abfahrtsplan
            // 
            this.tab_abfahrtsplan.BackColor = System.Drawing.Color.White;
            this.tab_abfahrtsplan.Location = new System.Drawing.Point(4, 25);
            this.tab_abfahrtsplan.Name = "tab_abfahrtsplan";
            this.tab_abfahrtsplan.Padding = new System.Windows.Forms.Padding(3);
            this.tab_abfahrtsplan.Size = new System.Drawing.Size(1098, 762);
            this.tab_abfahrtsplan.TabIndex = 1;
            this.tab_abfahrtsplan.Text = "Abfahrtsplan";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(58, 404);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(830, 96);
            this.treeView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 790);
            this.Controls.Add(this.tab_suab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tab_suab.ResumeLayout(false);
            this.tab_suche.ResumeLayout(false);
            this.tab_suche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_suab;
        private System.Windows.Forms.TabPage tab_suche;
        private System.Windows.Forms.Label label_von;
        private System.Windows.Forms.Label label_nach;
        private System.Windows.Forms.Label label_sbbtitle;
        private System.Windows.Forms.TabPage tab_abfahrtsplan;
        private System.Windows.Forms.DateTimePicker dateTimePicker_von;
        private System.Windows.Forms.Button button_verbindungsuchen;
        private System.Windows.Forms.DateTimePicker dateTimePicker_nach;
        private System.Windows.Forms.ComboBox comboBox_von;
        private System.Windows.Forms.ComboBox comboBox_nach;
        private System.Windows.Forms.TreeView treeView1;
    }
}

