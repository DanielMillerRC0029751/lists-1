using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
        void printNums(List<int> ns)
        {
            foreach (int i in ns)
            {
                richTextBox2.AppendText(i + ",");
            }
        }
        public Form1()
        {
         
            
            InitializeComponent();
            List<int> nums = new List<int>();
            nums.Add(3);
            nums.Add(5);
            nums.Add(3);
            printNums(nums);
            richTextBox2.AppendText("\n================\n");
            nums.Remove(3);
            printNums(nums);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
                        
        }
    }
}
