using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMinValueTobi
{
    public partial class frmFindMinValue : Form
    {
        public frmFindMinValue()
        {
            InitializeComponent();
            //hide label
            lblAnswer.Hide();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int MAX_ARRAY_SIZE = 10;
            int MAX_RANDOM_NUMBER = 500;
            int counter;
            int[] myArray = new int[MAX_ARRAY_SIZE];
            Random randNumber = new Random();
        }
    }
}
