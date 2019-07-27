namespace Client
{
    partial class ReleasePallet
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
            this.textBoxPalletID = new System.Windows.Forms.TextBox();
            this.buttonReleasePallet = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pallet ID";
            // 
            // textBoxPalletID
            // 
            this.textBoxPalletID.Location = new System.Drawing.Point(79, 80);
            this.textBoxPalletID.Name = "textBoxPalletID";
            this.textBoxPalletID.Size = new System.Drawing.Size(166, 22);
            this.textBoxPalletID.TabIndex = 1;
            // 
            // buttonReleasePallet
            // 
            this.buttonReleasePallet.Location = new System.Drawing.Point(56, 143);
            this.buttonReleasePallet.Name = "buttonReleasePallet";
            this.buttonReleasePallet.Size = new System.Drawing.Size(75, 23);
            this.buttonReleasePallet.TabIndex = 2;
            this.buttonReleasePallet.Text = "Release";
            this.buttonReleasePallet.UseVisualStyleBackColor = true;
            this.buttonReleasePallet.Click += new System.EventHandler(this.ButtonReleasePallet_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(201, 143);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ReleasePallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 204);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReleasePallet);
            this.Controls.Add(this.textBoxPalletID);
            this.Controls.Add(this.label1);
            this.Name = "ReleasePallet";
            this.Text = "ReleasePallet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPalletID;
        private System.Windows.Forms.Button buttonReleasePallet;
        private System.Windows.Forms.Button buttonCancel;
    }
}