using ComponentFactory.Krypton.Toolkit;
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
    public partial class FormObjectiveLenses : Form
    {
        public FormObjectiveLenses(string title)
        {
            InitializeComponent();
            Lbl_TitleStageAxes.Text = title;

            CmbBx_ObjectiveAxisObjectiveLenses.Items.Add(0);
            CmbBx_ObjectiveAxisObjectiveLenses.Items.Add(1);
           
        }
       
        public int indiceObjectiveAxis;
        public void CmbBx_ObjectiveAxisObjectiveLenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            indiceObjectiveAxis = CmbBx_ObjectiveAxisObjectiveLenses.SelectedIndex;
            
            DatosSubMenu.ObjectiveAxis = indiceObjectiveAxis;
            
        }
               
    }
}
