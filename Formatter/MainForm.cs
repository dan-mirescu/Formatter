using System;
using System.Drawing;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Formatter.Converters;
using Formatter.Formatters;
using Formatter.Minifiers;
using Formatter.Transformers;
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
                case "JS":
                    formatter = new JsFormatter();
                    break;
                case "XML":
                    formatter = new XmlFormatter();
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

        private void btnLinesToArray_Click(object sender, EventArgs e)
        {
            var converter = new LinesToArrayConverter();

            try
            {
                _box.Text = converter.Convert(_box.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            ITransformer transformer;

            switch(cmbTransformations.SelectedItem.ToString())
            {
                case "URL decode":
                    transformer = new UrlDecodeTransformer();
                break;
                case "URL encode":
                    transformer = new UrlEncodeTransformer();
                break;
                case "Base64 decode":
                    transformer = new Base64DecodeTransformer();
                break;
                default:
                    MessageBox.Show("Transformer not implemented!");
                return;
            }

            try
            {
                _box.Text = transformer.Transform(_box.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
