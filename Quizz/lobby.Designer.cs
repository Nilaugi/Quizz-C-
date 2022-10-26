namespace Quizz
{
    partial class lobby
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBClose = new System.Windows.Forms.PictureBox();
            this.label_con = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_rank = new System.Windows.Forms.Button();
            this.btn_selec_lvl = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel_contenu = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).BeginInit();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.pBClose);
            this.panel1.Controls.Add(this.label_con);
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 32);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pBClose
            // 
            this.pBClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBClose.Image = global::Quizz.Properties.Resources.close;
            this.pBClose.Location = new System.Drawing.Point(798, 4);
            this.pBClose.Name = "pBClose";
            this.pBClose.Size = new System.Drawing.Size(26, 22);
            this.pBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBClose.TabIndex = 4;
            this.pBClose.TabStop = false;
            this.pBClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_con
            // 
            this.label_con.AutoSize = true;
            this.label_con.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_con.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_con.Location = new System.Drawing.Point(398, 4);
            this.label_con.Name = "label_con";
            this.label_con.Size = new System.Drawing.Size(45, 19);
            this.label_con.TabIndex = 3;
            this.label_con.Text = "Conn?";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_title.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(12, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(76, 23);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Quizzizz";
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_menu.Controls.Add(this.btn_rank);
            this.panel_menu.Controls.Add(this.btn_selec_lvl);
            this.panel_menu.Controls.Add(this.btn_login);
            this.panel_menu.Location = new System.Drawing.Point(0, 31);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(106, 401);
            this.panel_menu.TabIndex = 1;
            // 
            // btn_rank
            // 
            this.btn_rank.FlatAppearance.BorderSize = 0;
            this.btn_rank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rank.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_rank.Image = global::Quizz.Properties.Resources.pika_run;
            this.btn_rank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rank.Location = new System.Drawing.Point(-3, 367);
            this.btn_rank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_rank.Name = "btn_rank";
            this.btn_rank.Size = new System.Drawing.Size(107, 32);
            this.btn_rank.TabIndex = 2;
            this.btn_rank.Text = "  Classement";
            this.btn_rank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_rank.UseVisualStyleBackColor = true;
            // 
            // btn_selec_lvl
            // 
            this.btn_selec_lvl.FlatAppearance.BorderSize = 0;
            this.btn_selec_lvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selec_lvl.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_selec_lvl.Image = global::Quizz.Properties.Resources.game1;
            this.btn_selec_lvl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_selec_lvl.Location = new System.Drawing.Point(-2, 36);
            this.btn_selec_lvl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_selec_lvl.Name = "btn_selec_lvl";
            this.btn_selec_lvl.Size = new System.Drawing.Size(107, 32);
            this.btn_selec_lvl.TabIndex = 1;
            this.btn_selec_lvl.Text = "       Niveaux";
            this.btn_selec_lvl.UseVisualStyleBackColor = true;
            this.btn_selec_lvl.Click += new System.EventHandler(this.btn_selec_lvl_Click);
            // 
            // btn_login
            // 
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_login.Image = global::Quizz.Properties.Resources.imageonline_resizegif_4597902;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(-2, 0);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(107, 32);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "   Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel_contenu
            // 
            this.panel_contenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_contenu.Location = new System.Drawing.Point(101, 31);
            this.panel_contenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_contenu.Name = "panel_contenu";
            this.panel_contenu.Size = new System.Drawing.Size(736, 400);
            this.panel_contenu.TabIndex = 2;
            // 
            // lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 430);
            this.Controls.Add(this.panel_contenu);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "lobby";
            this.Text = "Quizzizz";
            this.Load += new System.EventHandler(this.lobby_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel_menu;
        private Label label_title;
        private Panel panel_contenu;
        private Button btn_login;
        private Button btn_selec_lvl;
        private Button btn_rank;
        private Label label_con;
        private PictureBox pBClose;
    }
}