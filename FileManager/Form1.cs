using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        FileManage FM1 = new FileManage();
        public Form1()
        {
            InitializeComponent();
            SSort.Checked = true;
        }

        private void Open_Click(object sender, EventArgs e)
        {
            FM1.OpenFile();
        }

        private void Save_As_Click(object sender, EventArgs e)
        {
            string sortingtype = "";
            if (SSort.Checked)
            {
                sortingtype = "SSort";
            }
            else if (BSort.Checked)
            {
                sortingtype = "BSort";
            }
            else
            {
                sortingtype = "MSort";
            }
            FM1.Saveas(sortingtype);
        }
    }
}
