using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using FormSerialisation;

namespace Ontos
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += "- Test Button Clicked" + "\r\n";
        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string TestingTextBox;
            TestingTextBox = textBox1.Text;
            richTextBox2.Text += "- Text Box Output: " + TestingTextBox + "\r\n";
        }
    }
}
