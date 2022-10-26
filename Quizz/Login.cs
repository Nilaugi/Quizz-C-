﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace Quizz
{
    //bdd gratuite user = nilaugi
    //passwd = S3K6NvXSwml_0y6qz6xhjg
    public partial class Login : Form
    {
        public Players LoadjsonP() //Chargement d'un json
        {
            string json = string.Empty;
            json = File.ReadAllText(@"p_quizz.json");
            Players LE_p = JsonConvert.DeserializeObject<Players>(json);
            return LE_p;
        }

        lobby mainForm = null;
        public Login()
        {
            InitializeComponent();
        }

        public Login(Form callingForm)
        {
            mainForm = callingForm as lobby;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nb_player = LoadjsonP().players.Count;
            for (int i = 0; i < nb_player; i++)
            {
                if (txt_login_login.Text == LoadjsonP().players[i].name && txt_psswd_login.Text == LoadjsonP().players[i].passwd)
                {
                    label_test.Text = "réussite";
                    mainForm.Loginstate = true;
                    mainForm.Player = LoadjsonP().players[i];
                    mainForm.lobby_Load(sender, e);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txt_login_login.Clear();
            txt_psswd_login.Clear();
            txt_login_login.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_invite_Click(object sender, EventArgs e)
        {
            if (txt_pseudo.Text != null)
            {
                mainForm.Loginstate = true;
                mainForm.lobby_Load(sender, e);
            }
            else
            {
                txt_pseudo.Clear();
                txt_pseudo.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_insc_Click(object sender, EventArgs e)
        {
            int id_insc = LoadjsonP().players.Last().id;
            id_insc++;
            Players joueurs = LoadjsonP();
                joueurs.players.Add(new Player()
                {
                id = id_insc,
                name = txt_login_insc.Text,
                passwd = txt_passwd_insc.Text,
                lvl = 1
                });
            string new_json = JsonConvert.SerializeObject(joueurs);
            File.WriteAllText(@"p_quizz.json", new_json);
        }
    }
}