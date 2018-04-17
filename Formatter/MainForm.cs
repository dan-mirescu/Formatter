using System;
using System.Drawing;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Formatter.Formatters;
using Formatter.Minifiers;
using Newtonsoft.Json;

namespace Formatter
{
    public partial class MainForm : Form
    {
        private readonly FastColoredTextBox _box;

        public MainForm()
        {
            InitializeComponent();

            //_box = new FastColoredTextBox();
            //_box.Size = new Size(852, 480);
            //_box.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //_box.Location = new Point(12, 52);
            //_box.Language = Language.JS;
            //Controls.Add(_box);

            _box = new FastColoredTextBox();
            tableLayoutPanel1.Controls.Add(_box);
            _box.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            cmbLanguages.SelectedItem = "JSON";
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            IFormatter formatter;

            switch (cmbLanguages.SelectedItem.ToString())
            {
                case "JSON":
                    formatter = new JsonFormatter();
                    break;
                case "HTML":
                    formatter = new HtmlFormatter();
                    break;
                default:
                    MessageBox.Show("Formatter not implemented!");
                    return;
            }

            try
            {
                _box.Text = formatter.Format(_box.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbLanguages.SelectedItem.ToString())
            {
                case "JSON":
                    _box.Language = Language.JS;
                    break;
                case "HTML":
                    _box.Language = Language.HTML;
                    break;
            }
        }

        private void btnMinify_Click(object sender, EventArgs e)
        {
            IMinifier minifier;

            switch (cmbLanguages.SelectedItem.ToString())
            {
                case "JS":
                    minifier = new JsMinifier();
                    break;
                default:
                    MessageBox.Show("Minifier not implemented!");
                    return;
            }

            try
            {
                _box.Text = minifier.Minify(_box.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
