namespace FormsTehtava23
{
    partial class LisaaHighscore
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
            this.textBoxPelaajanNimi = new System.Windows.Forms.TextBox();
            this.labelNimi = new System.Windows.Forms.Label();
            this.buttonLisaaScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPelaajanNimi
            // 
            this.textBoxPelaajanNimi.Location = new System.Drawing.Point(168, 84);
            this.textBoxPelaajanNimi.Name = "textBoxPelaajanNimi";
            this.textBoxPelaajanNimi.Size = new System.Drawing.Size(414, 27);
            this.textBoxPelaajanNimi.TabIndex = 0;
            // 
            // labelNimi
            // 
            this.labelNimi.AutoSize = true;
            this.labelNimi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNimi.Location = new System.Drawing.Point(67, 70);
            this.labelNimi.Name = "labelNimi";
            this.labelNimi.Size = new System.Drawing.Size(80, 41);
            this.labelNimi.TabIndex = 1;
            this.labelNimi.Text = "Nimi";
            // 
            // buttonLisaaScore
            // 
            this.buttonLisaaScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonLisaaScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLisaaScore.Location = new System.Drawing.Point(168, 217);
            this.buttonLisaaScore.Name = "buttonLisaaScore";
            this.buttonLisaaScore.Size = new System.Drawing.Size(414, 67);
            this.buttonLisaaScore.TabIndex = 2;
            this.buttonLisaaScore.Text = "Tallenna tulos";
            this.buttonLisaaScore.UseVisualStyleBackColor = false;
            this.buttonLisaaScore.Click += new System.EventHandler(this.buttonLisaaScore_Click);
            // 
            // LisaaHighscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLisaaScore);
            this.Controls.Add(this.labelNimi);
            this.Controls.Add(this.textBoxPelaajanNimi);
            this.Name = "LisaaHighscore";
            this.Text = "LisaaHighscore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPelaajanNimi;
        private System.Windows.Forms.Label labelNimi;
        private System.Windows.Forms.Button buttonLisaaScore;
    }
}