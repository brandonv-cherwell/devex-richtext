namespace RichTextPOC
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonOpenWPF = new System.Windows.Forms.Button();
			this.buttonLoadHTML = new System.Windows.Forms.Button();
			this.buttonSaveHTML = new System.Windows.Forms.Button();
			this.buttonOpenRTE = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonOpenWPF);
			this.panel1.Controls.Add(this.buttonLoadHTML);
			this.panel1.Controls.Add(this.buttonSaveHTML);
			this.panel1.Controls.Add(this.buttonOpenRTE);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(923, 100);
			this.panel1.TabIndex = 0;
			// 
			// buttonOpenWPF
			// 
			this.buttonOpenWPF.Dock = System.Windows.Forms.DockStyle.Left;
			this.buttonOpenWPF.Location = new System.Drawing.Point(450, 0);
			this.buttonOpenWPF.Name = "buttonOpenWPF";
			this.buttonOpenWPF.Size = new System.Drawing.Size(150, 100);
			this.buttonOpenWPF.TabIndex = 3;
			this.buttonOpenWPF.Text = "Open RTE WPF";
			this.buttonOpenWPF.UseVisualStyleBackColor = true;
			this.buttonOpenWPF.Click += new System.EventHandler(this.buttonOpenWPF_Click);
			// 
			// buttonLoadHTML
			// 
			this.buttonLoadHTML.Dock = System.Windows.Forms.DockStyle.Left;
			this.buttonLoadHTML.Location = new System.Drawing.Point(300, 0);
			this.buttonLoadHTML.Name = "buttonLoadHTML";
			this.buttonLoadHTML.Size = new System.Drawing.Size(150, 100);
			this.buttonLoadHTML.TabIndex = 2;
			this.buttonLoadHTML.Text = "Load HTML";
			this.buttonLoadHTML.UseVisualStyleBackColor = true;
			// 
			// buttonSaveHTML
			// 
			this.buttonSaveHTML.Dock = System.Windows.Forms.DockStyle.Left;
			this.buttonSaveHTML.Location = new System.Drawing.Point(150, 0);
			this.buttonSaveHTML.Name = "buttonSaveHTML";
			this.buttonSaveHTML.Size = new System.Drawing.Size(150, 100);
			this.buttonSaveHTML.TabIndex = 1;
			this.buttonSaveHTML.Text = "Save HTML";
			this.buttonSaveHTML.UseVisualStyleBackColor = true;
			// 
			// buttonOpenRTE
			// 
			this.buttonOpenRTE.Dock = System.Windows.Forms.DockStyle.Left;
			this.buttonOpenRTE.Location = new System.Drawing.Point(0, 0);
			this.buttonOpenRTE.Name = "buttonOpenRTE";
			this.buttonOpenRTE.Size = new System.Drawing.Size(150, 100);
			this.buttonOpenRTE.TabIndex = 0;
			this.buttonOpenRTE.Text = "Open RTE";
			this.buttonOpenRTE.UseVisualStyleBackColor = true;
			this.buttonOpenRTE.Click += new System.EventHandler(this.buttonOpenRTE_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 100);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(923, 384);
			this.panel2.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(923, 384);
			this.textBox1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(923, 484);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "Main Form 17.2.13";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button buttonLoadHTML;
		private System.Windows.Forms.Button buttonSaveHTML;
		private System.Windows.Forms.Button buttonOpenRTE;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonOpenWPF;
	}
}