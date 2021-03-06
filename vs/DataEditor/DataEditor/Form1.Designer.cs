﻿namespace DataEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addBtn = new System.Windows.Forms.Button();
            this.offersBox = new System.Windows.Forms.ListBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.savingTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.volumeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dimensionsTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.startsDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.endsDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.copyFromClipboardBtn = new System.Windows.Forms.Button();
            this.removeImageBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.extrasTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.publishBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.partsTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 353);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(95, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Neues Angebot";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // offersBox
            // 
            this.offersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offersBox.FormattingEnabled = true;
            this.offersBox.IntegralHeight = false;
            this.offersBox.Items.AddRange(new object[] {
            "Reisprofi",
            "Mess and Go"});
            this.offersBox.Location = new System.Drawing.Point(12, 28);
            this.offersBox.Name = "offersBox";
            this.offersBox.Size = new System.Drawing.Size(196, 319);
            this.offersBox.TabIndex = 3;
            this.offersBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(113, 353);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(95, 23);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "Angebot löschen";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(9, 32);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(196, 20);
            this.nameTxt.TabIndex = 6;
            this.nameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTxt_KeyPress);
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(9, 71);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(196, 20);
            this.priceTxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preis:";
            // 
            // savingTxt
            // 
            this.savingTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savingTxt.Location = new System.Drawing.Point(9, 188);
            this.savingTxt.Name = "savingTxt";
            this.savingTxt.Size = new System.Drawing.Size(176, 20);
            this.savingTxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Geld gespart:";
            // 
            // volumeTxt
            // 
            this.volumeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeTxt.Location = new System.Drawing.Point(9, 32);
            this.volumeTxt.Name = "volumeTxt";
            this.volumeTxt.Size = new System.Drawing.Size(176, 20);
            this.volumeTxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Volumen z.B. \"3l, 2l\":";
            // 
            // dimensionsTxt
            // 
            this.dimensionsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dimensionsTxt.Location = new System.Drawing.Point(9, 71);
            this.dimensionsTxt.Name = "dimensionsTxt";
            this.dimensionsTxt.Size = new System.Drawing.Size(176, 20);
            this.dimensionsTxt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Maße z.B. \"2x 3x4x2cm\":";
            // 
            // startsDate
            // 
            this.startsDate.CustomFormat = "dd.MM.yyyy";
            this.startsDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startsDate.Location = new System.Drawing.Point(9, 110);
            this.startsDate.Name = "startsDate";
            this.startsDate.Size = new System.Drawing.Size(95, 20);
            this.startsDate.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Beginn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ende:";
            // 
            // endsDate
            // 
            this.endsDate.CustomFormat = "dd.MM.yyyy";
            this.endsDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endsDate.Location = new System.Drawing.Point(110, 110);
            this.endsDate.Name = "endsDate";
            this.endsDate.Size = new System.Drawing.Size(95, 20);
            this.endsDate.TabIndex = 17;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.Location = new System.Drawing.Point(211, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(295, 295);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 19;
            this.pictureBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Bild:";
            // 
            // copyFromClipboardBtn
            // 
            this.copyFromClipboardBtn.Location = new System.Drawing.Point(319, 333);
            this.copyFromClipboardBtn.Name = "copyFromClipboardBtn";
            this.copyFromClipboardBtn.Size = new System.Drawing.Size(185, 25);
            this.copyFromClipboardBtn.TabIndex = 21;
            this.copyFromClipboardBtn.Text = "Bild von Zwischenablage einfügen";
            this.copyFromClipboardBtn.UseVisualStyleBackColor = true;
            this.copyFromClipboardBtn.Click += new System.EventHandler(this.copyFromClipboardBtn_Click);
            // 
            // removeImageBtn
            // 
            this.removeImageBtn.Location = new System.Drawing.Point(211, 333);
            this.removeImageBtn.Name = "removeImageBtn";
            this.removeImageBtn.Size = new System.Drawing.Size(102, 25);
            this.removeImageBtn.TabIndex = 22;
            this.removeImageBtn.Text = "Bild entfernen";
            this.removeImageBtn.UseVisualStyleBackColor = true;
            this.removeImageBtn.Click += new System.EventHandler(this.removeImageBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Teile z.B. \"3\":";
            // 
            // extrasTxt
            // 
            this.extrasTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extrasTxt.Location = new System.Drawing.Point(9, 149);
            this.extrasTxt.Name = "extrasTxt";
            this.extrasTxt.Size = new System.Drawing.Size(176, 20);
            this.extrasTxt.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Extras z.B. \"inkl. Rezeptideen\":";
            // 
            // publishBtn
            // 
            this.publishBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.publishBtn.Location = new System.Drawing.Point(543, 381);
            this.publishBtn.Name = "publishBtn";
            this.publishBtn.Size = new System.Drawing.Size(191, 23);
            this.publishBtn.TabIndex = 28;
            this.publishBtn.Text = "Veröffentlichen";
            this.publishBtn.UseVisualStyleBackColor = true;
            this.publishBtn.Click += new System.EventHandler(this.publishBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.priceTxt);
            this.groupBox1.Controls.Add(this.removeImageBtn);
            this.groupBox1.Controls.Add(this.copyFromClipboardBtn);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.startsDate);
            this.groupBox1.Controls.Add(this.endsDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(224, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 364);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Angebot bearbeiten";
            // 
            // partsTxt
            // 
            this.partsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partsTxt.Location = new System.Drawing.Point(9, 110);
            this.partsTxt.Name = "partsTxt";
            this.partsTxt.Size = new System.Drawing.Size(176, 20);
            this.partsTxt.TabIndex = 28;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(435, 381);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(102, 23);
            this.saveBtn.TabIndex = 32;
            this.saveBtn.Text = "Speichern";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 386);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(164, 13);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://kerstin-sternkopf.github.io";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.partsTxt);
            this.groupBox2.Controls.Add(this.volumeTxt);
            this.groupBox2.Controls.Add(this.savingTxt);
            this.groupBox2.Controls.Add(this.dimensionsTxt);
            this.groupBox2.Controls.Add(this.extrasTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(9, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 222);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "optional";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Alle Angebote:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 416);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.publishBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.offersBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(762, 455);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angebotseditor für Tupperware";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox offersBox;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox savingTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox volumeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dimensionsTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startsDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker endsDate;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button copyFromClipboardBtn;
        private System.Windows.Forms.Button removeImageBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox extrasTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button publishBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox partsTxt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
    }
}

