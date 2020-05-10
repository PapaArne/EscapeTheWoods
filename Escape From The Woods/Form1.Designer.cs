namespace Escape_From_The_Woods
{
    partial class Form1
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
            this.pcbBos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBos)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbBos
            // 
            this.pcbBos.Location = new System.Drawing.Point(12, 12);
            this.pcbBos.Name = "pcbBos";
            this.pcbBos.Size = new System.Drawing.Size(600, 600);
            this.pcbBos.TabIndex = 0;
            this.pcbBos.TabStop = false;
            this.pcbBos.Paint += new System.Windows.Forms.PaintEventHandler(this.pcbBos_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 621);
            this.Controls.Add(this.pcbBos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbBos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbBos;
    }
}

