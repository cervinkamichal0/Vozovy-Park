
namespace Vozový_park
{
    partial class fAlert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAlert));
            this.lZprava = new System.Windows.Forms.Label();
            this.bNe = new System.Windows.Forms.Button();
            this.bAno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lZprava
            // 
            this.lZprava.AutoSize = true;
            this.lZprava.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lZprava.ForeColor = System.Drawing.Color.Red;
            this.lZprava.Location = new System.Drawing.Point(33, 9);
            this.lZprava.Name = "lZprava";
            this.lZprava.Size = new System.Drawing.Size(477, 45);
            this.lZprava.TabIndex = 0;
            this.lZprava.Text = "Opravdu chcete tuto položku smazat?";
            // 
            // bNe
            // 
            this.bNe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bNe.FlatAppearance.BorderSize = 0;
            this.bNe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNe.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNe.ForeColor = System.Drawing.Color.YellowGreen;
            this.bNe.Location = new System.Drawing.Point(288, 83);
            this.bNe.Name = "bNe";
            this.bNe.Size = new System.Drawing.Size(234, 56);
            this.bNe.TabIndex = 50;
            this.bNe.Text = "NE";
            this.bNe.UseVisualStyleBackColor = false;
            this.bNe.Click += new System.EventHandler(this.bNe_Click);
            // 
            // bAno
            // 
            this.bAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bAno.FlatAppearance.BorderSize = 0;
            this.bAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAno.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAno.ForeColor = System.Drawing.Color.Red;
            this.bAno.Location = new System.Drawing.Point(41, 83);
            this.bAno.Name = "bAno";
            this.bAno.Size = new System.Drawing.Size(222, 56);
            this.bAno.TabIndex = 49;
            this.bAno.Text = "ANO";
            this.bAno.UseVisualStyleBackColor = false;
            this.bAno.Click += new System.EventHandler(this.bAno_Click);
            // 
            // fAlert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(540, 164);
            this.Controls.Add(this.bNe);
            this.Controls.Add(this.bAno);
            this.Controls.Add(this.lZprava);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alert";
            this.Load += new System.EventHandler(this.fAlert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lZprava;
        private System.Windows.Forms.Button bNe;
        private System.Windows.Forms.Button bAno;
    }
}