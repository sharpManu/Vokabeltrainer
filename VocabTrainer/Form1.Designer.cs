namespace VocabTrainer
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
            this.lb_learn = new System.Windows.Forms.Label();
            this.lb_amountWords = new System.Windows.Forms.Label();
            this.lb_eng = new System.Windows.Forms.Label();
            this.lb_ger = new System.Windows.Forms.Label();
            this.lb_check = new System.Windows.Forms.Label();
            this.lb_add = new System.Windows.Forms.Label();
            this.lb_ger2 = new System.Windows.Forms.Label();
            this.lb_eng2 = new System.Windows.Forms.Label();
            this.tb_amountWords = new System.Windows.Forms.TextBox();
            this.tb_Eng1 = new System.Windows.Forms.TextBox();
            this.tb_Ger1 = new System.Windows.Forms.TextBox();
            this.tb_Check = new System.Windows.Forms.TextBox();
            this.tb_Eng2 = new System.Windows.Forms.TextBox();
            this.tb_Ger2 = new System.Windows.Forms.TextBox();
            this.btn_startFromFile = new System.Windows.Forms.Button();
            this.btn_cancel_top = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_stats = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_saveInFile = new System.Windows.Forms.Button();
            this.btn_switch = new System.Windows.Forms.Button();
            this.lbl_bewertung = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Try = new System.Windows.Forms.Label();
            this.lbl_Right = new System.Windows.Forms.Label();
            this.lbl_Wrong = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_learn
            // 
            this.lb_learn.AutoSize = true;
            this.lb_learn.BackColor = System.Drawing.Color.Red;
            this.lb_learn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_learn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_learn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_learn.Location = new System.Drawing.Point(36, 41);
            this.lb_learn.Name = "lb_learn";
            this.lb_learn.Size = new System.Drawing.Size(105, 15);
            this.lb_learn.TabIndex = 0;
            this.lb_learn.Text = "Vokabeln lernen:";
            // 
            // lb_amountWords
            // 
            this.lb_amountWords.AutoSize = true;
            this.lb_amountWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_amountWords.Location = new System.Drawing.Point(37, 67);
            this.lb_amountWords.Name = "lb_amountWords";
            this.lb_amountWords.Size = new System.Drawing.Size(87, 13);
            this.lb_amountWords.TabIndex = 1;
            this.lb_amountWords.Text = "Anzahl Wörter";
            // 
            // lb_eng
            // 
            this.lb_eng.AutoSize = true;
            this.lb_eng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_eng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_eng.Location = new System.Drawing.Point(37, 106);
            this.lb_eng.Name = "lb_eng";
            this.lb_eng.Size = new System.Drawing.Size(57, 15);
            this.lb_eng.TabIndex = 2;
            this.lb_eng.Text = "Englisch";
            // 
            // lb_ger
            // 
            this.lb_ger.AutoSize = true;
            this.lb_ger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_ger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ger.Location = new System.Drawing.Point(208, 106);
            this.lb_ger.Name = "lb_ger";
            this.lb_ger.Size = new System.Drawing.Size(56, 15);
            this.lb_ger.TabIndex = 3;
            this.lb_ger.Text = "Deutsch";
            // 
            // lb_check
            // 
            this.lb_check.AutoSize = true;
            this.lb_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_check.Location = new System.Drawing.Point(37, 161);
            this.lb_check.Name = "lb_check";
            this.lb_check.Size = new System.Drawing.Size(73, 13);
            this.lb_check.TabIndex = 4;
            this.lb_check.Text = "Auswertung";
            // 
            // lb_add
            // 
            this.lb_add.AutoSize = true;
            this.lb_add.BackColor = System.Drawing.Color.LimeGreen;
            this.lb_add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_add.Location = new System.Drawing.Point(32, 240);
            this.lb_add.Name = "lb_add";
            this.lb_add.Size = new System.Drawing.Size(152, 15);
            this.lb_add.TabIndex = 5;
            this.lb_add.Text = "Neue Vokabeln erfassen:";
            // 
            // lb_ger2
            // 
            this.lb_ger2.AutoSize = true;
            this.lb_ger2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_ger2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ger2.Location = new System.Drawing.Point(35, 274);
            this.lb_ger2.Name = "lb_ger2";
            this.lb_ger2.Size = new System.Drawing.Size(57, 15);
            this.lb_ger2.TabIndex = 6;
            this.lb_ger2.Text = "Englisch";
            // 
            // lb_eng2
            // 
            this.lb_eng2.AutoSize = true;
            this.lb_eng2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_eng2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_eng2.Location = new System.Drawing.Point(211, 274);
            this.lb_eng2.Name = "lb_eng2";
            this.lb_eng2.Size = new System.Drawing.Size(56, 15);
            this.lb_eng2.TabIndex = 7;
            this.lb_eng2.Text = "Deutsch";
            // 
            // tb_amountWords
            // 
            this.tb_amountWords.Location = new System.Drawing.Point(129, 64);
            this.tb_amountWords.Name = "tb_amountWords";
            this.tb_amountWords.Size = new System.Drawing.Size(68, 20);
            this.tb_amountWords.TabIndex = 8;
            // 
            // tb_Eng1
            // 
            this.tb_Eng1.Location = new System.Drawing.Point(39, 122);
            this.tb_Eng1.Name = "tb_Eng1";
            this.tb_Eng1.Size = new System.Drawing.Size(96, 20);
            this.tb_Eng1.TabIndex = 9;
            this.tb_Eng1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Eng1_KeyPress);
            // 
            // tb_Ger1
            // 
            this.tb_Ger1.Location = new System.Drawing.Point(211, 122);
            this.tb_Ger1.Name = "tb_Ger1";
            this.tb_Ger1.ReadOnly = true;
            this.tb_Ger1.Size = new System.Drawing.Size(100, 20);
            this.tb_Ger1.TabIndex = 10;
            // 
            // tb_Check
            // 
            this.tb_Check.Location = new System.Drawing.Point(39, 177);
            this.tb_Check.Name = "tb_Check";
            this.tb_Check.ReadOnly = true;
            this.tb_Check.Size = new System.Drawing.Size(293, 20);
            this.tb_Check.TabIndex = 11;
            // 
            // tb_Eng2
            // 
            this.tb_Eng2.Location = new System.Drawing.Point(35, 292);
            this.tb_Eng2.Name = "tb_Eng2";
            this.tb_Eng2.Size = new System.Drawing.Size(100, 20);
            this.tb_Eng2.TabIndex = 12;
            // 
            // tb_Ger2
            // 
            this.tb_Ger2.Location = new System.Drawing.Point(211, 292);
            this.tb_Ger2.Name = "tb_Ger2";
            this.tb_Ger2.Size = new System.Drawing.Size(100, 20);
            this.tb_Ger2.TabIndex = 13;
            // 
            // btn_startFromFile
            // 
            this.btn_startFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startFromFile.Location = new System.Drawing.Point(432, 12);
            this.btn_startFromFile.Name = "btn_startFromFile";
            this.btn_startFromFile.Size = new System.Drawing.Size(135, 23);
            this.btn_startFromFile.TabIndex = 14;
            this.btn_startFromFile.Text = "Start aus Datei";
            this.btn_startFromFile.UseVisualStyleBackColor = true;
            this.btn_startFromFile.Click += new System.EventHandler(this.btn_startFromFile_Click_1);
            // 
            // btn_cancel_top
            // 
            this.btn_cancel_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_top.Location = new System.Drawing.Point(432, 41);
            this.btn_cancel_top.Name = "btn_cancel_top";
            this.btn_cancel_top.Size = new System.Drawing.Size(135, 23);
            this.btn_cancel_top.TabIndex = 15;
            this.btn_cancel_top.Text = "Abbruch";
            this.btn_cancel_top.UseVisualStyleBackColor = true;
            this.btn_cancel_top.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_stats
            // 
            this.btn_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stats.Location = new System.Drawing.Point(35, 396);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(98, 23);
            this.btn_stats.TabIndex = 21;
            this.btn_stats.Text = "Statistik";
            this.btn_stats.UseVisualStyleBackColor = true;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(35, 318);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 23);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_saveInFile
            // 
            this.btn_saveInFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveInFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveInFile.Location = new System.Drawing.Point(211, 318);
            this.btn_saveInFile.Name = "btn_saveInFile";
            this.btn_saveInFile.Size = new System.Drawing.Size(129, 23);
            this.btn_saveInFile.TabIndex = 17;
            this.btn_saveInFile.Text = "Speichern in Datei";
            this.btn_saveInFile.UseVisualStyleBackColor = true;
            this.btn_saveInFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // btn_switch
            // 
            this.btn_switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_switch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_switch.Location = new System.Drawing.Point(432, 70);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(135, 23);
            this.btn_switch.TabIndex = 19;
            this.btn_switch.Text = "Lernen";
            this.btn_switch.UseVisualStyleBackColor = true;
            this.btn_switch.Click += new System.EventHandler(this.btn_switch_Click);
            // 
            // lbl_bewertung
            // 
            this.lbl_bewertung.AutoSize = true;
            this.lbl_bewertung.Location = new System.Drawing.Point(12, 252);
            this.lbl_bewertung.Name = "lbl_bewertung";
            this.lbl_bewertung.Size = new System.Drawing.Size(0, 13);
            this.lbl_bewertung.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hilfeToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            this.dateiToolStripMenuItem.Click += new System.EventHandler(this.dateiToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            this.hilfeToolStripMenuItem.Click += new System.EventHandler(this.hilfeToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetToolStripMenuItem.Text = "Neustarten";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Schließen";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lbl_Try
            // 
            this.lbl_Try.AutoSize = true;
            this.lbl_Try.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Try.Location = new System.Drawing.Point(432, 128);
            this.lbl_Try.Name = "lbl_Try";
            this.lbl_Try.Size = new System.Drawing.Size(2, 15);
            this.lbl_Try.TabIndex = 25;
            // 
            // lbl_Right
            // 
            this.lbl_Right.AutoSize = true;
            this.lbl_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Right.Location = new System.Drawing.Point(432, 145);
            this.lbl_Right.Name = "lbl_Right";
            this.lbl_Right.Size = new System.Drawing.Size(2, 15);
            this.lbl_Right.TabIndex = 26;
            // 
            // lbl_Wrong
            // 
            this.lbl_Wrong.AutoSize = true;
            this.lbl_Wrong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Wrong.Location = new System.Drawing.Point(432, 161);
            this.lbl_Wrong.Name = "lbl_Wrong";
            this.lbl_Wrong.Size = new System.Drawing.Size(2, 15);
            this.lbl_Wrong.TabIndex = 27;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.circularProgressBar1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.circularProgressBar1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.circularProgressBar1.Location = new System.Drawing.Point(179, 12);
            this.circularProgressBar1.Maximum = ((long)(100));
            this.circularProgressBar1.MinimumSize = new System.Drawing.Size(100, 100);
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.circularProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.circularProgressBar1.ProgressShape = CircularProgressBar._ProgressShape.Round;
            this.circularProgressBar1.Size = new System.Drawing.Size(229, 229);
            this.circularProgressBar1.TabIndex = 22;
            this.circularProgressBar1.Value = ((long)(0));
            this.circularProgressBar1.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(591, 431);
            this.Controls.Add(this.lbl_Wrong);
            this.Controls.Add(this.lbl_Right);
            this.Controls.Add(this.lbl_Try);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.lbl_bewertung);
            this.Controls.Add(this.btn_switch);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.btn_saveInFile);
            this.Controls.Add(this.btn_cancel_top);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_startFromFile);
            this.Controls.Add(this.tb_Ger2);
            this.Controls.Add(this.tb_Eng2);
            this.Controls.Add(this.tb_Check);
            this.Controls.Add(this.tb_Ger1);
            this.Controls.Add(this.tb_Eng1);
            this.Controls.Add(this.tb_amountWords);
            this.Controls.Add(this.lb_eng2);
            this.Controls.Add(this.lb_ger2);
            this.Controls.Add(this.lb_add);
            this.Controls.Add(this.lb_check);
            this.Controls.Add(this.lb_ger);
            this.Controls.Add(this.lb_eng);
            this.Controls.Add(this.lb_amountWords);
            this.Controls.Add(this.lb_learn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Vokabeltrainer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_learn;
        private System.Windows.Forms.Label lb_amountWords;
        private System.Windows.Forms.Label lb_eng;
        private System.Windows.Forms.Label lb_ger;
        private System.Windows.Forms.Label lb_check;
        private System.Windows.Forms.Label lb_add;
        private System.Windows.Forms.Label lb_ger2;
        private System.Windows.Forms.Label lb_eng2;
        private System.Windows.Forms.TextBox tb_amountWords;
        private System.Windows.Forms.TextBox tb_Eng1;
        private System.Windows.Forms.TextBox tb_Ger1;
        private System.Windows.Forms.TextBox tb_Check;
        private System.Windows.Forms.TextBox tb_Eng2;
        private System.Windows.Forms.TextBox tb_Ger2;
        private System.Windows.Forms.Button btn_startFromFile;
        private System.Windows.Forms.Button btn_cancel_top;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_stats;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_saveInFile;
        private System.Windows.Forms.Button btn_switch;
        private CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label lbl_bewertung;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Try;
        private System.Windows.Forms.Label lbl_Right;
        private System.Windows.Forms.Label lbl_Wrong;
    }
}

