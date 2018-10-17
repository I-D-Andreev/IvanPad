using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IvanPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Font = new System.Drawing.Font("Times New Roman", 16, FontStyle.Regular);
            toolStripComboBox2.Text = "16";

            toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Underline);
            toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Strikeout);




        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(richTextBox1.Text)))
            {
                DialogResult dlgResult = MessageBox.Show("Do you wish to save?", "New file opening", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dlgResult == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                    richTextBox1.Clear();
                }
                else
                    if (dlgResult == DialogResult.No)
                    {
                        richTextBox1.Clear();
                    }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = fontDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = saveFileDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DialogResult r = colorDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                richTextBox1.SelectionColor= colorDialog1.Color;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!richTextBox1.SelectionFont.Bold)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Bold);

                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);

                }
            }
            catch (Exception E)
            {
                richTextBox1.SelectionFont = new Font("Times New Roman", 16, FontStyle.Bold);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!richTextBox1.SelectionFont.Italic)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Italic);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
                }
            }
            catch (Exception E)
            {
                richTextBox1.SelectionFont = new Font("Times New Roman", 16, FontStyle.Italic);
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!richTextBox1.SelectionFont.Underline)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
                }
            }
            catch (Exception E)
            {
                richTextBox1.SelectionFont = new Font("Times New Roman", 16, FontStyle.Underline);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!richTextBox1.SelectionFont.Strikeout)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Strikeout);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Strikeout);
                }
            }
            catch (Exception E)
            {
                richTextBox1.SelectionFont = new Font("Times New Roman", 16, FontStyle.Strikeout);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!(string.IsNullOrWhiteSpace(richTextBox1.Text)))
            {
                
                DialogResult dlgResult = MessageBox.Show("Do you wish to save?", "Opening file", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dlgResult == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                    //richTextBox1.Clear();
                }
            }
            richTextBox1.Clear();

            DialogResult r = openFileDialog1.ShowDialog();
            richTextBox1.LoadFile(openFileDialog1.FileName);
            

        }

        private void bulletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(richTextBox1.Text)))
            {

                DialogResult dlgResult = MessageBox.Show("Do you wish to save?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dlgResult == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                    richTextBox1.Clear();
                }
            }
            Application.Exit();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SelectionFont = new System.Drawing.Font(toolStripComboBox1.Text, richTextBox1.SelectionFont.Size, FontStyle.Regular);
            }
            catch (Exception E)
            {
                if (toolStripComboBox2.Text == null)
                {
                    richTextBox1.SelectionFont = new System.Drawing.Font(toolStripComboBox1.Text, 16, FontStyle.Regular);

                }
                else
                {
                    try
                    {
                        richTextBox1.SelectionFont = new System.Drawing.Font(toolStripComboBox1.Text, int.Parse(toolStripComboBox2.Text), FontStyle.Regular);
                    }
                    catch (Exception EE)
                    {
                         richTextBox1.SelectionFont = new System.Drawing.Font("Times New Roman", 16, FontStyle.Regular);
                    }
                }
            }
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.SelectionFont.OriginalFontName, int.Parse(toolStripComboBox2.Text), FontStyle.Regular);
            }
            catch (Exception E)
            {
                if (toolStripComboBox1.Text == null)
                {
                    richTextBox1.SelectionFont = new System.Drawing.Font("Times New Roman", int.Parse(toolStripComboBox2.Text), FontStyle.Regular);
                }
                else
                {
                    try
                    {
                        richTextBox1.SelectionFont = new System.Drawing.Font(toolStripComboBox1.Text, int.Parse(toolStripComboBox2.Text), FontStyle.Regular);
                    }
                    catch (Exception EE)
                    {
                        richTextBox1.SelectionFont = new System.Drawing.Font("Times New Roman", 16, FontStyle.Regular);
                    }
                }
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.SelectionFont.Bold)
                {
                    toolStripButton1.BackColor = Color.Green;
                }
                else
                    toolStripButton1.BackColor = Color.Transparent;


                if (richTextBox1.SelectionFont.Italic)
                {
                    toolStripButton2.BackColor = Color.Green;
                }
                else
                    toolStripButton2.BackColor = Color.Transparent;

                if (richTextBox1.SelectionFont.Underline)
                {
                    toolStripButton3.BackColor = Color.Green;
                }
                else
                    toolStripButton3.BackColor = Color.Transparent;

                if (richTextBox1.SelectionFont.Strikeout)
                {
                    toolStripButton4.BackColor = Color.Green;
                }
                else
                    toolStripButton4.BackColor = Color.Transparent;

                

                foreach (string s in toolStripComboBox1.Items)
                {
                    if (s == richTextBox1.SelectionFont.OriginalFontName)
                        toolStripComboBox1.Text = s;
                }

                foreach (string ss in toolStripComboBox2.Items)
                {
                    if (ss == richTextBox1.SelectionFont.Size.ToString())
                    {
                        toolStripComboBox2.Text = ss;
                    }
                }

            }
            catch (Exception E)
            {
                // do nothing
            }
        }








    }
}
