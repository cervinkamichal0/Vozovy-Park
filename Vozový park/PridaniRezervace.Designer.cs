
namespace Vozový_park
{
    partial class fPridaniRezervace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPridaniRezervace));
            this.lPridaniRezervace = new System.Windows.Forms.Label();
            this.lBDostupneVozy = new System.Windows.Forms.ListBox();
            this.dTRezervaceVozuOd = new System.Windows.Forms.DateTimePicker();
            this.bPridatRezervaci = new System.Windows.Forms.Button();
            this.dTRezervaceVozuDo = new System.Windows.Forms.DateTimePicker();
            this.lOd = new System.Windows.Forms.Label();
            this.lDo = new System.Windows.Forms.Label();
            this.lRezervaceSePrekryvaSJinouRezervaci = new System.Windows.Forms.Label();
            this.ldatumOdNesmiBytStarsiNezDatumDo = new System.Windows.Forms.Label();
            this.lVTutoDobuJeVuzDeaktivovan = new System.Windows.Forms.Label();
            this.lMuisteVybratPolozkuZeSeznamu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lPridaniRezervace
            // 
            this.lPridaniRezervace.AutoSize = true;
            this.lPridaniRezervace.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPridaniRezervace.ForeColor = System.Drawing.Color.White;
            this.lPridaniRezervace.Location = new System.Drawing.Point(242, 9);
            this.lPridaniRezervace.Name = "lPridaniRezervace";
            this.lPridaniRezervace.Size = new System.Drawing.Size(432, 77);
            this.lPridaniRezervace.TabIndex = 7;
            this.lPridaniRezervace.Text = "Přidání rezerevace";
            // 
            // lBDostupneVozy
            // 
            this.lBDostupneVozy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lBDostupneVozy.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBDostupneVozy.ForeColor = System.Drawing.Color.White;
            this.lBDostupneVozy.FormattingEnabled = true;
            this.lBDostupneVozy.ItemHeight = 33;
            this.lBDostupneVozy.Location = new System.Drawing.Point(12, 99);
            this.lBDostupneVozy.Name = "lBDostupneVozy";
            this.lBDostupneVozy.Size = new System.Drawing.Size(879, 268);
            this.lBDostupneVozy.TabIndex = 9;
            this.lBDostupneVozy.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBDostupneVozy_MouseDoubleClick);
            // 
            // dTRezervaceVozuOd
            // 
            this.dTRezervaceVozuOd.CalendarForeColor = System.Drawing.Color.White;
            this.dTRezervaceVozuOd.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dTRezervaceVozuOd.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dTRezervaceVozuOd.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dTRezervaceVozuOd.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dTRezervaceVozuOd.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTRezervaceVozuOd.Location = new System.Drawing.Point(69, 432);
            this.dTRezervaceVozuOd.MinDate = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            this.dTRezervaceVozuOd.Name = "dTRezervaceVozuOd";
            this.dTRezervaceVozuOd.Size = new System.Drawing.Size(395, 52);
            this.dTRezervaceVozuOd.TabIndex = 10;
            this.dTRezervaceVozuOd.Value = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            // 
            // bPridatRezervaci
            // 
            this.bPridatRezervaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bPridatRezervaci.FlatAppearance.BorderSize = 0;
            this.bPridatRezervaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPridatRezervaci.Font = new System.Drawing.Font("Bahnschrift Condensed", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPridatRezervaci.ForeColor = System.Drawing.Color.White;
            this.bPridatRezervaci.Location = new System.Drawing.Point(470, 432);
            this.bPridatRezervaci.Name = "bPridatRezervaci";
            this.bPridatRezervaci.Size = new System.Drawing.Size(421, 125);
            this.bPridatRezervaci.TabIndex = 12;
            this.bPridatRezervaci.Text = "Přidat";
            this.bPridatRezervaci.UseVisualStyleBackColor = false;
            this.bPridatRezervaci.Click += new System.EventHandler(this.bPridatRezervaci_Click);
            // 
            // dTRezervaceVozuDo
            // 
            this.dTRezervaceVozuDo.CalendarForeColor = System.Drawing.Color.White;
            this.dTRezervaceVozuDo.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dTRezervaceVozuDo.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dTRezervaceVozuDo.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dTRezervaceVozuDo.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dTRezervaceVozuDo.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTRezervaceVozuDo.Location = new System.Drawing.Point(69, 501);
            this.dTRezervaceVozuDo.MinDate = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            this.dTRezervaceVozuDo.Name = "dTRezervaceVozuDo";
            this.dTRezervaceVozuDo.Size = new System.Drawing.Size(395, 52);
            this.dTRezervaceVozuDo.TabIndex = 13;
            this.dTRezervaceVozuDo.Value = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            // 
            // lOd
            // 
            this.lOd.AutoSize = true;
            this.lOd.Font = new System.Drawing.Font("Bahnschrift Condensed", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOd.ForeColor = System.Drawing.Color.White;
            this.lOd.Location = new System.Drawing.Point(14, 439);
            this.lOd.Name = "lOd";
            this.lOd.Size = new System.Drawing.Size(49, 43);
            this.lOd.TabIndex = 14;
            this.lOd.Text = "Od";
            // 
            // lDo
            // 
            this.lDo.AutoSize = true;
            this.lDo.Font = new System.Drawing.Font("Bahnschrift Condensed", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDo.ForeColor = System.Drawing.Color.White;
            this.lDo.Location = new System.Drawing.Point(14, 506);
            this.lDo.Name = "lDo";
            this.lDo.Size = new System.Drawing.Size(49, 43);
            this.lDo.TabIndex = 15;
            this.lDo.Text = "Do";
            // 
            // lRezervaceSePrekryvaSJinouRezervaci
            // 
            this.lRezervaceSePrekryvaSJinouRezervaci.AutoSize = true;
            this.lRezervaceSePrekryvaSJinouRezervaci.Font = new System.Drawing.Font("Bahnschrift Condensed", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRezervaceSePrekryvaSJinouRezervaci.ForeColor = System.Drawing.Color.Red;
            this.lRezervaceSePrekryvaSJinouRezervaci.Location = new System.Drawing.Point(205, 370);
            this.lRezervaceSePrekryvaSJinouRezervaci.Name = "lRezervaceSePrekryvaSJinouRezervaci";
            this.lRezervaceSePrekryvaSJinouRezervaci.Size = new System.Drawing.Size(497, 43);
            this.lRezervaceSePrekryvaSJinouRezervaci.TabIndex = 16;
            this.lRezervaceSePrekryvaSJinouRezervaci.Text = "Rezervace se překrývá s jinou rezervací";
            this.lRezervaceSePrekryvaSJinouRezervaci.Visible = false;
            // 
            // ldatumOdNesmiBytStarsiNezDatumDo
            // 
            this.ldatumOdNesmiBytStarsiNezDatumDo.AutoSize = true;
            this.ldatumOdNesmiBytStarsiNezDatumDo.Font = new System.Drawing.Font("Bahnschrift Condensed", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldatumOdNesmiBytStarsiNezDatumDo.ForeColor = System.Drawing.Color.Red;
            this.ldatumOdNesmiBytStarsiNezDatumDo.Location = new System.Drawing.Point(205, 370);
            this.ldatumOdNesmiBytStarsiNezDatumDo.Name = "ldatumOdNesmiBytStarsiNezDatumDo";
            this.ldatumOdNesmiBytStarsiNezDatumDo.Size = new System.Drawing.Size(496, 43);
            this.ldatumOdNesmiBytStarsiNezDatumDo.TabIndex = 17;
            this.ldatumOdNesmiBytStarsiNezDatumDo.Text = "Datum od nesmí být starší nez datum do";
            this.ldatumOdNesmiBytStarsiNezDatumDo.Visible = false;
            // 
            // lVTutoDobuJeVuzDeaktivovan
            // 
            this.lVTutoDobuJeVuzDeaktivovan.AutoSize = true;
            this.lVTutoDobuJeVuzDeaktivovan.Font = new System.Drawing.Font("Bahnschrift Condensed", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVTutoDobuJeVuzDeaktivovan.ForeColor = System.Drawing.Color.Red;
            this.lVTutoDobuJeVuzDeaktivovan.Location = new System.Drawing.Point(206, 370);
            this.lVTutoDobuJeVuzDeaktivovan.Name = "lVTutoDobuJeVuzDeaktivovan";
            this.lVTutoDobuJeVuzDeaktivovan.Size = new System.Drawing.Size(380, 43);
            this.lVTutoDobuJeVuzDeaktivovan.TabIndex = 18;
            this.lVTutoDobuJeVuzDeaktivovan.Text = "V tuto dobu je vůz deaktivován";
            this.lVTutoDobuJeVuzDeaktivovan.Visible = false;
            // 
            // lMuisteVybratPolozkuZeSeznamu
            // 
            this.lMuisteVybratPolozkuZeSeznamu.AutoSize = true;
            this.lMuisteVybratPolozkuZeSeznamu.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMuisteVybratPolozkuZeSeznamu.ForeColor = System.Drawing.Color.Red;
            this.lMuisteVybratPolozkuZeSeznamu.Location = new System.Drawing.Point(248, 374);
            this.lMuisteVybratPolozkuZeSeznamu.Name = "lMuisteVybratPolozkuZeSeznamu";
            this.lMuisteVybratPolozkuZeSeznamu.Size = new System.Drawing.Size(379, 39);
            this.lMuisteVybratPolozkuZeSeznamu.TabIndex = 33;
            this.lMuisteVybratPolozkuZeSeznamu.Text = "Musíte vybrat položku ze seznamu";
            this.lMuisteVybratPolozkuZeSeznamu.Visible = false;
            // 
            // fPridaniRezervace
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(903, 569);
            this.Controls.Add(this.lMuisteVybratPolozkuZeSeznamu);
            this.Controls.Add(this.lVTutoDobuJeVuzDeaktivovan);
            this.Controls.Add(this.ldatumOdNesmiBytStarsiNezDatumDo);
            this.Controls.Add(this.lRezervaceSePrekryvaSJinouRezervaci);
            this.Controls.Add(this.lDo);
            this.Controls.Add(this.lOd);
            this.Controls.Add(this.dTRezervaceVozuDo);
            this.Controls.Add(this.bPridatRezervaci);
            this.Controls.Add(this.dTRezervaceVozuOd);
            this.Controls.Add(this.lBDostupneVozy);
            this.Controls.Add(this.lPridaniRezervace);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "fPridaniRezervace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Přidat Rezervaci";
            this.Load += new System.EventHandler(this.fPridaniRezervace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPridaniRezervace;
        private System.Windows.Forms.ListBox lBDostupneVozy;
        private System.Windows.Forms.DateTimePicker dTRezervaceVozuOd;
        private System.Windows.Forms.Button bPridatRezervaci;
        private System.Windows.Forms.DateTimePicker dTRezervaceVozuDo;
        private System.Windows.Forms.Label lOd;
        private System.Windows.Forms.Label lDo;
        private System.Windows.Forms.Label lRezervaceSePrekryvaSJinouRezervaci;
        private System.Windows.Forms.Label ldatumOdNesmiBytStarsiNezDatumDo;
        private System.Windows.Forms.Label lVTutoDobuJeVuzDeaktivovan;
        private System.Windows.Forms.Label lMuisteVybratPolozkuZeSeznamu;
    }
}