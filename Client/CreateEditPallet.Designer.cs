﻿namespace Client
{
    partial class CreateEditPallet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPalletID = new System.Windows.Forms.TextBox();
            this.textBoxLocationID = new System.Windows.Forms.TextBox();
            this.textBoxPalletHeight = new System.Windows.Forms.TextBox();
            this.textBoxPalletArea = new System.Windows.Forms.TextBox();
            this.buttonCreatePallet = new System.Windows.Forms.Button();
            this.buttonUpdatePallet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pallet ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Area";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(192, 158);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Arrival Date";
            // 
            // textBoxPalletID
            // 
            this.textBoxPalletID.Location = new System.Drawing.Point(176, 39);
            this.textBoxPalletID.Name = "textBoxPalletID";
            this.textBoxPalletID.Size = new System.Drawing.Size(100, 22);
            this.textBoxPalletID.TabIndex = 6;
            // 
            // textBoxLocationID
            // 
            this.textBoxLocationID.Location = new System.Drawing.Point(176, 104);
            this.textBoxLocationID.Name = "textBoxLocationID";
            this.textBoxLocationID.Size = new System.Drawing.Size(100, 22);
            this.textBoxLocationID.TabIndex = 7;
            // 
            // textBoxPalletHeight
            // 
            this.textBoxPalletHeight.Location = new System.Drawing.Point(306, 39);
            this.textBoxPalletHeight.Name = "textBoxPalletHeight";
            this.textBoxPalletHeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxPalletHeight.TabIndex = 8;
            // 
            // textBoxPalletArea
            // 
            this.textBoxPalletArea.Location = new System.Drawing.Point(306, 101);
            this.textBoxPalletArea.Name = "textBoxPalletArea";
            this.textBoxPalletArea.Size = new System.Drawing.Size(100, 22);
            this.textBoxPalletArea.TabIndex = 9;
            // 
            // buttonCreatePallet
            // 
            this.buttonCreatePallet.Location = new System.Drawing.Point(192, 258);
            this.buttonCreatePallet.Name = "buttonCreatePallet";
            this.buttonCreatePallet.Size = new System.Drawing.Size(75, 23);
            this.buttonCreatePallet.TabIndex = 10;
            this.buttonCreatePallet.Text = "Create";
            this.buttonCreatePallet.UseVisualStyleBackColor = true;
            this.buttonCreatePallet.Click += new System.EventHandler(this.ButtonCreatePallet_Click);
            // 
            // buttonUpdatePallet
            // 
            this.buttonUpdatePallet.Location = new System.Drawing.Point(317, 258);
            this.buttonUpdatePallet.Name = "buttonUpdatePallet";
            this.buttonUpdatePallet.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdatePallet.TabIndex = 11;
            this.buttonUpdatePallet.Text = "Update";
            this.buttonUpdatePallet.UseVisualStyleBackColor = true;
            this.buttonUpdatePallet.Click += new System.EventHandler(this.ButtonUpdatePallet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(65, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(442, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "NOTE: When updating pallet details make sure to set the arrival date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(15, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(535, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "to the correct one again, failure to do so will change the arrival date to a wron" +
    "g one.";
            // 
            // CreateEditPallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 311);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonUpdatePallet);
            this.Controls.Add(this.buttonCreatePallet);
            this.Controls.Add(this.textBoxPalletArea);
            this.Controls.Add(this.textBoxPalletHeight);
            this.Controls.Add(this.textBoxLocationID);
            this.Controls.Add(this.textBoxPalletID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateEditPallet";
            this.Text = "CreateEditPallet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPalletID;
        private System.Windows.Forms.TextBox textBoxLocationID;
        private System.Windows.Forms.TextBox textBoxPalletHeight;
        private System.Windows.Forms.TextBox textBoxPalletArea;
        private System.Windows.Forms.Button buttonCreatePallet;
        private System.Windows.Forms.Button buttonUpdatePallet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}