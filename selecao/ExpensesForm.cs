﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace selecao
{
    public partial class ExpensesForm : Form
    {
        public ExpensesForm() => InitializeComponent();
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            switch (e.CloseReason)
            {                
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    Hide();
                    break;
                default:
                    break;
            }
        }
    }
}
