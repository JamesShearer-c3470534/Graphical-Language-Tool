using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using ICSharpCode.TextEditor.Document;
using GraphicalLanguageTool;
using TestCommandLine;
using ProFactoryPattern;
using ExecuteCommand;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;

namespace GraphicalLanguageTool
{
    public partial class Main : Form
    {
        /// <summary>
        /// <see cref="SqlConnection"/> used for the <see cref="GraphicalLanguageTool.Main"/> form.
        /// </summary>
        SqlConnection mainConnection;

        /// <summary>
        /// Identifies the programming language
        /// </summary>
        String language;

        /// <summary>
        ///  Entry point for the <see cref="GraphicalLanguageTool.Main"/> form.
        /// </summary>
        public Main()
        {
            InitializeComponent();
            Session();   
        }

        /// <summary>
        ///  Retrieves session data (<see cref="Login.sessionUsername"/>, <see cref="OpenBug.sessionOpenBug"/>) and initiates form function (<see cref="Populate"/>),
        ///  if a bug submission is loaded (when <see cref="BUGIDTXT"/> not empty).
        /// </summary>
        public void Session()
        {
            USERNAMETXT.Text = Login.sessionUsername;       //Username text field assigned value of current sessions 'Username' from Login form.
            
            BF.Enabled = false;                      //Change 'Fixed' status of bug button set to disabled by default, enabled later under conditions.
            SUBMIT.Enabled = false;   //'Submit' menu item set to disabled by default, enabled later under conditions.
           
        }
        
        /// <summary>
        ///  Connects to the database (<see cref="mainConnection"/>) and selects, then reads SQL data (<see cref="SqlDataReader"/>) that populates the fields in the <see cref="Main"/> form.
        /// </summary>
        public void Populate()
        {
            mainConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                |DataDirectory|\ASEABugTrackDB.mdf;");
            String selBugCommand = "SELECT Username, Application, Symptom, Cause, Class, Method, CodeBlock, LineNoStart, LineNoEnd, Language, Fixed FROM BugTable WHERE BugId = ";  //Only selects row of data for the currently loaded bug session.
            SqlCommand sqlBugCommand = new SqlCommand(selBugCommand, mainConnection);
            
            try
            {
                mainConnection.Open();
                SqlDataReader bugSqlDataReader = sqlBugCommand.ExecuteReader();
                while (bugSqlDataReader.Read())
                {
                    if (bugSqlDataReader.GetString(0) == Login.sessionUsername) { BF.Enabled = true; }
                    else if (bugSqlDataReader.GetString(0) != Login.sessionUsername) { BF.Enabled = false; }
                   
                    txtCode.Text = bugSqlDataReader.GetString(6);
                   
                    if (bugSqlDataReader.GetBoolean(10) == false) { LF.Text = "Unfixed"; SUBMIT.Enabled = true; }
                    else if (bugSqlDataReader.GetBoolean(10) == true) { LF.Text = "Fixed"; SUBMIT.Enabled = false;  }
                }

                String selVerCommand = "SELECT EntryNo, Username, EntryDateTime FROM VersionTable WHERE BugId = "; //Only selects rows (versions) of the bug for are linked to the original bug using the 'BugId'.
                SqlCommand sqlVerCommand = new SqlCommand(selVerCommand, mainConnection);

                bugSqlDataReader.Close();

                SqlDataReader verSqlDataReader = sqlVerCommand.ExecuteReader();
                

                
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        ///  Checks the input for code area (<see cref="txtCode"/>) is not empty or null for when a new edit submission is made.
        /// </summary>  
        public bool CheckInput()
        {
            bool rtnvalue = true;
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Error: code block empty.");
                rtnvalue = false;
            }
            return (rtnvalue);

        }

        /// <summary>
        ///  Tries to connect to the database (<see cref="mainConnection"/>), then tries to insert parameters by <see cref="SqlCommand"/>, then tries to execute.
        /// </summary>
        /// <param name="sqlFormatDateTimeNow">Used to specify <see cref="DateTime"/> formatted for SQL.</param>
        /// <param name="alteredcode">Used to indicate the block of edited code (<see cref="txtCode"/>).</param>
        /// <param name="username">Used to indicate the current session user's username (<see cref="Login.sessionUsername"/>).</param>
        /// <param name="bugid">Used to indicate the current session bug's idenfication (<see cref="BUGIDTXT"/>).</param>
        /// <param name="entryno">Used to indicate current entry number which is equal to the count of the number of edit entries (<see cref="LBINPUT"/>).</param>
        /// <param name="commandString">Used to indicate the <see cref="string"/> which inserts the parameters contained within <see cref="InsertRecord"/> to SQL format.</param>
        public void InsertRecord(String sqlFormatDateTimeNow, String alteredcode, String username, String bugid, String entryno, String commandString)
        {
            try
            {
                mainConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                |DataDirectory|\ASEABugTrackDB.mdf;");
                mainConnection.Open();
                SqlCommand cmdInsert = new SqlCommand(commandString, mainConnection);
                cmdInsert.Parameters.AddWithValue("@EntryDateTime", sqlFormatDateTimeNow);
                cmdInsert.Parameters.AddWithValue("@AlteredCode", alteredcode);
                cmdInsert.Parameters.AddWithValue("@Username", username);
                cmdInsert.Parameters.AddWithValue("@BugId", bugid);
                cmdInsert.Parameters.AddWithValue("@EntryNo", entryno);
                cmdInsert.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(bugid + "." + entryno + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///  Tries to connect to the database (<see cref="mainConnection"/>), then tries to insert <see cref="bool"/> parameter by <see cref="SqlCommand"/>, then tries to execute.
        /// </summary>
        /// <param name="fixBool">Used to specify <see cref="bool"/> value for whether bug is fixed or unfixed.</param>
        /// <param name="commandFixed">Used to indicate the <see cref="string"/> which inserts the <see cref="bool"/> parameter contained within <see cref="InsertFixRecord"/> to SQL format.</param>
        public void InsertFixRecord(bool fixBool, String commandFixed)
        {
            try
            {
                mainConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                |DataDirectory|\ASEABugTrackDB.mdf;");
                mainConnection.Open();
                SqlCommand cmdFixed = new SqlCommand(commandFixed, mainConnection);
                cmdFixed.Parameters.AddWithValue("@Fixed", fixBool);
                cmdFixed.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(fixBool + "." + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///  Assigns a programming language (<see cref="language"/>) from <see cref="TXTLANG"/>, then using a <see cref="FileSyntaxModeProvider"/>, 
        ///  sets the code text area (<see cref="txtCode"/>) when its reloaded to highlight syntax for the selected programming language (<see cref="language"/>).
        /// </summary>
        private void TxtCode_Load(object sender, EventArgs e)
        {
            language =Text;
            String dir = Application.StartupPath;
            FileSyntaxModeProvider fsmp;
            if (Directory.Exists(dir))
            {
                fsmp = new FileSyntaxModeProvider(dir);
                HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp);
                txtCode.SetHighlighting(language);
            }
        }

        /// <summary>
        ///  Exits application and environment when <see cref="EXIT"/> is clicked.
        /// </summary>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            Environment.Exit(1);
        }

        /// <summary>
        ///  This class opens a <see cref="NewBugForm"/> and displays it when <see cref="NEW"/> is clicked.
        /// </summary>
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBugForm nbf = new NewBugForm();
            nbf.Show();
        }

        /// <summary>
        ///  Opens a <see cref="OpenBug"/> form and displays it when <see cref="OPEN"/> is clicked.
        /// </summary>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenBug ob = new OpenBug();
            ob.Show();
        }

        /// <summary>
        ///  Logs the (<see cref="Login.sessionUsername"/>) out by closing <see cref="Main"/> form, creates a new <see cref="Login"/> form, 
        ///  resets <see cref="OpenBug.sessionOpenBug"/> to empty, then displays the new <see cref="Login"/> form when <see cref="logoutToolStripMenuItem"/> is clicked.
        /// </summary>
        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login session = new Login();
            OpenBug.sessionOpenBug = "";
            session.Show();
        }

        /// <summary>
        ///  Connects to the database (<see cref="mainConnection"/>) and selects, then reads SQL data (<see cref="SqlDataReader"/>) that populates the code text area 
        ///  (<see cref="txtCode"/>) and calls <see cref="TxtCode_Load"/> to reload when <see cref="LBINPUT"/> selection is changed.
        /// </summary>
        private void ListBoxInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                |DataDirectory|\ASEABugTrackDB.mdf;");
            String selCodeCommand = "SELECT AlteredCode FROM VersionTable WHERE EntryNo = " +  "AND BugId =" + OpenBug.sessionOpenBug;      //Selects the version selected from the list of the opened bug's versions.
            SqlCommand sqlCodeCommand = new SqlCommand(selCodeCommand, mainConnection);

            try
            {
                mainConnection.Open();
                SqlDataReader codeSqlDataReader = sqlCodeCommand.ExecuteReader();
                while (codeSqlDataReader.Read())
                {
                    txtCode.Text = codeSqlDataReader.GetString(0);      //Gets just the code from the database and assigns it to the text box.
                }
                codeSqlDataReader.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TxtCode_Load(null,e);       //Reloads the text area.
        }

        /// <summary>
        ///  If <see cref="CheckInput"/> is passed, inserts parameters (<see cref="InsertRecord"/>) to the database using SQL 'INSERT' statement (commandString), 
        ///  then calls <see cref="Populate"/> to display that addition in the Audit List (<see cref="LBINPUT"/>) when <see cref="SUBMIT"/> is clicked..
        /// </summary>
        private void SubmitAuditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
     
               
                Populate();
            }
        }

        /// <summary>
        ///  Opens a <see cref="DialogResult"/> prompting the user whether they would like to alter the bug's status (<see cref="LF"/> : Fixed or Unfixed), 
        ///  when 'Yes' is chosen <see cref="InsertFixRecord"/> is called to use 'UPDATE' SQL command (commandFixed) to the current (<see cref="OpenBug.sessionOpenBug"/>) 
        ///  bug's 'Fixed' value in the database when <see cref="BF"/> is clicked.
        /// </summary>
        private void ButtonFix_Click(object sender, EventArgs e)
        {
            if (LF.Text == "Unfixed")
            {
                DialogResult dialogResult = MessageBox.Show("Is the bug fixed so no more alteration submissions may be made?", "Change Bug Status", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SUBMIT.Enabled = false;
                    String commandFixed = "UPDATE BugTable SET Fixed = 1 WHERE BugId = " + Text;    
                    InsertFixRecord(true, commandFixed);                                                        //Updates database record of just the current bug's status to 'Fixed'
                    LF.Text = "Fixed";                                                                    //along with label to display on the form.
                }
                else if (dialogResult == DialogResult.No)
                {
                    //Nothing needed.
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to reopen the bug so alteration submissions may be made?", "Change Bug Status", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SUBMIT.Enabled = true;
                    String commandFixed = "UPDATE BugTable SET Fixed = 0 WHERE BugId = " + Text;      
                    InsertFixRecord(false, commandFixed);                                                       //Updates database record of just the current bug's status to 'Unfixed'.
                    LF.Text = "Unfixed";                                                                  //along with label to display on the form.
                }
                else if (dialogResult == DialogResult.No)
                {
                    //Nothing needed.
                }
            }
        }

        /// <summary>
        /// Simple 'About' dialog box to display author and 3rd party component details.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Produced by James Shearer, Computer Science Student", "About");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelLineTitle_Click(object sender, EventArgs e)
        {

        }

        private void labelHyphen1_Click(object sender, EventArgs e)
        {

        }

        private void txtLineNoEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLineNoStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLineNoEnd_Click(object sender, EventArgs e)
        {

        }

        private void txtLanguage_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonselectionif_Click(object sender, EventArgs e)
        {
            MessageBox.Show("An if statement, in C#, is a programming construct in C# used to selectively execute code statements based on the result of evaluating a Boolean expression. The Boolean expression must return either a true or false value. The if statement is used as a control statement to branch to different sections of code depending on the result of the Boolean conditional expression. The expression is stated within parentheses and evaluated during execution. If the expression results in a true value, the code following the if statement is executed. Otherwise, the code following an optional else statement is executed. If there is no else statement, execution continues with the code after the if block.","Selection - If Statement");
        }



        private void buttonselectionelse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("An if statement, in C#, is a programming construct in C# used to selectively execute code statements based on the result of evaluating a Boolean expression. The Boolean expression must return either a true or false value. The if statement is used as a control statement to branch to different sections of code depending on the result of the Boolean conditional expression. The expression is stated within parentheses and evaluated during execution. If the expression results in a true value, the code following the if statement is executed. Otherwise, the code following an optional else statement is executed. If there is no else statement, execution continues with the code after the if block.", "Selection - If Statement");
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

       
            

        private void Button1_Click_1(object sender, EventArgs e)
        {
        Form22 paint = new Form22();
                    paint.Show(); // or somename.ShowDialog(); if you want the new form to have priority until it is closed
        }

        private void MS1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
                Form1 commandline = new Form1();
                commandline.Show(); // or somename.ShowDialog(); if you want the new form to have priority until it is closed
            
        }

        Panel aspPanel = new Panel();
        Button aspbutton = new Button();

        private void USERNAMETXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form22 drawing = new Form22();
            drawing.Show(); // or somename.ShowDialog(); if you want the new form to have priority until it is closed
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form22 pen = new Form22();
            pen.Show(); // or somename.ShowDialog(); if you want the new form to have priority until it is closed
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            frmFactoryTest factoryclass = new frmFactoryTest();
            factoryclass.Show(); // or somename.ShowDialog(); if you want the new form to have priority until it is closed
        }



        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Process j = new Process();
            j.StartInfo.FileName = "EXC.exe";
            j.Start();
        }
       
    }

}
