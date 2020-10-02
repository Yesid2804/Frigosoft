namespace Presentacion.Productos.Res
{
    partial class FormRes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRes));
            this.btnRetroceso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRetroceso
            // 
            this.btnRetroceso.AutoSize = true;
            this.btnRetroceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetroceso.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRetroceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.btnRetroceso.Location = new System.Drawing.Point(12, 563);
            this.btnRetroceso.Name = "btnRetroceso";
            this.btnRetroceso.Size = new System.Drawing.Size(26, 28);
            this.btnRetroceso.TabIndex = 1;
            this.btnRetroceso.Text = "<";
            this.btnRetroceso.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btnRetroceso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRes";
            this.Text = "FormRes";
            this.Load += new System.EventHandler(this.FormRes_Load);
            this.BackgroundImageChanged += new System.EventHandler(this.FormRes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnRetroceso;
    }
}