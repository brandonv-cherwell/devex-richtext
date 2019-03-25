using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using r = DevExpress.XtraRichEdit;

namespace RichTextPOC
{
	/// <summary>
	/// Interaction logic for RichTextWindowWPF.xaml
	/// </summary>
	public partial class RichTextWindowWPF : Window
	{
		public RichTextWindowWPF()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			var cmd = new r.Commands.SetParagraphHeading5LevelCommand(this.richTectEditWPF);
			cmd.Execute();
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			var cmd = new r.Commands.SetParagraphHeading1LevelCommand(this.richTectEditWPF);
			cmd.Execute();
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			var cmd = new r.Commands.SetParagraphHeading2LevelCommand(this.richTectEditWPF);
			cmd.Execute();
		}

		private void Button_Click_4(object sender, RoutedEventArgs e)
		{
			var cmd = new r.Commands.SetParagraphHeading3LevelCommand(this.richTectEditWPF);
			cmd.Execute();
		}

		private void Button_Click_5(object sender, RoutedEventArgs e)
		{
			var cmd = new r.Commands.SetParagraphHeading4LevelCommand(this.richTectEditWPF);
			cmd.Execute();
		}
	}
}
