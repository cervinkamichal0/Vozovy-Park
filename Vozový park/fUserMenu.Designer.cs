
namespace Vozový_park
{
    partial class fUserMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUserMenu));
            this.lBPrehledRezervaci = new System.Windows.Forms.ListBox();
            this.lPosledniPrihlaseni = new System.Windows.Forms.Label();
            this.lUzivatelskeJmeno = new System.Windows.Forms.Label();
            this.bOdhlasitSe = new System.Windows.Forms.Button();
            this.bPridatRezervaci = new System.Windows.Forms.Button();
            this.bZmenaHesla = new System.Windows.Forms.Button();
            this.lLineVertical = new System.Windows.Forms.Label();
            this.lLineHorizontal = new System.Windows.Forms.Label();
            this.bObnovit = new System.Windows.Forms.Button();
            this.bOdstranitRezervaci = new System.Windows.Forms.Button();
            this.lMuisteVybratPolozkuZeSeznamu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBPrehledRezervaci
            // 
            this.lBPrehledRezervaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lBPrehledRezervaci.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBPrehledRezervaci.ForeColor = System.Drawing.Color.White;
            this.lBPrehledRezervaci.FormattingEnabled = true;
            this.lBPrehledRezervaci.HorizontalScrollbar = true;
            this.lBPrehledRezervaci.ItemHeight = 33;
            this.lBPrehledRezervaci.Location = new System.Drawing.Point(262, 135);
            this.lBPrehledRezervaci.Name = "lBPrehledRezervaci";
            this.lBPrehledRezervaci.Size = new System.Drawing.Size(1086, 400);
            this.lBPrehledRezervaci.TabIndex = 16;
            // 
            // lPosledniPrihlaseni
            // 
            this.lPosledniPrihlaseni.AutoSize = true;
            this.lPosledniPrihlaseni.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPosledniPrihlaseni.ForeColor = System.Drawing.Color.White;
            this.lPosledniPrihlaseni.Location = new System.Drawing.Point(695, 25);
            this.lPosledniPrihlaseni.Name = "lPosledniPrihlaseni";
            this.lPosledniPrihlaseni.Size = new System.Drawing.Size(653, 58);
            this.lPosledniPrihlaseni.TabIndex = 15;
            this.lPosledniPrihlaseni.Text = "Naposledy přihlášen: 10.12.2021 15:30:30";
            // 
            // lUzivatelskeJmeno
            // 
            this.lUzivatelskeJmeno.AutoSize = true;
            this.lUzivatelskeJmeno.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUzivatelskeJmeno.ForeColor = System.Drawing.Color.White;
            this.lUzivatelskeJmeno.Location = new System.Drawing.Point(351, 25);
            this.lUzivatelskeJmeno.Name = "lUzivatelskeJmeno";
            this.lUzivatelskeJmeno.Size = new System.Drawing.Size(316, 58);
            this.lUzivatelskeJmeno.TabIndex = 14;
            this.lUzivatelskeJmeno.Text = "Uživatelské jméno";
            // 
            // bOdhlasitSe
            // 
            this.bOdhlasitSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bOdhlasitSe.FlatAppearance.BorderSize = 0;
            this.bOdhlasitSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOdhlasitSe.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOdhlasitSe.ForeColor = System.Drawing.Color.White;
            this.bOdhlasitSe.Location = new System.Drawing.Point(12, 437);
            this.bOdhlasitSe.Name = "bOdhlasitSe";
            this.bOdhlasitSe.Size = new System.Drawing.Size(229, 88);
            this.bOdhlasitSe.TabIndex = 13;
            this.bOdhlasitSe.Text = "Odhlásit se";
            this.bOdhlasitSe.UseVisualStyleBackColor = false;
            this.bOdhlasitSe.Click += new System.EventHandler(this.bOdhlasitSe_Click);
            // 
            // bPridatRezervaci
            // 
            this.bPridatRezervaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bPridatRezervaci.FlatAppearance.BorderSize = 0;
            this.bPridatRezervaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPridatRezervaci.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPridatRezervaci.ForeColor = System.Drawing.Color.White;
            this.bPridatRezervaci.Location = new System.Drawing.Point(12, 175);
            this.bPridatRezervaci.Name = "bPridatRezervaci";
            this.bPridatRezervaci.Size = new System.Drawing.Size(229, 88);
            this.bPridatRezervaci.TabIndex = 12;
            this.bPridatRezervaci.Text = "Přidat rezervaci";
            this.bPridatRezervaci.UseVisualStyleBackColor = false;
            this.bPridatRezervaci.Click += new System.EventHandler(this.bPridatRezervaci_Click);
            // 
            // bZmenaHesla
            // 
            this.bZmenaHesla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bZmenaHesla.FlatAppearance.BorderSize = 0;
            this.bZmenaHesla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bZmenaHesla.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bZmenaHesla.ForeColor = System.Drawing.Color.White;
            this.bZmenaHesla.Location = new System.Drawing.Point(12, 44);
            this.bZmenaHesla.Name = "bZmenaHesla";
            this.bZmenaHesla.Size = new System.Drawing.Size(229, 88);
            this.bZmenaHesla.TabIndex = 11;
            this.bZmenaHesla.Text = "Změna hesla";
            this.bZmenaHesla.UseVisualStyleBackColor = false;
            this.bZmenaHesla.Click += new System.EventHandler(this.bZmenaHesla_Click);
            // 
            // lLineVertical
            // 
            this.lLineVertical.BackColor = System.Drawing.Color.White;
            this.lLineVertical.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lLineVertical.Location = new System.Drawing.Point(251, 0);
            this.lLineVertical.Name = "lLineVertical";
            this.lLineVertical.Size = new System.Drawing.Size(5, 582);
            this.lLineVertical.TabIndex = 10;
            // 
            // lLineHorizontal
            // 
            this.lLineHorizontal.BackColor = System.Drawing.Color.White;
            this.lLineHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lLineHorizontal.Location = new System.Drawing.Point(251, 102);
            this.lLineHorizontal.Name = "lLineHorizontal";
            this.lLineHorizontal.Size = new System.Drawing.Size(1114, 5);
            this.lLineHorizontal.TabIndex = 9;
            // 
            // bObnovit
            // 
            this.bObnovit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bObnovit.FlatAppearance.BorderSize = 0;
            this.bObnovit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bObnovit.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bObnovit.ForeColor = System.Drawing.Color.White;
            this.bObnovit.Image = ((System.Drawing.Image)(resources.GetObject("bObnovit.Image")));
            this.bObnovit.Location = new System.Drawing.Point(262, 12);
            this.bObnovit.Name = "bObnovit";
            this.bObnovit.Size = new System.Drawing.Size(71, 66);
            this.bObnovit.TabIndex = 28;
            this.bObnovit.UseVisualStyleBackColor = false;
            this.bObnovit.Click += new System.EventHandler(this.bObnovit_Click);
            // 
            // bOdstranitRezervaci
            // 
            this.bOdstranitRezervaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bOdstranitRezervaci.FlatAppearance.BorderSize = 0;
            this.bOdstranitRezervaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOdstranitRezervaci.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOdstranitRezervaci.ForeColor = System.Drawing.Color.DarkRed;
            this.bOdstranitRezervaci.Location = new System.Drawing.Point(12, 299);
            this.bOdstranitRezervaci.Name = "bOdstranitRezervaci";
            this.bOdstranitRezervaci.Size = new System.Drawing.Size(229, 104);
            this.bOdstranitRezervaci.TabIndex = 29;
            this.bOdstranitRezervaci.Text = "Odstranit rezervaci";
            this.bOdstranitRezervaci.UseVisualStyleBackColor = false;
            this.bOdstranitRezervaci.Click += new System.EventHandler(this.bOdstranitRezervaci_Click);
            // 
            // lMuisteVybratPolozkuZeSeznamu
            // 
            this.lMuisteVybratPolozkuZeSeznamu.AutoSize = true;
            this.lMuisteVybratPolozkuZeSeznamu.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMuisteVybratPolozkuZeSeznamu.ForeColor = System.Drawing.Color.Red;
            this.lMuisteVybratPolozkuZeSeznamu.Location = new System.Drawing.Point(587, 538);
            this.lMuisteVybratPolozkuZeSeznamu.Name = "lMuisteVybratPolozkuZeSeznamu";
            this.lMuisteVybratPolozkuZeSeznamu.Size = new System.Drawing.Size(379, 39);
            this.lMuisteVybratPolozkuZeSeznamu.TabIndex = 32;
            this.lMuisteVybratPolozkuZeSeznamu.Text = "Musíte vybrat položku ze seznamu";
            this.lMuisteVybratPolozkuZeSeznamu.Visible = false;
            // 
            // fUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1360, 580);
            this.Controls.Add(this.lMuisteVybratPolozkuZeSeznamu);
            this.Controls.Add(this.bOdstranitRezervaci);
            this.Controls.Add(this.bObnovit);
            this.Controls.Add(this.lBPrehledRezervaci);
            this.Controls.Add(this.lPosledniPrihlaseni);
            this.Controls.Add(this.lUzivatelskeJmeno);
            this.Controls.Add(this.bOdhlasitSe);
            this.Controls.Add(this.bPridatRezervaci);
            this.Controls.Add(this.bZmenaHesla);
            this.Controls.Add(this.lLineVertical);
            this.Controls.Add(this.lLineHorizontal);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "fUserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fUserMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fUserMenu_FormClosing);
            this.Load += new System.EventHandler(this.fUserMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBPrehledRezervaci;
        private System.Windows.Forms.Label lPosledniPrihlaseni;
        private System.Windows.Forms.Label lUzivatelskeJmeno;
        private System.Windows.Forms.Button bOdhlasitSe;
        private System.Windows.Forms.Button bPridatRezervaci;
        private System.Windows.Forms.Button bZmenaHesla;
        private System.Windows.Forms.Label lLineVertical;
        private System.Windows.Forms.Label lLineHorizontal;
        private System.Windows.Forms.Button bObnovit;
        private System.Windows.Forms.Button bOdstranitRezervaci;
        private System.Windows.Forms.Label lMuisteVybratPolozkuZeSeznamu;
    }
}