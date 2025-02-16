using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoNumbersAppWeek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TwoNumbers twoNumbers;

        

        private void btnAddNumbers_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Something");

            if (twoNumbers != null)
            {

                if(!int.TryParse(txtFirstNum.Text, out int addNum1) )
                {
                    MessageBox.Show("PLEASE! Using default value 0 for First Number.");
                }
                if(!int.TryParse(txtSecondNum.Text, out int addNum2) )
                {
                    MessageBox.Show("PLEASE! Using default value 0 for First Number.");
                }

                twoNumbers.AddNumbers(addNum1, addNum2);
                MessageBox.Show("Numbers added successfully!");

                txtFirstNum.Text = twoNumbers.ReturnNum1().ToString();
                txtSecondNum.Text = twoNumbers.ReturnNum1().ToString();
            }
        }
    }
}
