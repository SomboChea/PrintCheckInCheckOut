using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using min2Hour;
using System.IO;

namespace PrintCheckInCheckOut
{
    public partial class checkInCheckOut : Form
    {
        public checkInCheckOut()
        {
            InitializeComponent();
            //set Print document :
            document.PrintPage += new PrintPageEventHandler(printResult_PrintPage);
        }

        //Global variables access in this form are here :
        private DateTime start, end;
        private double totalMin = 0;
        private string res = "";
        private double pay = 0;
        bool hasSave = false;
        string pathName = "";
        string copyText = "";

        //Decleared for Printing Document : 
        PrintDocument document = new PrintDocument();
        PrintDialog dialogPrint = new PrintDialog();
        PrintPreviewDialog previewDocument = new PrintPreviewDialog();

        //Shortcut Key for Print document | Ctrl + P :
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Alt | Keys.P))
            {
                if(btnPrint.Enabled==true)
                {
                    //Show preview print document :
                    previewDocument.Document = printResult;
                    previewDocument.ShowDialog();
                } else
                {
                    MessageBox.Show("Cannot Preview Print! Document is nothing!");
                }
                
                return true;
            }

            if (keyData == (Keys.Control | Keys.P))
            {
                if (btnPrint.Enabled == true)
                {
                    dialogPrint.Document = document;
                    if (dialogPrint.ShowDialog() == DialogResult.OK)
                    {
                        document.Print();
                    }
                    else
                    {
                        MessageBox.Show("Error while printing...!");
                    }
                }
                else
                {
                    MessageBox.Show("Cannot Print! Document is nothing!");
                }

                return true;
            }

            if (keyData == (Keys.Control | Keys.X))
            {
                Application.Exit();

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Set document for print :
        private void printResult_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtRes.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black,0,0);
        }

        //Button for Printing Document here :
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (btnPrint.Enabled == true)
            {
                dialogPrint.Document = document;
                if (dialogPrint.ShowDialog() == DialogResult.OK)
                {
                    document.Print();
                }
                else
                {
                    MessageBox.Show("Error while printing...!");
                }
            }
            else
            {
                MessageBox.Show("Cannot Print! Document is nothing!");
            }
        }

        //Set for timer
        private void timer_Tick(object sender, EventArgs e)
        {
            lbTimer.Text = "Date: " + DateTime.Now.ToString("dd/MM/yyyy") + " - Time: " + DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss");
        }

        //Form load here :
        private void checkInCheckOut_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            btnCheckOut.Enabled = false;
            btnPrint.Enabled = false;
        }

        //Button for CheckOut here :
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = true;
            btnCheckIn.Enabled = true;
            btnCheckOut.Enabled = false;
            saveAsToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            printPreviewToolStripMenuItem.Enabled = true;
            printToolStripMenuItem.Enabled = true;
            copyToolStripMenuItem.Enabled = true;

            //Declared for Min to Hour function : 
            min2HourMain stHour = new min2HourMain();
            min2Timespan t = new min2Timespan();

            //Core checkOut code here :
            end = DateTime.Now;
            txtCheckOut.Text = end.ToString("dd/MM/yyyy HH:mm:ss");
            res += "End Time  : " + end + "\r\n";
            end = end.AddMilliseconds(-end.Millisecond);
            end = end.AddSeconds(-end.Second);
            totalMin = (end - start).TotalMinutes;
            totalMin = Math.Round(totalMin);
            double payTime = 0,totalTime = 0;
            totalTime = totalMin;
            int hour = t.tHour(totalMin);
            int min = t.tMin(totalMin);

            if (totalMin >= 120)
            {
                payTime = totalMin - 120;
            }
            
            if (hour >= 2)
            {
                hour -= 2;
                pay = hour * 2000;
                if (min >= 1 && min <= 30)
                {
                    pay += 1000;
                } else if (min > 30)
                {
                    pay += 2000;
                }
            }
            res += "------------------------------------------------\r\n";
            res += "Usage Time : " + stHour.min2Day(totalTime) + "\r\n";
            res += "NOTE * : FREE 2 HOURS\r\n";
            res += "------------------------------------------------\r\n";
            res += "Pay Time : " + stHour.min2Day(payTime) + "\r\n";
            res += "Total Pay : " + pay + " Riel";
            txtRes.Text = res;
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            previewDocument.Document = printResult;
            previewDocument.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogPrint.Document = document;
            if (dialogPrint.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
            else
            {
                MessageBox.Show("Error while printing...!");
            }
        }

        private void exitCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            res = "";
            txtRes.Text = "";
            txtCheckIn.Text = "";
            txtCheckOut.Text = "";
            btnCheckIn.Enabled = true;
            btnCheckOut.Enabled = false;
            btnPrint.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
            printToolStripMenuItem.Enabled = false;
            printPreviewToolStripMenuItem.Enabled = false;
            newToolStripMenuItem.Enabled = false;
            openToolStripMenuItem.Enabled = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "txt files (*.txt)|*.txt|sb files (*.sb)|*.sb|All files (*.*)|*.*";
            if (of.ShowDialog() == DialogResult.OK)
            {
                txtRes.Text = File.ReadAllText(of.FileName);
                saveAsToolStripMenuItem.Enabled = true;
                newToolStripMenuItem.Enabled = true;
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt|sb files (*.sb)|*.sb|All files (*.*)|*.*";
            saveFile.FilterIndex = 1;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, txtRes.Text);
                saveToolStripMenuItem.Enabled = false;
                openToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error while save file!");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt|sb files (*.sb)|*.sb|All files (*.*)|*.*";
            saveFile.FilterIndex = 1;
            
            if (hasSave == true)
            {
                if(File.Exists(pathName))
                {
                    File.WriteAllText(pathName, txtRes.Text);
                    MessageBox.Show("Was saved");
                } else
                {
                    MessageBox.Show("File not found!\nPlease save a new!");
                    saveAsToolStripMenuItem_Click(sender, e);
                }
            }
            else
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFile.FileName, txtRes.Text);
                    pathName = saveFile.FileName;
                    hasSave = true;
                    openToolStripMenuItem.Enabled = true;
                    saveToolStripMenuItem.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error while save file!");
                }
            }
        }

        private void txtRes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtRes.Text);
            copyText = Clipboard.GetText();
            pasteToolStripMenuItem.Enabled = true;
            copyToolStripMenuItem.Enabled = false;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRes.Text = copyText;
            copyToolStripMenuItem.Enabled = false;
        }

        private void aboutAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by SamboChea\r\nVersion : 0.0.0.1");
        }

        private void listHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            License objLin = new License();
            objLin.ShowDialog();
        }

        //Button for CheckIn has here :
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            res = "";
            txtRes.Text = "";
            btnCheckIn.Enabled = false;
            btnCheckOut.Enabled = true;
            btnPrint.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
            openToolStripMenuItem.Enabled = false;
            newToolStripMenuItem.Enabled = true;
            printPreviewToolStripMenuItem.Enabled = false;
            printToolStripMenuItem.Enabled = false;
            copyToolStripMenuItem.Enabled = false;
            pasteToolStripMenuItem.Enabled = false;

            //Core checkIn code here :
            start = DateTime.Now;
            txtCheckIn.Text = start.ToString("dd/MM/yyyy HH:mm:ss");
            res += "Start Time : " + start + "\r\n";
            start = start.AddMilliseconds(-start.Millisecond);
            start = start.AddSeconds(-start.Second);
          
            txtRes.Text = res;
        }
    }
}
