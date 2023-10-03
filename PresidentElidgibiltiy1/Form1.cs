using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresidentElidgibiltiy1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkPresident_Click(object sender, EventArgs e)
        {
            String number = age.Text;
            int presidentAge = int.Parse(number);

            String term = terms.Text;
            int termNumber = int.Parse(term);


            if (naturalBorn.Checked && !rebel.Checked &&presidentAge >= 35 && termNumber < 2)
            {
                MessageBox.Show("Congratulations! You are able to be President of United States of America!");
            }
            else
            {
                MessageBox.Show("You can NOT be President of United States of America.");
            }

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void terms_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
