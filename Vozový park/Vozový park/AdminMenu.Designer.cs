
namespace Vozový_park
{
    partial class fAdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdminMenu));
            this.lBSeznamUzivatelu = new System.Windows.Forms.ListBox();
            this.lPosledniPrihlaseni = new System.Windows.Forms.Label();
            this.lUzivatelskeJmeno = new System.Windows.Forms.Label();
            this.bOdhlasitSe = new System.Windows.Forms.Button();
            this.bPridatUzivatele = new System.Windows.Forms.Button();
            this.bZmenaHesla = new System.Windows.Forms.Button();
            this.lLineVertical = new System.Windows.Forms.Label();
            this.lLineHorizontal = new System.Windows.Forms.Label();
            this.lBRezervaceUzivatele = new System.Windows.Forms.ListBox();
            this.lBSeznamVozu = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bVlozitRezervaciJmenemUzivatele = new System.Windows.Forms.Button();
            this.bVynutitZměnuHesla = new System.Windows.Forms.Button();
            this.bPridatVuz = new System.Windows.Forms.Button();
            this.bAktivovatUzivatele = new System.Windows.Forms.Button();
            this.bDeaktivovatUzivatele = new System.Windows.Forms.Button();
            this.bOdstranitUzivatele = new System.Windows.Forms.Button();
            this.bOdstraitVuz = new System.Windows.Forms.Button();
            this.bObnovit = new System.Windows.Forms.Button();
            this.lNemuzeteOdstranitSebe = new System.Windows.Forms.Label();
            this.lNemuzeteDeaktivovatSebe = new System.Windows.Forms.Label();
            this.bOdstranitRezervaci = new System.Windows.Forms.Button();
            this.lMuisteVybratPolozkuZeSeznamu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBSeznamUzivatelu
            // 
            this.lBSeznamUzivatelu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lBSeznamUzivatelu.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBSeznamUzivatelu.ForeColor = System.Drawing.Color.White;
            this.lBSeznamUzivatelu.FormattingEnabled = true;
            this.lBSeznamUzivatelu.HorizontalScrollbar = true;
            this.lBSeznamUzivatelu.ItemHeight = 25;
            this.lBSeznamUzivatelu.Location = new System.Drawing.Point(280, 124);
            this.lBSeznamUzivatelu.Name = "lBSeznamUzivatelu";
            this.lBSeznamUzivatelu.Size = new System.Drawing.Size(467, 529);
            this.lBSeznamUzivatelu.TabIndex = 16;
            this.lBSeznamUzivatelu.SelectedIndexChanged += new System.EventHandler(this.lBSeznamUzivatelu_SelectedIndexChanged);
            // 
            // lPosledniPrihlaseni
            // 
            this.lPosledniPrihlaseni.AutoSize = true;
            this.lPosledniPrihlaseni.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPosledniPrihlaseni.ForeColor = System.Drawing.Color.White;
            this.lPosledniPrihlaseni.Location = new System.Drawing.Point(1063, 20);
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
            this.lUzivatelskeJmeno.Location = new System.Drawing.Point(389, 20);
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
            this.bOdhlasitSe.Location = new System.Drawing.Point(22, 667);
            this.bOdhlasitSe.Name = "bOdhlasitSe";
            this.bOdhlasitSe.Size = new System.Drawing.Size(229, 88);
            this.bOdhlasitSe.TabIndex = 13;
            this.bOdhlasitSe.Text = "Odhlásit se";
            this.bOdhlasitSe.UseVisualStyleBackColor = false;
            this.bOdhlasitSe.Click += new System.EventHandler(this.bOdhlasitSe_Click);
            // 
            // bPridatUzivatele
            // 
            this.bPridatUzivatele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bPridatUzivatele.FlatAppearance.BorderSize = 0;
            this.bPridatUzivatele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPridatUzivatele.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPridatUzivatele.ForeColor = System.Drawing.Color.White;
            this.bPridatUzivatele.Location = new System.Drawing.Point(22, 139);
            this.bPridatUzivatele.Name = "bPridatUzivatele";
            this.bPridatUzivatele.Size = new System.Drawing.Size(229, 88);
            this.bPridatUzivatele.TabIndex = 12;
            this.bPridatUzivatele.Text = "Přidat uživatele";
            this.bPridatUzivatele.UseVisualStyleBackColor = false;
            this.bPridatUzivatele.Click += new System.EventHandler(this.bPridatUzivatele_Click);
            // 
            // bZmenaHesla
            // 
            this.bZmenaHesla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bZmenaHesla.FlatAppearance.BorderSize = 0;
            this.bZmenaHesla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bZmenaHesla.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bZmenaHesla.ForeColor = System.Drawing.Color.White;
            this.bZmenaHesla.Location = new System.Drawing.Point(22, 21);
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
            this.lLineVertical.Location = new System.Drawing.Point(269, -4);
            this.lLineVertical.Name = "lLineVertical";
            this.lLineVertical.Size = new System.Drawing.Size(5, 777);
            this.lLineVertical.TabIndex = 10;
            // 
            // lLineHorizontal
            // 
            this.lLineHorizontal.BackColor = System.Drawing.Color.White;
            this.lLineHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lLineHorizontal.Location = new System.Drawing.Point(269, 93);
            this.lLineHorizontal.Name = "lLineHorizontal";
            this.lLineHorizontal.Size = new System.Drawing.Size(1626, 5);
            this.lLineHorizontal.TabIndex = 9;
            // 
            // lBRezervaceUzivatele
            // 
            this.lBRezervaceUzivatele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lBRezervaceUzivatele.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBRezervaceUzivatele.ForeColor = System.Drawing.Color.White;
            this.lBRezervaceUzivatele.FormattingEnabled = true;
            this.lBRezervaceUzivatele.HorizontalScrollbar = true;
            this.lBRezervaceUzivatele.ItemHeight = 25;
            this.lBRezervaceUzivatele.Location = new System.Drawing.Point(753, 124);
            this.lBRezervaceUzivatele.Name = "lBRezervaceUzivatele";
            this.lBRezervaceUzivatele.Size = new System.Drawing.Size(481, 529);
            this.lBRezervaceUzivatele.TabIndex = 17;
            // 
            // lBSeznamVozu
            // 
            this.lBSeznamVozu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lBSeznamVozu.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBSeznamVozu.ForeColor = System.Drawing.Color.White;
            this.lBSeznamVozu.FormattingEnabled = true;
            this.lBSeznamVozu.HorizontalScrollbar = true;
            this.lBSeznamVozu.ItemHeight = 33;
            this.lBSeznamVozu.Location = new System.Drawing.Point(1251, 124);
            this.lBSeznamVozu.Name = "lBSeznamVozu";
            this.lBSeznamVozu.Size = new System.Drawing.Size(482, 532);
            this.lBSeznamVozu.TabIndex = 18;
            this.lBSeznamVozu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBSeznamVozu_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(1240, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(5, 676);
            this.label1.TabIndex = 19;
            // 
            // bVlozitRezervaciJmenemUzivatele
            // 
            this.bVlozitRezervaciJmenemUzivatele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bVlozitRezervaciJmenemUzivatele.FlatAppearance.BorderSize = 0;
            this.bVlozitRezervaciJmenemUzivatele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVlozitRezervaciJmenemUzivatele.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVlozitRezervaciJmenemUzivatele.ForeColor = System.Drawing.Color.White;
            this.bVlozitRezervaciJmenemUzivatele.Location = new System.Drawing.Point(22, 254);
            this.bVlozitRezervaciJmenemUzivatele.Name = "bVlozitRezervaciJmenemUzivatele";
            this.bVlozitRezervaciJmenemUzivatele.Size = new System.Drawing.Size(229, 146);
            this.bVlozitRezervaciJmenemUzivatele.TabIndex = 20;
            this.bVlozitRezervaciJmenemUzivatele.Text = "Rezervace jménem uživatele";
            this.bVlozitRezervaciJmenemUzivatele.UseVisualStyleBackColor = false;
            this.bVlozitRezervaciJmenemUzivatele.Click += new System.EventHandler(this.bVlozitRezervaciJmenemUzivatele_Click);
            // 
            // bVynutitZměnuHesla
            // 
            this.bVynutitZměnuHesla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bVynutitZměnuHesla.FlatAppearance.BorderSize = 0;
            this.bVynutitZměnuHesla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVynutitZměnuHesla.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVynutitZměnuHesla.ForeColor = System.Drawing.Color.White;
            this.bVynutitZměnuHesla.Location = new System.Drawing.Point(22, 426);
            this.bVynutitZměnuHesla.Name = "bVynutitZměnuHesla";
            this.bVynutitZměnuHesla.Size = new System.Drawing.Size(229, 101);
            this.bVynutitZměnuHesla.TabIndex = 21;
            this.bVynutitZměnuHesla.Text = "Vynutit změnu hesla";
            this.bVynutitZměnuHesla.UseVisualStyleBackColor = false;
            this.bVynutitZměnuHesla.Click += new System.EventHandler(this.bVynutitZměnuHesla_Click);
            // 
            // bPridatVuz
            // 
            this.bPridatVuz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bPridatVuz.FlatAppearance.BorderSize = 0;
            this.bPridatVuz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPridatVuz.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPridatVuz.ForeColor = System.Drawing.Color.White;
            this.bPridatVuz.Location = new System.Drawing.Point(22, 547);
            this.bPridatVuz.Name = "bPridatVuz";
            this.bPridatVuz.Size = new System.Drawing.Size(229, 88);
            this.bPridatVuz.TabIndex = 22;
            this.bPridatVuz.Text = "Přidat vůz";
            this.bPridatVuz.UseVisualStyleBackColor = false;
            this.bPridatVuz.Click += new System.EventHandler(this.bPridatVuz_Click);
            // 
            // bAktivovatUzivatele
            // 
            this.bAktivovatUzivatele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bAktivovatUzivatele.FlatAppearance.BorderSize = 0;
            this.bAktivovatUzivatele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAktivovatUzivatele.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAktivovatUzivatele.ForeColor = System.Drawing.Color.YellowGreen;
            this.bAktivovatUzivatele.Location = new System.Drawing.Point(280, 662);
            this.bAktivovatUzivatele.Name = "bAktivovatUzivatele";
            this.bAktivovatUzivatele.Size = new System.Drawing.Size(235, 93);
            this.bAktivovatUzivatele.TabIndex = 23;
            this.bAktivovatUzivatele.Text = "Aktivovat uživatele";
            this.bAktivovatUzivatele.UseVisualStyleBackColor = false;
            this.bAktivovatUzivatele.Click += new System.EventHandler(this.bAktivovatUzivatele_Click);
            // 
            // bDeaktivovatUzivatele
            // 
            this.bDeaktivovatUzivatele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bDeaktivovatUzivatele.FlatAppearance.BorderSize = 0;
            this.bDeaktivovatUzivatele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeaktivovatUzivatele.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeaktivovatUzivatele.ForeColor = System.Drawing.Color.Orange;
            this.bDeaktivovatUzivatele.Location = new System.Drawing.Point(521, 660);
            this.bDeaktivovatUzivatele.Name = "bDeaktivovatUzivatele";
            this.bDeaktivovatUzivatele.Size = new System.Drawing.Size(235, 93);
            this.bDeaktivovatUzivatele.TabIndex = 24;
            this.bDeaktivovatUzivatele.Text = "Deaktivovat uživatele";
            this.bDeaktivovatUzivatele.UseVisualStyleBackColor = false;
            this.bDeaktivovatUzivatele.Click += new System.EventHandler(this.bDeaktivovatUzivatele_Click);
            // 
            // bOdstranitUzivatele
            // 
            this.bOdstranitUzivatele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bOdstranitUzivatele.FlatAppearance.BorderSize = 0;
            this.bOdstranitUzivatele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOdstranitUzivatele.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOdstranitUzivatele.ForeColor = System.Drawing.Color.DarkRed;
            this.bOdstranitUzivatele.Location = new System.Drawing.Point(762, 660);
            this.bOdstranitUzivatele.Name = "bOdstranitUzivatele";
            this.bOdstranitUzivatele.Size = new System.Drawing.Size(235, 93);
            this.bOdstranitUzivatele.TabIndex = 25;
            this.bOdstranitUzivatele.Text = "Odstranit uživatele";
            this.bOdstranitUzivatele.UseVisualStyleBackColor = false;
            this.bOdstranitUzivatele.Click += new System.EventHandler(this.bSmazatUzivatele_Click);
            // 
            // bOdstraitVuz
            // 
            this.bOdstraitVuz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bOdstraitVuz.FlatAppearance.BorderSize = 0;
            this.bOdstraitVuz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOdstraitVuz.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOdstraitVuz.ForeColor = System.Drawing.Color.DarkRed;
            this.bOdstraitVuz.Location = new System.Drawing.Point(1251, 662);
            this.bOdstraitVuz.Name = "bOdstraitVuz";
            this.bOdstraitVuz.Size = new System.Drawing.Size(482, 88);
            this.bOdstraitVuz.TabIndex = 26;
            this.bOdstraitVuz.Text = "Odstranit vůz";
            this.bOdstraitVuz.UseVisualStyleBackColor = false;
            this.bOdstraitVuz.Click += new System.EventHandler(this.bOdstraitVuz_Click);
            // 
            // bObnovit
            // 
            this.bObnovit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bObnovit.FlatAppearance.BorderSize = 0;
            this.bObnovit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bObnovit.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bObnovit.ForeColor = System.Drawing.Color.White;
            this.bObnovit.Image = ((System.Drawing.Image)(resources.GetObject("bObnovit.Image")));
            this.bObnovit.Location = new System.Drawing.Point(280, 12);
            this.bObnovit.Name = "bObnovit";
            this.bObnovit.Size = new System.Drawing.Size(71, 66);
            this.bObnovit.TabIndex = 27;
            this.bObnovit.UseVisualStyleBackColor = false;
            this.bObnovit.Click += new System.EventHandler(this.bObnovit_Click);
            // 
            // lNemuzeteOdstranitSebe
            // 
            this.lNemuzeteOdstranitSebe.AutoSize = true;
            this.lNemuzeteOdstranitSebe.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNemuzeteOdstranitSebe.ForeColor = System.Drawing.Color.Red;
            this.lNemuzeteOdstranitSebe.Location = new System.Drawing.Point(699, 31);
            this.lNemuzeteOdstranitSebe.Name = "lNemuzeteOdstranitSebe";
            this.lNemuzeteOdstranitSebe.Size = new System.Drawing.Size(321, 45);
            this.lNemuzeteOdstranitSebe.TabIndex = 28;
            this.lNemuzeteOdstranitSebe.Text = "Nemůžete odstranit sebe";
            this.lNemuzeteOdstranitSebe.Visible = false;
            // 
            // lNemuzeteDeaktivovatSebe
            // 
            this.lNemuzeteDeaktivovatSebe.AutoSize = true;
            this.lNemuzeteDeaktivovatSebe.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNemuzeteDeaktivovatSebe.ForeColor = System.Drawing.Color.Red;
            this.lNemuzeteDeaktivovatSebe.Location = new System.Drawing.Point(699, 33);
            this.lNemuzeteDeaktivovatSebe.Name = "lNemuzeteDeaktivovatSebe";
            this.lNemuzeteDeaktivovatSebe.Size = new System.Drawing.Size(352, 45);
            this.lNemuzeteDeaktivovatSebe.TabIndex = 29;
            this.lNemuzeteDeaktivovatSebe.Text = "Nemůžete deaktivovat sebe";
            this.lNemuzeteDeaktivovatSebe.Visible = false;
            // 
            // bOdstranitRezervaci
            // 
            this.bOdstranitRezervaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bOdstranitRezervaci.FlatAppearance.BorderSize = 0;
            this.bOdstranitRezervaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOdstranitRezervaci.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOdstranitRezervaci.ForeColor = System.Drawing.Color.DarkRed;
            this.bOdstranitRezervaci.Location = new System.Drawing.Point(1003, 660);
            this.bOdstranitRezervaci.Name = "bOdstranitRezervaci";
            this.bOdstranitRezervaci.Size = new System.Drawing.Size(235, 93);
            this.bOdstranitRezervaci.TabIndex = 30;
            this.bOdstranitRezervaci.Text = "Odstranit rezervaci";
            this.bOdstranitRezervaci.UseVisualStyleBackColor = false;
            this.bOdstranitRezervaci.Click += new System.EventHandler(this.bOdstranitRezervaci_Click);
            // 
            // lMuisteVybratPolozkuZeSeznamu
            // 
            this.lMuisteVybratPolozkuZeSeznamu.AutoSize = true;
            this.lMuisteVybratPolozkuZeSeznamu.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMuisteVybratPolozkuZeSeznamu.ForeColor = System.Drawing.Color.Red;
            this.lMuisteVybratPolozkuZeSeznamu.Location = new System.Drawing.Point(690, 33);
            this.lMuisteVybratPolozkuZeSeznamu.Name = "lMuisteVybratPolozkuZeSeznamu";
            this.lMuisteVybratPolozkuZeSeznamu.Size = new System.Drawing.Size(379, 39);
            this.lMuisteVybratPolozkuZeSeznamu.TabIndex = 31;
            this.lMuisteVybratPolozkuZeSeznamu.Text = "Musíte vybrat položku ze seznamu";
            this.lMuisteVybratPolozkuZeSeznamu.Visible = false;
            // 
            // fAdminMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1742, 767);
            this.Controls.Add(this.lMuisteVybratPolozkuZeSeznamu);
            this.Controls.Add(this.bOdstranitRezervaci);
            this.Controls.Add(this.lNemuzeteDeaktivovatSebe);
            this.Controls.Add(this.lNemuzeteOdstranitSebe);
            this.Controls.Add(this.bObnovit);
            this.Controls.Add(this.bOdstraitVuz);
            this.Controls.Add(this.bOdstranitUzivatele);
            this.Controls.Add(this.bDeaktivovatUzivatele);
            this.Controls.Add(this.bAktivovatUzivatele);
            this.Controls.Add(this.bPridatVuz);
            this.Controls.Add(this.bVynutitZměnuHesla);
            this.Controls.Add(this.bVlozitRezervaciJmenemUzivatele);
            this.Controls.Add(this.lBSeznamVozu);
            this.Controls.Add(this.lBRezervaceUzivatele);
            this.Controls.Add(this.lBSeznamUzivatelu);
            this.Controls.Add(this.lPosledniPrihlaseni);
            this.Controls.Add(this.lUzivatelskeJmeno);
            this.Controls.Add(this.bOdhlasitSe);
            this.Controls.Add(this.bPridatUzivatele);
            this.Controls.Add(this.bZmenaHesla);
            this.Controls.Add(this.lLineVertical);
            this.Controls.Add(this.lLineHorizontal);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAdminMenu_FormClosing);
            this.Load += new System.EventHandler(this.fAdminMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBSeznamUzivatelu;
        private System.Windows.Forms.Label lPosledniPrihlaseni;
        private System.Windows.Forms.Label lUzivatelskeJmeno;
        private System.Windows.Forms.Button bOdhlasitSe;
        private System.Windows.Forms.Button bPridatUzivatele;
        private System.Windows.Forms.Button bZmenaHesla;
        private System.Windows.Forms.Label lLineVertical;
        private System.Windows.Forms.Label lLineHorizontal;
        private System.Windows.Forms.ListBox lBRezervaceUzivatele;
        private System.Windows.Forms.ListBox lBSeznamVozu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bVlozitRezervaciJmenemUzivatele;
        private System.Windows.Forms.Button bVynutitZměnuHesla;
        private System.Windows.Forms.Button bPridatVuz;
        private System.Windows.Forms.Button bAktivovatUzivatele;
        private System.Windows.Forms.Button bDeaktivovatUzivatele;
        private System.Windows.Forms.Button bOdstranitUzivatele;
        private System.Windows.Forms.Button bOdstraitVuz;
        private System.Windows.Forms.Button bObnovit;
        private System.Windows.Forms.Label lNemuzeteOdstranitSebe;
        private System.Windows.Forms.Label lNemuzeteDeaktivovatSebe;
        private System.Windows.Forms.Button bOdstranitRezervaci;
        private System.Windows.Forms.Label lMuisteVybratPolozkuZeSeznamu;
    }
}