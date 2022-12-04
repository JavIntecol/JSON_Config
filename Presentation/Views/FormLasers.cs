using System;
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
    public partial class FormLasers : Form
    {
        public FormLasers(string title)
        {
            InitializeComponent();
            Lbl_TitleLasers.Text = title;

            for (int i = 1; i <= 100; i++)
            {
                CmbBx_LasersLaserLines.Items.Add(i);

            }
        }

        private void FormLasers_Load(object sender, EventArgs e)
        {

        }

        public int indiceLaser;
        private void CmbBx_LasersLaserLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceLaser = CmbBx_LasersLaserLines.SelectedIndex;

            DatosSubMenu.Laser = indiceLaser;
        }
    }
}
