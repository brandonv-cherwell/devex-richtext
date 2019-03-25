namespace RichTextPOC
{
	partial class RteForm
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
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonNormal = new System.Windows.Forms.Button();
			this.buttonHeading4 = new System.Windows.Forms.Button();
			this.buttonHeading3 = new System.Windows.Forms.Button();
			this.buttonHeading2 = new System.Windows.Forms.Button();
			this.buttonHeading1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonSave);
			this.panel1.Controls.Add(this.buttonNormal);
			this.panel1.Controls.Add(this.buttonHeading4);
			this.panel1.Controls.Add(this.buttonHeading3);
			this.panel1.Controls.Add(this.buttonHeading2);
			this.panel1.Controls.Add(this.buttonHeading1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(941, 81);
			this.panel1.TabIndex = 0;
			// 
			// buttonSave
			// 
			this.buttonSave.Dock = System.Windows.Forms.DockStyle.Left;
			this.buttonSave.Location = new System.Drawing.Point(750, 0);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(150, 81);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Save and Close";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonNormal
			// 
			this.buttonNormal.Dock = System.Windows.Forms.DockStyle.Left;
			this.buttonNormal.Location = new System.Drawing.Point(600, 0);
			this.buttonNormal.Name = "buttonNormal";
			this.buttonNormal.Size = new System.Drawing.Size(150, 81);
			this.buttonNormal.TabIndex = 5;
			this.buttonNormal.Text = "Normal";
			this.buttonNormal.UseVisualStyleBackColor = true;
			this.buttonNormal.Click += new System.EventHandler(this.buttonNormal_Click);
			// 
			// buttonHeading4
			// 
			this.buttonHeading4.Dock = System.Windows.Forms.DockStyle.Left;
			this.buttonHeading4.Location = new System.Drawing.Point(450, 0);
			this.buttonHeading4.Name = "buttonHeading4";
			this.buttonHeading4.Size = new System.Drawing.Size(150, 81);
			this.buttonHeading4.TabIndex = 3;
			this.buttonHeading4.Text = "Heading 4";
			this.buttonHeading4.UseVisualStyleBackColor = true;
			this.buttonHeading4.Click += new System.EventHandler(this.buttonHeading4_Click);
			// 
			// buttonHeading3
			// 
			this.buttonHeading3.Dock = System.Windows.Forms.DockStyle.Left;
			this.buttonHeading3.Location = new System.Drawing.Point(300, 0);
			this.buttonHeading3.Name = "buttonHeading3";
			this.buttonHeading3.Size = new System.Drawing.Size(150, 81);
			this.buttonHeading3.TabIndex = 2;
			this.buttonHeading3.Text = "Heading 3";
			this.buttonHeading3.UseVisualStyleBackColor = true;
			this.buttonHeading3.Click += new System.EventHandler(this.buttonHeading3_Click);
			// 
			// buttonHeading2
			// 
			this.buttonHeading2.Dock = System.Windows.Forms.DockStyle.Left;
			this.buttonHeading2.Location = new System.Drawing.Point(150, 0);
			this.buttonHeading2.Name = "buttonHeading2";
			this.buttonHeading2.Size = new System.Drawing.Size(150, 81);
			this.buttonHeading2.TabIndex = 1;
			this.buttonHeading2.Text = "Heading 2";
			this.buttonHeading2.UseVisualStyleBackColor = true;
			this.buttonHeading2.Click += new System.EventHandler(this.buttonHeading2_Click);
			// 
			// buttonHeading1
			// 
			this.buttonHeading1.Dock = System.Windows.Forms.DockStyle.Left;
			this.buttonHeading1.Location = new System.Drawing.Point(0, 0);
			this.buttonHeading1.Name = "buttonHeading1";
			this.buttonHeading1.Size = new System.Drawing.Size(150, 81);
			this.buttonHeading1.TabIndex = 0;
			this.buttonHeading1.Text = "Heading 1";
			this.buttonHeading1.UseVisualStyleBackColor = true;
			this.buttonHeading1.Click += new System.EventHandler(this.buttonHeading1_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.richEditControl1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 81);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(941, 435);
			this.panel2.TabIndex = 1;
			// 
			// richEditControl1
			// 
			this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richEditControl1.Location = new System.Drawing.Point(0, 0);
			this.richEditControl1.Name = "richEditControl1";
			this.richEditControl1.Size = new System.Drawing.Size(941, 435);
			this.richEditControl1.TabIndex = 0;
			this.richEditControl1.Text = "richEditControl1";
			// 
			// RteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(941, 516);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "RteForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RTE Form 17.2.13";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
		private System.Windows.Forms.Button buttonHeading4;
		private System.Windows.Forms.Button buttonHeading3;
		private System.Windows.Forms.Button buttonHeading2;
		private System.Windows.Forms.Button buttonHeading1;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonNormal;
	}
}