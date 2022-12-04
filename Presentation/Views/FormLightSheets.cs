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
    public partial class FormLightSheets : Form
    {
        public FormLightSheets(string title)
        {
            InitializeComponent();
            Lbl_TitleLightSheets.Text = title;

            for(int i = 1; i <= 100; i++)
            {
                CmbBx_LightSheetsLightsheetAxes.Items.Add(i);
                
            }
        }

        private void FormLightSheets_Load(object sender, EventArgs e)
        {

        }

        public int indiceLightSheet;
        private void CmbBx_LightSheetsLightsheetAxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceLightSheet = CmbBx_LightSheetsLightsheetAxes.SelectedIndex;

            DatosSubMenu.LightSheets = indiceLightSheet;
        }
    }
}
