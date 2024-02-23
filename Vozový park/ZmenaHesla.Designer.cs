
namespace Vozový_park
{
    partial class fZmenaHesla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fZmenaHesla));
            this.bZmenitHeslo = new System.Windows.Forms.Button();
            this.lPuvodniHeslo = new System.Windows.Forms.Label();
            this.lNoveHeslo = new System.Windows.Forms.Label();
            this.tBNoveHeslo = new System.Windows.Forms.TextBox();
            this.tBPuvodniHeslo = new System.Windows.Forms.TextBox();
            this.lZmenaHesla = new System.Windows.Forms.Label();
            this.lPotrvzeniNovehoHesla = new System.Windows.Forms.Label();
            this.tBPotvrzeniNovehoHesla = new System.Windows.Forms.TextBox();
            this.lChybnePuvodniHeslo = new System.Windows.Forms.Label();
            this.lNovaHeslaSeNeshoduji = new System.Windows.Forms.Label();
            this.lNoveHesloNesmiBytStejneJakoPuvodni = new System.Windows.Forms.Label();
            this.lNoveHesloNesmiBytPrazdne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bZmenitHeslo
            // 
            this.bZmenitHeslo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bZmenitHeslo.FlatAppearance.BorderSize = 0;
            this.bZmenitHeslo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bZmenitHeslo.Font = new System.Drawing.Font("Bahnschrift Condensed", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bZmenitHeslo.ForeColor = System.Drawing.Color.White;
            this.bZmenitHeslo.Location = new System.Drawing.Point(77, 562);
            this.bZmenitHeslo.Name = "bZmenitHeslo";
            this.bZmenitHeslo.Size = new System.Drawing.Size(252, 60);
            this.bZmenitHeslo.TabIndex = 11;
            this.bZmenitHeslo.Text = "Změnit heslo";
            this.bZmenitHeslo.UseVisualStyleBackColor = false;
            this.bZmenitHeslo.Click += new System.EventHandler(this.bZmenitHeslo_Click);
            // 
            // lPuvodniHeslo
            // 
            this.lPuvodniHeslo.AutoSize = true;
            this.lPuvodniHeslo.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPuvodniHeslo.ForeColor = System.Drawing.Color.White;
            this.lPuvodniHeslo.Location = new System.Drawing.Point(114, 130);
            this.lPuvodniHeslo.Name = "lPuvodniHeslo";
            this.lPuvodniHeslo.Size = new System.Drawing.Size(186, 45);
            this.lPuvodniHeslo.TabIndex = 10;
            this.lPuvodniHeslo.Text = "Původní heslo";
            // 
            // lNoveHeslo
            // 
            this.lNoveHeslo.AutoSize = true;
            this.lNoveHeslo.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNoveHeslo.ForeColor = System.Drawing.Color.White;
            this.lNoveHeslo.Location = new System.Drawing.Point(126, 329);
            this.lNoveHeslo.Name = "lNoveHeslo";
            this.lNoveHeslo.Size = new System.Drawing.Size(150, 45);
            this.lNoveHeslo.TabIndex = 9;
            this.lNoveHeslo.Text = "Nové heslo";
            // 
            // tBNoveHeslo
            // 
            this.tBNoveHeslo.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNoveHeslo.Location = new System.Drawing.Point(77, 377);
            this.tBNoveHeslo.MaxLength = 19;
            this.tBNoveHeslo.Name = "tBNoveHeslo";
            this.tBNoveHeslo.PasswordChar = '*';
            this.tBNoveHeslo.Size = new System.Drawing.Size(252, 52);
            this.tBNoveHeslo.TabIndex = 8;
            this.tBNoveHeslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBPuvodniHeslo
            // 
            this.tBPuvodniHeslo.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPuvodniHeslo.Location = new System.Drawing.Point(77, 178);
            this.tBPuvodniHeslo.MaxLength = 19;
            this.tBPuvodniHeslo.Name = "tBPuvodniHeslo";
            this.tBPuvodniHeslo.Size = new System.Drawing.Size(252, 52);
            this.tBPuvodniHeslo.TabIndex = 7;
            this.tBPuvodniHeslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lZmenaHesla
            // 
            this.lZmenaHesla.AutoSize = true;
            this.lZmenaHesla.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lZmenaHesla.ForeColor = System.Drawing.Color.White;
            this.lZmenaHesla.Location = new System.Drawing.Point(50, 9);
            this.lZmenaHesla.Name = "lZmenaHesla";
            this.lZmenaHesla.Size = new System.Drawing.Size(303, 77);
            this.lZmenaHesla.TabIndex = 6;
            this.lZmenaHesla.Text = "Změna Hesla";
            // 
            // lPotrvzeniNovehoHesla
            // 
            this.lPotrvzeniNovehoHesla.AutoSize = true;
            this.lPotrvzeniNovehoHesla.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPotrvzeniNovehoHesla.ForeColor = System.Drawing.Color.White;
            this.lPotrvzeniNovehoHesla.Location = new System.Drawing.Point(55, 452);
            this.lPotrvzeniNovehoHesla.Name = "lPotrvzeniNovehoHesla";
            this.lPotrvzeniNovehoHesla.Size = new System.Drawing.Size(298, 45);
            this.lPotrvzeniNovehoHesla.TabIndex = 13;
            this.lPotrvzeniNovehoHesla.Text = "Potvrzení nového hesla";
            // 
            // tBPotvrzeniNovehoHesla
            // 
            this.tBPotvrzeniNovehoHesla.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPotvrzeniNovehoHesla.Location = new System.Drawing.Point(77, 504);
            this.tBPotvrzeniNovehoHesla.MaxLength = 19;
            this.tBPotvrzeniNovehoHesla.Name = "tBPotvrzeniNovehoHesla";
            this.tBPotvrzeniNovehoHesla.PasswordChar = '*';
            this.tBPotvrzeniNovehoHesla.Size = new System.Drawing.Size(252, 52);
            this.tBPotvrzeniNovehoHesla.TabIndex = 12;
            this.tBPotvrzeniNovehoHesla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lChybnePuvodniHeslo
            // 
            this.lChybnePuvodniHeslo.AutoSize = true;
            this.lChybnePuvodniHeslo.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChybnePuvodniHeslo.ForeColor = System.Drawing.Color.Red;
            this.lChybnePuvodniHeslo.Location = new System.Drawing.Point(69, 262);
            this.lChybnePuvodniHeslo.Name = "lChybnePuvodniHeslo";
            this.lChybnePuvodniHeslo.Size = new System.Drawing.Size(280, 45);
            this.lChybnePuvodniHeslo.TabIndex = 14;
            this.lChybnePuvodniHeslo.Text = "Chybné původní heslo";
            this.lChybnePuvodniHeslo.Visible = false;
            // 
            // lNovaHeslaSeNeshoduji
            // 
            this.lNovaHeslaSeNeshoduji.AutoSize = true;
            this.lNovaHeslaSeNeshoduji.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNovaHeslaSeNeshoduji.ForeColor = System.Drawing.Color.Red;
            this.lNovaHeslaSeNeshoduji.Location = new System.Drawing.Point(55, 262);
            this.lNovaHeslaSeNeshoduji.Name = "lNovaHeslaSeNeshoduji";
            this.lNovaHeslaSeNeshoduji.Size = new System.Drawing.Size(309, 45);
            this.lNovaHeslaSeNeshoduji.TabIndex = 15;
            this.lNovaHeslaSeNeshoduji.Text = "Nová hesla se neshodují";
            this.lNovaHeslaSeNeshoduji.Visible = false;
            // 
            // lNoveHesloNesmiBytStejneJakoPuvodni
            // 
            this.lNoveHesloNesmiBytStejneJakoPuvodni.AutoSize = true;
            this.lNoveHesloNesmiBytStejneJakoPuvodni.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNoveHesloNesmiBytStejneJakoPuvodni.ForeColor = System.Drawing.Color.Red;
            this.lNoveHesloNesmiBytStejneJakoPuvodni.Location = new System.Drawing.Point(20, 272);
            this.lNoveHesloNesmiBytStejneJakoPuvodni.Name = "lNoveHesloNesmiBytStejneJakoPuvodni";
            this.lNoveHesloNesmiBytStejneJakoPuvodni.Size = new System.Drawing.Size(379, 33);
            this.lNoveHesloNesmiBytStejneJakoPuvodni.TabIndex = 16;
            this.lNoveHesloNesmiBytStejneJakoPuvodni.Text = "Nové heslo nesmí být stejné jako původní";
            this.lNoveHesloNesmiBytStejneJakoPuvodni.Visible = false;
            // 
            // lNoveHesloNesmiBytPrazdne
            // 
            this.lNoveHesloNesmiBytPrazdne.AutoSize = true;
            this.lNoveHesloNesmiBytPrazdne.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNoveHesloNesmiBytPrazdne.ForeColor = System.Drawing.Color.Red;
            this.lNoveHesloNesmiBytPrazdne.Location = new System.Drawing.Point(70, 274);
            this.lNoveHesloNesmiBytPrazdne.Name = "lNoveHesloNesmiBytPrazdne";
            this.lNoveHesloNesmiBytPrazdne.Size = new System.Drawing.Size(279, 33);
            this.lNoveHesloNesmiBytPrazdne.TabIndex = 17;
            this.lNoveHesloNesmiBytPrazdne.Text = "Nové heslo nesmí být prázdné";
            this.lNoveHesloNesmiBytPrazdne.Visible = false;
            // 
            // fZmenaHesla
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(411, 641);
            this.Controls.Add(this.lNoveHesloNesmiBytPrazdne);
            this.Controls.Add(this.lNoveHesloNesmiBytStejneJakoPuvodni);
            this.Controls.Add(this.lNovaHeslaSeNeshoduji);
            this.Controls.Add(this.lChybnePuvodniHeslo);
            this.Controls.Add(this.lPotrvzeniNovehoHesla);
            this.Controls.Add(this.tBPotvrzeniNovehoHesla);
            this.Controls.Add(this.bZmenitHeslo);
            this.Controls.Add(this.lPuvodniHeslo);
            this.Controls.Add(this.lNoveHeslo);
            this.Controls.Add(this.tBNoveHeslo);
            this.Controls.Add(this.tBPuvodniHeslo);
            this.Controls.Add(this.lZmenaHesla);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fZmenaHesla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Změna hesla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bZmenitHeslo;
        private System.Windows.Forms.Label lPuvodniHeslo;
        private System.Windows.Forms.Label lNoveHeslo;
        private System.Windows.Forms.TextBox tBNoveHeslo;
        private System.Windows.Forms.TextBox tBPuvodniHeslo;
        private System.Windows.Forms.Label lZmenaHesla;
        private System.Windows.Forms.Label lPotrvzeniNovehoHesla;
        private System.Windows.Forms.TextBox tBPotvrzeniNovehoHesla;
        private System.Windows.Forms.Label lChybnePuvodniHeslo;
        private System.Windows.Forms.Label lNovaHeslaSeNeshoduji;
        private System.Windows.Forms.Label lNoveHesloNesmiBytStejneJakoPuvodni;
        private System.Windows.Forms.Label lNoveHesloNesmiBytPrazdne;
    }
}