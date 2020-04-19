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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Creates a second custom form window
        Form2 secondForm = new Form2();



        //Error Message Template
        //How To Use:
        //In area the triggers error, list the following code:
        //
        //  string errormessage = "<INSERT ERROR MESSAGE>";
        //  ProgramFailure();
        //
        //The window will display the error message set by the error
        //in the custom error message box.
        private void ProgramFailure()
        {
            //Template for Error Messages
            string title = "Ontos - Error";
            MessageBox.Show(errormessage, title);
        }




        //Xeno Wiki Reference Menu Code
        //This just opens the link to the Xeno Series Wiki
        private void TheXenoSeriesWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the link to the Xeno Series Wiki in the default web browser
            //If link fails to open, display an error message.
            try
            {
                VisitXenoWiki();
            }
            catch (Exception ex)
            {
                string errormessage = "Failed to open link.";
                ProgramFailure();
            }
        }

        //Opens the Xeno Series Wiki
        private void VisitXenoWiki()
        {
            //Calls the Process.Start method to open the default browser
            //Opens a link to the Xeno Series Wiki
            System.Diagnostics.Process.Start("http://www.xenoserieswiki.org/wiki/Main_Page");
        }





        //IGNORE THIS CODE BLOCK
        private void Label3_Click(object sender, EventArgs e)
        {
            //IGNORE THIS CODE BLOCK, THIS IS IF YOU CLICK THE TITLE
            //ABOVE THE QUEST SELECT BOX
        }




        //The Information Menu Item Code
        private void InformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Meh - Placeholder Text";
            string title = "Ontos - Information";
            MessageBox.Show(message, title);
        }
    }
}
