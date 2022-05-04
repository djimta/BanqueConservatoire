using System;
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

        List<Adherent> adherent;
        Manager monManager = new Manager();
        public Form1()
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            adherent = monManager.getAdherents();
            refreshLb(0);
        }
        private void refreshLb(int index)
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = adherent;
            comboBox1.DisplayMember = "Description";
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
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
