using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMaxValueTobi
{
    public partial class frmFindMaxValue : Form
    {
        public frmFindMaxValue()
        {
            InitializeComponent();
            //hide label
            lblAnswer.Hide();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //Show label
            lblAnswer.Show();

            // Declare local variables
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, maxValue;
                
        }
    }
}
