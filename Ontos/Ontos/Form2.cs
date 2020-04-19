using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ontos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //This is the code for the information window.
        //Mainly, the only code that's here is for the "Close Window" button.
        //And that button does exactly what you think it does.
        //
        //That's about it....

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
