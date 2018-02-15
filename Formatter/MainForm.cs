using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Formatter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            txtCode.Text = FormatJson(txtCode.Text);
        }

        private string FormatJson(string text)
        {
            var obj = JsonConvert.DeserializeObject<dynamic>(text);
            var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            return json;
        }
    }
}
