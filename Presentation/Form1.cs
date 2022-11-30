using ComponentFactory.Krypton.Toolkit;
using Presentation.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

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

            Lbl_NumCameras.Enabled = true;

            int indiceCameras = CmbBx_Cameras.SelectedIndex;
            int num_cameras = indiceCameras + 1;

            for (int camera = num_cameras; camera >= 1; camera--)
            {
                AddBotton(PanelNumCameras, "Camera", camera);
            }

            AddTab(PanelNumCameras, "Cameras");

            //openChildForm(new FormCamera(), sender);

            HideSubPanel();
        }

        private void Btn_StageAxes_Click(object sender, EventArgs e)
        {
            ShowSubPanel(PanelStageAxes);
        }

        private void CmbBx_StageAxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PanelNumStageAxes.Controls.Clear();

            Lbl_NumStageAxes.Enabled = true;

            int indiceStageAxes = CmbBx_StageAxes.SelectedIndex;
            int num_StageAxes = indiceStageAxes + 1;

            for (int StageAxis = num_StageAxes; StageAxis >= 1; StageAxis--)
            {
                AddBotton(PanelNumStageAxes, "StageAxis", StageAxis);
            }

            AddTab(PanelNumStageAxes, "StageAxis");

            HideSubPanel();
        }

        private void Btn_ObjectiveLenses_Click(object sender, EventArgs e)
        {
            ShowSubPanel(PanelObjectiveLenses);
        }

        private void CmbBx_ObjectiveLenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PanelNumObjectiveLenses.Controls.Clear();

            Lbl_NumObjectiveLenses.Enabled = true;

            int indiceLenses = CmbBx_ObjectiveLenses.SelectedIndex;
            int num_ObjectiveLenses = indiceLenses + 1;

            for (int ObjectiveLens = num_ObjectiveLenses; ObjectiveLens >= 1; ObjectiveLens--)
            {
                AddBotton(PanelNumObjectiveLenses, "ObjectiveLens", ObjectiveLens);
            }

            AddTab(PanelNumObjectiveLenses, "ObjectiveLens");

            HideSubPanel();
        }

        private void Btn_LightSheets_Click(object sender, EventArgs e)
        {
            ShowSubPanel(PanelLightSheets);
        }

        private void CmbBx_LightSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PanelNumLightSheets.Controls.Clear();

            Lbl_NumLightSheets.Enabled = true;

            int indiceLightSheets = CmbBx_LightSheets.SelectedIndex;
            int num_LightSheets = indiceLightSheets + 1;

            for (int LightSheet = num_LightSheets; LightSheet >= 1; LightSheet--)
            {
                AddBotton(PanelNumLightSheets, "LightSheet", LightSheet);
            }

            AddTab(PanelNumLightSheets, "LightSheet");

            HideSubPanel();
        }

        private void Btn_Lasers_Click(object sender, EventArgs e)
        {
            ShowSubPanel(PanelLasers);
        }

        private void CmbBx_Lasers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PanelNumLasers.Controls.Clear();

            Lbl_NumLasers.Enabled = true;

            int indiceLasers = CmbBx_Lasers.SelectedIndex;
            int num_Lasers = indiceLasers + 1;

            for (int Laser = num_Lasers; Laser >= 1; Laser--)
            {
                AddBotton(PanelNumLasers, "Laser", Laser);
            }

            AddTab(PanelNumLasers, "Laser");

            HideSubPanel();
        }

        private void Btn_FilterWheels_Click(object sender, EventArgs e)
        {
            ShowSubPanel(PanelFilterWheels);
        }

        private void CmbBx_FilterWheels_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PanelNumFilterWheels.Controls.Clear();

            Lbl_NumFilterWheels.Enabled = true;

            int indiceFilterWheels = CmbBx_FilterWheels.SelectedIndex;
            int num_FilterWheels = indiceFilterWheels + 1;

            for (int FilterWheel = num_FilterWheels; FilterWheel >= 1; FilterWheel--)
            {
                AddBotton(PanelNumFilterWheels, "FilterWheel", FilterWheel);
            }

            AddTab(PanelNumFilterWheels, "FilterWheel");

            HideSubPanel();
        }


        private void AddTab(KryptonPanel ItemPanel, String Item)
        {
            KryptonPanel tab = new KryptonPanel();

            tab.Name = "Tab_" + Item;
            tab.Palette = krypton;
            tab.Dock = System.Windows.Forms.DockStyle.Left;
            tab.Width = 20;

            ItemPanel.Controls.Add(tab);
        }


        public KryptonPanel subMenu_ObjectiveLens_1 = null;
        public KryptonPanel subMenu_ObjectiveLens_2 = null;
        public KryptonPanel subMenu_ObjectiveLens_3 = null;
        public KryptonPanel subMenu_ObjectiveLens_4 = null;

        public KryptonPanel subMenu_LightSheet_1 = null;
        public KryptonPanel subMenu_LightSheet_2 = null;
        public KryptonPanel subMenu_LightSheet_3 = null;
        public KryptonPanel subMenu_LightSheet_4 = null;

        public KryptonPanel subMenu_Laser_1 = null;
        public KryptonPanel subMenu_Laser_2 = null;
        public KryptonPanel subMenu_Laser_3 = null;
        public KryptonPanel subMenu_Laser_4 = null;

        public KryptonPanel subMenu_FilterWheel_1 = null;
        public KryptonPanel subMenu_FilterWheel_2 = null;
        public KryptonPanel subMenu_FilterWheel_3 = null;
        public KryptonPanel subMenu_FilterWheel_4 = null;

        public void AddSubMenu(KryptonPanel ItemPanel, String Item)
        {
            KryptonPanel subMenu = new KryptonPanel();

            subMenu.Name = "subMenu_" + Item;
            subMenu.Palette = krypton;
            subMenu.Dock = System.Windows.Forms.DockStyle.Top;
            subMenu.AutoSize = true;

            subMenu_ObjectiveLens_1 = subMenu;



            ItemPanel.Controls.Add(subMenu);
        }


        public void AddBotton(KryptonPanel ItemPanel, String Item, int numButtons)
        {
            KryptonButton oBotton = new KryptonButton();

            oBotton.Name = "Btn_" + Item + "_" + numButtons.ToString();
            oBotton.Text = Item + " " + numButtons.ToString();
            oBotton.Palette = krypton;
            oBotton.Dock = System.Windows.Forms.DockStyle.Top;


            //if (numButtons > 1)
            //{
            //    oBotton.Enabled = false;
            //}

            if (Item == "Camera")
            {
                oBotton.Click += new EventHandler(handlerCameras_Click);
            }


            if (Item == "StageAxis")
                oBotton.Click += new EventHandler(handlerStageAxes_Click);

            if (Item == "ObjectiveLens")
            {
                oBotton.Click += new EventHandler(handlerObjectiveLenses_Click);
                AddSubMenu(PanelNumObjectiveLenses, Item + "_" + numButtons.ToString());
            }

            if (Item == "LightSheet")
                oBotton.Click += new EventHandler(handlerLightSheets_Click);

            if (Item == "Laser")
                oBotton.Click += new EventHandler(handlerLasers_Click);

            if (Item == "FilterWheel")
                oBotton.Click += new EventHandler(handlerFilterWheels_Click);

            ItemPanel.Controls.Add(oBotton);

        }

        private void AddBtnSubmenu(KryptonPanel PanelSubmenu, string nameSubMenu, int numButton)
        {
            int numBtnSubmenu = DatosSubMenu.ObjectiveAxis;

            KryptonButton BottonSubMenu = new KryptonButton();

            BottonSubMenu.Name = "Btn_" + nameSubMenu + "_" + numButton.ToString();
            BottonSubMenu.Text = nameSubMenu + " " + numButton.ToString();
            BottonSubMenu.Palette = krypton;
            BottonSubMenu.Dock = System.Windows.Forms.DockStyle.Top;


            //if (numButtons > 1)
            //{
            //    oBotton.Enabled = false;
            //}

            PanelSubmenu.Controls.Add(BottonSubMenu);

            AddTab(PanelSubmenu, nameSubMenu);
        }

        public void AddBtnNext(String Item)
        {
            this.PanelNext.Controls.Clear();

            KryptonButton BottonNext = new KryptonButton();

            BottonNext.Name = "Btn_Next" + Item;
            BottonNext.Text = "Next";
            BottonNext.Palette = krypton;
            BottonNext.Location = new Point(630, 20);
            BottonNext.Size = new Size(90, 40);

            if (Item == "ObjectiveLens")
            {
                
                BottonNext.Click += new EventHandler(handlerObjectiveAxis_Click);
                
            }

            PanelNext.Controls.Add(BottonNext);

        }

        #region HandlersPrincipales

        private Form FormCamera_1 = null;
        private Form FormCamera_2 = null;
        private Form FormCamera_3 = null;
        private Form FormCamera_4 = null;
        private void handlerCameras_Click(object sender, EventArgs e)
        {
            KryptonButton repBtnCamera = sender as KryptonButton;
            string IdBtnCamera = repBtnCamera.Text;

            if (IdBtnCamera == "Camera 1")
            {
                if (FormCamera_1 == null)
                {
                    FormCamera_1 = new FormCameras(IdBtnCamera);
                    openChildForm(FormCamera_1, sender);


                }
                else
                {
                    openChildForm(FormCamera_1, sender);
                }
            }

            if (IdBtnCamera == "Camera 2")
            {
                if (FormCamera_2 == null)
                {
                    FormCamera_2 = new FormCameras(IdBtnCamera);
                    openChildForm(FormCamera_2, sender);
                }
                else
                {
                    openChildForm(FormCamera_2, sender);
                }
            }

            if (IdBtnCamera == "Camera 3")
            {
                if (FormCamera_3 == null)
                {
                    FormCamera_3 = new FormCameras(IdBtnCamera);
                    openChildForm(FormCamera_3, sender);
                }
                else
                {
                    openChildForm(FormCamera_3, sender);
                }
            }

            if (IdBtnCamera == "Camera 4")
            {
                if (FormCamera_4 == null)
                {
                    FormCamera_4 = new FormCameras(IdBtnCamera);
                    openChildForm(FormCamera_4, sender);
                }
                else
                {
                    openChildForm(FormCamera_4, sender);
                }
            }

            AddBtnNext("Camera");

        }

        private Form FormStageAxis_1 = null;
        private Form FormStageAxis_2 = null;
        private Form FormStageAxis_3 = null;
        private Form FormStageAxis_4 = null;
        private void handlerStageAxes_Click(object sender, EventArgs e)
        {
            KryptonButton repBtnStageAxes = sender as KryptonButton;
            string IdBtnStageAxes = repBtnStageAxes.Text;

            if (IdBtnStageAxes == "StageAxis 1")
            {
                if (FormStageAxis_1 == null)
                {
                    FormStageAxis_1 = new FormStageAxes(IdBtnStageAxes);
                    openChildForm(FormStageAxis_1, sender);
                }
                else
                {
                    openChildForm(FormStageAxis_1, sender);
                }
            }

            if (IdBtnStageAxes == "StageAxis 2")
            {
                if (FormStageAxis_2 == null)
                {
                    FormStageAxis_2 = new FormStageAxes(IdBtnStageAxes);
                    openChildForm(FormStageAxis_2, sender);
                }
                else
                {
                    openChildForm(FormStageAxis_2, sender);
                }
            }

            if (IdBtnStageAxes == "StageAxis 3")
            {
                if (FormStageAxis_3 == null)
                {
                    FormStageAxis_3 = new FormStageAxes(IdBtnStageAxes);
                    openChildForm(FormStageAxis_3, sender);
                }
                else
                {
                    openChildForm(FormStageAxis_3, sender);
                }
            }

            if (IdBtnStageAxes == "StageAxis 4")
            {
                if (FormStageAxis_4 == null)
                {
                    FormStageAxis_4 = new FormStageAxes(IdBtnStageAxes);
                    openChildForm(FormStageAxis_4, sender);
                }
                else
                {
                    openChildForm(FormStageAxis_4, sender);
                }
            }

        }


        private Form FormObjectiveLens_1 = null;
        private Form FormObjectiveLens_2 = null;
        private Form FormObjectiveLens_3 = null;
        private Form FormObjectiveLens_4 = null;
        private void handlerObjectiveLenses_Click(object sender, EventArgs e)
        {
            KryptonButton repBtnObjectiveLens = sender as KryptonButton;
            string IdBtnObjectiveLens = repBtnObjectiveLens.Text;

            if (IdBtnObjectiveLens == "ObjectiveLens 1")
            {
                if (FormObjectiveLens_1 == null)
                {
                    FormObjectiveLens_1 = new FormObjectiveLenses(IdBtnObjectiveLens);
                    openChildForm(FormObjectiveLens_1, sender);
                }
                else
                {
                    openChildForm(FormObjectiveLens_1, sender);
                }
            }

            if (IdBtnObjectiveLens == "ObjectiveLens 2")
            {
                if (FormObjectiveLens_2 == null)
                {
                    FormObjectiveLens_2 = new FormObjectiveLenses(IdBtnObjectiveLens);
                    openChildForm(FormObjectiveLens_2, sender);
                }
                else
                {
                    openChildForm(FormObjectiveLens_2, sender);
                }
            }

            if (IdBtnObjectiveLens == "ObjectiveLens 3")
            {
                if (FormObjectiveLens_3 == null)
                {
                    FormObjectiveLens_3 = new FormObjectiveLenses(IdBtnObjectiveLens);
                    openChildForm(FormObjectiveLens_3, sender);
                }
                else
                {
                    openChildForm(FormObjectiveLens_3, sender);
                }
            }

            if (IdBtnObjectiveLens == "ObjectiveLens 4")
            {
                if (FormObjectiveLens_4 == null)
                {
                    FormObjectiveLens_4 = new FormObjectiveLenses(IdBtnObjectiveLens);
                    openChildForm(FormObjectiveLens_4, sender);
                }
                else
                {
                    openChildForm(FormObjectiveLens_4, sender);
                }
            }

            AddBtnNext("ObjectiveLens");

        }


        private Form FormLightSheet_1 = null;
        private Form FormLightSheet_2 = null;
        private Form FormLightSheet_3 = null;
        private Form FormLightSheet_4 = null;
        private void handlerLightSheets_Click(object sender, EventArgs e)
        {
            KryptonButton repBtnLightSheet = sender as KryptonButton;
            string IdBtnLightSheet = repBtnLightSheet.Text;

            if (IdBtnLightSheet == "LightSheet 1")
            {
                if (FormLightSheet_1 == null)
                {
                    FormLightSheet_1 = new FormLightSheets(IdBtnLightSheet);
                    openChildForm(FormLightSheet_1, sender);
                }
                else
                {
                    openChildForm(FormLightSheet_1, sender);
                }
            }

            if (IdBtnLightSheet == "LightSheet 2")
            {
                if (FormLightSheet_2 == null)
                {
                    FormLightSheet_2 = new FormLightSheets(IdBtnLightSheet);
                    openChildForm(FormLightSheet_2, sender);
                }
                else
                {
                    openChildForm(FormLightSheet_2, sender);
                }
            }

            if (IdBtnLightSheet == "LightSheet 3")
            {
                if (FormLightSheet_3 == null)
                {
                    FormLightSheet_3 = new FormLightSheets(IdBtnLightSheet);
                    openChildForm(FormLightSheet_3, sender);
                }
                else
                {
                    openChildForm(FormLightSheet_3, sender);
                }
            }

            if (IdBtnLightSheet == "LightSheet 4")
            {
                if (FormLightSheet_4 == null)
                {
                    FormLightSheet_4 = new FormLightSheets(IdBtnLightSheet);
                    openChildForm(FormLightSheet_4, sender);
                }
                else
                {
                    openChildForm(FormLightSheet_4, sender);
                }
            }
        }


        private Form FormLaser_1 = null;
        private Form FormLaser_2 = null;
        private Form FormLaser_3 = null;
        private Form FormLaser_4 = null;
        private void handlerLasers_Click(object sender, EventArgs e)
        {
            KryptonButton repBtnLaser = sender as KryptonButton;
            string IdBtnLaser = repBtnLaser.Text;

            if (IdBtnLaser == "Laser 1")
            {
                if (FormLaser_1 == null)
                {
                    FormLaser_1 = new FormLightSheets(IdBtnLaser);
                    openChildForm(FormLaser_1, sender);
                }
                else
                {
                    openChildForm(FormLaser_1, sender);
                }
            }

            if (IdBtnLaser == "Laser 2")
            {
                if (FormLaser_2 == null)
                {
                    FormLaser_2 = new FormLightSheets(IdBtnLaser);
                    openChildForm(FormLaser_2, sender);
                }
                else
                {
                    openChildForm(FormLaser_2, sender);
                }
            }

            if (IdBtnLaser == "Laser 3")
            {
                if (FormLaser_3 == null)
                {
                    FormLaser_3 = new FormLightSheets(IdBtnLaser);
                    openChildForm(FormLaser_3, sender);
                }
                else
                {
                    openChildForm(FormLaser_3, sender);
                }
            }

            if (IdBtnLaser == "Laser 4")
            {
                if (FormLaser_4 == null)
                {
                    FormLaser_4 = new FormLightSheets(IdBtnLaser);
                    openChildForm(FormLaser_4, sender);
                }
                else
                {
                    openChildForm(FormLaser_4, sender);
                }
            }
        }


        private Form FormFilterWheel_1 = null;
        private Form FormFilterWheel_2 = null;
        private Form FormFilterWheel_3 = null;
        private Form FormFilterWheel_4 = null;
        private void handlerFilterWheels_Click(object sender, EventArgs e)
        {
            KryptonButton repBtnFilterWheel = sender as KryptonButton;
            string IdBtnFilterWheel = repBtnFilterWheel.Text;

            if (IdBtnFilterWheel == "FilterWheel 1")
            {
                if (FormFilterWheel_1 == null)
                {
                    FormFilterWheel_1 = new FormFilterWheels(IdBtnFilterWheel);
                    openChildForm(FormFilterWheel_1, sender);
                }
                else
                {
                    openChildForm(FormFilterWheel_1, sender);
                }
            }

            if (IdBtnFilterWheel == "FilterWheel 2")
            {
                if (FormFilterWheel_2 == null)
                {
                    FormFilterWheel_2 = new FormFilterWheels(IdBtnFilterWheel);
                    openChildForm(FormFilterWheel_2, sender);
                }
                else
                {
                    openChildForm(FormFilterWheel_2, sender);
                }
            }

            if (IdBtnFilterWheel == "FilterWheel 3")
            {
                if (FormFilterWheel_3 == null)
                {
                    FormFilterWheel_3 = new FormFilterWheels(IdBtnFilterWheel);
                    openChildForm(FormFilterWheel_3, sender);
                }
                else
                {
                    openChildForm(FormFilterWheel_3, sender);
                }
            }

            if (IdBtnFilterWheel == "FilterWheel 4")
            {
                if (FormFilterWheel_4 == null)
                {
                    FormFilterWheel_4 = new FormFilterWheels(IdBtnFilterWheel);
                    openChildForm(FormFilterWheel_4, sender);
                }
                else
                {
                    openChildForm(FormFilterWheel_4, sender);
                }
            }

        }

        #endregion


        #region HandlersSubMenu

        private Form FormObjectiveAxis_1 = null;
        private void handlerObjectiveAxis_Click(object sender, EventArgs e)
        {
            if (DatosSubMenu.ObjectiveAxis == 1)
            {
                this.subMenu_ObjectiveLens_1.Controls.Clear();
                AddBtnSubmenu(subMenu_ObjectiveLens_1, "ObjectiveAxis", 1);
            }
            else
            {
                this.subMenu_ObjectiveLens_1.Controls.Clear();
            }
        }

        #endregion


        private void openChildForm(Form childForm, object sender)
        {
            AddOwnedForm(childForm);

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelViews.Controls.Add(childForm);
            PanelViews.Tag = childForm;
            childForm.BringToFront();

            childForm.Show();


        }


    }
}
