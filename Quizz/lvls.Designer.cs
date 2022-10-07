namespace Quizz
{
    partial class lvls
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_lvl1 = new System.Windows.Forms.Button();
            this.btn_lvl2 = new System.Windows.Forms.Button();
            this.btn_lvl3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_lvl1
            // 
            this.btn_lvl1.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_lvl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lvl1.FlatAppearance.BorderSize = 0;
            this.btn_lvl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lvl1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_lvl1.Location = new System.Drawing.Point(14, 16);
            this.btn_lvl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_lvl1.Name = "btn_lvl1";
            this.btn_lvl1.Size = new System.Drawing.Size(206, 200);
            this.btn_lvl1.TabIndex = 0;
            this.btn_lvl1.Text = "Niveau 1 !";
            this.btn_lvl1.UseVisualStyleBackColor = false;
            this.btn_lvl1.Click += new System.EventHandler(this.btn_lvl1_Click);
            this.btn_lvl1.MouseEnter += new System.EventHandler(this.btn_lvl1_MouseEnter);
            // 
            // btn_lvl2
            // 
            this.btn_lvl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_lvl2.BackColor = System.Drawing.Color.Coral;
            this.btn_lvl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lvl2.FlatAppearance.BorderSize = 0;
            this.btn_lvl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lvl2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_lvl2.Location = new System.Drawing.Point(305, 16);
            this.btn_lvl2.Margin = new System.Windows.Forms.Padding(89, 4, 89, 4);
            this.btn_lvl2.Name = "btn_lvl2";
            this.btn_lvl2.Size = new System.Drawing.Size(206, 200);
            this.btn_lvl2.TabIndex = 1;
            this.btn_lvl2.Text = "Niveau 2 !";
            this.btn_lvl2.UseVisualStyleBackColor = false;
            this.btn_lvl2.Click += new System.EventHandler(this.btn_lvl2_Click);
            this.btn_lvl2.MouseEnter += new System.EventHandler(this.btn_lvl2_MouseEnter);
            // 
            // btn_lvl3
            // 
            this.btn_lvl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_lvl3.BackColor = System.Drawing.Color.Red;
            this.btn_lvl3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lvl3.FlatAppearance.BorderSize = 0;
            this.btn_lvl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lvl3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_lvl3.Location = new System.Drawing.Point(603, 16);
            this.btn_lvl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_lvl3.Name = "btn_lvl3";
            this.btn_lvl3.Size = new System.Drawing.Size(206, 200);
            this.btn_lvl3.TabIndex = 2;
            this.btn_lvl3.Text = "Niveau 3 !";
            this.btn_lvl3.UseVisualStyleBackColor = false;
            this.btn_lvl3.Click += new System.EventHandler(this.btn_lvl3_Click);
            this.btn_lvl3.MouseEnter += new System.EventHandler(this.btn_lvl3_MouseEnter);
            // 
            // lvls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(823, 481);
            this.Controls.Add(this.btn_lvl3);
            this.Controls.Add(this.btn_lvl2);
            this.Controls.Add(this.btn_lvl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "lvls";
            this.Text = "lvls";
            this.Load += new System.EventHandler(this.lvls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource bindingSource1;
        private Button btn_lvl1;
        private Button btn_lvl2;
        private Button btn_lvl3;
    }
}