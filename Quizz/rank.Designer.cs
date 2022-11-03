namespace Quizz
{
    partial class rank
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nom = new System.Windows.Forms.ColumnHeader();
            this.score = new System.Windows.Forms.ColumnHeader();
            this.niveau = new System.Windows.Forms.ColumnHeader();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.score,
            this.niveau});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(89, 124);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(344, 270);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 140;
            // 
            // score
            // 
            this.score.Text = "Score";
            this.score.Width = 100;
            // 
            // niveau
            // 
            this.niveau.Text = "Niveau";
            this.niveau.Width = 100;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "Tous les niveaux",
            "Niveau 1",
            "Niveau 2",
            "Niveau 3"});
            this.listBox1.Location = new System.Drawing.Point(573, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 28);
            this.listBox1.TabIndex = 1;
            // 
            // rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 530);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rank";
            this.Text = "rank";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader Nom;
        private ColumnHeader score;
        private ColumnHeader niveau;
        private ListBox listBox1;
    }
}