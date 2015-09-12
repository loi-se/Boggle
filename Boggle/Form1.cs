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
    public partial class Form1 : Form
    {

        // The array that holds the Boggle Field:
        public char[,] field;

        // All words found by the computer algorithm:
        public ArrayList AllFoundWords;

        // All words paths found by the computer algorithm:
        public ArrayList AllFoundWordPaths;

        // Dictionairy used to couple words to a path to make words visible in the Boggle field:
        public Hashtable AllFoundWordsHashtable = new Hashtable();

        // All unique words found by the computer (the computer algorithm finds double words because sometimes a word can be made trough multiple paths):
        public ArrayList AllUniqueFoundWords;

        // The words typed in by the user:
        public ArrayList Userwords;

        // Panel holding the textboxes of the boggle field:
        public Panel pBoggleHolder;

        // Boggle field block size:
        public int textwidth = 30;

        // Counter for the timer:
        private int counter = 0;

        // User score:
        private int userscore = 0;
        private int userlabelscore = 0;

        // Computer score:
        private int compscore = 0;

        // Number of valid words typed in by the user (the user words are compared to the words found by the computer):
        private int validwords = 0;
        //private Timer timer2;

        public Form1()
        {      
            InitializeComponent();
            this.tableLayoutPanel1.CellPaint += tableLayoutPanel1_CellPaint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // timer2 = new Timer();

            AllFoundWordPaths = new ArrayList();
            //timer1 = new Timer();
            
            // Set the language to Dutch:
            cLanguage.SelectedIndex = 0;
            rUserWord.Width = Convert.ToInt32(0.8 * pTypewords.Width);

            // Set properties of controls:
            cTimer.Checked = true;
            bSolve.Enabled = false;
            rInput.ReadOnly = true;
            rUserWord.Enabled = false;
           // rUserWord.Text = "Enter your words here...";


            // Create the panel that holds the boggle field:
            pBoggleHolder = new Panel();
            pBoggleHolder.Width = (((textwidth) * Convert.ToInt32(nFieldWidth.Value)));
            pBoggleHolder.Height = (((textwidth) * Convert.ToInt32(nFieldWidth.Value)));
            // pBoggleHolder.Dock = DockStyle.Fill;
            pBoggleHolder.BorderStyle = BorderStyle.FixedSingle;

            pBoggleHolder.Location = new Point(
               pBoggle.ClientSize.Width / 2 - pBoggleHolder.Size.Width / 2,
                pBoggle.ClientSize.Height / 2 - pBoggleHolder.Size.Height / 2);
            pBoggleHolder.Anchor = AnchorStyles.None;
            pBoggleHolder.BorderStyle = BorderStyle.Fixed3D;
            this.pBoggle.Controls.Add(pBoggleHolder);


            // Create the label that shows the timer: 
            lblCountDown.Text = " __ __ __" ;
            lblCountDown.Location = new Point(
           pTimer.ClientSize.Width / 2 - lblCountDown.Size.Width / 2,
             pTimer.ClientSize.Height / 2 - lblCountDown.Size.Height / 2);
            //lblCountDown.Height = 30;
            lblCountDown.Anchor = AnchorStyles.None;
        }


        // Paint the lines in the tablelayout holding the controls:
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column >= 0 && e.Row > 0)
            {
                if (e.Row < 6)
                {
                    e.Graphics.DrawLine(Pens.Black, e.CellBounds.Location, new Point(e.CellBounds.Right, e.CellBounds.Top));
                }
                else
                {
                   
                }
            
            }
        }


        // Generate a field of random letters and start the Boggle game timer:
        private void bShuffle_Click(object sender, EventArgs e)
        {

            // Refresh collections:
            AllFoundWordsHashtable.Clear();
            AllFoundWordPaths.Clear();
            Userwords = new ArrayList();
            userscore = 0;
            userlabelscore = 0;
            compscore = 0;
            validwords = 0;

            // Refresh some controls that show information about a previous boggle game session:
            bSolve.Enabled = true;
            pFoundWords.Controls.Clear();
            pUser.Controls.Clear();
            pCPU.Controls.Clear();
            //rInput.Enabled = true;
            rInput.Text = "";
            pBoggle.Controls.Clear();
            rUserWord.Text = "";
            lUserScore.Text = "";
            lWordsEntered.Text = "";
            lusermessage.Text = "";
            rUserWord.Enabled = true;


            timer3.Stop();
            lblCountDown.Text = "";


            // Generate the Boggle Field Array:
            field = GenerateField(Convert.ToInt32(nFieldWidth.Value), Convert.ToInt32(nFieldWidth.Value));

            // Create the user interface of the Boggle Field:
            DumpField(field);

            // Setup and show the timer:
            if (cTimer.Checked == true)
            {
                counter = Convert.ToInt32(nSeconds.Value);

                timer3.Interval = 1000; // 1 second
                timer3.Start();

                string countertext = SecondsToHhMmSs(counter);

                lblCountDown.Text = countertext;
            }

            if (pTimer.Controls.Count > 1)
            {
                pTimer.Controls.RemoveAt(1);
            }

            // Solve the Boggle Field so entered words can be compared to the possible words!
            SolveBoggleField();

            // Focus on the richtextbox control:
            this.rUserWord.Focus();
            lUserScore.Text = "Score: " + userlabelscore.ToString();
            lWordsEntered.Text = "Found words: " + Userwords.Count.ToString() + " of " + AllUniqueFoundWords.Count.ToString();
        }


        // Show the words found by the computer and show user stats and computer stats:
        private void bSolve_Click(object sender, EventArgs e)
        {
            ShowSolution();

        }


        // Show the words found by the computer and the user stats and computer stats:
        public void ShowSolution() {

            timer3.Stop();

            try
            {

                pFoundWords.Controls.Clear();
                DataGridView GView = new DataGridView();
                GView.Name = "Gridview_computerwords";
                GView.BackgroundColor = Color.White;
                //GView.ScrollBars = ScrollBars.None;
                GView.ScrollBars = ScrollBars.Both;
                GView.ColumnHeadersHeight = 40;
                pFoundWords.AutoScroll = false;

                DataGridViewColumn newCol0 = new DataGridViewTextBoxColumn();
                newCol0.HeaderText = "Index";
                newCol0.Width = Convert.ToInt16(60);
                newCol0.ValueType = typeof(System.Int16);
                newCol0.SortMode = DataGridViewColumnSortMode.Automatic;
                GView.Columns.Add(newCol0);

                DataGridViewColumn newCol1 = new DataGridViewTextBoxColumn();
                newCol1.HeaderText = "Word";
                newCol1.Width = Convert.ToInt16(100);
                newCol1.SortMode = DataGridViewColumnSortMode.Automatic;
                GView.Columns.Add(newCol1);

                DataGridViewColumn newCol2 = new DataGridViewTextBoxColumn();
                newCol2.HeaderText = "Word length";
                newCol2.Width = Convert.ToInt16(100);
                newCol2.SortMode = DataGridViewColumnSortMode.Automatic;
                GView.Columns.Add(newCol2);


                int i = 1;
                // Show each unique found word in the Gridview:
                foreach (string foundword in AllUniqueFoundWords)
                {

                    DataGridViewRow row = (DataGridViewRow)GView.Rows[0].Clone();

                    row.Cells[0].Value = Convert.ToInt32(i.ToString());

                    row.Cells[1].Value = foundword.ToString();
                    row.Cells[2].Value = foundword.Length;


                    // If the word is found by the user show a Green row Backcolor:
                    if (Userwords.Contains(foundword))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;

                        // compute user score (score is depended on word length):
                        userscore = userscore + foundword.Length;
                        validwords = validwords + 1;
                    }
                    // If the word is not found by the user:
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }

                    // Compute computer score:
                    compscore = compscore + foundword.Length;

                    GView.Rows.Add(row);
                    i = i + 1;
                }

                GView.Width = pFoundWords.Width;
                GView.Height = pFoundWords.Height;

                GView.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(gridview_rowclick_computerwords);
                //GView.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(gridview_rowclick_noffiles);
                GView.PerformLayout();
                pFoundWords.Controls.Add(GView);

            }
            catch (Exception e2)
            {
                MessageBox.Show("An error occurred: '{0}':  " + e2);
            }
            // Show the computer stats:
            showCompstats();

            // Show the user stats:
            showUserstats();

            //MessageBox.Show("Click on a row header of a word in the Computer words gridview to see the word in the Boggle Field");

            DialogResult result3 = MessageBox.Show("Click on a row header of a word in the Computer words gridview to see the word in the Boggle Field",
             "Important Note",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information,
              MessageBoxDefaultButton.Button1);

            //Label solvedhelptext = new Label();
            //solvedhelptext.Name = "solvedhelptext";
            //solvedhelptext.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
            //solvedhelptext.Width = pTimer.Width;
            //solvedhelptext.Height = 30;
            //solvedhelptext.TextAlign = ContentAlignment.MiddleCenter;
            //solvedhelptext.BackColor = Color.WhiteSmoke;
            ////solvedhelptext.Height =
            //solvedhelptext.Text = "Click on a row header of a word in the Computer words" +  Environment.NewLine + "gridview to see the word in the Boggle Field";
            // pTimer.Controls.Add(solvedhelptext);
        
        }


        // Find all possible words in a Boggle field:
        public void SolveBoggleField() {
           
            // Set up which language dictionairy is used:
            string filename = "Dutch.txt";
           // Dutch
            if (cLanguage.SelectedIndex == 0)
            {
                filename = "Dutch.txt";
            }
            // English
            else if (cLanguage.SelectedIndex == 1)
            {
                filename = "English.txt";
            }
            // French
            else if (cLanguage.SelectedIndex == 2)
            {
                filename = "French.txt";
            }
            // German:
            else if (cLanguage.SelectedIndex == 3)
            {
                filename = "German.txt";
            }
            
            // Read all the words of a dictionairy file:
            //try
            //{
                var words = File.ReadAllLines(filename);
                var dictionary = BoggleSolver.LoadWords(words, UniqueCharsIn(field));
                var wordsInField = BoggleSolver.FindWords1(field, dictionary).ToArray();
            //}
            //catch
            //{
            //    MessageBox.Show("The dictionairy text file is not in your program directory! The field can't be solved by the computer!");
            //}
            // 
                 
            /////// Gridview
                try
                {
                    AllFoundWords = new ArrayList();
                    AllUniqueFoundWords = new ArrayList();

                    // Put all found words in an ArrayList:
                    foreach (var foundword in wordsInField.Select(w => w.Word))
                    {
                        AllFoundWords.Add(foundword.ToString());
                    }

                    // Put all found paths in an Arraylist (a path is an array of BoggleSolution.Points with X and Y coordinate points): 
                    foreach (var foundword in wordsInField.Select(w => w.Path))
                    {
                        AllFoundWordPaths.Add(foundword);
                    }

                    // 
                    int AllFoundWordsSize = 0;
                    if (AllFoundWords.Count == AllFoundWordPaths.Count)
                    {
                        AllFoundWordsSize = AllFoundWords.Count;
                    }

                    // Combine the All found words Path Arraylist with the All found words word Arraylist in a Hashtable:
                    // (this way the path of a word can be easily retrieved when the user clicks a row header column)
                    for (int ih = 0; ih < AllFoundWordsSize; ih++)
                    {
                        if (!AllFoundWordsHashtable.Contains(AllFoundWords[ih].ToString()))
                        {
                            AllFoundWordsHashtable.Add(AllFoundWords[ih].ToString(), AllFoundWordPaths[ih]);
                        }
                        else
                        {
                            // MessageBox.Show(AllFoundWords[ih].ToString());
                        }
                    }

                    // Get all Distinct words using Linq (we only want to show the unique words to the user so that is why this is needed):
                    var AllUniqueFoundWordsVar = AllFoundWords.ToArray().Distinct();

                    // Put all the distinct words in the All Unique words Arraylist:
                    foreach (string foundword in AllUniqueFoundWordsVar)
                    {
                        AllUniqueFoundWords.Add(foundword);
                    }
                }
                catch
                {
                }
        }


        // Show the computer stats:
        public void showCompstats() {

            try
            {
                pCPU.Controls.Clear();
                DataGridView GView_CPU = new DataGridView();
                GView_CPU.Dock = DockStyle.Fill;
                GView_CPU.Name = "Gridview_noffilesfolder";
                GView_CPU.BackgroundColor = Color.White;
                //GView.ScrollBars = ScrollBars.None;
                GView_CPU.ScrollBars = ScrollBars.Both;
                GView_CPU.ColumnHeadersHeight = 40;
                pFoundWords.AutoScroll = false;

                DataGridViewColumn newCol0_CPU = new DataGridViewTextBoxColumn();
                newCol0_CPU.HeaderText = "Description";
                newCol0_CPU.Width = Convert.ToInt16(200);
                newCol0_CPU.ValueType = typeof(System.Int16);
                newCol0_CPU.SortMode = DataGridViewColumnSortMode.Automatic;
                GView_CPU.Columns.Add(newCol0_CPU);

                DataGridViewColumn newCol1_CPU = new DataGridViewTextBoxColumn();
                newCol1_CPU.HeaderText = "Value";
                newCol1_CPU.Width = Convert.ToInt16(70);
                newCol1_CPU.SortMode = DataGridViewColumnSortMode.Automatic;
                GView_CPU.Columns.Add(newCol1_CPU);

                DataGridViewRow row_CPU = (DataGridViewRow)GView_CPU.Rows[0].Clone();
                row_CPU.Cells[0].Value = "Number of unique word paths";
                row_CPU.Cells[1].Value = AllFoundWords.Count;
                GView_CPU.Rows.Add(row_CPU);


                row_CPU = (DataGridViewRow)GView_CPU.Rows[0].Clone();
                row_CPU.Cells[0].Value = "Number of unique words";
                row_CPU.Cells[1].Value = AllUniqueFoundWords.Count.ToString();
                GView_CPU.Rows.Add(row_CPU);

                row_CPU = (DataGridViewRow)GView_CPU.Rows[0].Clone();
                row_CPU.Cells[0].Value = "Computer Score";
                row_CPU.Cells[1].Value = compscore.ToString();
                GView_CPU.Rows.Add(row_CPU);


                GView_CPU.Width = pFoundWords.Width;
                GView_CPU.Height = pFoundWords.Height;

                //GView.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(gridview_rowclick_noffiles);
                GView_CPU.PerformLayout();
                //GView_CPU.Dock = DockStyle.Fill;

                pCPU.Controls.Add(GView_CPU);
            }
            catch (Exception e2)
            {
                MessageBox.Show("An error occurred: '{0}':  " + e2);
            }

        }

        // Show the user stats:
        public void showUserstats()
        {
            try
            {
                pUser.Controls.Clear();
                DataGridView GView_User = new DataGridView();
                GView_User.Dock = DockStyle.Fill;
                GView_User.Name = "Gridview_noffilesfolder";
                GView_User.BackgroundColor = Color.White;
                //GView.ScrollBars = ScrollBars.None;
                GView_User.ColumnHeadersHeight = 40;
                GView_User.ScrollBars = ScrollBars.Both;
                pFoundWords.AutoScroll = false;

                DataGridViewColumn newCol0_User = new DataGridViewTextBoxColumn();
                newCol0_User.HeaderText = "Description";
                newCol0_User.Width = Convert.ToInt16(200);
                newCol0_User.ValueType = typeof(System.Int16);
                newCol0_User.SortMode = DataGridViewColumnSortMode.Automatic;
                GView_User.Columns.Add(newCol0_User);

                DataGridViewColumn newCol1_User = new DataGridViewTextBoxColumn();
                newCol1_User.HeaderText = "Value";
                newCol1_User.Width = Convert.ToInt16(70);
                newCol1_User.SortMode = DataGridViewColumnSortMode.Automatic;
                GView_User.Columns.Add(newCol1_User);

                DataGridViewRow row_User = (DataGridViewRow)GView_User.Rows[0].Clone();
                row_User.Cells[0].Value = "Entered words";
                row_User.Cells[1].Value = Userwords.Count.ToString();
                GView_User.Rows.Add(row_User);

                row_User = (DataGridViewRow)GView_User.Rows[0].Clone();
                row_User.Cells[0].Value = "Valid words";
                row_User.Cells[1].Value = validwords.ToString();
                GView_User.Rows.Add(row_User);


                row_User = (DataGridViewRow)GView_User.Rows[0].Clone();
                row_User.Cells[0].Value = "User Score";
                row_User.Cells[1].Value = userscore.ToString();
                GView_User.Rows.Add(row_User);


                GView_User.Width = pFoundWords.Width;
                GView_User.Height = pFoundWords.Height;

                //GView.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(gridview_rowclick_noffiles);
                GView_User.PerformLayout();

                pUser.Controls.Add(GView_User);
            }
            catch (Exception e2)
            {
                MessageBox.Show("An error occurred: '{0}':  " + e2);
            }

        }


        // Show a word in the boggle field:
        private void displayword(string userword)

        {
            if (AllFoundWordsHashtable.Contains(userword)) 
                        {

                        // Get the path of a word from the Hashtable (key = word, value = path):
                         object pathpoints = AllFoundWordsHashtable[userword];
                        
                        // Put the path in an Array of Boggle Points:
                         BogglePath.Point[] bogglepoints = (BogglePath.Point[])pathpoints;
                        
                        int i = 0;

                        // Find each textbox corresponding with a boggle point and change the backcolor of the textbox:
                        for (i = 0; i < bogglepoints.Length; i++)
                        {
                            String pathpointX = bogglepoints[i].X.ToString();
                            String pathpointY = bogglepoints[i].Y.ToString();

                            // A textbox is found based on the name consisting of a X point and Y point in the Boggle Field:
                            String tag = pathpointX + "/" + pathpointY;

                            //Find the textbox which color needs to change:
                            TextBox tbx = pBoggleHolder.Controls.Find(tag, true).FirstOrDefault() as TextBox;
                            tbx.BackColor = Color.LightGreen;
                        }
                        }
                 else
                      {
                      //  MessageBox.Show(" Word not in Hashtable!");
                      }

        }



        // Event that is triggered when a user is clicking on the row column of the Gridview containing all found words by the computer:
        // (When a user clicks such a column the word is shown in the Boggle Field)
        public void gridview_rowclick_computerwords(object sender, DataGridViewCellMouseEventArgs e)
        {

            int value = e.RowIndex;
            string computerword = "";

            // Make all textboxes of the Bogglefield white again:
            try
            {
                foreach (Control c in pBoggleHolder.Controls)
                {
                    if (c is TextBox)
                    {
                        c.BackColor = Color.White;
                    }
                }
            }
            catch
            {
            }

            
            if (pFoundWords.Controls.ContainsKey("Gridview_computerwords"))
            {
                Control[] controls = pFoundWords.Controls.Find("Gridview_computerwords", true);

                foreach (DataGridView c in controls)
                {
                    if (c.Name == "Gridview_computerwords")
                    {
                        try
                        {
                        // retrieve the word from the row:
                        computerword = c.Rows[e.RowIndex].Cells[1].Value.ToString();
                        
                        // Check if the word is found 
                        if (AllFoundWordsHashtable.Contains(computerword)) 
                        {

                        // Get the path of a word from the Hashtable (key = word, value = path):
                        object pathpoints = AllFoundWordsHashtable[computerword];
                        
                        // Put the path in an Array of Boggle Points:
                        BogglePath.Point[] bogglepoints = (BogglePath.Point[])pathpoints;
                        
                        int i = 0;

                        // Find each textbox corresponding with a boggle point and change the backcolor of the textbox:
                        for (i = 0; i < bogglepoints.Length; i++)
                        {
                            String pathpointX = bogglepoints[i].X.ToString();
                            String pathpointY = bogglepoints[i].Y.ToString();

                            // A textbox is found based on the name consisting of a X point and Y point in the Boggle Field:
                            String tag = pathpointX + "/" + pathpointY;

                            //Find the textbox which color needs to change:
                            TextBox tbx = pBoggleHolder.Controls.Find(tag, true).FirstOrDefault() as TextBox;
                            tbx.BackColor = Color.LightGreen;
                        }
                        }
                        else
                        {
                        MessageBox.Show(" Word not in Hashtable!");
                        }

                        }
                        catch
                        {
                        }
                    }
                }

            }
        }


        private static HashSet<char> UniqueCharsIn(char[,] chars)
        {
            return new HashSet<char>(chars.Cast<char>().Distinct());
        }


        // Generate a Boggle Field Array:
        private static char[,] GenerateField(int xmax, int ymax)
        {
            var chars = //Dutch scrabble distribution
                new string('a', 6) +
                new string('b', 2) +
                new string('c', 2) +
                new string('d', 5) +
                new string('e', 18) +
                new string('f', 2) +
                new string('g', 3) +
                new string('h', 2) +
                new string('i', 4) +
                new string('j', 2) +
                new string('k', 3) +
                new string('l', 3) +
                new string('m', 3) +
                new string('n', 10) +
                new string('o', 6) +
                new string('p', 2) +
                new string('q', 1) +
                new string('r', 5) +
                new string('s', 5) +
                new string('t', 5) +
                new string('u', 3) +
                new string('v', 2) +
                new string('w', 2) +
                new string('x', 1) +
                new string('y', 1) +
                new string('z', 2);


            var field = new char[xmax, ymax];
            var random = new Random();
            for (int x = 0; x < xmax; x++)
            {
                for (int y = 0; y < ymax; y++)
                {
                    field[x, y] = chars[random.Next(chars.Length)];
                }
            }
            return field;
        }


        // Construct the Boggle Field (the field consists of textboxes in a panel):
        public void DumpField(char[,] chars)
        {
            int xpoint = 0;
            int ypoint = 0;

            pBoggle.Controls.Clear();
            pBoggleHolder = new Panel();
            pBoggleHolder.Width = (((textwidth ) * Convert.ToInt32(nFieldWidth.Value)));
            pBoggleHolder.Height = (((textwidth ) * Convert.ToInt32(nFieldWidth.Value)));
           // pBoggleHolder.Dock = DockStyle.Fill;
            pBoggleHolder.BorderStyle = BorderStyle.FixedSingle;

            pBoggleHolder.Location = new Point(
               pBoggle.ClientSize.Width / 2 - pBoggleHolder.Size.Width / 2,
                pBoggle.ClientSize.Height / 2 - pBoggleHolder.Size.Height / 2);
            pBoggleHolder.Anchor = AnchorStyles.None;


            for (int y = 0; y < chars.GetLength(0); y++)
            {
                for (int x = 0; x < chars.GetLength(0); x++)
                {
                    if (x == 0)
                    {
                        xpoint = xpoint;
                    }
                    else
                    {
                        xpoint = xpoint + textwidth;
                    }

                    TextBox txt = new TextBox();
                    //txt.Name = "textBox" + y.ToString();
                    txt.Name = x.ToString() + "/" + y.ToString(); 
                    txt.Multiline = true;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.BackColor = Color.WhiteSmoke;
                    txt.ReadOnly = true;
                    txt.Width = textwidth;
                    txt.Height = textwidth;
                    txt.Tag = x.ToString() + "/" + y.ToString();
                    txt.TextAlign = HorizontalAlignment.Center;
                    //txt.Anchor = AnchorStyles.Right;
                    //txt.Anchor = AnchorStyles.Left;
                    //txt.Anchor = AnchorStyles.Top;
                    //txt.Anchor = AnchorStyles.Bottom;
                

                    txt.Font = new Font("Arial", 12.0f, FontStyle.Bold);
                    txt.Text = Convert.ToString(chars[x, y]);


                   txt.Location = new Point(xpoint, ypoint);
                  
                   // pBoggleHolder.Anchor = AnchorStyles.
                    pBoggleHolder.Controls.Add(txt);
                    pBoggleHolder.BorderStyle = BorderStyle.Fixed3D;

                }
                ypoint = ypoint + textwidth;
                xpoint = 0;

                //Console.WriteLine();
            }
            this.pBoggle.Controls.Add(pBoggleHolder);
        }


        // Handle user words and check if they are valid:
        private void rUserWord_KeyDown_1(object sender, KeyEventArgs e)
        {

            // Make all textboxes of the Bogglefield white again:
            try
            {
                foreach (Control c in pBoggleHolder.Controls)
                {
                    if (c is TextBox)
                    {
                        c.BackColor = Color.White;
                    }
                }
            }
            catch
            {
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                lusermessage.Text = "";
                string userword = rUserWord.Text.ToString();
                char[] charsToTrim = {' '};
                userword = userword.Trim(charsToTrim);
                userword = userword.ToLower();

                // User words should be atleast 2 characters in length
                if (userword.Length > 2)
                {
                    // Check if the user has already entered the word:
                    
                    if (!Userwords.Contains(userword))
                    {

                        // Check if the words is a valid:
                        if (AllUniqueFoundWords.Contains(userword))
                        {
                            Userwords.Add(userword);
                            displayword(userword);
                            rInput.Text = rInput.Text + Environment.NewLine + userword;
                            userlabelscore = userlabelscore + userword.Length;
                            lUserScore.Text = "Score: " + userlabelscore.ToString();

                            rUserWord.Text = "";
                            lWordsEntered.Text = "Found words: " + Userwords.Count.ToString() + " of " + AllUniqueFoundWords.Count.ToString();


                            try
                            {
                                SoundPlayer simpleSound = new SoundPlayer(@"valid.wav");
                                simpleSound.Play();
                            }
                            catch
                            {
                            }

                            //System.Media.SystemSounds.Hand.Play();

                        } else {

                            lusermessage.Text = userword + " is not a valid word";
                            rUserWord.Text = "";

                            try
                            {
                                SoundPlayer simpleSound = new SoundPlayer(@"wrong.wav");
                                simpleSound.Play();
                            }
                            catch
                            {
                            }
                            //System.Media.SystemSounds.Play();
                            //MessageBox.Show("This is not a valid word!");
                        }
                        
                    }
                    else
                    {
                        lusermessage.Text = "You already found the word: " + userword;
                        rUserWord.Text = "";
                        try
                        {
                            SoundPlayer simpleSound = new SoundPlayer(@"wrong.wav");
                            simpleSound.Play();
                        }
                        catch
                        {
                        }
                        //MessageBox.Show("You already found this word!");
                    }
                }
                else
                {
                    lusermessage.Text = "Only words of 3 characters and more are allowed!";
                    rUserWord.Text = "";
                    try
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"wrong.wav");
                        simpleSound.Play();
                    }
                    catch
                    {
                    }
                    //MessageBox.Show("Only words of 3 characters and more are allowed!");
                }


                // getuserwords();
            }
        }


        // Timer clock:
        private void timer3_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer3.Stop();
                lusermessage.Text = "You are out of time! Press 'solve' to see all possible words.";
                rUserWord.Enabled = false;
                ShowSolution();
                // rInput.Enabled = false;
            }
            string countertext = SecondsToHhMmSs(counter);

            lblCountDown.Text = countertext;
        }

        // From seconds to digital clock format:
        private string SecondsToHhMmSs(int seconds)
        {
            return string.Format("{0:00}:{1:00}:{2:00}", seconds / 3600, (seconds / 60) % 60, seconds % 60);
        }

        // Show help menu:
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help Helpform = new Help();
            Helpform.Show();
        }

    }
}
