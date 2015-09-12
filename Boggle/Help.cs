using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections;
using System.Linq;
using System.Media;

namespace Boggle_game
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {


            try
            {

                rHelp.Text = File.ReadAllText("help.txt");

                //string[] helptext = File.ReadAllLines("help.txt");

                //foreach (string helpsentence in helptext)
                //{
                //    tHelp.Text = helptext + Environment.NewLine + helpsentence;
                //}

            }
            catch
            {
                MessageBox.Show("Help.text file could not be found!");
            }
        }

     
    }
}
