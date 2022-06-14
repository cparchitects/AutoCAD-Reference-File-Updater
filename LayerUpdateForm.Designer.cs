
namespace AutoUpdateRef
{
    partial class RefUpdateForm
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lstDwgs = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRefFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateRef = new System.Windows.Forms.Button();
            this.SelectNewRF = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRefName = new System.Windows.Forms.TextBox();
            this.txtRefPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Browse to folder location of DWG files to update References:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(332, 96);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(153, 26);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lstDwgs
            // 
            this.lstDwgs.FormattingEnabled = true;
            this.lstDwgs.Location = new System.Drawing.Point(25, 150);
            this.lstDwgs.Name = "lstDwgs";
            this.lstDwgs.Size = new System.Drawing.Size(460, 277);
            this.lstDwgs.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Reference File Name Characters to filter:";
            // 
            // txtRefFilter
            // 
            this.txtRefFilter.Location = new System.Drawing.Point(254, 440);
            this.txtRefFilter.Name = "txtRefFilter";
            this.txtRefFilter.Size = new System.Drawing.Size(231, 20);
            this.txtRefFilter.TabIndex = 5;
            this.txtRefFilter.Text = "X_T";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Browse and select the New DWG Reference file:";
            // 
            // btnUpdateRef
            // 
            this.btnUpdateRef.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdateRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRef.Location = new System.Drawing.Point(276, 518);
            this.btnUpdateRef.Name = "btnUpdateRef";
            this.btnUpdateRef.Size = new System.Drawing.Size(209, 58);
            this.btnUpdateRef.TabIndex = 9;
            this.btnUpdateRef.Text = "Update Reference";
            this.btnUpdateRef.UseVisualStyleBackColor = false;
            this.btnUpdateRef.Click += new System.EventHandler(this.btnUpdateRef_Click);
            // 
            // SelectNewRF
            // 
            this.SelectNewRF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SelectNewRF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectNewRF.Location = new System.Drawing.Point(276, 476);
            this.SelectNewRF.Name = "SelectNewRF";
            this.SelectNewRF.Size = new System.Drawing.Size(209, 26);
            this.SelectNewRF.TabIndex = 10;
            this.SelectNewRF.Text = "Select New Ref File";
            this.SelectNewRF.UseVisualStyleBackColor = false;
            this.SelectNewRF.Click += new System.EventHandler(this.SelectNewRF_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoUpdateRef.Properties.Resources.CP_HorizontalwithTagline_3C;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "List of drawings in the directory that wil be updated:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(497, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "Info....";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "New Reference File Name: (Edit If Needed)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 543);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "New Reference File Path: (Edit If Needed)";
            // 
            // txtRefName
            // 
            this.txtRefName.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefName.Location = new System.Drawing.Point(25, 522);
            this.txtRefName.Name = "txtRefName";
            this.txtRefName.Size = new System.Drawing.Size(236, 20);
            this.txtRefName.TabIndex = 18;
            // 
            // txtRefPath
            // 
            this.txtRefPath.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefPath.Location = new System.Drawing.Point(25, 556);
            this.txtRefPath.Name = "txtRefPath";
            this.txtRefPath.Size = new System.Drawing.Size(236, 20);
            this.txtRefPath.TabIndex = 19;
            // 
            // RefUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 601);
            this.Controls.Add(this.txtRefPath);
            this.Controls.Add(this.txtRefName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SelectNewRF);
            this.Controls.Add(this.btnUpdateRef);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRefFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDwgs);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(513, 640);
            this.MinimumSize = new System.Drawing.Size(513, 640);
            this.Name = "RefUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reference Update Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RefUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox lstDwgs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRefFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateRef;
        private System.Windows.Forms.Button SelectNewRF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRefName;
        private System.Windows.Forms.TextBox txtRefPath;
    }
}