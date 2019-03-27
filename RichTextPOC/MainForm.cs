using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace RichTextPOC
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void buttonOpenRTE_Click(object sender, EventArgs e)
		{
			if (radioButtonHTML.Checked)
			{
				var richTextForm = new RteForm();
				if (!string.IsNullOrWhiteSpace(this.textBox1.Text))
				{
					richTextForm.SetHtml(textBox1.Text);
				}

				var result = richTextForm.ShowDialog();
				if (result == DialogResult.OK)
				{
					textBox1.Text = richTextForm.GetHtml();
				}
			}
			else
			{
				var richTextForm = new RteForm();
				if (!string.IsNullOrWhiteSpace(this.textBox1.Text))
				{
					richTextForm.SetRtf(textBox1.Text);
				}

				var result = richTextForm.ShowDialog();
				if (result == DialogResult.OK)
				{
					textBox1.Text = richTextForm.GetRtf();
				}
			}
		}

		private void buttonOpenWPF_Click(object sender, EventArgs e)
		{
			var wpfRtf = new RichTextWindowWPF();
			wpfRtf.ShowDialog();

			if (!string.IsNullOrWhiteSpace(this.textBox1.Text))
			{
				wpfRtf.SetHtml(textBox1.Text);
			}
		}
	}
}
