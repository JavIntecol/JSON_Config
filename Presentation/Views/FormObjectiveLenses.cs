﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class FormObjectiveLenses : Form
    {
        public FormObjectiveLenses(string title)
        {
            InitializeComponent();
            Lbl_TitleStageAxes.Text = title;
        }

        private void PanelControlObjectiveLenses_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}