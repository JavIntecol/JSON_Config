using ComponentFactory.Krypton.Toolkit;
using Presentation.Views;
using Presentation.Views.SubMenu;
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
            KryptonLabel TitleTreeVeiw = new KryptonLabel();

            FontFamily fontTittleTreeView = new FontFamily("Microsoft Sans Serif");
            Font font = new Font(fontTittleTreeView, 25, FontStyle.Bold, GraphicsUnit.Pixel);


            TitleTreeVeiw.Name = "Lbl_TittleTreeView";
            TitleTreeVeiw.Text = "Tree View";
            TitleTreeVeiw.AutoSize = true;
            TitleTreeVeiw.StateNormal.ShortText.Font = font;
            TitleTreeVeiw.Palette = krypton;

            TitleTreeVeiw.StateNormal.ShortText.Color1 = Color.White;
            TitleTreeVeiw.Dock = System.Windows.Forms.DockStyle.Top;

            SplitContainer.Panel1.Controls.Add(TitleTreeVeiw);
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

        public void AddSubMenu(KryptonPanel ItemPanel, String Item, int idSubMenu)
        {
            KryptonPanel subMenu = new KryptonPanel();

            subMenu.Name = "subMenu_" + Item;
            subMenu.Tag = idSubMenu.ToString();
            subMenu.Palette = krypton;
            subMenu.Dock = System.Windows.Forms.DockStyle.Top;
            subMenu.AutoSize = true;

            if (Item == "ObjectiveLens_1" || Item == "ObjectiveLens_2" || Item == "ObjectiveLens_3" || Item == "ObjectiveLens_4")
            {
                if (idSubMenu == 1)
                {
                    subMenu_ObjectiveLens_1 = subMenu;
                }

                if (idSubMenu == 2)
                {
                    subMenu_ObjectiveLens_2 = subMenu;
                }

                if (idSubMenu == 3)
                {
                    subMenu_ObjectiveLens_3 = subMenu;
                }

                if (idSubMenu == 4)
                {
                    subMenu_ObjectiveLens_4 = subMenu;
                }
            }

            if (Item == "LightSheet_1" || Item == "LightSheet_2" || Item == "LightSheet_3" || Item == "LightSheet_4")
            {
                if (idSubMenu == 1)
                {
                    subMenu_LightSheet_1 = subMenu;
                }

                if (idSubMenu == 2)
                {
                    subMenu_LightSheet_2 = subMenu;
                }

                if (idSubMenu == 3)
                {
                    subMenu_LightSheet_3 = subMenu;
                }

                if (idSubMenu == 4)
                {
                    subMenu_LightSheet_4 = subMenu;
                }
            }

            if (Item == "Laser_1" || Item == "Laser_2" || Item == "Laser_3" || Item == "Laser_4")
            {
                if (idSubMenu == 1)
                {
                    subMenu_Laser_1 = subMenu;
                }

                if (idSubMenu == 2)
                {
                    subMenu_Laser_2 = subMenu;
                }

                if (idSubMenu == 3)
                {
                    subMenu_Laser_3 = subMenu;
                }

                if (idSubMenu == 4)
                {
                    subMenu_Laser_4 = subMenu;
                }
            }

            if (Item == "FilterWheel_1" || Item == "FilterWheel_2" || Item == "FilterWheel_3" || Item == "FilterWheel_4")
            {
                if (idSubMenu == 1)
                {
                    subMenu_FilterWheel_1 = subMenu;
                }

                if (idSubMenu == 2)
                {
                    subMenu_FilterWheel_2 = subMenu;
                }

                if (idSubMenu == 3)
                {
                    subMenu_FilterWheel_3 = subMenu;
                }

                if (idSubMenu == 4)
                {
                    subMenu_FilterWheel_4 = subMenu;
                }
            }





            ItemPanel.Controls.Add(subMenu);

            //return subMenu;
        }



        public void AddBotton(KryptonPanel ItemPanel, String Item, int numButtons)
        {
            KryptonButton oBotton = new KryptonButton();

            FontFamily fontFamilyBtn = new FontFamily("Microsoft Sans Serif");
            Font fontBtn = new Font(fontFamilyBtn, 13, FontStyle.Bold, GraphicsUnit.Pixel);



            oBotton.Name = "Btn_" + Item + "_" + numButtons.ToString();
            oBotton.Text = Item;
            oBotton.Values.ExtraText = numButtons.ToString();
            oBotton.StateCommon.Content.ShortText.Font = fontBtn;
            oBotton.StateCommon.Content.LongText.Font = fontBtn;
            oBotton.AutoSize = true;

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
                AddSubMenu(PanelNumObjectiveLenses, Item + "_" + numButtons.ToString(), numButtons);
            }

            if (Item == "LightSheet")
            {
                oBotton.Click += new EventHandler(handlerLightSheets_Click);
                AddSubMenu(PanelNumLightSheets, Item + "_" + numButtons.ToString(), numButtons);
            }

            if (Item == "Laser")
            {
                oBotton.Click += new EventHandler(handlerLasers_Click);
                AddSubMenu(PanelNumLasers, Item + "_" + numButtons.ToString(), numButtons);
            }

            if (Item == "FilterWheel")
            {
                oBotton.Click += new EventHandler(handlerFilterWheels_Click);
                AddSubMenu(PanelNumFilterWheels, Item + "_" + numButtons.ToString(), numButtons);
            }


            ItemPanel.Controls.Add(oBotton);

        }

        private void AddBtnSubmenu(KryptonPanel PanelSubmenu, string nameSubMenu, string numButton)
        {
            int numBtnSubmenu = DatosSubMenu.ObjectiveAxis;

            KryptonButton BottonSubMenu = new KryptonButton();

            FontFamily fontFamily = new FontFamily("Microsoft Sans Serif");
            Font font = new Font(fontFamily, 12, FontStyle.Bold, GraphicsUnit.Pixel);

            BottonSubMenu.Name = "Btn_" + nameSubMenu + "_" + numButton;
            BottonSubMenu.Text = nameSubMenu + " " + numButton;
            BottonSubMenu.Tag = numButton;
            BottonSubMenu.Palette = krypton;
            BottonSubMenu.Dock = System.Windows.Forms.DockStyle.Top;


            //if (numButtons > 1)
            //{
            //    oBotton.Enabled = false;
            //}

            PanelSubmenu.Controls.Add(BottonSubMenu);

            if (nameSubMenu == "ObjectiveAxis")
            {
                BottonSubMenu.Click += new EventHandler(handlerSubMenuObjectiveAxis_Click);
            }

            if (nameSubMenu == "LightSheetAxes")
            {
                BottonSubMenu.Click += new EventHandler(handlerSubMenuLightSheetAxes_Click);
            }

            if (nameSubMenu == "Laser")
            {
                BottonSubMenu.Click += new EventHandler(handlerSubMenuLaserLines_Click);
            }

            if (nameSubMenu == "FilterWheel")
            {
                BottonSubMenu.Click += new EventHandler(handlerSubMenuFilters_Click);
            }

            //AddTab(PanelSubmenu, nameSubMenu);
        }

        public void AddBtnNext(String Item, string IdBtn, string IdBtnSender)
        {
            this.PanelNext.Controls.Clear();

            KryptonButton BottonNext = new KryptonButton();

            BottonNext.Name = "Btn_Next" + Item + IdBtnSender;
            BottonNext.Text = "Next";
            BottonNext.Tag = IdBtn;
            BottonNext.Palette = krypton;
            BottonNext.Location = new Point(580, 20);
            BottonNext.Size = new Size(100, 40);
            //BottonNext.

            if (Item == "ObjectiveLens")
            {

                BottonNext.Click += new EventHandler(handlerObjectiveAxis_Click);

            }

            if (Item == "LightSheet")
            {

                BottonNext.Click += new EventHandler(handlerLightSheet_Click);

            }

            if (Item == "Laser")
            {

                BottonNext.Click += new EventHandler(handlerLaser_Click);

            }

            if (Item == "FilterWheel")
            {

                BottonNext.Click += new EventHandler(handlerFilterWheel_Click);

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
            string IdBtnCamera = repBtnCamera.Values.ExtraText;

            if (IdBtnCamera == "1")
            {
                if (FormCamera_1 == null)
                {
                    FormCamera_1 = new FormCameras("Camera " + IdBtnCamera);
                    openChildForm(FormCamera_1, sender);


                }
                else
                {
                    openChildForm(FormCamera_1, sender);
                }
            }

            if (IdBtnCamera == "2")
            {
                if (FormCamera_2 == null)
                {
                    FormCamera_2 = new FormCameras("Camera " + IdBtnCamera);
                    openChildForm(FormCamera_2, sender);
                }
                else
                {
                    openChildForm(FormCamera_2, sender);
                }
            }

            if (IdBtnCamera == "3")
            {
                if (FormCamera_3 == null)
                {
                    FormCamera_3 = new FormCameras("Camera " + IdBtnCamera);
                    openChildForm(FormCamera_3, sender);
                }
                else
                {
                    openChildForm(FormCamera_3, sender);
                }
            }

            if (IdBtnCamera == "4")
            {
                if (FormCamera_4 == null)
                {
                    FormCamera_4 = new FormCameras("Camera " + IdBtnCamera);
                    openChildForm(FormCamera_4, sender);
                }
                else
                {
                    openChildForm(FormCamera_4, sender);
                }
            }

            AddBtnNext("Camera", "0", "0");

        }

        private Form FormStageAxis_1 = null;
        private Form FormStageAxis_2 = null;
        private Form FormStageAxis_3 = null;
        private Form FormStageAxis_4 = null;
        private void handlerStageAxes_Click(object sender, EventArgs e)
        {
            KryptonButton repBtnStageAxes = sender as KryptonButton;
            string IdBtnStageAxes = repBtnStageAxes.Values.ExtraText;

            if (IdBtnStageAxes == "1")
            {
                if (FormStageAxis_1 == null)
                {
                    FormStageAxis_1 = new FormStageAxes("StageAxes " + IdBtnStageAxes);
                    openChildForm(FormStageAxis_1, sender);
                }
                else
                {
                    openChildForm(FormStageAxis_1, sender);
                }
            }

            if (IdBtnStageAxes == "2")
            {
                if (FormStageAxis_2 == null)
                {
                    FormStageAxis_2 = new FormStageAxes("StageAxes " + IdBtnStageAxes);
                    openChildForm(FormStageAxis_2, sender);
                }
                else
                {
                    openChildForm(FormStageAxis_2, sender);
                }
            }

            if (IdBtnStageAxes == "3")
            {
                if (FormStageAxis_3 == null)
                {
                    FormStageAxis_3 = new FormStageAxes("StageAxes " + IdBtnStageAxes);
                    openChildForm(FormStageAxis_3, sender);
                }
                else
                {
                    openChildForm(FormStageAxis_3, sender);
                }
            }

            if (IdBtnStageAxes == "4")
            {
                if (FormStageAxis_4 == null)
                {
                    FormStageAxis_4 = new FormStageAxes("StageAxes " + IdBtnStageAxes);
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
            string IdBtnObjectiveLens = repBtnObjectiveLens.Values.ExtraText;
            string NameBtnObjectiveLens = repBtnObjectiveLens.Text + " " + IdBtnObjectiveLens;

            if (IdBtnObjectiveLens == "1")
            {
                if (FormObjectiveLens_1 == null)
                {
                    FormObjectiveLens_1 = new FormObjectiveLenses(NameBtnObjectiveLens);
                    openChildForm(FormObjectiveLens_1, sender);
                    AddBtnNext("ObjectiveLens", IdBtnObjectiveLens, "1");
                }
                else
                {
                    openChildForm(FormObjectiveLens_1, sender);
                }
            }

            if (IdBtnObjectiveLens == "2")
            {
                if (FormObjectiveLens_2 == null)
                {
                    FormObjectiveLens_2 = new FormObjectiveLenses(NameBtnObjectiveLens);
                    openChildForm(FormObjectiveLens_2, sender);
                    AddBtnNext("ObjectiveLens", IdBtnObjectiveLens, "2");
                }
                else
                {
                    openChildForm(FormObjectiveLens_2, sender);
                }
            }

            if (IdBtnObjectiveLens == "3")
            {
                if (FormObjectiveLens_3 == null)
                {
                    FormObjectiveLens_3 = new FormObjectiveLenses(NameBtnObjectiveLens);
                    openChildForm(FormObjectiveLens_3, sender);
                    AddBtnNext("ObjectiveLens", IdBtnObjectiveLens, "3");
                }
                else
                {
                    openChildForm(FormObjectiveLens_3, sender);
                }
            }

            if (IdBtnObjectiveLens == "4")
            {
                if (FormObjectiveLens_4 == null)
                {
                    FormObjectiveLens_4 = new FormObjectiveLenses(NameBtnObjectiveLens);
                    openChildForm(FormObjectiveLens_4, sender);
                    AddBtnNext("ObjectiveLens", IdBtnObjectiveLens, "4");
                }
                else
                {
                    openChildForm(FormObjectiveLens_4, sender);
                }
            }



        }


        private Form FormLightSheet_1 = null;
        private Form FormLightSheet_2 = null;
        private Form FormLightSheet_3 = null;
        private Form FormLightSheet_4 = null;
        private void handlerLightSheets_Click(object sender, EventArgs e)
        {
            KryptonButton repBtnLightSheet = sender as KryptonButton;
            string IdBtnLightSheet = repBtnLightSheet.Values.ExtraText;

            if (IdBtnLightSheet == "1")
            {
                if (FormLightSheet_1 == null)
                {
                    FormLightSheet_1 = new FormLightSheets("LightSheet " + IdBtnLightSheet);
                    openChildForm(FormLightSheet_1, sender);
                    AddBtnNext("LightSheet", IdBtnLightSheet, "1");
                }
                else
                {
                    openChildForm(FormLightSheet_1, sender);
                }
            }

            if (IdBtnLightSheet == "2")
            {
                if (FormLightSheet_2 == null)
                {
                    FormLightSheet_2 = new FormLightSheets("LightSheet " + IdBtnLightSheet);
                    openChildForm(FormLightSheet_2, sender);
                    AddBtnNext("LightSheet", IdBtnLightSheet, "2");
                }
                else
                {
                    openChildForm(FormLightSheet_2, sender);
                }
            }

            if (IdBtnLightSheet == "3")
            {
                if (FormLightSheet_3 == null)
                {
                    FormLightSheet_3 = new FormLightSheets("LightSheet " + IdBtnLightSheet);
                    openChildForm(FormLightSheet_3, sender);
                    AddBtnNext("LightSheet", IdBtnLightSheet, "3");
                }
                else
                {
                    openChildForm(FormLightSheet_3, sender);
                }
            }

            if (IdBtnLightSheet == "4")
            {
                if (FormLightSheet_4 == null)
                {
                    FormLightSheet_4 = new FormLightSheets("LightSheet " + IdBtnLightSheet);
                    openChildForm(FormLightSheet_4, sender);
                    AddBtnNext("LightSheet", IdBtnLightSheet, "4");
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
            string IdBtnLaser = repBtnLaser.Values.ExtraText;

            if (IdBtnLaser == "1")
            {
                if (FormLaser_1 == null)
                {
                    FormLaser_1 = new FormLasers("Laser " + IdBtnLaser);
                    openChildForm(FormLaser_1, sender);
                    AddBtnNext("Laser", IdBtnLaser, "1");
                }
                else
                {
                    openChildForm(FormLaser_1, sender);
                }
            }

            if (IdBtnLaser == "2")
            {
                if (FormLaser_2 == null)
                {
                    FormLaser_2 = new FormLasers("Laser " + IdBtnLaser);
                    openChildForm(FormLaser_2, sender);
                    AddBtnNext("Laser", IdBtnLaser, "2");
                }
                else
                {
                    openChildForm(FormLaser_2, sender);
                }
            }

            if (IdBtnLaser == "3")
            {
                if (FormLaser_3 == null)
                {
                    FormLaser_3 = new FormLasers("Laser " + IdBtnLaser);
                    openChildForm(FormLaser_3, sender);
                    AddBtnNext("Laser", IdBtnLaser, "3");
                }
                else
                {
                    openChildForm(FormLaser_3, sender);
                }
            }

            if (IdBtnLaser == "4")
            {
                if (FormLaser_4 == null)
                {
                    FormLaser_4 = new FormLasers("Laser " + IdBtnLaser);
                    openChildForm(FormLaser_4, sender);
                    AddBtnNext("Laser", IdBtnLaser, "4");
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
            string IdBtnFilterWheel = repBtnFilterWheel.Values.ExtraText;

            if (IdBtnFilterWheel == "1")
            {
                if (FormFilterWheel_1 == null)
                {
                    FormFilterWheel_1 = new FormFilterWheels("FilterWheel " + IdBtnFilterWheel);
                    openChildForm(FormFilterWheel_1, sender);
                    AddBtnNext("FilterWheel", IdBtnFilterWheel, "1");
                }
                else
                {
                    openChildForm(FormFilterWheel_1, sender);
                }
            }

            if (IdBtnFilterWheel == "2")
            {
                if (FormFilterWheel_2 == null)
                {
                    FormFilterWheel_2 = new FormFilterWheels("FilterWheel " + IdBtnFilterWheel);
                    openChildForm(FormFilterWheel_2, sender);
                    AddBtnNext("FilterWheel", IdBtnFilterWheel, "2");
                }
                else
                {
                    openChildForm(FormFilterWheel_2, sender);
                }
            }

            if (IdBtnFilterWheel == "3")
            {
                if (FormFilterWheel_3 == null)
                {
                    FormFilterWheel_3 = new FormFilterWheels("FilterWheel " + IdBtnFilterWheel);
                    openChildForm(FormFilterWheel_3, sender);
                    AddBtnNext("FilterWheel", IdBtnFilterWheel, "3");
                }
                else
                {
                    openChildForm(FormFilterWheel_3, sender);
                }
            }

            if (IdBtnFilterWheel == "4")
            {
                if (FormFilterWheel_4 == null)
                {
                    FormFilterWheel_4 = new FormFilterWheels("FilterWheel " + IdBtnFilterWheel);
                    openChildForm(FormFilterWheel_4, sender);
                    AddBtnNext("FilterWheel", IdBtnFilterWheel, "4");
                }
                else
                {
                    openChildForm(FormFilterWheel_4, sender);
                }
            }

        }

        #endregion


        private void AddTitleSubmenu(KryptonPanel PanelSubmenu, string Lbl_TitleSubMenu, string numBtnSubMenu)
        {
            KryptonLabel LabelTitleSubmenu = new KryptonLabel();
            FontFamily fontFamily = new FontFamily("Microsoft Sans Serif");
            Font font = new Font(fontFamily, 12, FontStyle.Bold, GraphicsUnit.Pixel);

            LabelTitleSubmenu.Name = "Btn_" + numBtnSubMenu + "_" + numBtnSubMenu;
            LabelTitleSubmenu.Text = Lbl_TitleSubMenu;
            LabelTitleSubmenu.StateNormal.ShortText.Font = font;
            LabelTitleSubmenu.Palette = krypton;
            LabelTitleSubmenu.StateNormal.ShortText.Color1 = Color.White;
            LabelTitleSubmenu.Dock = System.Windows.Forms.DockStyle.Top;

            PanelSubmenu.Controls.Add(LabelTitleSubmenu);

        }

        private void numSubBttons(KryptonPanel PanelSubMenu, string Item, int num)
        {
            for (int i = num + 1; i >= 1; i--)
            {
                AddBtnSubmenu(PanelSubMenu, Item, i.ToString());
            }

            AddTab(PanelSubMenu, Item);
        }


        #region Handlers Items SubMenu

        private void handlerObjectiveAxis_Click(object sender, EventArgs e)
        {

            KryptonButton repBtnObjectiveAxis = sender as KryptonButton;
            string IdBtnObjectiveAxis = repBtnObjectiveAxis.Tag.ToString();
            int numBtns = DatosSubMenu.ObjectiveAxis;

            if (DatosSubMenu.ObjectiveAxis > 0)
            {
                if (IdBtnObjectiveAxis == "1")
                {
                    this.subMenu_ObjectiveLens_1.Controls.Clear();
                    numSubBttons(subMenu_ObjectiveLens_1, "ObjectiveAxis", numBtns);
                    //AddTitleSubmenu(subMenu_ObjectiveLens_1, "ObjectiveAxis", IdBtnObjectiveAxis);
                }

                if (IdBtnObjectiveAxis == "2")
                {
                    this.subMenu_ObjectiveLens_2.Controls.Clear();
                    numSubBttons(subMenu_ObjectiveLens_2, "ObjectiveAxis", numBtns);
                    //AddTitleSubmenu(subMenu_ObjectiveLens_2, "ObjectiveAxis", IdBtnObjectiveAxis);
                }

                if (IdBtnObjectiveAxis == "3")
                {
                    this.subMenu_ObjectiveLens_3.Controls.Clear();
                    numSubBttons(subMenu_ObjectiveLens_3, "ObjectiveAxis", numBtns);
                    //AddTitleSubmenu(subMenu_ObjectiveLens_3, "ObjectiveAxis", IdBtnObjectiveAxis);
                }

                if (IdBtnObjectiveAxis == "4")
                {
                    this.subMenu_ObjectiveLens_1.Controls.Clear();
                    numSubBttons(subMenu_ObjectiveLens_4, "ObjectiveAxis", numBtns);
                    //AddTitleSubmenu(subMenu_ObjectiveLens_4, "ObjectiveAxis", IdBtnObjectiveAxis);
                }


            }
            else
            {
                this.subMenu_ObjectiveLens_1.Controls.Clear();
            }
        }


        private void handlerLightSheet_Click(object sender, EventArgs e)
        {

            KryptonButton repBtnLightSheets = sender as KryptonButton;
            string IdBtnLightSheet = repBtnLightSheets.Tag.ToString();
            int numBtns = DatosSubMenu.LightSheets;


            if (IdBtnLightSheet == "1")
            {
                this.subMenu_LightSheet_1.Controls.Clear();
                numSubBttons(subMenu_LightSheet_1, "LightSheetAxes", numBtns);
                //AddTitleSubmenu(subMenu_ObjectiveLens_1, "ObjectiveAxis", IdBtnObjectiveAxis);
            }

            if (IdBtnLightSheet == "2")
            {
                this.subMenu_LightSheet_2.Controls.Clear();
                numSubBttons(subMenu_LightSheet_2, "LightSheetAxes", numBtns);
                //AddTitleSubmenu(subMenu_ObjectiveLens_2, "ObjectiveAxis", IdBtnObjectiveAxis);
            }

            if (IdBtnLightSheet == "3")
            {
                this.subMenu_LightSheet_3.Controls.Clear();
                numSubBttons(subMenu_LightSheet_3, "LightSheetAxes", numBtns);
                //AddTitleSubmenu(subMenu_ObjectiveLens_3, "ObjectiveAxis", IdBtnObjectiveAxis);
            }

            if (IdBtnLightSheet == "4")
            {
                this.subMenu_LightSheet_4.Controls.Clear();
                numSubBttons(subMenu_LightSheet_4, "LightSheetAxes", numBtns);
                //AddTitleSubmenu(subMenu_ObjectiveLens_4, "ObjectiveAxis", IdBtnObjectiveAxis);
            }


        }

        private void handlerLaser_Click(object sender, EventArgs e)
        {

            KryptonButton repBtnLaser = sender as KryptonButton;
            string IdBtnLaser = repBtnLaser.Tag.ToString();
            int numBtns = DatosSubMenu.Laser;


            if (IdBtnLaser == "1")
            {
                this.subMenu_Laser_1.Controls.Clear();
                numSubBttons(subMenu_Laser_1, "Laser", numBtns);
                //AddTitleSubmenu(subMenu_ObjectiveLens_1, "ObjectiveAxis", IdBtnObjectiveAxis);
            }

            if (IdBtnLaser == "2")
            {
                this.subMenu_Laser_2.Controls.Clear();
                numSubBttons(subMenu_Laser_2, "Laser", numBtns);
                //AddTitleSubmenu(subMenu_ObjectiveLens_2, "ObjectiveAxis", IdBtnObjectiveAxis);
            }

            if (IdBtnLaser == "3")
            {
                this.subMenu_Laser_3.Controls.Clear();
                numSubBttons(subMenu_Laser_3, "Laser", numBtns);
                //AddTitleSubmenu(subMenu_ObjectiveLens_3, "ObjectiveAxis", IdBtnObjectiveAxis);
            }

            if (IdBtnLaser == "4")
            {
                this.subMenu_Laser_4.Controls.Clear();
                numSubBttons(subMenu_Laser_4, "Laser", numBtns);
                //AddTitleSubmenu(subMenu_ObjectiveLens_4, "ObjectiveAxis", IdBtnObjectiveAxis);
            }



        }

        private void handlerFilterWheel_Click(object sender, EventArgs e)
        {

            KryptonButton repBtnFilterWheel = sender as KryptonButton;
            string IdBtnFilterWheel = repBtnFilterWheel.Tag.ToString();
            int numBtns = DatosSubMenu.Laser;


            if (IdBtnFilterWheel == "1")
            {
                this.subMenu_FilterWheel_1.Controls.Clear();
                numSubBttons(subMenu_FilterWheel_1, "FilterWheel", numBtns);
                //AddTitleSubmenu(subMenu_ObjectiveLens_1, "ObjectiveAxis", IdBtnObjectiveAxis);
            }

            if (IdBtnFilterWheel == "2")
            {
                this.subMenu_FilterWheel_2.Controls.Clear();
                numSubBttons(subMenu_FilterWheel_2, "FilterWheel", numBtns);
                //AddTitleSubmenu(subMenu_ObjectiveLens_2, "ObjectiveAxis", IdBtnObjectiveAxis);
            }

            if (IdBtnFilterWheel == "3")
            {
                this.subMenu_FilterWheel_3.Controls.Clear();
                numSubBttons(subMenu_FilterWheel_3, "FilterWheel", numBtns);
                //AddTitleSubmenu(subMenu_ObjectiveLens_3, "ObjectiveAxis", IdBtnObjectiveAxis);
            }

            if (IdBtnFilterWheel == "4")
            {
                this.subMenu_FilterWheel_4.Controls.Clear();
                numSubBttons(subMenu_FilterWheel_4, "FilterWheel", numBtns);
                //AddTitleSubmenu(subMenu_ObjectiveLens_4, "ObjectiveAxis", IdBtnObjectiveAxis);
            }



        }


        #endregion

        #region Handlers SubMenus

        Form newObjectiveAxis = null;
        Form newLightSheetAxes = null;
        Form newLaserLines = null;
        Form newFilters = null;
        private void handlerSubMenuObjectiveAxis_Click(object sender, EventArgs e)
        {

            KryptonButton repBtnSubMenuObjectiveAxis = sender as KryptonButton;
            string IdBtnSubMenuObjectiveAxis = repBtnSubMenuObjectiveAxis.Text;

            newObjectiveAxis = new FormObjectiveAxis(IdBtnSubMenuObjectiveAxis);
            openChildForm(newObjectiveAxis, sender);

        }

        private void handlerSubMenuLightSheetAxes_Click(object sender, EventArgs e)
        {

            KryptonButton repBtnSubMenuLightSheetAxes = sender as KryptonButton;
            string IdBtnSubMenuLightSheetAxes = repBtnSubMenuLightSheetAxes.Text;

            newLightSheetAxes = new FormLightSheetAxes(IdBtnSubMenuLightSheetAxes);
            openChildForm(newLightSheetAxes, sender);

        }

        private void handlerSubMenuLaserLines_Click(object sender, EventArgs e)
        {

            KryptonButton repBtnSubMenuLaserLines = sender as KryptonButton;
            string IdBtnSubMenuLaserLines = repBtnSubMenuLaserLines.Text;

            newLaserLines = new FormLaserLines(IdBtnSubMenuLaserLines);
            openChildForm(newLaserLines, sender);

        }

        private void handlerSubMenuFilters_Click(object sender, EventArgs e)
        {

            KryptonButton repBtnSubMenuFilters = sender as KryptonButton;
            string IdBtnSubMenuFilters = repBtnSubMenuFilters.Text;

            newFilters = new FormFilters(IdBtnSubMenuFilters);
            openChildForm(newFilters, sender);

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
