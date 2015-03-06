using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace PayrollSystem.view
{
    public partial class PayslipForm : Form
    {
        public PayslipForm()
        {
            InitializeComponent();
            ElementHost elhost = new ElementHost();
            elhost.Size = new Size(688, 396);
            //elhost.Location = new Point(45, 35);

            PayslipWPFControl wpfctl = new PayslipWPFControl();
            elhost.Child = wpfctl;

            this.Controls.Add(elhost);
        }
    }
}
