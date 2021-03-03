namespace NopeusPeli
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelPisteet = new System.Windows.Forms.Label();
            this.buttonAloitaPeli = new System.Windows.Forms.Button();
            this.buttonHSOpen = new System.Windows.Forms.Button();
            this.textBoxNimi = new System.Windows.Forms.TextBox();
            this.buttonLisaaHighScore = new System.Windows.Forms.Button();
            this.listViewHighScores = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.labelPeliPaattyi = new System.Windows.Forms.Label();
            this.timerPeliAIka = new System.Windows.Forms.Timer(this.components);
            this.labelAika = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.buttonOrange);
            this.groupBox1.Controls.Add(this.buttonGreen);
            this.groupBox1.Controls.Add(this.buttonYellow);
            this.groupBox1.Controls.Add(this.buttonRed);
            this.groupBox1.Location = new System.Drawing.Point(46, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonOrange
            // 
            this.buttonOrange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonOrange.Location = new System.Drawing.Point(517, 15);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(156, 104);
            this.buttonOrange.TabIndex = 0;
            this.buttonOrange.UseVisualStyleBackColor = false;
            // 
            // buttonGreen
            // 
            this.buttonGreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.Location = new System.Drawing.Point(355, 15);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(156, 104);
            this.buttonGreen.TabIndex = 0;
            this.buttonGreen.UseVisualStyleBackColor = false;
            // 
            // buttonYellow
            // 
            this.buttonYellow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonYellow.Location = new System.Drawing.Point(193, 15);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(156, 104);
            this.buttonYellow.TabIndex = 0;
            this.buttonYellow.UseVisualStyleBackColor = false;
            // 
            // buttonRed
            // 
            this.buttonRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRed.BackColor = System.Drawing.Color.Maroon;
            this.buttonRed.Location = new System.Drawing.Point(31, 15);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(156, 104);
            this.buttonRed.TabIndex = 0;
            this.buttonRed.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelPisteet
            // 
            this.labelPisteet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPisteet.AutoSize = true;
            this.labelPisteet.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPisteet.ForeColor = System.Drawing.Color.Lime;
            this.labelPisteet.Location = new System.Drawing.Point(362, 88);
            this.labelPisteet.Name = "labelPisteet";
            this.labelPisteet.Size = new System.Drawing.Size(88, 106);
            this.labelPisteet.TabIndex = 2;
            this.labelPisteet.Text = "0";
            this.labelPisteet.Visible = false;
            // 
            // buttonAloitaPeli
            // 
            this.buttonAloitaPeli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAloitaPeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAloitaPeli.Location = new System.Drawing.Point(239, 12);
            this.buttonAloitaPeli.Name = "buttonAloitaPeli";
            this.buttonAloitaPeli.Size = new System.Drawing.Size(318, 73);
            this.buttonAloitaPeli.TabIndex = 3;
            this.buttonAloitaPeli.Text = "Aloita peli";
            this.buttonAloitaPeli.UseVisualStyleBackColor = false;
            this.buttonAloitaPeli.Click += new System.EventHandler(this.buttonAloitaPeli_Click);
            // 
            // buttonHSOpen
            // 
            this.buttonHSOpen.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonHSOpen.Location = new System.Drawing.Point(13, 13);
            this.buttonHSOpen.Name = "buttonHSOpen";
            this.buttonHSOpen.Size = new System.Drawing.Size(211, 42);
            this.buttonHSOpen.TabIndex = 4;
            this.buttonHSOpen.Text = "HighScores";
            this.buttonHSOpen.UseVisualStyleBackColor = false;
            this.buttonHSOpen.Click += new System.EventHandler(this.buttonHSOpen_Click);
            // 
            // textBoxNimi
            // 
            this.textBoxNimi.Location = new System.Drawing.Point(239, 197);
            this.textBoxNimi.Name = "textBoxNimi";
            this.textBoxNimi.Size = new System.Drawing.Size(318, 27);
            this.textBoxNimi.TabIndex = 5;
            this.textBoxNimi.Visible = false;
            // 
            // buttonLisaaHighScore
            // 
            this.buttonLisaaHighScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonLisaaHighScore.Location = new System.Drawing.Point(239, 242);
            this.buttonLisaaHighScore.Name = "buttonLisaaHighScore";
            this.buttonLisaaHighScore.Size = new System.Drawing.Size(318, 53);
            this.buttonLisaaHighScore.TabIndex = 6;
            this.buttonLisaaHighScore.Text = "Tallenna tulos";
            this.buttonLisaaHighScore.UseVisualStyleBackColor = false;
            this.buttonLisaaHighScore.Visible = false;
            this.buttonLisaaHighScore.Click += new System.EventHandler(this.buttonLisaaHighScore_Click);
            // 
            // listViewHighScores
            // 
            this.listViewHighScores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewHighScores.HideSelection = false;
            this.listViewHighScores.Location = new System.Drawing.Point(13, 61);
            this.listViewHighScores.Name = "listViewHighScores";
            this.listViewHighScores.Size = new System.Drawing.Size(220, 365);
            this.listViewHighScores.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewHighScores.TabIndex = 7;
            this.listViewHighScores.UseCompatibleStateImageBehavior = false;
            this.listViewHighScores.View = System.Windows.Forms.View.Details;
            this.listViewHighScores.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pisteet";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nimi";
            // 
            // labelPeliPaattyi
            // 
            this.labelPeliPaattyi.AutoSize = true;
            this.labelPeliPaattyi.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPeliPaattyi.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelPeliPaattyi.Location = new System.Drawing.Point(180, 9);
            this.labelPeliPaattyi.Name = "labelPeliPaattyi";
            this.labelPeliPaattyi.Size = new System.Drawing.Size(453, 106);
            this.labelPeliPaattyi.TabIndex = 8;
            this.labelPeliPaattyi.Text = "Peli päättyi!";
            this.labelPeliPaattyi.Visible = false;
            // 
            // timerPeliAIka
            // 
            this.timerPeliAIka.Interval = 1000;
            this.timerPeliAIka.Tick += new System.EventHandler(this.timerPeliAIka_Tick);
            // 
            // labelAika
            // 
            this.labelAika.AutoSize = true;
            this.labelAika.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAika.ForeColor = System.Drawing.Color.Yellow;
            this.labelAika.Location = new System.Drawing.Point(446, 128);
            this.labelAika.Name = "labelAika";
            this.labelAika.Size = new System.Drawing.Size(0, 41);
            this.labelAika.TabIndex = 9;
            this.labelAika.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAika);
            this.Controls.Add(this.labelPeliPaattyi);
            this.Controls.Add(this.listViewHighScores);
            this.Controls.Add(this.buttonLisaaHighScore);
            this.Controls.Add(this.textBoxNimi);
            this.Controls.Add(this.buttonHSOpen);
            this.Controls.Add(this.buttonAloitaPeli);
            this.Controls.Add(this.labelPisteet);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Nopeustestipeli - Timo Mykkänen";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonRed;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelPisteet;
        private System.Windows.Forms.Button buttonAloitaPeli;
        private System.Windows.Forms.Button buttonHSOpen;
        public System.Windows.Forms.TextBox textBoxNimi;
        public System.Windows.Forms.Button buttonLisaaHighScore;
        private System.Windows.Forms.ListView listViewHighScores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.Label labelPeliPaattyi;
        public System.Windows.Forms.Timer timerPeliAIka;
        public System.Windows.Forms.Label labelAika;
    }
}

