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
    
    public partial class Form2 : formX
    {
        Form3 fmr3 = new Form3();

        
        public Form2()
        {
            InitializeComponent();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for Uesing ATM Machine.. Good bye","Quit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DepositForm depostform = new DepositForm();
            depostform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            Form3 form3 = new Form3();
           form3.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Balance: "+balance, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

    }
}
