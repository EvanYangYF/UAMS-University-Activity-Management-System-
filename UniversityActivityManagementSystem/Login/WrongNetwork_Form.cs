using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityActivityManagementSystem
{
    public partial class WrongNetwork_Form : Form
    {
            public WrongNetwork_Form()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                 this.DialogResult = DialogResult.Retry;
                 this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
    }

