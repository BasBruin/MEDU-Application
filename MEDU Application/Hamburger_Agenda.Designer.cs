
namespace MEDU_Application
{
    partial class Hamburger_Agenda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.navigatiebar = new System.Windows.Forms.Panel();
            this.Kruisje_Ham = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Help_Ham = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Uitloggen_Ham = new System.Windows.Forms.Label();
            this.Instellingen_Ham = new System.Windows.Forms.Label();
            this.Vandaag_Ham = new System.Windows.Forms.Label();
            this.Medicijnen_Ham = new System.Windows.Forms.Label();
            this.Agenda_Ham = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.navigatiebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kruisje_Ham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.navigatiebar);
            this.groupBox1.Controls.Add(this.Help_Ham);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.Instellingen_Ham);
            this.groupBox1.Controls.Add(this.Vandaag_Ham);
            this.groupBox1.Controls.Add(this.Medicijnen_Ham);
            this.groupBox1.Controls.Add(this.Agenda_Ham);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 479);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // navigatiebar
            // 
            this.navigatiebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navigatiebar.Controls.Add(this.Kruisje_Ham);
            this.navigatiebar.Controls.Add(this.pictureBox1);
            this.navigatiebar.Location = new System.Drawing.Point(4, 21);
            this.navigatiebar.Name = "navigatiebar";
            this.navigatiebar.Size = new System.Drawing.Size(207, 95);
            this.navigatiebar.TabIndex = 3;
            this.navigatiebar.Paint += new System.Windows.Forms.PaintEventHandler(this.navigatiebar_Paint);
            // 
            // Kruisje_Ham
            // 
            this.Kruisje_Ham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kruisje_Ham.Image = global::MEDU_Application.Properties.Resources.Krosso_Hamburger;
            this.Kruisje_Ham.Location = new System.Drawing.Point(10, 28);
            this.Kruisje_Ham.Name = "Kruisje_Ham";
            this.Kruisje_Ham.Size = new System.Drawing.Size(45, 39);
            this.Kruisje_Ham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Kruisje_Ham.TabIndex = 4;
            this.Kruisje_Ham.TabStop = false;
            this.Kruisje_Ham.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MEDU_Application.Properties.Resources.MED_U_Logo_White;
            this.pictureBox1.Location = new System.Drawing.Point(85, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Help_Ham
            // 
            this.Help_Ham.AutoSize = true;
            this.Help_Ham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help_Ham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Help_Ham.Location = new System.Drawing.Point(19, 347);
            this.Help_Ham.Name = "Help_Ham";
            this.Help_Ham.Size = new System.Drawing.Size(64, 29);
            this.Help_Ham.TabIndex = 9;
            this.Help_Ham.Text = "Help";
            this.Help_Ham.Click += new System.EventHandler(this.Help_Ham_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Uitloggen_Ham);
            this.panel1.Location = new System.Drawing.Point(-7, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 58);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Uitloggen_Ham
            // 
            this.Uitloggen_Ham.AutoSize = true;
            this.Uitloggen_Ham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Uitloggen_Ham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Uitloggen_Ham.ForeColor = System.Drawing.Color.White;
            this.Uitloggen_Ham.Location = new System.Drawing.Point(18, 12);
            this.Uitloggen_Ham.Name = "Uitloggen_Ham";
            this.Uitloggen_Ham.Size = new System.Drawing.Size(117, 29);
            this.Uitloggen_Ham.TabIndex = 0;
            this.Uitloggen_Ham.Text = "Uitloggen";
            this.Uitloggen_Ham.Click += new System.EventHandler(this.Inloggen_Ham_Click);
            // 
            // Instellingen_Ham
            // 
            this.Instellingen_Ham.AutoSize = true;
            this.Instellingen_Ham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Instellingen_Ham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Instellingen_Ham.Location = new System.Drawing.Point(19, 295);
            this.Instellingen_Ham.Name = "Instellingen_Ham";
            this.Instellingen_Ham.Size = new System.Drawing.Size(136, 29);
            this.Instellingen_Ham.TabIndex = 8;
            this.Instellingen_Ham.Text = "Instellingen";
            this.Instellingen_Ham.Click += new System.EventHandler(this.Instellingen_Ham_Click);
            // 
            // Vandaag_Ham
            // 
            this.Vandaag_Ham.AutoSize = true;
            this.Vandaag_Ham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vandaag_Ham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Vandaag_Ham.Location = new System.Drawing.Point(19, 139);
            this.Vandaag_Ham.Name = "Vandaag_Ham";
            this.Vandaag_Ham.Size = new System.Drawing.Size(108, 29);
            this.Vandaag_Ham.TabIndex = 1;
            this.Vandaag_Ham.Text = "Vandaag";
            this.Vandaag_Ham.Click += new System.EventHandler(this.Vandaag_Ham_Click);
            // 
            // Medicijnen_Ham
            // 
            this.Medicijnen_Ham.AutoSize = true;
            this.Medicijnen_Ham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Medicijnen_Ham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Medicijnen_Ham.Location = new System.Drawing.Point(19, 241);
            this.Medicijnen_Ham.Name = "Medicijnen_Ham";
            this.Medicijnen_Ham.Size = new System.Drawing.Size(167, 29);
            this.Medicijnen_Ham.TabIndex = 7;
            this.Medicijnen_Ham.Text = "Medicijnenlijst";
            this.Medicijnen_Ham.Click += new System.EventHandler(this.Medicijnen_Ham_Click);
            // 
            // Agenda_Ham
            // 
            this.Agenda_Ham.AutoSize = true;
            this.Agenda_Ham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Agenda_Ham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Agenda_Ham.Location = new System.Drawing.Point(19, 190);
            this.Agenda_Ham.Name = "Agenda_Ham";
            this.Agenda_Ham.Size = new System.Drawing.Size(96, 29);
            this.Agenda_Ham.TabIndex = 6;
            this.Agenda_Ham.Text = "Agenda";
            this.Agenda_Ham.Click += new System.EventHandler(this.Agenda_Ham_Click);
            // 
            // Hamburger_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 484);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hamburger_Agenda";
            this.Text = "Hamburger_Agenda";
            this.Load += new System.EventHandler(this.Hamburger_Agenda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.navigatiebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Kruisje_Ham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel navigatiebar;
        private System.Windows.Forms.PictureBox Kruisje_Ham;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Help_Ham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Uitloggen_Ham;
        private System.Windows.Forms.Label Instellingen_Ham;
        private System.Windows.Forms.Label Vandaag_Ham;
        private System.Windows.Forms.Label Medicijnen_Ham;
        private System.Windows.Forms.Label Agenda_Ham;
    }
}