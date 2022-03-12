using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.Visible = false;       
        }
        private void button1_Click(object sender, EventArgs e)
        {

            folderBrowserDialog1.ShowDialog();
            string manzil = folderBrowserDialog1.SelectedPath;
            string[] fayllar = Directory.GetFiles(manzil);
            foreach (string k in fayllar)
            {
                checkedListBox1.Items.Add(k);
            }
            checkedListBox1.Visible = true;
        }
        void tanlaganini_qoyish()
        {

            string tanlangan = checkedListBox1.GetItemText(checkedListBox1.SelectedItem);
            //MessageBox.Show("tanlandi");
            axWindowsMediaPlayer1.URL = tanlangan;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tanlaganini_qoyish();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kalit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tanlaganini_qoyish();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
