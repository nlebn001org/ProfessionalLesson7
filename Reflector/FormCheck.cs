using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reflector
{
    public partial class FormCheck : Form
    {
        public FormCheck()
        {
            InitializeComponent();
            (cbAll.Checked, cbMethod.Checked, cbProperties.Checked, cbWithAttributes.Checked) = Checker.Checkboxes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Checker.Checkboxes = (cbAll.Checked, cbMethod.Checked, cbProperties.Checked, cbWithAttributes.Checked);
            Close();
        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked == true)
            {
                cbMethod.Checked = false;
                cbProperties.Checked = false;
                cbWithAttributes.Checked = false;
                cbMethod.Enabled = false;
                cbProperties.Enabled = false;
                cbWithAttributes.Enabled = false;
            }
            else
            {
                cbMethod.Enabled = true;
                cbProperties.Enabled = true;
                cbWithAttributes.Enabled = true;
            }

        }
    }
}
