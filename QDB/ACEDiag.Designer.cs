namespace QDB
{
    partial class ACEDiag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACEDiag));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ACEnamelbl = new System.Windows.Forms.Label();
            this.scrName = new System.Windows.Forms.TextBox();
            this.executeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nodes = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nodes)).BeginInit();
            this.SuspendLayout();
            // 
            // ACEnamelbl
            // 
            this.ACEnamelbl.AutoSize = true;
            this.ACEnamelbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ACEnamelbl.Location = new System.Drawing.Point(5, 4);
            this.ACEnamelbl.Name = "ACEnamelbl";
            this.ACEnamelbl.Size = new System.Drawing.Size(51, 13);
            this.ACEnamelbl.TabIndex = 0;
            this.ACEnamelbl.Text = "Function:";
            // 
            // scrName
            // 
            this.scrName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrName.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrName.Location = new System.Drawing.Point(53, 2);
            this.scrName.Name = "scrName";
            this.scrName.Size = new System.Drawing.Size(182, 20);
            this.scrName.TabIndex = 1;
            // 
            // executeBtn
            // 
            this.executeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.executeBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.executeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.executeBtn.Location = new System.Drawing.Point(240, 2);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(33, 20);
            this.executeBtn.TabIndex = 2;
            this.executeBtn.Text = "Run";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.Go);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(2, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nodes
            // 
            this.nodes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.nodes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.nodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Key,
            this.Value});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.nodes.DefaultCellStyle = dataGridViewCellStyle1;
            this.nodes.Location = new System.Drawing.Point(5, 93);
            this.nodes.MultiSelect = false;
            this.nodes.Name = "nodes";
            this.nodes.RowHeadersVisible = false;
            this.nodes.Size = new System.Drawing.Size(258, 106);
            this.nodes.TabIndex = 4;
            this.nodes.Visible = false;
            // 
            // Type
            // 
            this.Type.FillWeight = 60F;
            this.Type.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Type.HeaderText = "Type";
            this.Type.Items.AddRange(new object[] {
            "Int",
            "Float",
            "QbKey",
            "String",
            "WString"});
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Type.Width = 60;
            // 
            // Key
            // 
            this.Key.FillWeight = 96F;
            this.Key.HeaderText = "Key";
            this.Key.MinimumWidth = 16;
            this.Key.Name = "Key";
            this.Key.Width = 96;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // ACEDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 79);
            this.Controls.Add(this.nodes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.scrName);
            this.Controls.Add(this.ACEnamelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ACEDiag";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Execute Script";
            ((System.ComponentModel.ISupportInitialize)(this.nodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ACEnamelbl;
        private System.Windows.Forms.TextBox scrName;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView nodes;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}