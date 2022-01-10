
namespace MEDU_Application
{
    partial class Agenda
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
            this.navigatiebar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbIngenomen = new System.Windows.Forms.Label();
            this.lbwijzeInname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbdose = new System.Windows.Forms.Label();
            this.lbmedicineName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxMedicine = new System.Windows.Forms.ListBox();
            this.lbxTijd = new System.Windows.Forms.ListBox();
            this.monthCalander = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.navigatiebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigatiebar
            // 
            this.navigatiebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navigatiebar.Controls.Add(this.pictureBox2);
            this.navigatiebar.Controls.Add(this.pictureBox1);
            this.navigatiebar.Location = new System.Drawing.Point(12, 12);
            this.navigatiebar.Name = "navigatiebar";
            this.navigatiebar.Size = new System.Drawing.Size(265, 92);
            this.navigatiebar.TabIndex = 4;
            this.navigatiebar.Paint += new System.Windows.Forms.PaintEventHandler(this.navigatiebar_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::MEDU_Application.Properties.Resources._800px_Hamburger_icon_white_svg;
            this.pictureBox2.Location = new System.Drawing.Point(5, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MEDU_Application.Properties.Resources.MED_U_Logo_White;
            this.pictureBox1.Location = new System.Drawing.Point(80, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lbxMedicine);
            this.groupBox1.Controls.Add(this.lbxTijd);
            this.groupBox1.Controls.Add(this.monthCalander);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 477);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agenda";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.lbIngenomen);
            this.groupBox3.Controls.Add(this.lbwijzeInname);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbdose);
            this.groupBox3.Controls.Add(this.lbmedicineName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F);
            this.groupBox3.Location = new System.Drawing.Point(6, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 97);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prescriptie Medicijn";
            // 
            // lbIngenomen
            // 
            this.lbIngenomen.AutoSize = true;
            this.lbIngenomen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F);
            this.lbIngenomen.Location = new System.Drawing.Point(82, 79);
            this.lbIngenomen.Name = "lbIngenomen";
            this.lbIngenomen.Size = new System.Drawing.Size(10, 13);
            this.lbIngenomen.TabIndex = 14;
            this.lbIngenomen.Text = "-";
            // 
            // lbwijzeInname
            // 
            this.lbwijzeInname.AutoSize = true;
            this.lbwijzeInname.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F);
            this.lbwijzeInname.Location = new System.Drawing.Point(96, 63);
            this.lbwijzeInname.Name = "lbwijzeInname";
            this.lbwijzeInname.Size = new System.Drawing.Size(10, 13);
            this.lbwijzeInname.TabIndex = 13;
            this.lbwijzeInname.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.4F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ingenomen:";
            // 
            // lbdose
            // 
            this.lbdose.AutoSize = true;
            this.lbdose.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F);
            this.lbdose.Location = new System.Drawing.Point(50, 45);
            this.lbdose.Name = "lbdose";
            this.lbdose.Size = new System.Drawing.Size(10, 13);
            this.lbdose.TabIndex = 10;
            this.lbdose.Text = "-";
            // 
            // lbmedicineName
            // 
            this.lbmedicineName.AutoSize = true;
            this.lbmedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F);
            this.lbmedicineName.Location = new System.Drawing.Point(66, 28);
            this.lbmedicineName.Name = "lbmedicineName";
            this.lbmedicineName.Size = new System.Drawing.Size(10, 13);
            this.lbmedicineName.TabIndex = 9;
            this.lbmedicineName.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.4F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wijze inname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.4F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dose:";
            // 
            // lbxMedicine
            // 
            this.lbxMedicine.FormattingEnabled = true;
            this.lbxMedicine.ItemHeight = 16;
            this.lbxMedicine.Location = new System.Drawing.Point(142, 305);
            this.lbxMedicine.Name = "lbxMedicine";
            this.lbxMedicine.Size = new System.Drawing.Size(120, 68);
            this.lbxMedicine.TabIndex = 12;
            this.lbxMedicine.SelectedIndexChanged += new System.EventHandler(this.lbxMedicine_SelectedIndexChanged);
            // 
            // lbxTijd
            // 
            this.lbxTijd.FormattingEnabled = true;
            this.lbxTijd.ItemHeight = 16;
            this.lbxTijd.Location = new System.Drawing.Point(6, 305);
            this.lbxTijd.Name = "lbxTijd";
            this.lbxTijd.Size = new System.Drawing.Size(120, 68);
            this.lbxTijd.TabIndex = 11;
            this.lbxTijd.SelectedIndexChanged += new System.EventHandler(this.lbxTijd_SelectedIndexChanged);
            // 
            // monthCalander
            // 
            this.monthCalander.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.monthCalander.Location = new System.Drawing.Point(28, 95);
            this.monthCalander.Name = "monthCalander";
            this.monthCalander.TabIndex = 10;
            this.monthCalander.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalander_DateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.4F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(4, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Medicijn:";
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 491);
            this.Controls.Add(this.navigatiebar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.navigatiebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigatiebar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbIngenomen;
        private System.Windows.Forms.Label lbwijzeInname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbdose;
        private System.Windows.Forms.Label lbmedicineName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxMedicine;
        private System.Windows.Forms.ListBox lbxTijd;
        private System.Windows.Forms.MonthCalendar monthCalander;
    }
}