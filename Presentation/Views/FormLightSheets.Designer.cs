namespace Presentation.Views
{
    partial class FormLightSheets
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
            this.PanelControlLightSheets = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_TitleLightSheets = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlLightSheets)).BeginInit();
            this.PanelControlLightSheets.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControlLightSheets
            // 
            this.PanelControlLightSheets.Controls.Add(this.kryptonTextBox1);
            this.PanelControlLightSheets.Controls.Add(this.Lbl_TitleLightSheets);
            this.PanelControlLightSheets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlLightSheets.Location = new System.Drawing.Point(0, 0);
            this.PanelControlLightSheets.Name = "PanelControlLightSheets";
            this.PanelControlLightSheets.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.PanelControlLightSheets.Size = new System.Drawing.Size(946, 636);
            this.PanelControlLightSheets.TabIndex = 1;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(253, 171);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(438, 27);
            this.kryptonTextBox1.TabIndex = 2;
            // 
            // Lbl_TitleLightSheets
            // 
            this.Lbl_TitleLightSheets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_TitleLightSheets.Location = new System.Drawing.Point(386, 36);
            this.Lbl_TitleLightSheets.Name = "Lbl_TitleLightSheets";
            this.Lbl_TitleLightSheets.Size = new System.Drawing.Size(209, 49);
            this.Lbl_TitleLightSheets.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.Lbl_TitleLightSheets.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleLightSheets.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Lbl_TitleLightSheets.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Lbl_TitleLightSheets.TabIndex = 1;
            this.Lbl_TitleLightSheets.Values.Text = "LightSheet";
            // 
            // FormLightSheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 636);
            this.Controls.Add(this.PanelControlLightSheets);
            this.Name = "FormLightSheets";
            this.Text = "FormLightSheets";
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlLightSheets)).EndInit();
            this.PanelControlLightSheets.ResumeLayout(false);
            this.PanelControlLightSheets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel PanelControlLightSheets;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel Lbl_TitleLightSheets;
    }
}