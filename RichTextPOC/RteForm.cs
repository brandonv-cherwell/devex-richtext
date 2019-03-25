using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using r = DevExpress.XtraRichEdit;

namespace RichTextPOC
{
	public partial class RteForm : Form
	{
		public RteForm()
		{
			InitializeComponent();
		}

		private void buttonHeading1_Click(object sender, EventArgs e)
		{
			//richEditControl1.CreateCommand();
			var cmd = new r.Commands.SetParagraphHeading1LevelCommand(richEditControl1);
			cmd.Execute();
		}

		private void buttonHeading2_Click(object sender, EventArgs e)
		{
			var heading2 = new r.Commands.SetParagraphHeading2LevelCommand(richEditControl1);
			heading2.Execute();
		}

		private void buttonHeading3_Click(object sender, EventArgs e)
		{
			var cmd = new r.Commands.SetParagraphHeading3LevelCommand(richEditControl1);
			cmd.Execute();
		}

		private void buttonHeading4_Click(object sender, EventArgs e)
		{
			var cmd = new r.Commands.SetParagraphHeading4LevelCommand(richEditControl1);
			cmd.Execute();
		}
		
		private void buttonSave_Click(object sender, EventArgs e)
		{
			Close();
			DialogResult = DialogResult.OK;
		}

		public string GetHtml()
		{
			return richEditControl1.HtmlText;
		}

		public void SetHtml(string html)
		{
			richEditControl1.HtmlText = html;
		}

		private void buttonNormal_Click(object sender, EventArgs e)
		{
			var cmd = new r.Commands.SetParagraphBodyTextLevelCommand(richEditControl1);
			cmd.Execute();
		}
	}
}
