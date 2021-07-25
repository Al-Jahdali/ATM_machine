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
    public partial class formX : Form
    {
      public  static long balance = 20000;

       public static void deposit(long amunt)
        {
            balance += amunt;
        }

      public static void withdraw(long amunt)
        {
            if (amunt <= balance)
                balance -= amunt;
            else
                MessageBox.Show("Your balance is too low to do this", "Ererr", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       public long checkBalance()
        {
            return balance;
        }

        public formX()
        {
            InitializeComponent();
        }

        private void formX_Load(object sender, EventArgs e)
        {

        }
    }
}
