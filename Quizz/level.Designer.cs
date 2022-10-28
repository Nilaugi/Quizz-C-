namespace Quizz
{
    partial class level
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
            this.components = new System.ComponentModel.Container();
            this.label_niveau = new System.Windows.Forms.Label();
            this.btn_repA = new System.Windows.Forms.Button();
            this.btn_repB = new System.Windows.Forms.Button();
            this.btn_repC = new System.Windows.Forms.Button();
            this.btn_repD = new System.Windows.Forms.Button();
            this.label_question = new System.Windows.Forms.Label();
            this.label_n_q = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_rank = new System.Windows.Forms.Label();
            this.panel_correction = new System.Windows.Forms.Panel();
            this.label_correction = new System.Windows.Forms.Label();
            this.timer_correction = new System.Windows.Forms.Timer(this.components);
            this.panel_wait = new System.Windows.Forms.Panel();
            this.probar_timer = new CircularProgressBar.CircularProgressBar();
            this.timer_user = new System.Windows.Forms.Timer(this.components);
            this.panel_correction.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_niveau
            // 
            this.label_niveau.AutoSize = true;
            this.label_niveau.BackColor = System.Drawing.Color.Transparent;
            this.label_niveau.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_niveau.Location = new System.Drawing.Point(26, 23);
            this.label_niveau.Name = "label_niveau";
            this.label_niveau.Size = new System.Drawing.Size(87, 28);
            this.label_niveau.TabIndex = 0;
            this.label_niveau.Text = "Niveau :";
            // 
            // btn_repA
            // 
            this.btn_repA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_repA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_repA.FlatAppearance.BorderSize = 0;
            this.btn_repA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_repA.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_repA.Location = new System.Drawing.Point(67, 74);
            this.btn_repA.Margin = new System.Windows.Forms.Padding(0);
            this.btn_repA.Name = "btn_repA";
            this.btn_repA.Size = new System.Drawing.Size(300, 150);
            this.btn_repA.TabIndex = 10;
            this.btn_repA.Text = "Réponse A";
            this.btn_repA.UseVisualStyleBackColor = false;
            this.btn_repA.Click += new System.EventHandler(this.btn_repA_Click);
            // 
            // btn_repB
            // 
            this.btn_repB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_repB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btn_repB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_repB.FlatAppearance.BorderSize = 0;
            this.btn_repB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_repB.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_repB.Location = new System.Drawing.Point(450, 74);
            this.btn_repB.Margin = new System.Windows.Forms.Padding(0);
            this.btn_repB.Name = "btn_repB";
            this.btn_repB.Size = new System.Drawing.Size(300, 150);
            this.btn_repB.TabIndex = 10;
            this.btn_repB.Text = "Réponse B";
            this.btn_repB.UseVisualStyleBackColor = false;
            this.btn_repB.Click += new System.EventHandler(this.btn_repB_Click);
            // 
            // btn_repC
            // 
            this.btn_repC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_repC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btn_repC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_repC.FlatAppearance.BorderSize = 0;
            this.btn_repC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_repC.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_repC.Location = new System.Drawing.Point(67, 313);
            this.btn_repC.Margin = new System.Windows.Forms.Padding(0);
            this.btn_repC.Name = "btn_repC";
            this.btn_repC.Size = new System.Drawing.Size(300, 150);
            this.btn_repC.TabIndex = 10;
            this.btn_repC.Text = "Réponse C";
            this.btn_repC.UseVisualStyleBackColor = false;
            this.btn_repC.Click += new System.EventHandler(this.btn_repC_Click);
            // 
            // btn_repD
            // 
            this.btn_repD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_repD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_repD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_repD.FlatAppearance.BorderSize = 0;
            this.btn_repD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_repD.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_repD.Location = new System.Drawing.Point(450, 313);
            this.btn_repD.Margin = new System.Windows.Forms.Padding(0);
            this.btn_repD.Name = "btn_repD";
            this.btn_repD.Size = new System.Drawing.Size(300, 150);
            this.btn_repD.TabIndex = 10;
            this.btn_repD.Text = "Réponse D";
            this.btn_repD.UseVisualStyleBackColor = false;
            this.btn_repD.Click += new System.EventHandler(this.btn_repD_Click);
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.BackColor = System.Drawing.Color.Transparent;
            this.label_question.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_question.Location = new System.Drawing.Point(141, 23);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(108, 28);
            this.label_question.TabIndex = 1;
            this.label_question.Text = "Question :";
            this.label_question.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_n_q
            // 
            this.label_n_q.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_n_q.AutoSize = true;
            this.label_n_q.BackColor = System.Drawing.Color.Transparent;
            this.label_n_q.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_n_q.Location = new System.Drawing.Point(613, 490);
            this.label_n_q.Name = "label_n_q";
            this.label_n_q.Size = new System.Drawing.Size(108, 28);
            this.label_n_q.TabIndex = 1;
            this.label_n_q.Text = "Question :";
            // 
            // label_score
            // 
            this.label_score.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.Color.Transparent;
            this.label_score.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_score.Location = new System.Drawing.Point(350, 490);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(86, 28);
            this.label_score.TabIndex = 1;
            this.label_score.Text = "Score : ";
            // 
            // label_rank
            // 
            this.label_rank.AutoSize = true;
            this.label_rank.BackColor = System.Drawing.Color.Transparent;
            this.label_rank.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_rank.Location = new System.Drawing.Point(67, 498);
            this.label_rank.Name = "label_rank";
            this.label_rank.Size = new System.Drawing.Size(112, 28);
            this.label_rank.TabIndex = 1;
            this.label_rank.Text = "classement";
            this.label_rank.Visible = false;
            // 
            // panel_correction
            // 
            this.panel_correction.BackColor = System.Drawing.Color.Transparent;
            this.panel_correction.Controls.Add(this.label_correction);
            this.panel_correction.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_correction.Location = new System.Drawing.Point(12, 365);
            this.panel_correction.Name = "panel_correction";
            this.panel_correction.Size = new System.Drawing.Size(40, 23);
            this.panel_correction.TabIndex = 8;
            this.panel_correction.Visible = false;
            // 
            // label_correction
            // 
            this.label_correction.BackColor = System.Drawing.Color.Transparent;
            this.label_correction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_correction.Location = new System.Drawing.Point(0, 0);
            this.label_correction.Name = "label_correction";
            this.label_correction.Size = new System.Drawing.Size(40, 23);
            this.label_correction.TabIndex = 1;
            this.label_correction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_correction
            // 
            this.timer_correction.Interval = 10;
            this.timer_correction.Tick += new System.EventHandler(this.timer_correction_Tick);
            // 
            // panel_wait
            // 
            this.panel_wait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_wait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_wait.Location = new System.Drawing.Point(0, 0);
            this.panel_wait.Name = "panel_wait";
            this.panel_wait.Size = new System.Drawing.Size(20, 23);
            this.panel_wait.TabIndex = 0;
            this.panel_wait.Visible = false;
            // 
            // probar_timer
            // 
            this.probar_timer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.probar_timer.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.probar_timer.AnimationSpeed = 500;
            this.probar_timer.BackColor = System.Drawing.Color.Transparent;
            this.probar_timer.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.probar_timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.probar_timer.InnerColor = System.Drawing.Color.Transparent;
            this.probar_timer.InnerMargin = 1;
            this.probar_timer.InnerWidth = -1;
            this.probar_timer.Location = new System.Drawing.Point(788, 478);
            this.probar_timer.MarqueeAnimationSpeed = 2000;
            this.probar_timer.Name = "probar_timer";
            this.probar_timer.OuterColor = System.Drawing.Color.Gray;
            this.probar_timer.OuterMargin = -25;
            this.probar_timer.OuterWidth = 26;
            this.probar_timer.ProgressColor = System.Drawing.Color.Black;
            this.probar_timer.ProgressWidth = 25;
            this.probar_timer.SecondaryFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.probar_timer.Size = new System.Drawing.Size(40, 40);
            this.probar_timer.StartAngle = 270;
            this.probar_timer.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.probar_timer.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.probar_timer.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.probar_timer.SubscriptText = ".23";
            this.probar_timer.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.probar_timer.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.probar_timer.SuperscriptText = "%";
            this.probar_timer.TabIndex = 0;
            this.probar_timer.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.probar_timer.Value = 1;
            // 
            // timer_user
            // 
            this.timer_user.Interval = 1000;
            this.timer_user.Tick += new System.EventHandler(this.timer_user_Tick);
            // 
            // level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 530);
            this.Controls.Add(this.probar_timer);
            this.Controls.Add(this.panel_correction);
            this.Controls.Add(this.label_rank);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_n_q);
            this.Controls.Add(this.label_question);
            this.Controls.Add(this.btn_repD);
            this.Controls.Add(this.btn_repC);
            this.Controls.Add(this.btn_repB);
            this.Controls.Add(this.btn_repA);
            this.Controls.Add(this.label_niveau);
            this.Controls.Add(this.panel_wait);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "level";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "level";
            this.panel_correction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_niveau;
        private Button btn_repA;
        private Button btn_repB;
        private Button btn_repC;
        private Button btn_repD;
        private Label label_question;
        private Label label_n_q;
        private Label label_score;
        private Label label_rank;
        private Panel panel_correction;
        private Label label_correction;
        private System.Windows.Forms.Timer timer_correction;
        private Panel panel_wait;
        private CircularProgressBar.CircularProgressBar probar_timer;
        private System.Windows.Forms.Timer timer_user;
    }
}