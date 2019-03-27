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
using rn = DevExpress.XtraRichEdit.API.Native;

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
			LoopStyles();
		}

		private void buttonHeading2_Click(object sender, EventArgs e)
		{
			var heading2 = new r.Commands.SetParagraphHeading2LevelCommand(richEditControl1);
			heading2.Execute();
			LoopStyles();
		}

		private void buttonHeading3_Click(object sender, EventArgs e)
		{
			var cmd = new r.Commands.SetParagraphHeading3LevelCommand(richEditControl1);
			cmd.Execute();
			LoopStyles();
		}

		private void buttonHeading4_Click(object sender, EventArgs e)
		{
			var cmd = new r.Commands.SetParagraphHeading4LevelCommand(richEditControl1);
			cmd.Execute();
			LoopStyles();
		}
		
		private void buttonSave_Click(object sender, EventArgs e)
		{
			Close();
			DialogResult = DialogResult.OK;
		}

		public string GetRtf()
		{
			return richEditControl1.RtfText;
		}

		public void SetRtf(string value)
		{
			richEditControl1.RtfText = value;
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

		private void LoopStyles()
		{
			var styles = richEditControl1.Document.ParagraphStyles.ToList();
			foreach (var style in styles)
			{
				Console.WriteLine(style.Name);
			}
		}

		private void SetStyles()
		{
			var document = richEditControl1.Document;

			rn.ParagraphStyle normalStyle = document.ParagraphStyles.CreateNew();
			if (normalStyle != null)
			{
				normalStyle = document.ParagraphStyles.CreateNew();
				normalStyle.Name = "Normal";
				normalStyle.LineSpacingType = rn.ParagraphLineSpacing.Single;
				normalStyle.Alignment = rn.ParagraphAlignment.Left;
				normalStyle.FontName = "Calibri";
				normalStyle.FontSize = 12;
				normalStyle.ForeColor = Color.Black;
				normalStyle.Bold = false;
				document.ParagraphStyles.Add(normalStyle);
			}
			document.ParagraphStyles.Add(normalStyle);

			rn.ParagraphStyle h1Style = document.ParagraphStyles.CreateNew();
			if (h1Style != null)
			{
				h1Style = document.ParagraphStyles.CreateNew();
				h1Style.Name = "Heading 1";
				h1Style.LineSpacingType = rn.ParagraphLineSpacing.Double;
				h1Style.Alignment = rn.ParagraphAlignment.Center;
				h1Style.FontName = "Calibri";
				h1Style.FontSize = 20;
				h1Style.ForeColor = Color.Blue;
				h1Style.Bold = true;
				document.ParagraphStyles.Add(h1Style);
			}
			document.ParagraphStyles.Add(h1Style);

			rn.ParagraphStyle h2Style = document.ParagraphStyles.CreateNew();
			if (h2Style != null)
			{
				h2Style = document.ParagraphStyles.CreateNew();
				h2Style.Name = "Heading 2";
				h2Style.LineSpacingType = rn.ParagraphLineSpacing.Double;
				h2Style.Alignment = rn.ParagraphAlignment.Center;
				h2Style.FontName = "Calibri";
				h2Style.FontSize = 18;
				h2Style.ForeColor = Color.Orange;
				h2Style.Bold = true;
				document.ParagraphStyles.Add(h2Style);
			}
			document.ParagraphStyles.Add(h2Style);

			rn.ParagraphStyle h3Style = document.ParagraphStyles.CreateNew();
			if (h2Style != null)
			{
				h3Style = document.ParagraphStyles.CreateNew();
				h3Style.Name = "Heading 3";
				h3Style.LineSpacingType = rn.ParagraphLineSpacing.Double;
				h3Style.Alignment = rn.ParagraphAlignment.Center;
				h3Style.FontName = "Calibri";
				h3Style.FontSize = 16;
				h3Style.ForeColor = Color.Salmon;
				h3Style.Bold = true;
				document.ParagraphStyles.Add(h3Style);
			}
			document.ParagraphStyles.Add(h3Style);
		}


		private void RteForm_Load(object sender, EventArgs e)
		{
			//SetStyles();
		}
	}
}
