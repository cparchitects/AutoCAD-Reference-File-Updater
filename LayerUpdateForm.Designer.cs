
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lstDwgs = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRefFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRefNew = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnUpdateRef = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Folder Path or Browse to folder location of DWG files to update:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(25, 98);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(343, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "D:\\Programming\\AutoCAD\\xrefUpdate";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(374, 78);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(111, 40);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lstDwgs
            // 
            this.lstDwgs.FormattingEnabled = true;
            this.lstDwgs.Location = new System.Drawing.Point(25, 137);
            this.lstDwgs.Name = "lstDwgs";
            this.lstDwgs.Size = new System.Drawing.Size(460, 290);
            this.lstDwgs.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Reference File Name Characters to filter:";
            // 
            // txtRefFilter
            // 
            this.txtRefFilter.Location = new System.Drawing.Point(254, 445);
            this.txtRefFilter.Name = "txtRefFilter";
            this.txtRefFilter.Size = new System.Drawing.Size(231, 20);
            this.txtRefFilter.TabIndex = 5;
            this.txtRefFilter.Text = "X_T";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Replacement  Reference:";
            // 
            // txtRefNew
            // 
            this.txtRefNew.Location = new System.Drawing.Point(182, 481);
            this.txtRefNew.Name = "txtRefNew";
            this.txtRefNew.Size = new System.Drawing.Size(183, 20);
            this.txtRefNew.TabIndex = 7;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(22, 514);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(43, 13);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Info......";
            // 
            // btnUpdateRef
            // 
            this.btnUpdateRef.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdateRef.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRef.Location = new System.Drawing.Point(358, 531);
            this.btnUpdateRef.Name = "btnUpdateRef";
            this.btnUpdateRef.Size = new System.Drawing.Size(127, 30);
            this.btnUpdateRef.TabIndex = 9;
            this.btnUpdateRef.Text = "Update Reference";
            this.btnUpdateRef.UseVisualStyleBackColor = false;
            this.btnUpdateRef.Click += new System.EventHandler(this.btnUpdateRef_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(374, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "Select New Ref File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoUpdateRef.Properties.Resources.CP_HorizontalwithTagline_3C;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // RefUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 577);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateRef);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtRefNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRefFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDwgs);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RefUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reference Update Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RefUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox lstDwgs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRefFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRefNew;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnUpdateRef;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}