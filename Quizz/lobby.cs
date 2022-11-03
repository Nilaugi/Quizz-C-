using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace Quizz
{
    public partial class lobby : Form
    {
        Color couleur_selec = Color.MidnightBlue;
        Color couleur = Color.RoyalBlue;
        private Button currentButton;
        private Form activeForm;
        private void AddDrag(Control Control) { Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown); }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
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
        Player player;

        public bool con { get; private set; } // getter et setter privé de l'état de connexion à internet

        public Player Player // Setter et Getter du joueur
        {
            get
            {
                return player;
            }
            set
            {
                player = value;
            }
        }

        private bool loginstate;

        public bool Loginstate // Getter et Setter sur l'état de connexion du joueur
        {
            get
            {
                return loginstate;
            }
            set
            {
                loginstate = value;
            }
        }

        public bool check_conn() // vérification de la connexion à internet par le ping à google
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (true);
            }
            catch (Exception)
            {
                return (false);
            }
        }

        public lobby()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Icon = Properties.Resources.question; 
            if (check_conn())
            {
                label_con.Text = "Online";
                con = true;
            }
            else
            {
                label_con.Text = "Offline";
                con = false;
            }
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }
        public void lobby_Load(object sender, EventArgs e)
        {
            if (loginstate == false)
            {
                btn_selec_lvl.Visible = false;
            }
            else if (loginstate == true)
            {
                btn_selec_lvl.Visible = true;
            }
        }


        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = couleur_selec;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel_menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = couleur;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_contenu.Controls.Add(childForm);
            this.panel_contenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            change_color("bleu");
            OpenChildForm(new Login(this), sender);
        }

        private void label_title_Click(object sender, EventArgs e)
        {
            // timer1.Start();
        }

        private void btn_selec_lvl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new lvls(this), sender);
        }

        public void change_color(string color)
        {
            if (color == "vert")
            {
                couleur = Color.FromArgb(50, 205, 50);
                couleur_selec = Color.FromArgb(173, 255, 47);
                btn_selec_lvl.BackColor = couleur_selec;
                btn_login.BackColor = couleur;
                btn_rank.BackColor = couleur;
                panel_menu.BackColor = couleur;
                panel1.BackColor = couleur_selec;
                label_title.ForeColor = Color.DarkGreen;
            } else if (color == "orange")
            {
                couleur = Color.FromArgb(255, 127, 80);
                couleur_selec = Color.FromArgb(255, 99, 71);
                btn_selec_lvl.BackColor = couleur_selec;
                btn_login.BackColor = couleur;
                btn_rank.BackColor = couleur;
                panel_menu.BackColor = couleur;
                panel1.BackColor = couleur_selec;
                label_title.ForeColor = Color.DarkOrange;
            }
            else if (color == "rouge")
            {
                couleur = Color.FromArgb(255, 0, 0);
                couleur_selec = Color.FromArgb(139, 0, 0);
                btn_selec_lvl.BackColor = couleur_selec;
                btn_login.BackColor = couleur;
                btn_rank.BackColor = couleur;
                panel_menu.BackColor = couleur;
                panel1.BackColor = couleur_selec;
                label_title.ForeColor = Color.Black;
            }
            else
            {
                couleur = Color.RoyalBlue;
                couleur_selec = Color.DarkBlue;
                btn_selec_lvl.BackColor = couleur_selec;
                btn_login.BackColor = couleur;
                panel_menu.BackColor = couleur;
                panel1.BackColor = couleur_selec;
                label_title.ForeColor = Color.Black;
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_rank_Click(object sender, EventArgs e)
        {
            OpenChildForm(new rank(this), sender);
        }


        /*private void timer1_Tick(object sender, EventArgs e)
        {
            if (slidebar)
            {
                panel_menu.Width -= 10;
                if (panel_menu.Width <= 45)
                {
                    slidebar = false;
                    timer1.Stop();
                }
            }
            else if (!slidebar)
            {
                panel_menu.Width += 10;
                if (panel_menu.Width >= 120)
                {
                    slidebar = true;
                    timer1.Stop();
                }
            }
        }*/
    }
}
