namespace Formatter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnFormat = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLanguages = new System.Windows.Forms.ComboBox();
            this.btnMinify = new System.Windows.Forms.Button();
            this.btnLinesToArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(13, 12);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(75, 23);
            this.btnFormat.TabIndex = 1;
            this.btnFormat.Text = "Format";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(851, 441);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Language";
            // 
            // cmbLanguages
            // 
            this.cmbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguages.FormattingEnabled = true;
            this.cmbLanguages.Items.AddRange(new object[] {
            "JSON",
            "HTML",
            "JS"});
            this.cmbLanguages.Location = new System.Drawing.Point(181, 13);
            this.cmbLanguages.Name = "cmbLanguages";
            this.cmbLanguages.Size = new System.Drawing.Size(133, 21);
            this.cmbLanguages.TabIndex = 4;
            this.cmbLanguages.SelectedIndexChanged += new System.EventHandler(this.cmbLanguages_SelectedIndexChanged);
            // 
            // btnMinify
            // 
            this.btnMinify.Location = new System.Drawing.Point(404, 11);
            this.btnMinify.Name = "btnMinify";
            this.btnMinify.Size = new System.Drawing.Size(75, 23);
            this.btnMinify.TabIndex = 5;
            this.btnMinify.Text = "Minify";
            this.btnMinify.UseVisualStyleBackColor = true;
            this.btnMinify.Click += new System.EventHandler(this.btnMinify_Click);
            // 
            // btnLinesToArray
            // 
            this.btnLinesToArray.Location = new System.Drawing.Point(590, 11);
            this.btnLinesToArray.Name = "btnLinesToArray";
            this.btnLinesToArray.Size = new System.Drawing.Size(111, 23);
            this.btnLinesToArray.TabIndex = 6;
            this.btnLinesToArray.Text = "Lines to array";
            this.btnLinesToArray.UseVisualStyleBackColor = true;
            this.btnLinesToArray.Click += new System.EventHandler(this.btnLinesToArray_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 495);
            this.Controls.Add(this.btnLinesToArray);
            this.Controls.Add(this.btnMinify);
            this.Controls.Add(this.cmbLanguages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnFormat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Formatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLanguages;
        private System.Windows.Forms.Button btnMinify;
        private System.Windows.Forms.Button btnLinesToArray;
    }
}

