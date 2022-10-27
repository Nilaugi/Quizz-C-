using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz
{
    public partial class lvls : Form
    {

        private lobby mainForm = null;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public lvls()
        {
            InitializeComponent();
        }

        public lvls(Form callingForm)
        {
            mainForm = callingForm as lobby;
            InitializeComponent();
        }

        private void lvls_Load(object sender, EventArgs e)
        {

            foreach (var button in this.Controls.OfType<Button>())
            {
            button.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button.Width, button.Height, 50, 50));
            }
        }

        private void btn_lvl1_MouseEnter(object sender, EventArgs e)
        {
            mainForm.change_color("vert"); // vert, orange ou rouge
        }


        private void btn_lvl2_MouseEnter(object sender, EventArgs e)
        {
            if (mainForm.Player.lvl < 2)
            {
                btn_lvl2.BackColor = Color.Gray;
                btn_lvl2.BackgroundImage = global::Quizz.Properties.Resources.cadenas_1;
                btn_lvl2.Text = "";
            }else if (mainForm.Player.lvl == 2)
            {
                mainForm.change_color("orange");
            }
        }

        private void btn_lvl3_MouseEnter(object sender, EventArgs e)
        {
            if (mainForm.Player.lvl < 3)
            {
                btn_lvl3.BackColor = Color.Gray;
                btn_lvl3.BackgroundImage = global::Quizz.Properties.Resources.cadenas_1;
                btn_lvl3.Text = "";
            }else if (mainForm.Player.lvl == 4)
            {
                mainForm.change_color("rouge");
            }
        }

        private void btn_lvl1_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new level(1, mainForm), sender);
        }
        private void btn_lvl2_Click(object sender, EventArgs e)
        {
            if (mainForm.Player.lvl == 2)
            {
                mainForm.OpenChildForm(new level(2, this), sender);
            }
        }

        private void btn_lvl3_Click(object sender, EventArgs e)
        {
            if (mainForm.Player.lvl == 3)
            {
                mainForm.OpenChildForm(new level(3, this), sender);
            }
        }
    }
}
