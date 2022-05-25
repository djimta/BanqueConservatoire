﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestBanque.Model;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using TestBanque.Controleur;


namespace TestBanque.Vue
{
    public partial class Form1 : Form
    {

        List<Adherent> List_adherent;
        List<Inscritption> List_inscrptions;
        Adherent adherent_Selected = new Adherent(0, null, null);
        Manager monManager = new Manager();
        public Form1()
        {
            InitializeComponent();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List_adherent = monManager.getAdherents();
            refreshComboBox(0);
        }
        private void refreshComboBox(int index)
        {    
            comboBox1.DataSource = null;
            comboBox1.DataSource = List_adherent;
            comboBox1.DisplayMember = "Description"; 
            
            
        }

        private void refreshListBox(int index)
        {
            List_Box1.DataSource = null;
            List_Box1.DataSource = List_inscrptions;
            List_Box1.DisplayMember = "Description";

            /*for (int i = 0; i < List_inscrptions.Count; i++)
            {
                if (monManager.ChargementDbPaye(List_inscrptions[i]) == false)
                {
                    List_Box1.Items[i].BackColor = Color.Red;
                }
            }*/

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void créditerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
 
        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void débiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int i = comboBox1.SelectedIndex;

            adherent_Selected = List_adherent[i];
            List_inscrptions = monManager.chargementDbInsc(adherent_Selected);
            refreshListBox(0);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
