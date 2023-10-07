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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTransformations = new System.Windows.Forms.ComboBox();
            this.btnTransform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(222, 12);
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
            this.label1.Location = new System.Drawing.Point(10, 16);
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
            "JS",
            "XML"});
            this.cmbLanguages.Location = new System.Drawing.Point(72, 12);
            this.cmbLanguages.Name = "cmbLanguages";
            this.cmbLanguages.Size = new System.Drawing.Size(133, 21);
            this.cmbLanguages.TabIndex = 4;
            this.cmbLanguages.SelectedIndexChanged += new System.EventHandler(this.cmbLanguages_SelectedIndexChanged);
            // 
            // btnMinify
            // 
            this.btnMinify.Location = new System.Drawing.Point(313, 12);
            this.btnMinify.Name = "btnMinify";
            this.btnMinify.Size = new System.Drawing.Size(75, 23);
            this.btnMinify.TabIndex = 5;
            this.btnMinify.Text = "Minify";
            this.btnMinify.UseVisualStyleBackColor = true;
            this.btnMinify.Click += new System.EventHandler(this.btnMinify_Click);
            // 
            // btnLinesToArray
            // 
            this.btnLinesToArray.Location = new System.Drawing.Point(777, 12);
            this.btnLinesToArray.Name = "btnLinesToArray";
            this.btnLinesToArray.Size = new System.Drawing.Size(87, 23);
            this.btnLinesToArray.TabIndex = 6;
            this.btnLinesToArray.Text = "Lines to array";
            this.btnLinesToArray.UseVisualStyleBackColor = true;
            this.btnLinesToArray.Click += new System.EventHandler(this.btnLinesToArray_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Transform";
            // 
            // cmbTransformations
            // 
            this.cmbTransformations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransformations.FormattingEnabled = true;
            this.cmbTransformations.Items.AddRange(new object[] {
            "URL decode",
            "URL encode",
            "Base64 decode",
            "Unescape"});
            this.cmbTransformations.Location = new System.Drawing.Point(486, 12);
            this.cmbTransformations.Name = "cmbTransformations";
            this.cmbTransformations.Size = new System.Drawing.Size(133, 21);
            this.cmbTransformations.TabIndex = 8;
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(635, 11);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(44, 23);
            this.btnTransform.TabIndex = 9;
            this.btnTransform.Text = "Do";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 495);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.cmbTransformations);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTransformations;
        private System.Windows.Forms.Button btnTransform;
    }
}

