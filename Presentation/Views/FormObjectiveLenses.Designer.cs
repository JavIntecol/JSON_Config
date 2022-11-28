namespace Presentation.Views
{
    partial class FormObjectiveLenses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.krypton = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.PanelControlObjectiveLenses = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Lbl_TitleStageAxes = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox3 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlObjectiveLenses)).BeginInit();
            this.PanelControlObjectiveLenses.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControlObjectiveLenses
            // 
            this.PanelControlObjectiveLenses.Controls.Add(this.kryptonTextBox3);
            this.PanelControlObjectiveLenses.Controls.Add(this.kryptonTextBox2);
            this.PanelControlObjectiveLenses.Controls.Add(this.kryptonTextBox1);
            this.PanelControlObjectiveLenses.Controls.Add(this.Lbl_TitleStageAxes);
            this.PanelControlObjectiveLenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlObjectiveLenses.Location = new System.Drawing.Point(0, 0);
            this.PanelControlObjectiveLenses.Name = "PanelControlObjectiveLenses";
            this.PanelControlObjectiveLenses.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.PanelControlObjectiveLenses.Size = new System.Drawing.Size(946, 636);
            this.PanelControlObjectiveLenses.TabIndex = 1;
            this.PanelControlObjectiveLenses.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelControlObjectiveLenses_Paint);
            // 
            // Lbl_TitleStageAxes
            // 
            this.Lbl_TitleStageAxes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_TitleStageAxes.Location = new System.Drawing.Point(342, 44);
            this.Lbl_TitleStageAxes.Name = "Lbl_TitleStageAxes";
            this.Lbl_TitleStageAxes.Size = new System.Drawing.Size(312, 49);
            this.Lbl_TitleStageAxes.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.Lbl_TitleStageAxes.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleStageAxes.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Lbl_TitleStageAxes.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Lbl_TitleStageAxes.TabIndex = 1;
            this.Lbl_TitleStageAxes.Values.Text = "ObjectiveLenses";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(185, 168);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(211, 27);
            this.kryptonTextBox1.TabIndex = 2;
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Location = new System.Drawing.Point(368, 305);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(211, 27);
            this.kryptonTextBox2.TabIndex = 3;
            // 
            // kryptonTextBox3
            // 
            this.kryptonTextBox3.Location = new System.Drawing.Point(505, 182);
            this.kryptonTextBox3.Name = "kryptonTextBox3";
            this.kryptonTextBox3.Size = new System.Drawing.Size(211, 27);
            this.kryptonTextBox3.TabIndex = 4;
            // 
            // FormObjectiveLenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 636);
            this.Controls.Add(this.PanelControlObjectiveLenses);
            this.Name = "FormObjectiveLenses";
            this.Text = "FormObjectiveLenses";
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlObjectiveLenses)).EndInit();
            this.PanelControlObjectiveLenses.ResumeLayout(false);
            this.PanelControlObjectiveLenses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette krypton;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel PanelControlObjectiveLenses;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Lbl_TitleStageAxes;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
    }
}