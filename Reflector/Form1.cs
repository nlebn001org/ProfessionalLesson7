using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;


namespace Reflector
{
    public partial class Form1 : Form
    {

        Assembly assembly = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string path = openFileDialog.FileName;

                try
                {
                    assembly = Assembly.LoadFile(path);
                    textBox.Text += "ASSEMBLY    " + path + "  -  WAS SUCCESSFULLY DOWNLOADED" + Environment.NewLine + Environment.NewLine;
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                textBox.Text += "LIST OF ALL CHOSEN TYPES IN ASSEMBLY:     " + assembly.FullName + Environment.NewLine + Environment.NewLine;

                Type[] types = assembly.GetTypes();

                if (Checker.Checkboxes.CAll && types != null) Logic.GetAll(types, textBox);
                if (Checker.Checkboxes.CMethods && types != null) Logic.GetMethods(types, textBox);
                if (Checker.Checkboxes.CProperties && types != null) Logic.GetProperties(types, textBox);
                if (Checker.Checkboxes.CAttributes && types != null) Logic.GetWithAttributes(types, textBox);
                if (Checker.Checkboxes == (false, false, false, false)) { textBox.Text = "Nothing was chosen."; }

            }
        }
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CHoose(object sender, EventArgs e)
        {
            FormCheck formCheck = new FormCheck();
            formCheck.Show();
        }

        private void ClearTextBlock(object sender, EventArgs e)
        {
            textBox.Text = string.Empty;
        }
    }
}
