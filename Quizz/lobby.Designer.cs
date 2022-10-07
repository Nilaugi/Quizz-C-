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
            this.label_title = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_rank = new System.Windows.Forms.Button();
            this.btn_selec_lvl = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel_contenu = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 43);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_title.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(14, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(91, 29);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Quizzzz";
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_menu.Controls.Add(this.btn_rank);
            this.panel_menu.Controls.Add(this.btn_selec_lvl);
            this.panel_menu.Controls.Add(this.btn_login);
            this.panel_menu.Location = new System.Drawing.Point(0, 41);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(121, 535);
            this.panel_menu.TabIndex = 1;
            // 
            // btn_rank
            // 
            this.btn_rank.FlatAppearance.BorderSize = 0;
            this.btn_rank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rank.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_rank.Image = global::Quizz.Properties.Resources.pika_run;
            this.btn_rank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rank.Location = new System.Drawing.Point(-3, 489);
            this.btn_rank.Name = "btn_rank";
            this.btn_rank.Size = new System.Drawing.Size(122, 43);
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
            this.btn_selec_lvl.Location = new System.Drawing.Point(-2, 48);
            this.btn_selec_lvl.Name = "btn_selec_lvl";
            this.btn_selec_lvl.Size = new System.Drawing.Size(122, 43);
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
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(122, 43);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "   Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel_contenu
            // 
            this.panel_contenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_contenu.Location = new System.Drawing.Point(115, 41);
            this.panel_contenu.Name = "panel_contenu";
            this.panel_contenu.Size = new System.Drawing.Size(841, 533);
            this.panel_contenu.TabIndex = 2;
            // 
            // lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 573);
            this.Controls.Add(this.panel_contenu);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lobby";
            this.Text = "lobby";
            this.Load += new System.EventHandler(this.lobby_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}