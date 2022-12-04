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
    public partial class FormFilterWheels : Form
    {
        public FormFilterWheels(string title)
        {
            InitializeComponent();
            Lbl_TitleFilterWheels.Text = title;

            for (int i = 1; i <= 100; i++)
            {
                CmbBx_FilterWheelsFilters.Items.Add(i);

            }
        }

        private void FormFilterWheels_Load(object sender, EventArgs e)
        {

        }

        public int indiceFilterWheel;
        private void CmbBx_FilterWheelsFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceFilterWheel = CmbBx_FilterWheelsFilters.SelectedIndex;

            DatosSubMenu.Laser = indiceFilterWheel;
        }
    }
}
