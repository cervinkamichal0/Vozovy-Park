
namespace Vozový_park
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.lLogin = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tBUzivatelskeJmeno = new System.Windows.Forms.TextBox();
            this.tBHeslo = new System.Windows.Forms.TextBox();
            this.lHeslo = new System.Windows.Forms.Label();
            this.lUzivatelskeJmeno = new System.Windows.Forms.Label();
            this.bPrihlasitSe = new System.Windows.Forms.Button();
            this.lSpatneUdaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLogin.ForeColor = System.Drawing.Color.White;
            this.lLogin.Location = new System.Drawing.Point(117, -2);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(147, 77);
            this.lLogin.TabIndex = 0;
            this.lLogin.Text = "Login";
            // 
            // tBUzivatelskeJmeno
            // 
            this.tBUzivatelskeJmeno.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBUzivatelskeJmeno.Location = new System.Drawing.Point(66, 144);
            this.tBUzivatelskeJmeno.MaxLength = 19;
            this.tBUzivatelskeJmeno.Name = "tBUzivatelskeJmeno";
            this.tBUzivatelskeJmeno.Size = new System.Drawing.Size(252, 52);
            this.tBUzivatelskeJmeno.TabIndex = 1;
            this.tBUzivatelskeJmeno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBHeslo
            // 
            this.tBHeslo.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBHeslo.Location = new System.Drawing.Point(66, 257);
            this.tBHeslo.MaxLength = 19;
            this.tBHeslo.Name = "tBHeslo";
            this.tBHeslo.PasswordChar = '*';
            this.tBHeslo.Size = new System.Drawing.Size(252, 52);
            this.tBHeslo.TabIndex = 2;
            this.tBHeslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lHeslo
            // 
            this.lHeslo.AutoSize = true;
            this.lHeslo.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeslo.ForeColor = System.Drawing.Color.White;
            this.lHeslo.Location = new System.Drawing.Point(149, 209);
            this.lHeslo.Name = "lHeslo";
            this.lHeslo.Size = new System.Drawing.Size(86, 45);
            this.lHeslo.TabIndex = 3;
            this.lHeslo.Text = "Heslo";
            // 
            // lUzivatelskeJmeno
            // 
            this.lUzivatelskeJmeno.AutoSize = true;
            this.lUzivatelskeJmeno.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUzivatelskeJmeno.ForeColor = System.Drawing.Color.White;
            this.lUzivatelskeJmeno.Location = new System.Drawing.Point(69, 96);
            this.lUzivatelskeJmeno.Name = "lUzivatelskeJmeno";
            this.lUzivatelskeJmeno.Size = new System.Drawing.Size(240, 45);
            this.lUzivatelskeJmeno.TabIndex = 4;
            this.lUzivatelskeJmeno.Text = "Uživatelské jméno";
            // 
            // bPrihlasitSe
            // 
            this.bPrihlasitSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bPrihlasitSe.FlatAppearance.BorderSize = 0;
            this.bPrihlasitSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrihlasitSe.Font = new System.Drawing.Font("Bahnschrift Condensed", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrihlasitSe.ForeColor = System.Drawing.Color.White;
            this.bPrihlasitSe.Location = new System.Drawing.Point(66, 321);
            this.bPrihlasitSe.Name = "bPrihlasitSe";
            this.bPrihlasitSe.Size = new System.Drawing.Size(252, 58);
            this.bPrihlasitSe.TabIndex = 5;
            this.bPrihlasitSe.Text = "Přihlásit se";
            this.bPrihlasitSe.UseVisualStyleBackColor = false;
            this.bPrihlasitSe.Click += new System.EventHandler(this.bPrihlasitSe_Click);
            // 
            // lSpatneUdaje
            // 
            this.lSpatneUdaje.AutoSize = true;
            this.lSpatneUdaje.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSpatneUdaje.ForeColor = System.Drawing.Color.Red;
            this.lSpatneUdaje.Location = new System.Drawing.Point(34, 382);
            this.lSpatneUdaje.Name = "lSpatneUdaje";
            this.lSpatneUdaje.Size = new System.Drawing.Size(331, 45);
            this.lSpatneUdaje.TabIndex = 6;
            this.lSpatneUdaje.Text = "Zadané údaje jsou chybné";
            this.lSpatneUdaje.Visible = false;
            // 
            // fLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(388, 427);
            this.Controls.Add(this.lSpatneUdaje);
            this.Controls.Add(this.bPrihlasitSe);
            this.Controls.Add(this.lUzivatelskeJmeno);
            this.Controls.Add(this.lHeslo);
            this.Controls.Add(this.tBHeslo);
            this.Controls.Add(this.tBUzivatelskeJmeno);
            this.Controls.Add(this.lLogin);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.Shown += new System.EventHandler(this.fLogin_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tBUzivatelskeJmeno;
        private System.Windows.Forms.TextBox tBHeslo;
        private System.Windows.Forms.Label lHeslo;
        private System.Windows.Forms.Label lUzivatelskeJmeno;
        private System.Windows.Forms.Button bPrihlasitSe;
        private System.Windows.Forms.Label lSpatneUdaje;
    }
}

