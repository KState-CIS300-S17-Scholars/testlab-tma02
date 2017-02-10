using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        SieveList _list;
        public Form1()
        {
            InitializeComponent();
        }

        private void uxFindPrimes_Click(object sender, EventArgs e)
        {
            _list = new SieveList(Convert.ToInt32(uxUpperBound.Text));
            _list.FindPrimes();
            foreach (int val in _list)
            {
                uxPrimes.Text += val + " ";
            }
        }
    }
}
