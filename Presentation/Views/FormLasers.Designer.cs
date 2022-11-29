namespace Presentation.Views
{
    partial class FormLasers
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
            this.PanelControlLasers = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_TitleLasers = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlLasers)).BeginInit();
            this.PanelControlLasers.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControlLasers
            // 
            this.PanelControlLasers.Controls.Add(this.kryptonTextBox1);
            this.PanelControlLasers.Controls.Add(this.Lbl_TitleLasers);
            this.PanelControlLasers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlLasers.Location = new System.Drawing.Point(0, 0);
            this.PanelControlLasers.Name = "PanelControlLasers";
            this.PanelControlLasers.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.PanelControlLasers.Size = new System.Drawing.Size(946, 636);
            this.PanelControlLasers.TabIndex = 2;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(253, 171);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(438, 27);
            this.kryptonTextBox1.TabIndex = 2;
            // 
            // Lbl_TitleLasers
            // 
            this.Lbl_TitleLasers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_TitleLasers.Location = new System.Drawing.Point(386, 36);
            this.Lbl_TitleLasers.Name = "Lbl_TitleLasers";
            this.Lbl_TitleLasers.Size = new System.Drawing.Size(138, 49);
            this.Lbl_TitleLasers.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.Lbl_TitleLasers.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleLasers.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Lbl_TitleLasers.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Lbl_TitleLasers.TabIndex = 1;
            this.Lbl_TitleLasers.Values.Text = "Lasers";
            // 
            // FormLasers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 636);
            this.Controls.Add(this.PanelControlLasers);
            this.Name = "FormLasers";
            this.Text = "FormLasers";
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlLasers)).EndInit();
            this.PanelControlLasers.ResumeLayout(false);
            this.PanelControlLasers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel PanelControlLasers;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel Lbl_TitleLasers;
    }
}