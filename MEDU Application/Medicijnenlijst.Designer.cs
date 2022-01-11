
namespace MEDU_Application
{
    partial class Medicijnenlijst
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
            this.lbwijzeInname = new System.Windows.Forms.Label();
            this.lbmedicineName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxMedicijn = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lblProfiel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.navigatiebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // navigatiebar
            // 
            this.navigatiebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navigatiebar.Controls.Add(this.lblProfiel);
            this.navigatiebar.Controls.Add(this.pictureBox3);
            this.navigatiebar.Controls.Add(this.pictureBox2);
            this.navigatiebar.Controls.Add(this.pictureBox1);
            this.navigatiebar.Location = new System.Drawing.Point(2, 3);
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
            this.pictureBox1.Location = new System.Drawing.Point(74, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxMedicijn);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 484);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Medicijnenlijst";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.lbCategory);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lbwijzeInname);
            this.groupBox3.Controls.Add(this.lbmedicineName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F);
            this.groupBox3.Location = new System.Drawing.Point(6, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 185);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prescriptie Medicijn";
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
            // lbxMedicijn
            // 
            this.lbxMedicijn.FormattingEnabled = true;
            this.lbxMedicijn.ItemHeight = 16;
            this.lbxMedicijn.Location = new System.Drawing.Point(6, 159);
            this.lbxMedicijn.Name = "lbxMedicijn";
            this.lbxMedicijn.Size = new System.Drawing.Size(257, 116);
            this.lbxMedicijn.TabIndex = 15;
            this.lbxMedicijn.SelectedIndexChanged += new System.EventHandler(this.lbxMedicijn_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.4F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soort medicijn:";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F);
            this.lbCategory.Location = new System.Drawing.Point(103, 98);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(10, 13);
            this.lbCategory.TabIndex = 15;
            this.lbCategory.Text = "-";
            // 
            // lblProfiel
            // 
            this.lblProfiel.AutoSize = true;
            this.lblProfiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.lblProfiel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProfiel.Location = new System.Drawing.Point(199, 62);
            this.lblProfiel.Name = "lblProfiel";
            this.lblProfiel.Size = new System.Drawing.Size(48, 16);
            this.lblProfiel.TabIndex = 7;
            this.lblProfiel.Text = "poepo";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox3.Image = global::MEDU_Application.Properties.Resources.MED_U_user_wit;
            this.pictureBox3.Location = new System.Drawing.Point(202, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // Medicijnenlijst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 491);
            this.Controls.Add(this.navigatiebar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Medicijnenlijst";
            this.Text = "Medicijnenlijst";
            this.navigatiebar.ResumeLayout(false);
            this.navigatiebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigatiebar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbwijzeInname;
        private System.Windows.Forms.Label lbmedicineName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxMedicijn;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProfiel;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}