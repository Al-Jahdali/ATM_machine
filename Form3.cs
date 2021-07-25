using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm_machine_wf
{
    public partial class Form3 :  formX
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void button5_Click(object sender, EventArgs e)
        {
            withdraw(500);
            MessageBox.Show("Withdrawl done Successfully\n Balance: " + balance, "Withdawl", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public void button2_Click(object sender, EventArgs e)
        {
            withdraw(1000);
            MessageBox.Show("Withdrawl done Successfully\n Balance: " + balance, "Withdawl", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void button6_Click(object sender, EventArgs e)
        {
            withdraw(3000);
            MessageBox.Show("Withdrawl done Successfully\n Balance: " + balance, "Withdawl", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public void button3_Click(object sender, EventArgs e)
        {
            withdraw(5000);
            MessageBox.Show("Withdrawl done Successfully\n Balance: " + balance, "Withdawl", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Form3_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            withdraw(1500);
            MessageBox.Show("Withdrawl done Successfully\n Balance: " + balance, "Withdawl", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public void button4_Click(object sender, EventArgs e)
        {
            withdraw(2000);
            MessageBox.Show("Withdrawl done Successfully\n Balance: " + balance, "Withdawl", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
