using ComponentFactory.Krypton.Toolkit;
using System;

namespace Presentation
{
    public partial class Form1 : KryptonForm
    {

        public Form1()
        {
            InitializeComponent();
            CustomizeDesing();


            CmbBx_Cameras.Items.Add(1);
            CmbBx_Cameras.Items.Add(2);
            CmbBx_Cameras.Items.Add(3);
            CmbBx_Cameras.Items.Add(4);

            CmbBx_StageAxes.Items.Add(1);
            CmbBx_StageAxes.Items.Add(2);
            CmbBx_StageAxes.Items.Add(3);
            CmbBx_StageAxes.Items.Add(4);

            CmbBx_ObjectiveLenses.Items.Add(1);
            CmbBx_ObjectiveLenses.Items.Add(2);
            CmbBx_ObjectiveLenses.Items.Add(3);
            CmbBx_ObjectiveLenses.Items.Add(4);

            CmbBx_LightSheets.Items.Add(1);
            CmbBx_LightSheets.Items.Add(2);
            CmbBx_LightSheets.Items.Add(3);
            CmbBx_LightSheets.Items.Add(4);

            CmbBx_Lasers.Items.Add(1);
            CmbBx_Lasers.Items.Add(2);
            CmbBx_Lasers.Items.Add(3);
            CmbBx_Lasers.Items.Add(4);

            CmbBx_FilterWheels.Items.Add(1);
            CmbBx_FilterWheels.Items.Add(2);
            CmbBx_FilterWheels.Items.Add(3);
            CmbBx_FilterWheels.Items.Add(4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CustomizeDesing()
        {
            PanelCameras.Visible = false;
            PanelStageAxes.Visible = false;
            PanelObjectiveLenses.Visible = false;
            PanelLightSheets.Visible = false;
            PanelLasers.Visible = false;
            PanelFilterWheels.Visible = false;
        }

        private void HideSubPanel()
        {
            if (PanelCameras.Visible == true)
                PanelCameras.Visible = false;

            if (PanelStageAxes.Visible == true)
                PanelStageAxes.Visible = false;

            if (PanelObjectiveLenses.Visible == true)
                PanelObjectiveLenses.Visible = false;

            if (PanelLightSheets.Visible == true)
                PanelLightSheets.Visible = false;

            if (PanelLasers.Visible == true)
                PanelLasers.Visible = false;

            if (PanelFilterWheels.Visible == true)
                PanelFilterWheels.Visible = false;
        }

        private void ShowSubPanel(KryptonPanel SubPanel)
        {
            if (SubPanel.Visible == false)
            {
                HideSubPanel();
                SubPanel.Visible = true;
            }
            else
                SubPanel.Visible = false;
        }

        private void Btn_Cameras_Click(object sender, EventArgs e)
        {
            ShowSubPanel(PanelCameras);

        }

        private void CmbBx_Cameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PanelNumCameras.Controls.Clear();


            int indiceCameras = CmbBx_Cameras.SelectedIndex;
            int num_cameras = indiceCameras + 1;

            for (int camera = num_cameras; camera >= 1; camera--)
            {
                AddBotton(PanelNumCameras, "Camera", camera);
            }


            HideSubPanel();
        }

        private void Btn_StageAxes_Click(object sender, EventArgs e)
        {
            ShowSubPanel(PanelStageAxes);
        }

        private void CmbBx_StageAxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PanelNumStageAxes.Controls.Clear();


            int indiceStageAxes = CmbBx_StageAxes.SelectedIndex;
            int num_StageAxes = indiceStageAxes + 1;

            for (int StageAxis = num_StageAxes; StageAxis >= 1; StageAxis--)
            {
                AddBotton(PanelNumStageAxes, "StageAxis", StageAxis);
            }

            HideSubPanel();
        }

        private void Btn_ObjectiveLenses_Click(object sender, EventArgs e)
        {
            ShowSubPanel(PanelObjectiveLenses);
        }

        private void CmbBx_ObjectiveLenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PanelNumObjectiveLenses.Controls.Clear();


            int indiceLenses = CmbBx_ObjectiveLenses.SelectedIndex;
            int num_ObjectiveLenses = indiceLenses + 1;

            for (int ObjectiveLens = num_ObjectiveLenses; ObjectiveLens >= 1; ObjectiveLens--)
            {
                AddBotton(PanelNumObjectiveLenses, "ObjectiveLens", ObjectiveLens);
            }

            HideSubPanel();
        }

        private void Btn_LightSheets_Click(object sender, EventArgs e)
        {
            ShowSubPanel(PanelLightSheets);
        }

        private void CmbBx_LightSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PanelNumLightSheets.Controls.Clear();


            int indiceLightSheets = CmbBx_LightSheets.SelectedIndex;
            int num_LightSheets = indiceLightSheets + 1;

            for (int LightSheet = num_LightSheets; LightSheet >= 1; LightSheet--)
            {
                AddBotton(PanelNumLightSheets, "LightSheet", LightSheet);
            }

            HideSubPanel();
        }

        private void Btn_Lasers_Click(object sender, EventArgs e)
        {
            ShowSubPanel(PanelLasers);
        }

        private void CmbBx_Lasers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PanelNumLasers.Controls.Clear();


            int indiceLasers = CmbBx_Lasers.SelectedIndex;
            int num_Lasers = indiceLasers + 1;

            for (int Laser = num_Lasers; Laser >= 1; Laser--)
            {
                AddBotton(PanelNumLasers, "Laser", Laser);
            }

            HideSubPanel();
        }

        private void Btn_FilterWheels_Click(object sender, EventArgs e)
        {
            ShowSubPanel(PanelFilterWheels);
        }

        private void CmbBx_FilterWheels_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PanelNumFilterWheels.Controls.Clear();


            int indiceFilterWheels = CmbBx_FilterWheels.SelectedIndex;
            int num_FilterWheels = indiceFilterWheels + 1;

            for (int FilterWheel = num_FilterWheels; FilterWheel >= 1; FilterWheel--)
            {
                AddBotton(PanelNumFilterWheels, "FilterWheel", FilterWheel);
            }

            HideSubPanel();
        }

        private void Btn_Summary_Click(object sender, EventArgs e)
        {
            HideSubPanel();
        }

        private void AddBotton(KryptonPanel ItemPanel, String Item, int numButtons)
        {
            KryptonButton oBotton = new KryptonButton();

            oBotton.Name = "Btn_" + Item + "_" + numButtons.ToString();
            oBotton.Text = Item + " " + numButtons.ToString();
            oBotton.Palette = krypton;
            oBotton.Dock = System.Windows.Forms.DockStyle.Top;

            if (numButtons > 1)
            {
                oBotton.Enabled = false;
            }

            ItemPanel.Controls.Add(oBotton);

        }

        private void handlerComun_Click(object sender, EventArgs e)
        {
            Console.Beep(((KryptonButton)sender).Location.Y * 10, 100);
        }
    }
}
