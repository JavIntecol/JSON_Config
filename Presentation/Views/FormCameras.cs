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
    public partial class FormCameras : Form
    {
        public FormCameras(string title)
        {
            InitializeComponent();
            Lbl_TitleCamera.Text = title;
        }
    }
}
