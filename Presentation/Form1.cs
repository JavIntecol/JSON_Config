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
            HideSubPanel();
        }

        private void Btn_StageAxes_Click(object sender, EventArgs e)
        {
            ShowSubPanel(PanelStageAxes);
        }

        private void CmbBx_StageAxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideSubPanel();
        }

        private void Btn_ObjectiveLenses_Click(object sender, EventArgs e)
        {
            ShowSubPanel(PanelObjectiveLenses);
        }

        private void CmbBx_ObjectiveLenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideSubPanel();
        }

        private void Btn_LightSheets_Click(object sender, EventArgs e)
        {
            ShowSubPanel(PanelLightSheets);
        }

        private void CmbBx_LightSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideSubPanel();
        }

        private void Btn_Lasers_Click(object sender, EventArgs e)
        {
            ShowSubPanel(PanelLasers);
        }

        private void CmbBx_Lasers_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideSubPanel();
        }

        private void Btn_FilterWheels_Click(object sender, EventArgs e)
        {
            ShowSubPanel(PanelFilterWheels);
        }

        private void CmbBx_FilterWheels_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideSubPanel();
        }

        private void Btn_Summary_Click(object sender, EventArgs e)
        {
            HideSubPanel();
        }
    }
}
