namespace QDB
{
    partial class QbKeyTest
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
            this.qkl = new System.Windows.Forms.Label();
            this.inputString = new System.Windows.Forms.TextBox();
            this.inputHex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // qkl
            // 
            this.qkl.AutoSize = true;
            this.qkl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.qkl.Location = new System.Drawing.Point(8, 8);
            this.qkl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qkl.Name = "qkl";
            this.qkl.Size = new System.Drawing.Size(95, 45);
            this.qkl.TabIndex = 0;
            this.qkl.Text = "String:\r\n\r\nCRC:     0x";
            // 
            // inputString
            // 
            this.inputString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputString.Location = new System.Drawing.Point(80, 5);
            this.inputString.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputString.MaxLength = 64;
            this.inputString.Name = "inputString";
            this.inputString.Size = new System.Drawing.Size(206, 22);
            this.inputString.TabIndex = 1;
            this.inputString.TextChanged += new System.EventHandler(this.changeBasedOnText);
            this.inputString.Enter += new System.EventHandler(this.editMode2Str);
            // 
            // inputHex
            // 
            this.inputHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputHex.Location = new System.Drawing.Point(99, 36);
            this.inputHex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputHex.MaxLength = 8;
            this.inputHex.Name = "inputHex";
            this.inputHex.Size = new System.Drawing.Size(187, 22);
            this.inputHex.TabIndex = 2;
            this.inputHex.TextChanged += new System.EventHandler(this.changeBasedOnCRC);
            this.inputHex.Enter += new System.EventHandler(this.editMode2CRC);
            this.inputHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editMode2CRC);
            // 
            // QbKeyTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 64);
            this.Controls.Add(this.inputHex);
            this.Controls.Add(this.inputString);
            this.Controls.Add(this.qkl);
            this.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QbKeyTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter QbKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qkl;
        private System.Windows.Forms.TextBox inputString;
        private System.Windows.Forms.TextBox inputHex;
    }
}