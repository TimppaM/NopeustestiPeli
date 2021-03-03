namespace NopeusPeli
{
    partial class HighscoreForm
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
            this.listViewHighScores = new System.Windows.Forms.ListView();
            this.columnHeaderNimi = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPisteet = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listViewHighScores
            // 
            this.listViewHighScores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNimi,
            this.columnHeaderPisteet});
            this.listViewHighScores.HideSelection = false;
            this.listViewHighScores.Location = new System.Drawing.Point(90, 62);
            this.listViewHighScores.Name = "listViewHighScores";
            this.listViewHighScores.Size = new System.Drawing.Size(605, 478);
            this.listViewHighScores.TabIndex = 0;
            this.listViewHighScores.UseCompatibleStateImageBehavior = false;
            this.listViewHighScores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNimi
            // 
            this.columnHeaderNimi.Text = "Nimi";
            this.columnHeaderNimi.Width = 300;
            // 
            // columnHeaderPisteet
            // 
            this.columnHeaderPisteet.Text = "Pisteet";
            this.columnHeaderPisteet.Width = 300;
            // 
            // HighscoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 564);
            this.Controls.Add(this.listViewHighScores);
            this.Name = "HighscoreForm";
            this.Text = "HighscoreForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewHighScores;
        private System.Windows.Forms.ColumnHeader columnHeaderNimi;
        private System.Windows.Forms.ColumnHeader columnHeaderPisteet;
    }
}