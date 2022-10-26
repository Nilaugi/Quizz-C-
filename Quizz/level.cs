using Newtonsoft.Json;
using Quizz.Properties;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Media;

namespace Quizz
{
    public partial class level : Form
    {
        //Initialisation de quelques variables
        Form mainForm = new Form();
        int score = 0;
        int lvl = 0;
        int count = 0;
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

        //Initialisation des fonctions de bases
        public level() //A l'appel de level() :
        {
            InitializeComponent();
        }

        public level(int valeur, Form callingForm) //A l'appel de level avec un paramètre à l'intérieur
        {
            InitializeComponent();
            mainForm = callingForm as lobby;
            label_niveau.Text = "Niveau :" + valeur.ToString(); //Le label du niveau prend une valeur
            label_score.Text = "Score :" + score.ToString(); //Le label de score prend une valeur
            timer_user.Start();
            Next_Q(); //Next_Q() pour next question
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button.Width, button.Height, 50, 50));
            }
        }

        //Différents objets :
        public class QuestionBase //Une question
        {
            public string question { get; set; }
            public List<string> answers { get; set; }
            public int correctIndex { get; set; }
            public string correction { get; set; }
        }
        public class Root //Liste de questions
        {
            public List<QuestionBase> questions { get; set; }
        }


        //Fonction utile à la gestion des réponses du quizz
        public Root LoadjsonQ() //Chargement d'un json
        {
            
            if (true)
            {

            }
            string json = string.Empty;
            json = File.ReadAllText(@"q_quizz.json");
            Root LA_q = JsonConvert.DeserializeObject<Root>(json);
            return LA_q;
        }
        private void Next_Q() //Sers à afficher les questions et les réponses et affiche le classement
        {
            panel_wait.Visible = false;
            panel_correction.Visible = false;
            panel_correction.Location = new Point(12, 365);
            panel_correction.Size = new Size(40, 23);
            label_n_q.Text = "";
            probar_timer.Value = 0;
            timer_user.Start();
            if (lvl < 10)
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.Visible = true;
                }
                Root LA_q = LoadjsonQ();
                label_question.Text = LA_q.questions[lvl].question;
                // label_n_q.Text = "Question : " + (lvl + 1);
                btn_repA.Text = LA_q.questions[lvl].answers[0];
                btn_repB.Text = LA_q.questions[lvl].answers[1];
                btn_repC.Text = LA_q.questions[lvl].answers[2];
                btn_repD.Text = LA_q.questions[lvl].answers[3];
            }
            else
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.Visible = false;
                }
                label_question.Visible = false;
                /*label_rank.Visible = true;*/
                /*Players joueurs = LoadjsonP();
                string j_json = JsonConvert.SerializeObject(joueurs);
                File.WriteAllText(@"p_quizz.json", j_json);*/
            }
        }

        private async void timer_correction_Tick(object sender, EventArgs e)
        {
            timer_user.Stop();
            panel_correction.Visible = true;
            panel_wait.Visible = true;
            panel_wait.Dock = System.Windows.Forms.DockStyle.Fill;
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Visible = false;
            }
            int x = panel_correction.Location.X;
            int y = panel_correction.Location.Y;
            int sx = panel_correction.Size.Width;
            int sy = panel_correction.Size.Height;
            string text = LoadjsonQ().questions[lvl].correction;
            if (x < 198)
            {
                x += 10;
                y -= 15;
                sx += 16;
                sy += 10;
                panel_correction.Location = new Point(x, y);
                panel_correction.Size = new Size(sx, sy);
            } else if (x > 198 && count <= text.Length)
            {
                label_correction.Text = text.Substring(0, count);
                count++;
            } else if (label_correction.Text == text)
            {
                count = 0;
                lvl++;
                timer_correction.Stop();
            }
            // 377 => 100 = 25
            // 20 => 210 = 
        }

        private void right_ans()
        {
            label_n_q.Text = "exact !\n";
            timer_correction.Start();
                score++;
                label_score.Text = "Score : " + score.ToString();
            System.Media.SoundPlayer correct = new System.Media.SoundPlayer(Quizz.Properties.Resources.correct);
            correct.Play();
        }

        private void wrong_ans()
        {
            label_n_q.Text = "Pas vraiment !\n";
            timer_correction.Start();
            System.Media.SoundPlayer faux = new System.Media.SoundPlayer(Quizz.Properties.Resources.error);
            faux.Play();

        }

        private void btn_repA_Click(object sender, EventArgs e) //Bouton A à D
        {
            if (LoadjsonQ().questions[lvl].correctIndex == 0)
            {
                right_ans();
            }
            else
            {
                wrong_ans();
            }
        }

        private void btn_repB_Click(object sender, EventArgs e)
        {
            if (LoadjsonQ().questions[lvl].correctIndex == 1)
            {
                right_ans();
            }
            else
            {
                wrong_ans();
            }
        }

        private void btn_repC_Click(object sender, EventArgs e)
        {
            if (LoadjsonQ().questions[lvl].correctIndex == 2)
            {
                right_ans();
            }
            else
            {
                wrong_ans();
            }
        }

        private void btn_repD_Click(object sender, EventArgs e)
        {
            if (LoadjsonQ().questions[lvl].correctIndex == 3)
            {
                right_ans();
            }
            else
            {
                wrong_ans();
            }
        }

        private void panel_wait_Click(object sender, EventArgs e)
        {
            label_correction.Text = "";
            Next_Q();
        }

        private void timer_user_Tick(object sender, EventArgs e)
        {
            probar_timer.Value += 10;
            if (probar_timer.Value >= 100)
            {
                timer_user.Stop();
                timer_correction.Start();
            }
        }
    }


}