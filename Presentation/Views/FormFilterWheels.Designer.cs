namespace Presentation.Views
{
    partial class FormFilterWheels
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
            this.PanelControlFilterWheels = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Lbl_TitleFilterWheels = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlFilterWheels)).BeginInit();
            this.PanelControlFilterWheels.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControlFilterWheels
            // 
            this.PanelControlFilterWheels.Controls.Add(this.kryptonTextBox1);
            this.PanelControlFilterWheels.Controls.Add(this.Lbl_TitleFilterWheels);
            this.PanelControlFilterWheels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControlFilterWheels.Location = new System.Drawing.Point(0, 0);
            this.PanelControlFilterWheels.Name = "PanelControlFilterWheels";
            this.PanelControlFilterWheels.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.PanelControlFilterWheels.Size = new System.Drawing.Size(946, 553);
            this.PanelControlFilterWheels.TabIndex = 3;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(253, 171);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(438, 27);
            this.kryptonTextBox1.TabIndex = 2;
            // 
            // Lbl_TitleFilterWheels
            // 
            this.Lbl_TitleFilterWheels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_TitleFilterWheels.Location = new System.Drawing.Point(386, 36);
            this.Lbl_TitleFilterWheels.Name = "Lbl_TitleFilterWheels";
            this.Lbl_TitleFilterWheels.Size = new System.Drawing.Size(240, 49);
            this.Lbl_TitleFilterWheels.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.Lbl_TitleFilterWheels.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleFilterWheels.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Lbl_TitleFilterWheels.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Lbl_TitleFilterWheels.TabIndex = 1;
            this.Lbl_TitleFilterWheels.Values.Text = "FilterWheels";
            // 
            // FormFilterWheels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 553);
            this.Controls.Add(this.PanelControlFilterWheels);
            this.Name = "FormFilterWheels";
            this.Text = "FormFilterWheels";
            ((System.ComponentModel.ISupportInitialize)(this.PanelControlFilterWheels)).EndInit();
            this.PanelControlFilterWheels.ResumeLayout(false);
            this.PanelControlFilterWheels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel PanelControlFilterWheels;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel Lbl_TitleFilterWheels;
    }
}