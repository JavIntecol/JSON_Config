namespace Presentation.Views
{
    partial class FormStageAxes
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
            this.PanelControlStageAxes = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Lbl_TitleStageAxes = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.krypton = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlStageAxes)).BeginInit();
            this.PanelControlStageAxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControlStageAxes
            // 
            this.PanelControlStageAxes.Controls.Add(this.kryptonTextBox1);
            this.PanelControlStageAxes.Controls.Add(this.Lbl_TitleStageAxes);
            this.PanelControlStageAxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlStageAxes.Location = new System.Drawing.Point(0, 0);
            this.PanelControlStageAxes.Name = "PanelControlStageAxes";
            this.PanelControlStageAxes.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.PanelControlStageAxes.Size = new System.Drawing.Size(946, 636);
            this.PanelControlStageAxes.TabIndex = 0;
            // 
            // Lbl_TitleStageAxes
            // 
            this.Lbl_TitleStageAxes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_TitleStageAxes.Location = new System.Drawing.Point(386, 36);
            this.Lbl_TitleStageAxes.Name = "Lbl_TitleStageAxes";
            this.Lbl_TitleStageAxes.Size = new System.Drawing.Size(210, 49);
            this.Lbl_TitleStageAxes.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.Lbl_TitleStageAxes.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleStageAxes.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Lbl_TitleStageAxes.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Lbl_TitleStageAxes.TabIndex = 1;
            this.Lbl_TitleStageAxes.Values.Text = "StageAxes";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(253, 171);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(438, 27);
            this.kryptonTextBox1.TabIndex = 2;
            // 
            // FormStageAxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 636);
            this.Controls.Add(this.PanelControlStageAxes);
            this.Name = "FormStageAxes";
            this.Text = "FormStageAxes";
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlStageAxes)).EndInit();
            this.PanelControlStageAxes.ResumeLayout(false);
            this.PanelControlStageAxes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel PanelControlStageAxes;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette krypton;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel Lbl_TitleStageAxes;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
    }
}